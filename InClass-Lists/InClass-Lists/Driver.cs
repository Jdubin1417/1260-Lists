using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass_Lists
{
    public class Driver
    {
        public static void Main()
        {
            //CapacityCheckingWithDefault();
            //CapacityCheckingWhenSpecified();
            //ListBasics();
            //ListsWithObjects();
            MoreListMethods();
        }

        public static void CapacityCheckingWithDefault()
        {
            List<int> myNums = new List<int>(); //default is capacity of 0

            Console.WriteLine($"Capacity: {myNums.Capacity}");
            Console.WriteLine($"Count: {myNums.Count}");

            Console.WriteLine("Adding the value 3");
            myNums.Add(3); //capacity from 0 will go to 4 when adding an item

            Console.WriteLine($"Capacity: {myNums.Capacity}");
            Console.WriteLine($"Count: {myNums.Count}");

            Console.WriteLine("Adding the value 1");
            myNums.Add(1); //item 2

            Console.WriteLine($"Capacity: {myNums.Capacity}");
            Console.WriteLine($"Count: {myNums.Count}");

            Console.WriteLine("Adding the value 2");
            myNums.Add(2); //item 3

            Console.WriteLine($"Capacity: {myNums.Capacity}");
            Console.WriteLine($"Count: {myNums.Count}");

            Console.WriteLine("Adding the value 3");
            myNums.Add(3); //item 4

            Console.WriteLine($"Capacity: {myNums.Capacity}");
            Console.WriteLine($"Count: {myNums.Count}");

            Console.WriteLine("Adding the value 4");
            myNums.Add(4); //item 5 - need to expand, capacity should double

            Console.WriteLine($"Capacity: {myNums.Capacity}");
            Console.WriteLine($"Count: {myNums.Count}");
        }

        public static void CapacityCheckingWhenSpecified()
        {
            List<int> myNums = new List<int>(5); //initial capacity of 5

            Console.WriteLine($"Capacity: {myNums.Capacity}");
            Console.WriteLine($"Count: {myNums.Count}");

            Console.WriteLine("Adding the value 3");
            myNums.Add(3); //item 1

            Console.WriteLine($"Capacity: {myNums.Capacity}");
            Console.WriteLine($"Count: {myNums.Count}");

            Console.WriteLine("Adding the value 1");
            myNums.Add(1); //item 2

            Console.WriteLine($"Capacity: {myNums.Capacity}");
            Console.WriteLine($"Count: {myNums.Count}");

            Console.WriteLine("Adding the value 2");
            myNums.Add(2); //item 3

            Console.WriteLine($"Capacity: {myNums.Capacity}");
            Console.WriteLine($"Count: {myNums.Count}");

            Console.WriteLine("Adding the value 3");
            myNums.Add(3); //item 4

            Console.WriteLine($"Capacity: {myNums.Capacity}");
            Console.WriteLine($"Count: {myNums.Count}");

            Console.WriteLine("Adding the value 4");
            myNums.Add(4); //item 5

            Console.WriteLine($"Capacity: {myNums.Capacity}");
            Console.WriteLine($"Count: {myNums.Count}");

            Console.WriteLine("Adding the value 8");
            myNums.Add(8); //item 6 - capacity should double to 10

            Console.WriteLine($"Capacity: {myNums.Capacity}");
            Console.WriteLine($"Count: {myNums.Count}");
        }

        public static void ListBasics()
        {
            List<int> myNums = new List<int>();

            //fill the list with multiples of 2
            //0, 2, 4, 6, 8, 10, 12, 14, 16, 18
            for(int i = 0; i < 10; i++)
            {
                myNums.Add(i * 2);
            }

            //print all the elements in the list
            Console.WriteLine();
            for (int i = 0; i < myNums.Count; i++)
            {
                Console.WriteLine(myNums[i]);
            }

            myNums.RemoveAt(3); //removes the value 6

            Console.WriteLine();
            for (int i = 0; i < myNums.Count; i++)
            {
                Console.WriteLine(myNums[i]);
            }

            myNums.Add(16);
            myNums.Add(16);
            myNums.Add(16);
            myNums.Add(16);
            myNums.Add(16);

            Console.WriteLine();
            for (int i = 0; i < myNums.Count; i++)
            {
                Console.WriteLine(myNums[i]);
            }

            myNums.Remove(16); //remove the first instance of the value 16 from the list

            Console.WriteLine();
            for (int i = 0; i < myNums.Count; i++)
            {
                Console.WriteLine(myNums[i]);
            }

            myNums.Insert(4, 100);

            Console.WriteLine();
            for (int i = 0; i < myNums.Count; i++)
            {
                Console.WriteLine(myNums[i]);
            }

            myNums[0] = 1000; //replace a value

            Console.WriteLine();
            for (int i = 0; i < myNums.Count; i++)
            {
                Console.WriteLine(myNums[i]);
            }
        }

        public static void ListsWithObjects()
        {
            List<Person> peopleList = new List<Person>();

            //creating and adding on 2 lines
            Person p1 = new Person("Bob", 43);
            peopleList.Add(p1);

            //creating and adding on 1 line
            peopleList.Add(new Person("John", 33));

            peopleList.Add(new Person("Larry", 64));

            foreach(Person p in peopleList)
            {
                Console.WriteLine(p);
            }
        }

        public static void MoreListMethods()
        {
            List<int> myNums = new List<int>();
            myNums.Add(5);
            myNums.Add(2);
            myNums.Add(1);
            myNums.Add(7);
            myNums.Add(9);

            for(int i = 0; i < myNums.Count; i++)
            {
                Console.WriteLine(myNums[i]);
            }
            Console.WriteLine();
            
            List<int> myOtherNums = new List<int>();
            myOtherNums.Add(9);
            myOtherNums.Add(2);
            myOtherNums.Add(7);
            myOtherNums.Add(8);
            myOtherNums.Add(0);

            myNums.AddRange(myOtherNums);

            for (int i = 0; i < myNums.Count; i++)
            {
                Console.WriteLine(myNums[i]);
            }
            Console.WriteLine();

            myNums.RemoveRange(3, 2); //start index, number of values to remove

            for (int i = 0; i < myNums.Count; i++)
            {
                Console.WriteLine(myNums[i]);
            }
            Console.WriteLine();

            int indexOfVal1 = myNums.IndexOf(1);
            Console.WriteLine(indexOfVal1);
            Console.WriteLine();

            myNums.Sort();

            for (int i = 0; i < myNums.Count; i++)
            {
                Console.WriteLine(myNums[i]);
            }
            Console.WriteLine();

            //int[] myNumsArr = myNums.ToArray();
            //List<int> myNumsArrToList = myNumsArr.ToList();
        }
    }
}
