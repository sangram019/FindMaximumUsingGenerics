using System;
using FindMaximumNumber;

namespace TestMaximum
{
    class program
    {
        public static void Main(string[] args)
        {
            FindMaximum test = new FindMaximum();

            Console.WriteLine("Welcome to Maximum of Three using generics!");

            while (true)
            {

                Console.WriteLine("Choose the Program to be executed :\n1)Find Max Using Int\n2)Find Max Using Float\n3)Find Max Using String\n4)Find Max Using Generic class & Method\n5)Find Max Using array");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:


                        Console.WriteLine("Max number of 3 variables i.e. 1, 2, 3 ");
                        test.FindMaxInteger(1, 2, 3);

                        Console.WriteLine("Max number of 3 variables i.e. 1, 2, 3 ");
                        test.FindMaxInteger(3, 1, 2);

                        Console.WriteLine("Max number of 3 variables i.e. 1, 3, 2 ");
                        test.FindMaxInteger(1, 3, 2);
                        break;
                    case 2:

                        Console.WriteLine("Max number of 3 float i.e. 1.2f, 3.6f, 6.7f ");
                        test.FindMaxFloat(1.2f, 3.6f, 6.7f);

                        Console.WriteLine("Max number of 3 float i.e. 6.7f, 1.2f, 3.6f ");
                        test.FindMaxFloat(6.7f, 1.2f, 3.6f);

                        Console.WriteLine("Max number of 3 float i.e. 1.2f, 6.7f, 3.6f ");
                        test.FindMaxFloat(1.2f, 6.7f, 3.6f);
                        break;
                    case 3:

                        Console.WriteLine("Max number of 3 string i.e. Apple, Peach, Banana");
                        test.FindMaxString("Apple", "Peach", "Banana");

                        Console.WriteLine("Max number of 3 string i.e. Banana, Apple, Peach");
                        test.FindMaxString("Banana", "Apple", "Peach");

                        Console.WriteLine("Max number of 3 string i.e. Apple, Banana, Peach");
                        test.FindMaxString("Apple", "Banana", "Peach");
                        break;
                    case 4:

                        Console.WriteLine("Max number of 3 variables i.e. 1, 2, 3 ");
                        int genClass1 = FindMaximum<int>.MaxValueGeneric<int>(1, 2, 3);

                        Console.WriteLine("Max number of 3 floats i.e. 1.2, 6.7, 3.6 ");
                        double genClass2 = FindMaximum<double>.MaxValueGeneric<double>(1.2, 6.7, 3.6);

                        Console.WriteLine("Max number of 3 string i.e. Apple, Banana, Peach ");
                        string genClass3 = FindMaximum<string>.MaxValueGeneric<string>("Apple", "Banana", "Peach");
                        break;
                    case 5:

                        int[] intarray = { 1, 2, 3, 4, 5, 6, 7 };
                        int Array1 = FindMaximumNum<int>.MaxValue<int>(intarray);
                        Console.WriteLine("The Maximum of IntArray is :" + Array1);

                        double[] doublearray = { 1.1, 2.2, 3.3, 4.4, 5.5 };
                        double Array2 = FindMaximumNum<double>.MaxValue<double>(doublearray);
                        Console.WriteLine("The Maximum of DoubleArray is :" + Array2);

                        string[] stringarray = { "Apple", "Peach", "Banana" };
                        string Array3 = FindMaximumNum<string>.MaxValue<string>(stringarray);
                        Console.WriteLine("The Maximum of StringArray is :" + Array3);
                        break;
                }
            }


        }


    }


}