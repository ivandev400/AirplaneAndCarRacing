using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirplaneAndCarRacing
{
    internal interface IStartEngine
    {
        public Task<string> StartEngine();
    }
}
