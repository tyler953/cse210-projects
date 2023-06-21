namespace Learning05
{
    public class Square : Shape
    {
        private double _side;

        public Square(string color, double side) : base(color)
        {
            this._side = side;
        }

        public override double GetArea()
        {
            return Math.Pow(this._side, 2);
        }
    }
}