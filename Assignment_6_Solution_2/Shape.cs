using System;

namespace Assignment_6_Solution_2
{
    // Class: Shape
    // Summary: Class shape contains the property name, a constructor holds the 
    // information and abstract methods.
    public abstract class Shape
    {
        // Name property to store the received string
        public string Name
        { get; private set; }
        // Shape constructor hold the string name of the shape
        public Shape(string name)
        { Name = name; }
        // Abstract method of the shape area to be override by derived class
        public abstract double Area();
        // Abstract method of the shape perimeter to be override by derived class
        public abstract double Perimeter();
    }
    // Class: Circle
    // Summary: Radius derived from the base class property and methods. 
    // It has override area and perimeter method.
    public class circle : Shape
    {
        // Initialized the radius of the circle
        private double Radius;
        // Circle constructor derived from the base N parameter
        // that hold the radius and string name
        public circle(string name, double radius) : base(name)
        {
            Radius = radius;
        }
        // Radius property read and write field radius 
        public double radius { get; private set; }
        // Override method return the area of the circle
        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
        // Override Perimeter method return the perimeter of a circle
        public override double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
    // Class: Square
    // Summary: Class square derived from the base class property and methods. 
    // It has override area and perimethod method.
    public class square : Shape
    {
        // Create a private side field of the class
        private double Side;
        // Square constructor derived from the base N parameter
        // that hold the side and string name
        public square(string name, double side) : base(name)
        { Side = side; }
        // Override method return the area of the square
        public override double Area()
        {
            return Math.Pow(Side, 2);
        }
        // Override method return the perimeter of a square
        public override double Perimeter()
        { return 4 * Side; }
    }
}
