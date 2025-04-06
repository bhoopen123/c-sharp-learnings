// See https://aka.ms/new-console-template for more information

using Default_Interface_Methods_C_;

Console.WriteLine("Hello, World!");

ICustomer customer = new SampleCustomer(Guid.NewGuid(), "John Doe", DateTime.UtcNow.AddYears(-3));
Console.WriteLine(customer.GetLoyaltyDiscount());  // 0.10m


// 1. Default Interface Methods are NOT inherited
SampleCustomer sampleCustomer = new SampleCustomer(Guid.NewGuid(), "Jane Doe", DateTime.UtcNow.AddYears(-1));
//sampleCustomer.GetLoyaltyDiscount(); // will not work

// More details //https://andrewlock.net/understanding-default-interface-methods/

IShape shape = new MySemiCircle();
Console.WriteLine(shape.GetName());

//More importantly, you also can't use default interface members in .NET Framework. 