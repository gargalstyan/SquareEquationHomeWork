using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareEquation
{
    public class SquareEquationSolver
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }

        public SquareEquationSolver(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }
        private double? d;

        public double D
        {
            get
            {
                if (d == null)
                {
                    d = B * B - 4 * A * C;

                }
                return d.Value;
            }
        }
        public ComplexNumber X1
        {
            get
            {
                if (D >= 0)
                {
                    return new ComplexNumber((-B + Math.Sqrt(D)) / (2 * A), 0);
                }
                else
                {
                    return new ComplexNumber(-B / (2 * A), Math.Sqrt(-D) / (2 * A));
                }
            }
        }
        public ComplexNumber X2
        {
            get
            {
                if (D >= 0)
                {
                    return new ComplexNumber((-B - Math.Sqrt(D)) / (2 * A), 0);
                }
                else
                {
                    return new ComplexNumber(-B / (2 * A), -Math.Sqrt(-D) / (2 * A));
                }
            }
        }
    }
}
