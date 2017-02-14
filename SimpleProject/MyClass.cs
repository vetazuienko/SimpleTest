using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleProject
{
    public class MyClass
    {

        private double increment(double x) {
            return x + 1;
        }

        public string prompt(string name) {
            return "Hello, " + name;
        }

        public List<double> increment_vector(List<double> vector) {

            List<double> result = new List<double>();

            foreach (double element in vector) {
                result.Add(increment(element));
            }

            return result;
        }
    }
}
