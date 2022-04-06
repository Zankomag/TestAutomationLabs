namespace Lab2; 

public class Store {

	private readonly ICurrencyExchange currencyExchangeService;
	private readonly IDatabase database;
	private readonly IFlags flags;

	public Store(ICurrencyExchange currencyExchangeService, IDatabase database, IFlags flags) {
		this.currencyExchangeService = currencyExchangeService;
		this.database = database;
		this.flags = flags;
	}

	public void Purchase(User user, List<Item> items) {
		decimal total = 0;
		foreach(var item in items) {
			decimal price = item.Price;
			if(item.Currency != user.Account.Currency) {
				price *= currencyExchangeService.GetCurrencyRate(item.Currency, user.Account.Currency);
			}
			total += price;
			database.Items.Remove(item);
		}
		if(user.Account.Balance <= total)
			throw new InvalidOperationException("User doesn't have enough balance to pay");
		database.History.Add(new History {
			Id = Guid.NewGuid(),
			Items = items,
			PurchaseDateTimeOffset = DateTimeOffset.Now,
			Store = this,
			User = user
		});
		user.Account.Balance -= total;
		
	}

	public string GetCountryFlagByUser(User user) => flags.GetCountryFlag(user.Country);

	public void AddItem(Item item) => database.Items.Add(item);

	public void RemoveItem(Item item) => database.Items.Remove(item);

}