using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExerciseapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //adding items to arraylist.
            ArrayList fruitList = new ArrayList();
            fruitList.Add("apple");
            fruitList.Add("banana");
            fruitList.Add("cherry");
            fruitList.Add("date");
            fruitList.Add("elderberry");

            //print total number of items in array.
            Console.WriteLine("Number of items in arraylist: \t" + fruitList.Count);
            //print all the elements in array using a loop.
            PrintElements(fruitList);
            //check if the arraylist contains the item "date".
            bool containsDate = SearchItem(fruitList, "date");
            Console.WriteLine("Does the arraylist contains Date? \t" + containsDate);
            //insert the element"fig" at second position in arraylist.
            InsertItem(fruitList, 1, "fig");
            //remove the item "banana" from the list.
            RemoveItem(fruitList, "banana");
            //print all array item in arraylist after modification.
            Console.WriteLine("Elements in arraylist after modification: ");
            PrintElements(fruitList);
            Console.ReadKey();
        }

            static void PrintElements(ArrayList list)
            {
                Console.WriteLine("Elements in arraylist: \t");
                foreach (var item in list) 
                {
                    Console.WriteLine(item);
                }
            }
            static bool SearchItem(ArrayList list, string item)
            {
                return list.Contains(item);
            }
            static void InsertItem(ArrayList list, int index ,object item) 
            {
                list.Insert(index,item);
            }
            static void RemoveItem(ArrayList list, object item) 
            {
                list.Remove(item);
            }



        }
        
    }
