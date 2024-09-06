using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirplaneAndCarRacing
{
    internal class Airplan : Vehicle, IStartEngine
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public DateTime Time;

        public Airplan(string name, string color)
        {
            Name = name;
            Color = color;
        }

        public async Task<string> StartEngine()
        {
            Time = DateTime.Now;
            await Task.Delay(4000);
            return $"The engine in {Name} {Color} color was started";
        }
        public async Task Race()
        {
            var tasks = new List<Task<string>>
            {
                StartEngine(),
                Move(Name, Color, 10000),
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
