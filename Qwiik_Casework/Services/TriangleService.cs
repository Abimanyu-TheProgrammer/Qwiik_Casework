using System;
namespace Qwiik_Casework.Services
{
    public class TriangleService : ITriangleService
    {
        public string TypeOfTriangle(int x, int y, int z)
        {
            if (x == y && y == z)
                return "Equilateral Triangle";

            else if (x == y || y == z || z == x)
                return "Isosceles Triangle";

            else
                return "Scalene Triangle";
        }
    }
}

