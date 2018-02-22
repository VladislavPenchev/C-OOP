namespace ClassBox
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class StartUp
    {
        public static void Main()
        {
            double[] doubleParams = new double[3];

            for (int i = 0; i < doubleParams.Length; i++)
            {
                doubleParams[i] = double.Parse(Console.ReadLine());
            }


            Box box = new Box(doubleParams[0], doubleParams[1], doubleParams[2]);           


            Type boxType = typeof(Box);
            FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            Console.WriteLine(fields.Count());
            
            Console.WriteLine($"Surface Area – {box.SurfaceArea():f2}");
            Console.WriteLine($"Lateral Surface Area – {box.LeteralSurfaceArea():f2}");
            Console.WriteLine($"Volume – {box.Volume():f2}");


        }
    }
}
