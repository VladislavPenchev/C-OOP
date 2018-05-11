namespace Pizza_Calories
{
    public class Dough
    {
        private GlobalConstants _flourType;
        private GlobalConstants _bakingTechnique;
        private int _weight;

        public Dough(GlobalConstants flourType,GlobalConstants bakingTechnique, int weight)
        {
            this._flourType = flourType;
            this._bakingTechnique = bakingTechnique;
            this._weight = weight;
        }

    }
}
