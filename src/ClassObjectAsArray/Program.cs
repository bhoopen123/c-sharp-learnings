using System;

namespace ClassObjectAsArray
{
    class Program
    {
        static int Main(string[] args)
        {

            // //To create an array of objects, you can declare an array variable and use the square brackets to specify its size.
            //Employee[] StaffMembers = new Employee[3];

            // You can also use the var keyword to create the array but omit the first square brackets.
            var StaffMembers1 = new Employee[3];

            // you can then access each member using its index, allocate memory for it using the new operator,
            // then access each of its fields, still using its index, to assign it the desired value.
            //var StaffMembers = new Employee[3];

            //StaffMembers[0] = new Employee();
            //StaffMembers[0].EmployeeNumber = 20204;
            //StaffMembers[0].EmployeeName = "Harry Fields";
            //StaffMembers[0].Status = EmploymentStatus.FullTime;
            //StaffMembers[0].HourlySalary = 16.85;

            //StaffMembers[1] = new Employee();
            //StaffMembers[1].EmployeeNumber = 92857;
            //StaffMembers[1].EmployeeName = "Jennifer Almonds";
            //StaffMembers[1].Status = EmploymentStatus.FullTime;
            //StaffMembers[1].HourlySalary = 22.25;

            //StaffMembers[2] = new Employee();
            //StaffMembers[2].EmployeeNumber = 42963;
            //StaffMembers[2].EmployeeName = "Sharon Culbritt";
            //StaffMembers[2].Status = EmploymentStatus.PartTime;
            //StaffMembers[2].HourlySalary = 10.95;


            // //As an alternative, you can also initialize each member of the array when creating it. To do this,
            // //before the semi-colon of creating the array, open the curly brackets,
            // //allocate memory for each member and specify the values of each field. 
            // //To do this, you must use a constructor that takes each member you want to initialize, as argument.

            var StaffMembers2 = new Employee[]
                                            {
                                                new Employee(20204, "Harry Fields", EmploymentStatus.FullTime, 16.85),
                                                new Employee(92857, "Jennifer Almonds", EmploymentStatus.FullTime, 22.25),
                                                new Employee(42963, "Sharon Culbritt", EmploymentStatus.PartTime, 10.95)
                                            };

            // // If using the var keyword and a constructor to initialize the array, 
            // // you can omit calling the name of the class before the square brackets.
            var StaffMembers = new[]
                                    {
                                        new Employee(20204, "Harry Fields", EmploymentStatus.FullTime, 16.85),
                                        new Employee(92857, "Jennifer Almonds", EmploymentStatus.FullTime, 22.25),
                                        new Employee(42963, "Sharon Culbritt", EmploymentStatus.PartTime, 10.95)
                                   };

            // // After creating and initializing the array, you can use it as you see fit. For example, 
            // // you may want to display its values to the user.
            // // You can access any member of the array by its index, 
            // // then use the same index to get its field(s) and consequently its (their) value(s).
            Console.WriteLine("Employee Record");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Employee #: {0}", StaffMembers[2].EmployeeNumber);
            Console.WriteLine("Full Name:  {0}", StaffMembers[2].EmployeeName);
            Console.WriteLine("Status:     {0}", StaffMembers[2].Status);
            Console.WriteLine("Hourly Wage {0}", StaffMembers[2].HourlySalary);
            Console.WriteLine("---------------------------\n");


            Console.WriteLine("Employees Records");
            Console.WriteLine("==========================");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Employee #: {0}", StaffMembers[i].EmployeeNumber);
                Console.WriteLine("Full Name:  {0}", StaffMembers[i].EmployeeName);
                Console.WriteLine("Status:     {0}", StaffMembers[i].Status);
                Console.WriteLine("Hourly Wage {0}", StaffMembers[i].HourlySalary);
                Console.WriteLine("---------------------------");
            }


            Console.WriteLine("Employees Records");
            Console.WriteLine("==========================");
            foreach (var Member in StaffMembers)
            {
                Console.WriteLine("Employee #: {0}", Member.EmployeeNumber);
                Console.WriteLine("Full Name:  {0}", Member.EmployeeName);
                Console.WriteLine("Status:     {0}", Member.Status);
                Console.WriteLine("Hourly Wage {0}", Member.HourlySalary);
                Console.WriteLine("---------------------------");
            }


            // // Rental Property 

            RentalProperty[] Properties = new RentalProperty[8];

