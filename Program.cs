using CL_military;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_7A___C___Military_Unit_Implementing_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write your main class first. This will consist of your variables and methods that execute the mission of your unit.Since you have not built your unit, 
            //you cannot actually run the program, so you will have to supply your methods with appropriate print statements to have your program run to completion.
            CommShop comm = new CommShop();
            Networking networking = new Networking();
            Radio radio = new Radio();
            Techs techs = new Techs();

            Console.WriteLine("This is the each section of the comshop at 1/8");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine($"{comm.JobDesc()}{networking.JobDesc()}");
            Console.WriteLine($"{comm.MOS()}{networking.MOS()}");
            Console.WriteLine($"{comm.Weapons()}{networking.Weapons()}");
            Console.WriteLine($"{comm.Equipment()}{networking.Equipment()}");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine($"{comm.JobDesc()}{radio.JobDesc()}");
            Console.WriteLine($"{comm.MOS()}{radio.MOS()}");
            Console.WriteLine($"{comm.Weapons()}{radio.Weapons()}");
            Console.WriteLine($"{comm.Equipment()}{radio.Equipment()}");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine($"{comm.JobDesc()}{techs.JobDesc()}");
            Console.WriteLine($"{comm.MOS()}{techs.MOS()}");
            Console.WriteLine($"{comm.Weapons()}{techs.Weapons()}");
            Console.WriteLine($"{comm.Equipment()}{techs.Equipment()}");
            Console.ReadKey();
            Console.Clear();

        }
    }
}
