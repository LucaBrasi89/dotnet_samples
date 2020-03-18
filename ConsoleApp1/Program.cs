using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //CustomType item = new  CustomType();
            //PropertyInfo[] myPropertyInfo;
            //// Get the properties of 'Type' class object.
            //myPropertyInfo = Type.GetType("ConsoleApp1.CustomType").GetProperties();
            //Console.WriteLine("Properties of System.Type are:");
            //for (int i = 0; i < myPropertyInfo.Length; i++)
            //{
            //    Console.WriteLine(myPropertyInfo[i].Name.ToString());
            //}
            //// Access to properties of obj
            //foreach (var propInfo in myPropertyInfo)
            //{
            //    Console.WriteLine(item.GetType().GetProperty(propInfo.Name).GetValue(item, null));
            //}

            DescriptionBlock db = new DescriptionBlock();
            Console.WriteLine(db);

        }
    }
}
