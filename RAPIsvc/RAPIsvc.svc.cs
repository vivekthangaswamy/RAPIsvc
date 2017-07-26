using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAPIsvc
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class RAPIsvc : IReadifyInterviewService
    {
        public Guid WhatIsMyToken()
        {
            return new Guid("eb65085d-699c-4c69-ab0e-6c8d38160997");
        }


        public TriangleType WhatShapeIsThis(int x, int y, int z)
        {
            if ((x + y > z && x + z > y && y + z > x) && (x > 0 && y > 0 && z > 0))
            {
                if (x == y && y == z)
                {
                    return TriangleType._Equilateral;
                }
                else if (x == y || y == z || x == z)
                {
                    return TriangleType._Isosceles;
                }
                else
                {
                    return TriangleType._Scalene;
                }
            }
            else
            {
                return TriangleType._Error;
            }
        }


        public long FibonacciNumber(long c)
        {
            long counter = c;
            var fibonacci = new List<long>();

            if (c == 0)
            {
                return 0;
            }
            //check for negative value, 
            //if it is negative convert to positive by multiplying by -1
            if (c < 0)
            {
                counter = counter * -1;
            }


            fibonacci.Add(0);
            fibonacci.Add(1);

            for (int i = 2; i <= counter; i++)
            {
                fibonacci.Add(fibonacci[i - 1] + fibonacci[i - 2]);
            }

            var result = fibonacci[fibonacci.Count - 1];

            if (c < -1)
            {
                result = result * -1;
            }
            return result;

        }

        public string ReverseWords(string s)
        {
            string temp = "", result = "";
            for (int i = 0; i < s.Length; i++)
                if (s[i] != ' ')

                    temp = s[i] + temp;
                else
                {
                    result += temp + s[i];
                    temp = "";
                }

            result += temp;

            return result;
        }

      
    }
}
