using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMath
{
    public class MathHelper
    {
        public int PrintValue(int a, int b)
        { return a + b;}  
        public int PrintValue(bool a)
        {return a? 1 : 0;}  
        public void PrintValue(string a, string b)
        { Console.WriteLine(a + b); }
        public int PrintValue(int a, int b, int c)
        { return a * b * c;}
    }

}    
