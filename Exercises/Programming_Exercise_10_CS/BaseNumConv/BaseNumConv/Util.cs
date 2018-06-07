using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseNumConv
{
    class Util
    {
        public static int dec2bin(int input)
        {
            int d = 1;
            int r = 0;
            while (input > 0)
            {
                int c = input % 2;
                r += d * c;
                input = input / 2;
                d *= 10;
            }
        }
        public static int dec2oct(int input)
        {
            int d = 1;
            int r = 0;
            while (input > 0)
            {
                int c = input % 8;
                r += d * c;
                input = input / 8;
                d *= 2;
            }
        }
        public static int bin2dec(int input)
        {
            int d = 1;
            int r = 0;
            while (input > 0)
            {
                int c = input % 10;
                r += d * c;
                input = input / 10;
                d *= 2;
            }
        }
        public static int bin2oct(int input)
        {
            int d = 1;
            int r = 0;
            while (input > 0)
            {
                int c = input % 8;
                r += d * c;
                input = input / 8;
                d *= 2;
            }
        }
        public static int oct2bin(int input)
        {
            int d = 1;
            int r = 0;
            while (input > 0)
            {
                int c = input % 2;
                r += d * c;
                input = input / 2;
                d *= 8;
            }
        }
        public static int oct2dec(int input)
        {
            int d = 1;
            int r = 0;
            while (input > 0)
            {
                int c = input % 10;
                r += d * c;
                input = input / 10;
                d *= 8;
            }
        }
    }
}
