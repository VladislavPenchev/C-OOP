namespace _09.RectangleIntersection
{
    public class Rectangle
    {
        private string _ID;
        private double _width;
        private double _height;
        private double _x;
        private double _y;

        public Rectangle(string id,double width, double height, double horizontal, double vertical)
        {
            this._ID = id;
            this._width = width;
            this._height = height;
            this._x = horizontal;
            this._y = vertical;
        }

        public bool InteresectWith(Rectangle rectangle)
        {
            if (this._x <= rectangle._x + rectangle._width 
                && this._x + this._width >= rectangle._x 
                && this._y <= rectangle._y + rectangle._height
                && this._y + this._height >= rectangle._y)
            {
                return true;
            }
            return false;
        }
    }
}
