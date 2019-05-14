// The program is designed to use an abstract class Shape that support
// the ability to request the automatically implement string propety, 
// area method, and its perimeter method. In addition, the property Name
// has a private set implementation and public get implementation. 
// The area and perimeter methods have to be abstract and public.
using System;
using System.Collections.Generic;

namespace Assignment_6_Solution_2
{
    // This class program contains the list, putinShapeList method. When it calls 
    // the program display the shape information on the list and its area and perimeter.
    class Program
    {
        // Create an instance of the list that hold the class Shape 
        private static List<Shape> TheShapes = new List<Shape>();
        // Static method that add instance of shape to the list theShapes.
        static void putInShapeList(Shape S) { TheShapes.Add(S); }
        // This method is to place instances of a circle and square in a List of the 
        // base class type and iterate through the List to print out the derived 
        // instances name, perimeter and area.
        static void Main(string[] args)
        {
            // Call the putInShapeList method hold the circle radius and square side.
            putInShapeList(new circle("circle", 10.0));
            putInShapeList(new square("square", 5));
            // To display how many shapes are on the list
            Console.WriteLine($"There are {TheShapes.Count} shapes in our list");
            // Loop through the object, name, circle, and square on the list and 
            // to display the object shape, area, and perimeter.
            foreach (var S in TheShapes)
                Console.WriteLine($"\tThe object is a {S.Name}, its perimeter is " +
                    $"{S.Perimeter():F5} " + $"and the Area is {S.Area():F5}");
        }
    }
}
