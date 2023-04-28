using System;
using System.Security.AccessControl;

namespace ConsoleApp4
{
    class program
    {
        static void Main()
        {
             Class1 bil1 = new Class1();
            bil1.mymetod_3 = 3500;
            bil1.mymetod_1 = "Mercedes";
            bil1.mymetod_2 = 2023;

            Console.WriteLine(" Din bils information " + bil1.mymetod_1+ " Vikten är " + bil1.mymetod_2 + " Årsmodellen är  " + bil1.mymetod_3);

        }


    }
}