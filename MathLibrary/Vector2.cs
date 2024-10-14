namespace MathLibrary
{
    public struct Vector2
    {
        public float x, y;

        public float Magnitude
        {
            get
            {
                return (float)Math.Abs(Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)));
            }
        }

        public Vector2 Normalized
        {
            get
            {
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
            return "(" + x + ", " + y + ")";
        }

        public static bool operator ==(Vector2 left, Vector2 right)
        {
            return (left.x == right.x) && (left.y == right.y);
        }

        public static bool operator !=(Vector2 left, Vector2 right)
        {
            return !(left == right);
        }

        public static Vector2 operator +(Vector2 left, Vector2 right)
        {
            return new Vector2(left.x + right.x, left.y + right.y);
        }

        public static Vector2 operator -(Vector2 left, Vector2 right)
        {
            return new Vector2(left.x - right.x, left.y - right.y);
        }

        public static Vector2 operator *(Vector2 left, float scalar)
        {
            return new Vector2(left.x * scalar, left.y * scalar);
        }

        public static Vector2 operator /(Vector2 left, float scalar)
        {
            return new Vector2(left.x / scalar, left.y / scalar);
        }

        public static implicit operator Vector2(System.Numerics.Vector2 vector)
        {
            return new Vector2(vector.X, vector.Y);
        }

        public static implicit operator System.Numerics.Vector2(Vector2 vector)
        {
            return new System.Numerics.Vector2(vector.x, vector.y);
        }
    }
}
