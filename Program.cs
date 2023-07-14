using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConDay5Assign7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Apple");
            arrayList.Add("Banana");
            arrayList.Add("Cherry");
            arrayList.Add("Date");
            arrayList.Add("elderberry");
            
            int totalEle = arrayList.Count;
            Console.WriteLine("No.of elements in arraylist list : " + totalEle);
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }
            Console.WriteLine("Enter item to serach ");
            string searchItem = Console.ReadLine();
            int index = arrayList.IndexOf(searchItem);
            if (index == -1)
            {
                Console.WriteLine($"No such item {searchItem} exist in hardwARE List");
            }
            else
            {

                Console.WriteLine("enter update item");
                arrayList.Insert(1,"fig") ;
                Console.ReadLine();
                Console.WriteLine("updated arrays List is as follows!!");
                for (int i = 0; i < arrayList.Count; i++)
                {
                    Console.WriteLine(arrayList[i]);
                }
            }
            Console.WriteLine(" Before Element banana is removed");
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }
            

            arrayList.RemoveAt(2);
           // Console.WriteLine(" After Element banana is removed");
            Console.WriteLine(" All the elements in Arraylist will be: ");
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }
            Console.ReadKey();
        }
    }
}
