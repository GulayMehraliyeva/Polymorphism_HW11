namespace Polymorphism___Homework11
{
    internal class Square : Figure
    {
        public int _side;
        public int Side
        {
            get
            {
                return _side;
            }
            set
            {
                if (value > 0)
                {
                    _side = value;
                }
                else
                {
                    Console.WriteLine("Side cannot be negative or 0");
                }
            }
        }
        public Square(int side)
        {
            Side = side;
        }

        public override int CalcArea()
        {
            return Side * Side;
        }
    }
}
