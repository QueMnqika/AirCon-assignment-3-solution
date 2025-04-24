using System;
using AirConditioner;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            AirCon homeAirCon = new AirCon("Samsung", "Cool", 20, "Medium");
            string question = "Would you like to switch the Aircon on? \n Yes or No?";
            Console.WriteLine(question);
            string reply = Console.ReadLine();

            

            if (reply == "Yes" || reply == "YES" || reply == "yes")
                homeAirCon.TurnOn();
            else if (reply == "No" || reply == "NO" || reply == "no")
                homeAirCon.TurnOff();
            else
            {
                Console.WriteLine("OOPS! Maybe you made a mistake, try again!");
                while (reply != "Yes" || reply != "No" || reply != "yes")
                {
                    Console.WriteLine(question);
                    reply = Console.ReadLine();
                    if (reply == "Yes" || reply == "YES" || reply == "yes")
                    {
                        homeAirCon.TurnOn();
                        break;
                    }
                    else if (reply == "No" || reply == "NO" || reply == "no")
                    {
                        Console.WriteLine("");
                        homeAirCon.TurnOff();
                    }
                }
            }



        }
    }
}
