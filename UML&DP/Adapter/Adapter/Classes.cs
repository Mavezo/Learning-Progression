
namespace Adapter
{
    public class RoundPeg
    {
        private double radius;
        public RoundPeg(double radius)
        {
            this.radius = radius;
        }
        public double GetRadius()
        {
            return radius;
        }

        public bool Fits(RoundHole hole)
        {
            return hole.Fits(this);
        }
    }


    public class RoundHole
    {
        private double radius;
        public RoundHole(double radius)
        {
            this.radius = radius;
        }
        public double GetRadius()
        {
            return radius;
        }
        public bool Fits(RoundPeg peg)
        {
            if (peg.GetRadius() <= radius)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }


    public class SquarePegAdapter : RoundPeg
    {
        private SquarePeg peg;

        public SquarePegAdapter(SquarePeg peg) : base(GetRadius(peg))
        {
            this.peg = peg;
        }
        public double GetRadius()
        {
            double halfWidth = peg.GetWidth() / 2;
            return Math.Sqrt(Math.Pow(halfWidth, 2) * 2);
        }

        public static double GetRadius(SquarePeg squarePeg)
        {
            double halfWidth = squarePeg.GetWidth() / 2;
            return Math.Sqrt(Math.Pow(halfWidth, 2) * 2);
        }

    }



    public class SquarePeg
    {
        public double width;
        public SquarePeg(double width)
        {
            this.width = width;
        }
        public double GetWidth()
        {
            return width;
        }
    }




}