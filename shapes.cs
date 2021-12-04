using System;

namespace assignment5
{
    public class BaseShape
    {
        public BaseShape() {}
        public virtual float area() { return 0f; }
        public virtual float perimeter() { return 0f; }
    }

    public class Square : BaseShape
    {
        public float length;
        public float width;

        public Square(float length, float width)
        {
            this.length = length;
            this.width = width;
        }

        public override float area()
        {
            return this.length * this.width;
        }

        public override float perimeter()
        {
            return (2f * this.length) + (2f * this.width);
        }
    }

    public class Cube : Square
    {
        public float height;

        public Cube(float length, float width, float height) : base(length, width)
        {
            this.height = height;
        }

        public override float area()
        {
            return this.length * this.width * this.height;
        }

        public override float perimeter()
        {
            return (2 * length * width) + (2 * length * height) + (2 * width * height);
        }
    }

    public class Circle : BaseShape
    {
        public float radius;

        public Circle(float radius)
        {
            this.radius = radius;
        }

        public override float area()
        {
            return 3.14f * this.radius * this.radius;
        }

        public override float perimeter()
        {
            return 2f * 3.14f * this.radius;
        }
    }

    public class Sphere : Circle
    {
        public Sphere(float radius) : base(radius) {}

        public override float area()
        {
            return (4/3) * 3.14f * radius * radius * radius;
        }

        public override float perimeter()
        {
            return 4f * 3.14f * radius * radius;
        }
    }

    public class Cylinder : Circle
    {
        public float height;

        public Cylinder(float radius, float height) : base(radius)
        {
            this.height = height;
        }

        public override float area()
        {
            return 3.14f * radius * radius * height;
        }

        public override float perimeter()
        {
            return (2f * 3.14f * radius * height) + (2f * 3.14f * radius * radius);
        }
    }
}
