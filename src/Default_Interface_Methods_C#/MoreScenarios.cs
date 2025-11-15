namespace Default_Interface_Methods_C_
{
    interface IShape
    {
        string GetName() => "IShape"; // Default implementation
    }

    interface IHasStraightEdges : IShape
    {
        string IShape.GetName() => "IHasStraightEdges"; // Override the default
    }

    interface IHasCurvedEdges : IShape
    {
        string IShape.GetName() => "IHasCurvedEdges"; // Override the default
    }

    // inherits both interfaces
    // The below code won't compile, instead you get an error:
    //public class MySemiCircleWithEdges : IHasStraightEdges, IHasCurvedEdges { }

    // What following code will print, Its a diamond problem
    // IShape shape = new MySemiCircle(); // cast to IShape
    // Console.WriteLine(shape.GetName()); // What should this print?!

    // Optionally Implement IShape explicitly  👇
    public class MySemiCircle : IHasStraightEdges, IHasCurvedEdges, IShape
    {
        // Its is required to implement GetName method here to resolve the diamond problem, because both IHasStraightEdges and IHasCurvedEdges provide their own implementations of GetName and MySemiCircle class implements both interfaces.
        public string GetName() => "MySemiCircle"; // 👈 Provide an implementation (required)
    }

    // Now following code will work
    // IShape shape = new MySemiCircle(); // cast to IShape
    // Console.WriteLine(shape.GetName()); // What should this print?!
}
