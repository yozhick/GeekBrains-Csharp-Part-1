using System;

namespace Task3
{
    public class RationalNumber
    {
        public int Numerator { get; private set; }
        public int Denominator { get; private set; }

        public double Decimal => Numerator / (double)Denominator;

        public static RationalNumber operator +(RationalNumber a, RationalNumber b)
        {
            int lcm = GetLeastCommonMultiple(a.Denominator, b.Denominator);
            int coefA = lcm / a.Denominator;
            int coefB = lcm / b.Denominator;

            return new RationalNumber(a.Numerator * coefA + b.Numerator * coefB, a.Denominator * coefA);
        }

        public static RationalNumber operator -(RationalNumber a, RationalNumber b)
        {
            int lcm = GetLeastCommonMultiple(a.Denominator, b.Denominator);
            int coefA = lcm / a.Denominator;
            int coefB = lcm / b.Denominator;

            return new RationalNumber(a.Numerator * coefA - b.Numerator * coefB, a.Denominator * coefA);
        }

        public static RationalNumber operator *(RationalNumber a, RationalNumber b)
        {
            return new RationalNumber(a.Numerator * b.Numerator, a.Denominator * b.Denominator);
        }

        public static RationalNumber operator /(RationalNumber a, RationalNumber b)
        {
            return new RationalNumber(a.Numerator * b.Denominator, a.Denominator * b.Numerator);
        }


        public RationalNumber(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new ArgumentException("Знаменатель не может быть равен 0");

            if (numerator < 0 && denominator < 0)
            {
                numerator = Math.Abs(numerator);
                denominator = Math.Abs(denominator);
            }
            else
            {
                if (denominator < 0)
                {
                    numerator = -numerator;
                    denominator = -denominator;
                }
            }

            Numerator = numerator;
            Denominator = denominator;

            Reduce();
        }

        public void Reduce()
        {
            int gcd = GetGreatestCommonDivisor(Numerator, Denominator);
            Numerator /= gcd;
            Denominator /= gcd;
        }

        private static int GetGreatestCommonDivisor(int num1, int num2)
        {
            num1 = Math.Abs(num1);
            num2 = Math.Abs(num2);

            while (num1 != num2)
            {
                if (num1 > num2)
                    num1 -= num2;
                else
                    num2 -= num1;
            }
            return num1;
        }

        private static int GetLeastCommonMultiple(int num1, int num2)
        {
            return Math.Abs(num1 * num2 / GetGreatestCommonDivisor(num1, num2));
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }
    }
}
