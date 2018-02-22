namespace ClassBox
{
    public class Box
    {
        private double _length;
        private double _width;
        private double _height;

        public Box(double length,double width, double height)
        {
            this._length = length;
            this._width = width;
            this._height = height;
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
