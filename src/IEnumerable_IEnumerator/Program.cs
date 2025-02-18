using System;
using System.Collections;
using System.Collections.Generic;

namespace IEnumerable_IEnumerator
{
    public class Car
    {
        public string carName;
        public int currSpeed;

        public Car(string c_Name, int speed)
        {
            carName = c_Name;
            currSpeed = speed;
        }
    }

    // IEnumerable : this interface informs the caller that object's subitems can be enumerable
    public class Garage : IEnumerable
    {
        // garage has array of cars
        private Car[] carArray;

        //public Car[] getcars() { return carArray; }
        // fill the car Array with cars
        public Garage()
        {
            carArray = new Car[4];

            carArray[0] = new Car("car1", 30);
            carArray[1] = new Car("car2", 40);
            carArray[2] = new Car("car3", 50);
            carArray[3] = new Car("car4", 60);
        }

        // Implements the method of IEnumerable interface...
        public IEnumerator GetEnumerator()
        {
            // System.Array already implements IEnumerator
            return carArray.GetEnumerator();
            
            // or To implement this method as below
            //int index = 0;
            //for (int i = 0; i <= carArray.Length; i++)
            //{
            //    index++;
            //    // Lets check for end of list (its bad code since we used arrays)
            //    if (index <= carArray.Length)
            //    {
            //        // Return the current element and then on next function call 
            //        // resume from next element rather than starting all over again;
            //        yield return carArray[i];

            //    }
            //    else
            //    {
            //        yield return null;
            //    }
            //}
        }
    }

    /// <summary>
    /// This program is about when we have to use IEnumrable and IEnumerator,
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Garage carLot = new Garage();

            // Idealy it would be convenient to iterate the garage objects subitems using c# foreach
            // But the Compiler informs you that the Garage class does not implement a method GetEnumerator 
            // foreach(car c in carLot) // line thows error 

            // So we have to use GetEnumerator method of the class..
            IEnumerator obj = carLot.GetEnumerator();

            // Use MoveNext to iterate
            while (obj.MoveNext())
            {
                Car car = (Car)obj.Current;
                Console.WriteLine("car {0} ", car.carName.ToString());
            }

            //obj.MoveNext();
            //while (obj.Current != null)
            //{
            //    Car car = (Car)obj.Current;
            //    Console.WriteLine("car {0} ", car.carName.ToString());
            //    obj.MoveNext();
            //}


            //Let us now go ahead and use our custom MyArrayList with IEnumerable<T> implemented
            MyArrayList<string> myList = new MyArrayList<string>();

            myList.Add("1");
            myList.Add("2");
            myList.Add("3");
            myList.Add("4");

            foreach (string s in myList)
            {
                Console.WriteLine(s);
            }

            // Lets see how yield return works
            foreach (int i in YieldReturn())
            {
                Console.WriteLine(i);
            }
            Console.Read();
        }

        //the normal return statement does not preserve the state of the function while returning. 
        //i.e. every call to this function is a new call and it will return the first value only.
        static int SimpleReturn()
        {
            return 1;
            return 2;
            return 3;
        }

        //Where as if I replace the return keyword by yield return then the function will become capable of saving
        //its state while returning the value. 
        //i.e. when the function is called second time, it will continue the processing from where is has returned 
        //in the previous call.
        // must have IEnumerable return type...
        static IEnumerable<int> YieldReturn()
        {
            yield return 1;
            yield return 2;
            yield return 3;
        }
    }

    class MyArrayList<T> : IEnumerable<T>
    {
        T[] m_Items = null;
        int freeIndex = 0;

        public MyArrayList()
        {
            // For the sake of simplicity lets keep them as arrays
            // ideally it should be link list
            m_Items = new T[100];
        }

        public void Add(T item)
        {
            // Let us only worry about adding the item 
            m_Items[freeIndex] = item;
            freeIndex++;
        }

        #region IEnumerable<T> Members

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T t in m_Items)
            {
                // Lets check for end of list (its bad code since we used arrays)
                if (t == null) // this wont work if T is not a nullable type
                {
                    break;
                }

                // Return the current element and then on next function call 
                // resume from next element rather than starting all over again;
                yield return t;
            }
        }

        #endregion

        #region IEnumerable Members

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            // Lets call the generic version here
            return this.GetEnumerator();
        }

        #endregion
    }
}
