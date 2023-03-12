// Written by Dr. Shane Wilson.
// The author licenses this file to you under the MIT license.
// See the LICENSE file in the solution root for more information.

namespace Structures
{
    // A simple structure to store the x and y position of something.
    public struct Coords
    {
        public double _xPos;
        public double _yPos;

        public Coords(double x, double y)
        {
            _xPos = x;
            _yPos = y;
        }

        public override string ToString()
        {
            return $"({_xPos}, {_yPos})";
        }
    }

    // Define a simple structure that stores screen coordinates 
    // This struct uses Properties instead of fields
    public readonly struct CoordsReadOnly
    {
        public CoordsReadOnly(double x, double y)
        {
            X = x;
            Y = y;
        }
        // Property called X that is read only
        public double X { get; init; }
        public double Y { get; init; }
        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }

    //// Define a simple structure that stores a 3D vector
    //public struct Vector3D
    //{
    //    public double x;
    //    public double y;
    //    public double z;
    //    public Vector3D(double xValue, double yValue, double zValue)
    //    {
    //        x = xValue;
    //        y = yValue;
    //        z = zValue;
    //    }
    //    public override string ToString()
    //    {
    //        return $"{x}, {y}, {z}";
    //    }
    //}


    // Activity solution
    // Define a simple structure that stores a 3D vector with properties
    public struct Vector3D
    {
        public Vector3D(double xValue, double yValue, double zValue)
        {
            X = xValue;
            Y = yValue;
            Z = zValue;
        }

        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public override string ToString()
        {
            return $"{X}, {Y}, {Z}";
        }
    }


    /// <summary>
    /// A simple structure with get set and init accessors.
    /// </summary>
    public struct Book
    {
        // private backing fields for the properties
        private string _bookTitle;
        private string _isbn;

        // To make a property readonly add the readonly modifier and remove the set accessor
        //public readonly string BookTitle
        public string BookTitle
        {
            // get accessor just returns _bookTitle
            get { return _bookTitle; }
            // set accessor assigns _bookTitle to value
            set { _bookTitle = value; }
        }
        public string ISBN
        {
            get { return _isbn; }
            // init accessor 
            init { _isbn = value; }
        }
        // Example of expression-bodied Property member 
        // the single expression follows the => 
        public string BookDetails => $"Title: {_bookTitle} ISBN:{_isbn}";
    }

    public struct SaleItem
    {
        // Auto implemented properties
        // backing fields automatically added
        // Required keyword forces client to initialise 

        //public required string Name { get; set; } //required only in > C# 11 .NET 7
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
