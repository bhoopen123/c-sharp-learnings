using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PassingReferenceTypeByValueType
{
    class Products
    {
        public int Pro_No;
        public string Pro_Name;
        public Products(string prName,int prNo)
        {
            Pro_Name = prName;
            Pro_No = prNo;
        }
    }

    class Program
    {
        static void PassRefByValue(Products p1)
        {
            //// Change the Pro_No of 'p1'?
            p1.Pro_No = 1001;       // these changes will be reflect as till here the object will be same 
            p1.Pro_Name = "Vimal";  // these changes will be reflect as till here the object will be same 

            // Will the caller see this reassignment?
            p1 = new Products("Send By Pr1", 10001); // but once we asign the reference of a new object 
                                                     // it will create a new object and store the values in that object
                                                     // so these values wil not be updated..
 
        }

        static void PassListByValue(List<Products> list)
        {
            Console.WriteLine("Modifying the list values");
            for (int i = 0; i < list.Count;i++ )
            {
                if (list[i].Pro_Name == "pro2")
                {
                    list[i].Pro_Name = "Pro_Name has been changed to Changed ";

                    Products p1 = new Products("Send By Pr1", 10001);
                    list.Add(p1);
                }
            }

        }


        static void Main(string[] args)
        {
            //Console.WriteLine("create the object of Class");
            //Products pr1 = new Products("Santoor",101);
            //Console.WriteLine("Print the value Before Pass Ref By Value");
            //Console.WriteLine("pr1.Pro_No ="+pr1.Pro_No);
            //Console.WriteLine("pr1.Pro_Name =" + pr1.Pro_Name);
            //Console.WriteLine("Pass reference by value");
            //PassRefByValue(pr1);
            //Console.WriteLine("Print the value After Pass Ref By Value");
            //Console.WriteLine("pr1.Pro_No =" + pr1.Pro_No);
            //Console.WriteLine("pr1.Pro_Name =" + pr1.Pro_Name);


            // as the PassRefByValue() method is pointing to the same object as the caller, it is possible to alter the
            // object’s state data. What is not possible is to reassign what the reference is pointing to (slightly akin to
            // a constant pointer in C++).

            List<Products> proList = new List<Products>();
            proList.Add(new Products("pro1",11));
            proList.Add(new Products("pro2",11));
            proList.Add(new Products("pro3",11));
            proList.Add(new Products("pro4",11));
            proList.Add(new Products("pro5",11));
            proList.Add(new Products("pro6",11));

            Console.WriteLine("Before callimg PassListByValue");
            foreach (var item in proList)
	        {
		         Console.WriteLine(item.Pro_Name +"  "+ item.Pro_No);
	        }

            PassListByValue(proList);

            Console.WriteLine("After callimg PassListByValue");
            foreach (var item in proList)
            {
                Console.WriteLine(item.Pro_Name + "  " + item.Pro_No);
            }

            Console.Read();

        }
    }
}
