namespace _09.RectangleIntersection
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var rectangles = new Dictionary<string, Rectangle>();
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var numberOfRectangle = input[0];
            var intersectionChecks = input[1];

            for (int i = 0; i < numberOfRectangle; i++)
            {
                var rectangleInfo = Console.ReadLine().Split();
                var id = rectangleInfo[0];
                var width = double.Parse(rectangleInfo[1]);
                var height = double.Parse(rectangleInfo[2]);
                var topLeftHor = double.Parse(rectangleInfo[3]);
                var topLeftVer = double.Parse(rectangleInfo[4]);

                rectangles.Add(id, new Rectangle(id,width, height, topLeftHor, topLeftVer));
            }

            for (int i = 0; i < intersectionChecks; i++)
            {
                var checksID = Console.ReadLine().Split();

                var result = rectangles[checksID[0]].InteresectWith(rectangles[checksID[1]]);
                Console.WriteLine(result.ToString().ToLower());
            }


        }
    }
}
