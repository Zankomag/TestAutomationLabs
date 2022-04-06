#pragma warning disable CS8618
namespace Lab2; 

public class History {
	
	public Guid Id { get; set; }
	public DateTimeOffset PurchaseDateTimeOffset { get; set; }
	public User User { get; set; }
	public Store Store { get; set; }
	public ICollection<Item> Items { get; set; }


}