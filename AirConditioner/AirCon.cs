using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirConditioner
{
    public class AirCon
    {
        public string BrandName;
        public string AirConMode;
        public int AirConTemperature;
        public string AirConFanSpeed;
        private bool isOn;
        private int topTemperature = 29;
        private int lowTemperature = 18;
    

    public AirCon(string brandName, string userMode, int userTemperature, string userFanSpeed)
        {
            BrandName = brandName;
            AirConMode = userMode;
            AirConTemperature = userTemperature;
            AirConFanSpeed = userFanSpeed;
            this.isOn = true;
        }

        public void TurnOn()
        {
            if (isOn)
            {
                Console.WriteLine("The air con is ON!");
                Console.WriteLine("Which mode of the aircon would you like? Cool, Heat or Dry?");
                string modeReply = Console.ReadLine();
                SetMode(modeReply);
                Console.WriteLine("What is the desired temperature (∘C)");
                string temperatureReply = Console.ReadLine();
                SetTemperature(int.Parse(temperatureReply));
                Console.WriteLine("What is the desired fan speed? Low, Medium, or High?");
                string fanSpeedReply = Console.ReadLine();
                SetFanSpeed(fanSpeedReply);
                Console.WriteLine($"Tadaaaa! Your {BrandName} air con is on {modeReply} Mode, {temperatureReply}∘C and at a {fanSpeedReply} fan speed");

            }
        }

        public void TurnOff()
        {
            if (!isOn)
            {
                Console.WriteLine("The aircon is OFF!");
                
            }
        }

        public void SetMode (string userMode)
        {
            string[] airConModes = { "Heat", "Cool", "Dry" };
            while(userMode != string.Empty)
            {
                if (userMode == airConModes[0] || userMode == airConModes[0].ToLower() || userMode == airConModes[0].ToUpper())
                {
                    Console.WriteLine($"The selected mode is {airConModes[0]}");
                    userMode = airConModes[0];
                    break;
                } else if (userMode == airConModes[1] || userMode== airConModes[1].ToLower() || userMode== airConModes[1].ToUpper())
                {
                    Console.WriteLine($"The selected mode is {airConModes[1]}");
                    userMode = airConModes[1];
                    break;
                } else if(userMode == airConModes[2] || userMode == airConModes[2].ToLower() || userMode == airConModes[2].ToUpper())
                {
                    Console.WriteLine($"The selected mode is {airConModes[2]}");
                    userMode = airConModes[2];
                    break;
                }
                
            }


        }

        public void SetTemperature(int userTemperature)
        {
            
            if (userTemperature > topTemperature)
            {
                Console.WriteLine($"Your temperature required is above the maximum temperature");
                userTemperature = topTemperature;
                Console.WriteLine($"We've set your temperature to the maximum of {topTemperature}∘C");
            } else if (userTemperature < lowTemperature)
            {
                Console.WriteLine($"Your temperature required is above the minimum temperature");
                userTemperature = lowTemperature;
                Console.WriteLine($"We've set your temperature to the minimum of {lowTemperature}∘C");
            }
            else if (userTemperature <= topTemperature || userTemperature >= lowTemperature )
            {
                Console.WriteLine($"The temperature set is {userTemperature}∘C");
            }
        }

        public void SetFanSpeed (string userFanSpeed)
        {
            string[] fanSpeed = { "Low", "Medium", "High" };

            if (userFanSpeed == fanSpeed[0] || userFanSpeed == fanSpeed[0].ToLower() || userFanSpeed == fanSpeed[0].ToUpper())
            {
                Console.WriteLine($"The selected fan speed is {fanSpeed[0]}");
                userFanSpeed = fanSpeed[0];
            } else if (userFanSpeed == fanSpeed[1] || userFanSpeed == fanSpeed[1].ToLower() || userFanSpeed == fanSpeed[1].ToUpper())
            {
                Console.WriteLine($"The selected fan speed is {fanSpeed[1]}");
                userFanSpeed= fanSpeed[1];
            }else if (userFanSpeed == fanSpeed[2] || userFanSpeed == fanSpeed[2].ToLower() || userFanSpeed == fanSpeed[2].ToUpper())
            {
                Console.WriteLine($"The selected fan speed is {fanSpeed[2]}");
                userFanSpeed= fanSpeed[2];
            }
        }
    }
}
