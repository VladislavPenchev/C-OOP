namespace Live_Demo
{
    using System;

    public class Dice
    {
        private int _sizes;

        public Dice(int sizes)
        {
            this.Sizes = sizes;
        }

        public int Sizes
        {
            get { return this._sizes; }

            set
            {
                if(value < 6)
                {
                    throw new Exception("Dice can't have less than 6 sizes");
                }

                this._sizes = value;
            }
        }
    }
}
