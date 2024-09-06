using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AirplaneAndCarRacing
{
    internal class Car : Vehicle, IStartEngine
    {
        public string Name { get; set; }
        public string Color { get; set; }

        public DateTime Time;

        public Car(string name, string color)
        {
            Name = name;
            Color = color;
        }

        public async Task<string> StartEngine()
        {
            Time = DateTime.Now;
            await Task.Delay(3000);
            return $"The engine in {Name} {Color} color was started";
        }
        public async Task Race()
        {
            var tasks = new List<Task<string>> 
            { 
                StartEngine(),
                Move(Name, Color, 12000),
            };

            while (tasks.Count > 0)
            {
                var createdTask = await Task.WhenAny(tasks);

                tasks.Remove(createdTask);

                Console.WriteLine(createdTask.Result);
            }

            Console.WriteLine(Finish(Name, Color, Time).Result);
        }
    }
}
