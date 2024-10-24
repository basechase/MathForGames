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
                // Calculate the magnitude of the vector
                return (float)Math.Abs(Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2) + Math.Pow(w, 2)));
            }
        }

        public void Normalize()
        {
            float magnitude = Magnitude;
            if (magnitude > 0)
            {
                x /= magnitude;
                y /= magnitude;
                z /= magnitude;
                w /= magnitude;
            }
        }

        public Vector4 Normalized
        {
            get
            {
                float magnitude = Magnitude;
                return magnitude > 0 ? this / magnitude : new Vector4(0, 0, 0, 0);
            }
        }

        public Vector4(float x = 0, float y = 0, float z = 0, float w = 0)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        public Vector4 CrossProduct(Vector4 other)
        {
            return new Vector4(
                y * other.z - z * other.y,
                z * other.x - x * other.z,
                x * other.y - y * other.x,
                0);
        }

        public static Vector4 operator *(Vector4 left, float scalar)
        {
            return new Vector4(left.x * scalar, left.y * scalar, left.z * scalar, left.w * scalar);
        }

        public static Vector4 operator *(float scalar, Vector4 vector)
        {
            return new Vector4(vector.x * scalar, vector.y * scalar, vector.z * scalar, vector.w * scalar);
        }

        public static Vector4 operator +(Vector4 left, Vector4 right)
        {
            return new Vector4(left.x + right.x, left.y + right.y, left.z + right.z, left.w + right.w);
        }

        public static Vector4 operator -(Vector4 left, Vector4 right)
        {
            return new Vector4(left.x - right.x, left.y - right.y, left.z - right.z, left.w - right.w);
        }

        public static Vector4 operator /(Vector4 vector, float scalar)
        {
            
            return new Vector4(vector.x / scalar, vector.y / scalar, vector.z / scalar, vector.w / scalar);
        }

        public float DotProduct(Vector4 other)
        {
            return (x * other.x) + (y * other.y) + (z * other.z) + (w * other.w);
        }
    }
}