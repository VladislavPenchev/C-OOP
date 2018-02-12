using System;
using System.Reflection;

class StartUp
    {
        static void Main()
        {
        Type personType = typeof(Person);   
        FieldInfo[] fields = personType.GetField(BindingFlags.Public | BindingFlags.Instance);
        Console.WriteLine(fields.Length);


    }    
    }

