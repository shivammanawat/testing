using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOD.BAL
{
    public class Calculate
    {
        public int Add(int a,int b)
        {
            return a + b;
        }
        public string Greet(string name)
        {
            return "Hello " + name;
        }
        public List<string> GetNames()
        {
            return new List<string>()
            {
                "Rohan",
                "Sachin",
                "Karan",
                "Jeson"
            };
        }
    }
}
