using System;

namespace ClassBox
{
    public class Box
    {
        private double _length;
        private double _width;
        private double _height;

        public Box(double length,double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }
        
        public double Length
        {
            get { return this._length; }
            private set
            {
                
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(Length)} cannot be zero or negative.");
                }

                this._length = value;

            }
        }

        private double Width
        {
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(Width)} cannot be zero or negative.");
                }

                this._width = value;
            }
        }

        private double Height
        {
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(Height)} cannot be zero or negative.");
                }

                this._height = value;
            }
        }
        

        public double SurfaceArea()
        {
            //2lw + 2lh + 2wh

            double surfaceAreaFormula = (2 * this._length * this._width) + (2 * this._length * this._height) + (2 * this._width * this._height);

            return surfaceAreaFormula;
        }

        public double LeteralSurfaceArea()
        {
            //2lh + 2wh
            double leteralSurfaceAreaForumula = (2 * this._length * this._height) + (2 * this._width * this._height);

            return leteralSurfaceAreaForumula;
        }

        public double Volume()
        {
            // lwh
            double volumeFormula = this._length * this._width * this._height;

            return volumeFormula;
        }

        

    }
}
