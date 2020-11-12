namespace Task1
{
    class ComplexClass
    {
        private double im;
        double re;

        public double Im
        {
            get { return im; }
            set
            {
                if (value >= 0) im = value;
            }
        }

        public ComplexClass()
        {
            im = 0;
            re = 0;
        }

        public ComplexClass(double im, double re)
        {           
            this.im = im;
            this.re = re;
        }

        public ComplexClass Plus(ComplexClass x2)
        {
            ComplexClass x3 = new ComplexClass();
            x3.im = x2.im + im;
            x3.re = x2.re + re;
            return x3;
        }

        public ComplexClass Minus(ComplexClass x2)
        {
            ComplexClass x3 = new ComplexClass();
            x3.im = x2.im - im;
            x3.re = x2.re - re;
            return x3;
        }

        public ComplexClass Multi(ComplexClass x2)
        {
            ComplexClass x3 = new ComplexClass();
            x3.im = re * x2.im + im * x2.re;
            x3.re = re * x2.re - im * x2.im;
            return x3;
        }

        public override string ToString()
        {
            string strRe = re == 0 ? string.Empty : re.ToString();
            string strIm = im < 0 ? $"({im}i)" : im == 0 ? string.Empty : $"{im}i";

            if (strRe == string.Empty && strIm == string.Empty)
                return "0";

            if (strRe == string.Empty || strIm == string.Empty)
                return strRe + strIm;

            return $"{strRe} + {strIm}";
        }
    }

}
