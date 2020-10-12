using System;
//using System.Text;
 
 namespace comparison
 {
      class listing
    {
        static void Main(string[] args)
        {
            StringBuilder builder = new StringBuilder("Introduction to C#");
            StringBuilder builder1 =builder;

            bool sameRefs = builder == builder1;
            Console.WriteLine("Reference to same: {0}", sameRefs);

            Console.WriteLine("Press enter to end.");
            Console.ReadLine();
        }
    }
 }
