// See https://aka.ms/new-console-template for more information

public class SampleCustomer(Guid id, string name, DateTime dateJoined) : ICustomer
{
    public Guid Id { get; } = id;
    public string Name { get; } = name;
    public DateTime DateJoined { get; } = dateJoined;
    // GetLoyaltyDiscount() is not implemented, but the code will still compile and run fine.

    // Or the consumer can provide its own implementation
    // public decimal GetLoyaltyDiscount() => 0; // Never give a discount

}
//sampleCustomer.GetLoyaltyDiscount(); // will not work
