namespace Live_Demo
{
    public class StartUp
    {
        public static void Main()   
        {
            Dice dice = new Dice();


            //dice.Sizes = -5;
            dice.Sizes= 6; 

            System.Console.WriteLine(dice.Sizes);
        }
    }
}
