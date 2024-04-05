using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFace.Models
{
    internal class Calculate: IAdd1, IMultiply, IDifference, IDivide
    {
        public float Add(float x, float y) => x + y;
        public float Difference(float x, float y) => x - y;
        public float Divide(float x, float y) => x / y;
        public float Multiply(float x, float y) => x * y;
    }
}
