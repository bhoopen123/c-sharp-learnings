// See https://aka.ms/new-console-template for more information

// Default interface methods are a feature of C# 8.0
// It allows you to provide a method body in an interface similar to how you might use an `abstract` class.
public interface ICustomer
{
    DateTime DateJoined { get; }
    string Name { get; }

    // 👇 Provide a body for the new method
    // this will not break existing consumers of the interface
    decimal GetLoyaltyDiscount()
    {
        var twoYearsAgo = DateTime.UtcNow.AddYears(-2);
        if (DateJoined < twoYearsAgo)
        {
            // Customers who joined > 2 years ago get a 10% discount
            return 0.10m;
        }

        // Otherwise no discount
        return 0;
    }
}
//sampleCustomer.GetLoyaltyDiscount(); // will not work
