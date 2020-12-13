using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2020
{
    public class TestClass : IGetFullInfo
    {
        public string GetFullInfo()
        {
            return "Вызван из TestClass, Full info"; ;
        }

        public string GetInfoInt()
        {
            return "Вызван из TestClass";
        }
    }
}
