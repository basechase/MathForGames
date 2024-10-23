using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace MathLibrary
{
    public struct Vector4
    {
        public float x, y, z, w;

        public float Magnitude
        {
            get
            {
                // c = sqrt(x^2 + y^2)
                return (float)Math.Abs(Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2) + Math.Pow(w,2)));
            }
        }

        public float DotProduct(Vector4 other)
        {
            return (x * other.x) + (y * other.y) + (z * other.z) + (w * other.w);
        }


    }

}