using System;
using System.Collections.Generic;

namespace lambda
{
    class Program
    {
        //delegate int CalculateAreaDel(int a);

        //static CalculateAreaDel CA = CalculateArea;

        static void Main(string[] args)
        {
            // 1st syntax- using anonymous funcation

            //CalculateAreaDel CA = new CalculateAreaDel( delegate (int a)
            //                                            {
            //                                                return (a * a);
            //                                            });

            //2nd syntax - using lambda expression
            //CalculateAreaDel CA = a => a * a;

            //3rd syntax - using Func - it takes input variable type and output variablet type, then you can define the method using the lambda syntax
            //Func<int, int> CA = area => area * area;

            //4th syntax - using Action, it only TAKES parameter and NO output is given. then you can define the method using the lambda syntax.
            Action<string> MyAction = y => Console.Write(y);
            MyAction("hi hellu");

            //5th Syntax - using Predicate - this is just a boolean returning function
            Predicate<string> IsSuperman = x => x == "Superman"; // this will return true of supplied string is eq Superman

            List<string> Names = new List<string>();

            Names.Add("Superman");
            Names.Add("Spiderman");
            Names.Add("Batman");

            var myname = Names.Find(IsSuperman); // you can use predicate here to filter a collection

            Console.WriteLine(myname);


            //Console.WriteLine(CA(3));
            Console.Read();

        }
        
    }
}
