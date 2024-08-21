namespace Polymorphism___Homework11
{
    internal class Rectangular : Figure
    {
        public int _width;
        public int _length;
        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                if(value > 0)
                {
                    _width = value;
                }
                else
                {
                    Console.WriteLine("Width cannot be negatif or 0");
                }
            }
        }

        public int Length
        {
            get
            {
                return _length;
            }
            set
            {
                if (value > 0)
                {
                    _length = value;
                } 
                else
                {
                    Console.WriteLine("Length cannot be negatif or 0");
                }
            }
        }
        public Rectangular(int width, int length)
        {
            Width = width;
            Length = length;
        }

        public override int CalcArea()
        {
            return Width * Length;
        }
    }
}
