using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_Test
{
    public class Calculator
    {
        public int Sum(int a,int b)=>a+b;
        public int Max(int a, int b) => (a > b) ? a : b;

    }
}
