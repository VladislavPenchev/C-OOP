namespace DateModifier
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var inputFirstDate = Console
                                    .ReadLine()
                                    .Split()
                                    .Select(int.Parse)
                                    .ToList();

            var inputSecondDate = Console
                        .ReadLine()
                        .Split()
                        .Select(int.Parse)
                        .ToList();


            int diffrenceOfYears = inputSecondDate[0] - inputFirstDate[0];



        }
    }
}
