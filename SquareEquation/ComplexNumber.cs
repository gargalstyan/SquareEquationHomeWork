using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareEquation
{
    public struct ComplexNumber
    {
        public double A { get; set; }
        public double B { get; set; }
        public ComplexNumber(double a, double b)
        {
            this.A = a;
            this.B = b;
        }

        public static ComplexNumber operator +(ComplexNumber complexNumber1, ComplexNumber complexNumber2)
        {
            double realPart = complexNumber1.A + complexNumber2.A;
            double imaginaryPart = complexNumber1.B + complexNumber2.B;
            return new ComplexNumber(realPart, imaginaryPart);
        }
        public static ComplexNumber operator -(ComplexNumber complexNumber1, ComplexNumber complexNumber2)
        {
            double realPart = complexNumber1.A - complexNumber2.A;
            double imaginaryPart = complexNumber1.B - complexNumber2.B;
            return new ComplexNumber(realPart, imaginaryPart);
        }
        public static ComplexNumber operator *(ComplexNumber complexNumber1, ComplexNumber complexNumber2)
        {
            double realPart = complexNumber1.A * complexNumber2.A - complexNumber1.B * complexNumber2.B;
            double imaginaryPart = complexNumber1.A * complexNumber2.B + complexNumber2.A * complexNumber1.B;
            return new ComplexNumber(realPart, imaginaryPart);
        }
        public static ComplexNumber operator /(ComplexNumber complexNumber1, ComplexNumber complexNumber2)
        {
            double realPart = (complexNumber1.A * complexNumber2.A + complexNumber1.B * complexNumber2.B) / (Math.Pow(complexNumber2.A, 2) + Math.Pow(complexNumber2.B, 2));
            double imaginaryPart = (complexNumber1.B * complexNumber2.A - complexNumber1.A * complexNumber2.B) / (Math.Pow(complexNumber2.A, 2) + Math.Pow(complexNumber2.B, 2));
            return new ComplexNumber(realPart, imaginaryPart);
        }
        public static implicit operator double(ComplexNumber complexNumber)
        {
            if (complexNumber.B != 0)
            {
                throw new InvalidCastException("Cannot convert complex number to double");
            }
            else
                return complexNumber.A;
        }
        public override string ToString()
        {
            if (B == 0)
                return $"{A}";

            if (A == 0)
                return $"i{B}";

            if (B > 0)
            {
                if (B != 1)
                {
                    return $"{A} + {B}i";
                }
                else
                    return $"{A} + i";
            }
            else
            {
                if (B != -1)
                {
                    return $"{A}{B}i"; ;
                }
                else
                    return $"{A} - i";
            }
        }
    }
}
