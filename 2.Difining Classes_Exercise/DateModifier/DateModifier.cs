namespace DateModifier
{
    public class DateModifier
    {
        private int _year;
        private int _month;
        private int _day;

        public DateModifier()
        {
            this._year = Year;
            this._month = Month;
            this._day = Day;
        }
        
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
    }
}