            Properties[0] = new RentalProperty();
            Properties[0].propertyNumber = 192873;
            Properties[0].TypeOfProperty = PropertyType.SingleFamily;
            Properties[0].BedRooms = 5;
            Properties[0].BathRooms = 3.50F;
            Properties[0].MonthlyRent = 2250.00D;
            Properties[1] = new RentalProperty();
            Properties[1].propertyNumber = 498730;
            Properties[1].TypeOfProperty = PropertyType.SingleFamily;
            Properties[1].BedRooms = 4;
            Properties[1].BathRooms = 2.50F;
            Properties[1].MonthlyRent = 1885.00D;
            Properties[2] = new RentalProperty();
            Properties[2].propertyNumber = 218502;
            Properties[2].TypeOfProperty = PropertyType.Apartment;
            Properties[2].BedRooms = 2;
            Properties[2].BathRooms = 1.00F;
            Properties[2].MonthlyRent = 1175.50D;
            Properties[3] = new RentalProperty();
            Properties[3].propertyNumber = 612739;
            Properties[3].TypeOfProperty = PropertyType.Apartment;
            Properties[3].BedRooms = 1;
            Properties[3].BathRooms = 1.00F;
            Properties[3].MonthlyRent = 945.00D;
            Properties[4] = new RentalProperty();
            Properties[4].propertyNumber = 457834;
            Properties[4].TypeOfProperty = PropertyType.TownHouse;
            Properties[4].BedRooms = 3;
            Properties[4].BathRooms = 2.50F;
            Properties[4].MonthlyRent = 1750.50D;
            Properties[5] = new RentalProperty();
            Properties[5].propertyNumber = 927439;
            Properties[5].TypeOfProperty = PropertyType.Apartment;
            Properties[5].BedRooms = 1;
            Properties[5].BathRooms = 1.00F;
            Properties[5].MonthlyRent = 1100.00D;
            Properties[6] = new RentalProperty();
            Properties[6].propertyNumber = 570520;
            Properties[6].TypeOfProperty = PropertyType.Apartment;
            Properties[6].BedRooms = 3;
            Properties[6].BathRooms = 2.00F;
            Properties[6].MonthlyRent = 1245.95D;
            Properties[7] = new RentalProperty();
            Properties[7].propertyNumber = 734059;
            Properties[7].TypeOfProperty = PropertyType.TownHouse;
            Properties[7].BedRooms = 4;
            Properties[7].BathRooms = 1.50F;
            Properties[7].MonthlyRent = 1950.25D;

            Console.Title = "Solas Property Rental";

            Console.WriteLine("Properties Listing");
            Console.WriteLine("=============================================");
            Console.WriteLine("Prop #  Property Type Beds Baths Monthly Rent");
            Console.WriteLine("---------------------------------------------");
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("{0}\t{1}\t{2}  {3:F}{4,12}",
                                  Properties[i].propertyNumber,
                                  Properties[i].TypeOfProperty,
                                  Properties[i].BedRooms,
                                  Properties[i].BathRooms,
                                  Properties[i].MonthlyRent.ToString("F"));
            }
            Console.WriteLine("=============================================");

            Console.ReadKey();

            return 0;
        }
    }


    public enum EmploymentStatus
    {
        FullTime,
        PartTime,
        Unknown
    };

    public class Employee
    {
        private long emplNbr;
        private string name;
        private EmploymentStatus st;
        private double wage;

        public long EmployeeNumber
        {
            get { return emplNbr; }
            set { emplNbr = value; }
        }

        public string EmployeeName
        {
            get { return name; }
            set { name = value; }
        }

        public EmploymentStatus Status
        {
            get { return st; }
            set { st = value; }
        }

        public double HourlySalary
        {
            get { return wage; }
            set { wage = value; }
        }

        public Employee()
        {
        }

        public Employee(long Number, string Name,
                        EmploymentStatus EStatus, double Salary)
        {
            emplNbr = Number;
            name = Name;
            st = EStatus;
            wage = Salary;
        }
    }

    public enum PropertyType
    {
        SingleFamily, TownHouse, Apartment, Unknown
    };

    public class RentalProperty
    {
        private long nbr;

        public long propertyNumber
        {
            get { return nbr; }
            set { nbr = value; }
        }

        private PropertyType tp;

        public PropertyType TypeOfProperty
        {
            get { return tp; }
            set { tp = value; }
        }

        private short bd;

        public short BedRooms
        {
            get { return bd; }
            set { bd = value; }
        }

        private float bt;

        public float BathRooms
        {
            get { return bt; }
            set { bt = value; }
        }

        private double rnt;

        public double MonthlyRent
        {
            get { return rnt; }
            set { rnt = value; }
        }

        public RentalProperty(long PropNbr = 0,
                                PropertyType Type = PropertyType.Unknown,
                                short Beds = 0,
                                float Baths = 0.0F,
                                double Rent = 0D)
        {
            PropNbr = nbr;
            Type = PropertyType.Unknown;
            Beds = bd;
            Baths = bt;
            Rent = rnt;
        }


    }
}
