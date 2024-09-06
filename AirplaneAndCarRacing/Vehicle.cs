using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirplaneAndCarRacing
{
    internal abstract class Vehicle
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public DateTime Time { get; set; }

        public async Task<string> Move(string name, string color, int delay)
        {
            await Task.Delay(delay);
            return $"The {name} {color} color is moving";
        }
        public async Task<string> Finish(string name, string color, DateTime time)
        {
            await Task.Delay(1000);
            var finishTime = DateTime.Now - time;
            return $"The {name} {color} color is finished for {finishTime} milliseconds";
        }
    }
}
