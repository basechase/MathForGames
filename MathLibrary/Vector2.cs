using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Xml.Schema;

namespace MathLibrary
{
    public struct Vector2
    {
        public float x, y;

        public float Magnitude
        {
            get
            {
                // c = sqrt(x^2 x y^2)
                return (float)Math.Abs(Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)));
            }
        }

        public Vector2 Normalized
        {
            get
            {
                if (Magnitude == 0)
                {
                    return new Vector2();
                }
                return this / Magnitude;
            }
        }



        public Vector2(float x = 0, float y = 0)
        {
            this.x = x;
            this.y = y;
        }

        public Vector2 Normalize()
        {
            this = Normalized;
            return this;
        }

        public override string ToString()
        {
            // (x, y)
            return   x + ", " + y + ")";
        }

        public float DotProduct(Vector2 other)
        {

            return (x * other.x) + (y * other.y);
        }

        public float Distance(Vector2 other)
        {
            return (other - this).Magnitude;
        }


        public static bool operator ==(Vector2 lhs, Vector2 rhs)
        {
            
            return (lhs.x == rhs.x) && (lhs.y == rhs.y);
        }

        public static bool operator !=(Vector2 lhs, Vector2 rhs)
        {
            return !(lhs == rhs);
        }


        //op overload for addition

       public static Vector2 operator +(Vector2 left, Vector2 right)
        {
            return new Vector2(left.x + right.x, left.y + right.y);
        }

        //op overload for subtraction

        public static Vector2 operator -(Vector2 left, Vector2 right)
        {
            return new Vector2(left.x - right.x, left.y - right.y);
        }


        //op overload for multipication by a vector
        /*
        public static Vector2 operator *(Vector2 left, Vector2 right)
        {
            return new Vector2(left.x * right.x, left.y * right.y);
        }
               in the math world you cant do this, is a bad habit 

        */


        //op overload for multplication by a scalar
        public static Vector2 operator *(Vector2 left, float scalar)
        {
            return new Vector2(left.x * scalar, left.y * scalar);
        }

        //op overload for division
        public static Vector2 operator /(Vector2 left,float scalar)
        {
            return new Vector2(left.x / scalar, left.y / scalar);
        }

        //implicit conversion from System.Numerics.Vector2 to Vector2
        
        public static implicit operator Vector2(System.Numerics.Vector2 vector)
        {
            return new Vector2(vector.X, vector.Y);
        }

        //implicit conversion from Vector2 to System.Numerics.Vector2

        public static implicit operator System.Numerics.Vector2(Vector2 vector)
        {
            return new System.Numerics.Vector2(vector.x, vector.y);
        }
        

        

    }
}
