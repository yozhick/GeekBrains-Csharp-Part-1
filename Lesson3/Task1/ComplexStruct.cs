
namespace Task1
{
    struct ComplexStruct
    {
        public double im;
        public double re;
        
        public ComplexStruct Plus(ComplexStruct x)
        {
            ComplexStruct y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }

        public ComplexStruct Minus(ComplexStruct x)
        {
            ComplexStruct y;
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }    
        
        public ComplexStruct Multi(ComplexStruct x)
        {
            ComplexStruct y;
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
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
