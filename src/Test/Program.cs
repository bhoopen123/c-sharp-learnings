using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Test
{
    //public class Name
    //{
    //    public readonly string firstName, lastName;
    //    public Name(string f, string l)
    //    {
    //        this.firstName = f;
    //        this.lastName = l;
    //    }
    //    public override bool Equals(System.Object obj)
    //    {
    //        if (obj == null) return false;
    //        if (obj.GetType() != this.GetType()) return false;
    //        Name n = obj as Name;
    //        return firstName.ToLower() == n.firstName.ToLower() &&
    //               lastName.ToLower() == lastName.ToLower();
    //    }
    //    public override string ToString()
    //    {
    //        return firstName + " " + lastName;
    //    }
    //}

    //public class FindDuplicates : IEqualityComparer<Name>
    //{
    //    public static void printDuplicates(Dictionary<Name, int> names)
    //    {
    //        //2. Should have a Null/Count check before entering the loop
    //        if (names == null || names.Count <= 1)
    //            return;
    //        //

    //        foreach (var pair in names)
    //        {
    //            if (pair.Value > 1)
    //            {
    //                Console.WriteLine(pair.Key);
    //            }
    //        }
    //    }

    //    public bool Equals(Name x, Name y)
    //    {
    //        return (x.firstName == y.firstName && x.lastName == y.lastName);
    //    }

    //    public int GetHashCode(Name obj)
    //    {
    //        return RuntimeHelpers.GetHashCode(obj);
    //    }
    //}

    class Program
    {
        static void Main(string[] args)
        {

            int i = 123;
            //Console.WriteLine($"{i--}");  // print - 123, i = 122
            //Console.WriteLine($"{++i}");  // print - 123, i = 123
            //Console.WriteLine($"{i++}");  // print - 123, i = 124

            i = 123;
            Console.WriteLine($"{i--},{++i},{i++}");    // print - 123, 123, 123 : i = 124
            Console.WriteLine($"{++i},{--i},{i--}");    // print - 125, 124, 124 : i = 123

            int v1 = 3;
            int v2 = 4;

            //v1 = v2 >= 5;


            Type t = typeof(string);
            BindingFlags flags = BindingFlags.Public
                         | BindingFlags.NonPublic
                         | BindingFlags.Instance;
            MemberInfo[] members = t.GetMembers(flags);
            foreach (MemberInfo item in members)
            {
                Console.WriteLine(item.Name);
            }
            Console.Read();
        }
        //public static void Main(String[] args)
        //{
        //    Name[] names = {new Name("Navin", "Kabra"),

        //                    new Name("NAVIN", "KABRA"),
        //                    new Name("NAVIN", "KABRA"),
        //                    new Name("Amit", "Paranjape"),
        //                    new Name("amit", "paranjape"),
        //                    new Name("amit", "paranjape"),
        //                    new Name("Navin", "Kotkar"),
        //                    new Name("Gaurav", "Kotkar")};

        //    FindDuplicates findDupObj = new FindDuplicates();
        //    Dictionary<Name, int> hash = new Dictionary<Name, int>(findDupObj);
        //    foreach (Name n in names)
        //    {
        //        //1. Contains has been applied on object, which would never find duplicate against other.
        //        // Should implement check on Keys explicitly 
        //        //if (hash.Keys.Contains<Name>(n))
        //        //for(int i=0; i<hash.Count;i++)
        //        if (hash.Keys.Contains(n, findDupObj))
        //        {
        //            //int ii=0;
        //            //hash.TryGetValue(n, out ii);
        //            //hash[n] += 1;

        //            IEnumerator<Name> enuNames = hash.Keys.GetEnumerator();
        //            while (enuNames.MoveNext())
        //            {
        //                Name nn = enuNames.Current;
        //                if (n.firstName == nn.firstName && n.lastName == nn.lastName)
        //                {
        //                    hash[nn] += 1;
        //                    break;
        //                }
        //            }

        //        }
        //        else
        //        {
        //            hash.Add(n, 1);
        //           // Console.WriteLine("Hash Data :"+ hash[n]);
        //        }

        //    }

        //    FindDuplicates.printDuplicates(hash);

        //    Console.Read();
        //}
    }
}
//    }
