using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Declare arrays
            //int[] myFirstArray = new int[5];
            //myFirstArray[0] = 10;
            //myFirstArray[1] = 9;
            //myFirstArray[2] = 8;
            //myFirstArray[3] = 7;
            //myFirstArray[4] = 6;
            //int[] mySecondArray = { 1, 2, 3, 4, 5 };

            //// loop vrem sa printam fiecare array in parte
            //for (int i = 0; i < myFirstArray.Length; i++)
            //{
            //    Console.WriteLine($"First{i} = {myFirstArray[i]}");
            //}
            ////secont
            //for(int i = 0; i < mySecondArray.Length; i++)
            //{
            //    Console.WriteLine($"Second{i} = {mySecondArray[i]}");
            //}

            //Console.WriteLine($"myFirstArray: {myFirstArray}");
            //Console.WriteLine($"mySecondArray: {mySecondArray}");

            ////read and print an array adeed by the user
            ////1. get array lenght
            //int lenght = int.Parse(Console.ReadLine());
            ////2. initialize array
            //int[] myThirdArray = new int[lenght];
            ////3. add elements to array
            //for(int i = 0; i < lenght; i++)
            //{
            //    Console.WriteLine($"Add element {i}:");
            //    myThirdArray[i] = int.Parse(Console.ReadLine());
            //}
            ////4. print elements
            //foreach(var element in myThirdArray)
            //{
            //    Console.WriteLine(element);
            //}
            // ReverseArray();

            // GetSum();

            //GetNumberOfOccurences();

            //GetOdd();

            // GetMultiply();
            // Unique();
            //SmallestElement();
            // LargestElement();
            //Multidimensional();
            //CalcSum();
            //CalcDiagonally();
            CalcDiagonally2();
            
        }

        //
        public static int[] GetArrayFromUser()
        {
            //get length
            Console.WriteLine("Add the length of the array");
            int length = int.Parse(Console.ReadLine());
            //initialize
            int[] myArray = new int[length];
            //add element to array
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"Add element {i}");
                myArray[i] = int.Parse(Console.ReadLine());
            }
            return myArray;
        }

        //reverse an array
        public static void ReverseArray()
        {
            var myArray = GetArrayFromUser();
            for (int i = myArray.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(myArray[i]);
            }
            ReverseArray();
        }

        //sum of all elements of an array
        public static void GetSum()
        {
            var myArray = GetArrayFromUser();
            var sum = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                sum = sum + myArray[i];
            }
            Console.WriteLine($"Sum of myArray is {sum}");
        }

        //number of occurences of an element
        public static void GetNumberOfOccurences()
        {
            var myArray = GetArrayFromUser();
            var count = 0;
            Console.WriteLine("Wich number are you looking for....");
            int number = int.Parse(Console.ReadLine());

            foreach (var element in myArray)
            {
                if (element == number)
                {
                    count++;
                }
            }
            Console.WriteLine($"{number} found {count} times");
        }

        //sum of all odd/even elements
        public static void GetOdd()
        {
            var myArray = GetArrayFromUser();
            var sum = 0;
            foreach (var element in myArray)
            {

                if (element % 2 == 1)
                {
                    sum = sum + element;
                }
            }
            Console.WriteLine($"Sum of odd number is {sum}");
        }

        //multiply elements from two arrays
        //[1,2,3,4,5]
        //[6,7,8,9,10]
        //[0] => 6
        //[1] => 14
        public static void GetMultiply()
        {
            var myArray1 = GetArrayFromUser();
            var myArray2 = GetArrayFromUser();
            var length = myArray1.Length >= myArray2.Length ? myArray2.Length : myArray1.Length;
            // both have the same length
            for (int i = 0; i < length; i++)
            {
                var result = myArray1[i] * myArray2[i];
                Console.WriteLine($"Multiply = {result}");
            }
            //one is larger than the other


        }
        // print unique elements Ex: [1,2,2,2,3,3] => 1) [1,2,3] 2) "1,2,3"
        public static void Unique()
        {
            var myArray = GetArrayFromUser();
            //array to print
            int[] arrayToPrint = new int[myArray.Length];

            var index = -1;//to know where to add our unique element
            //string to print
            var stringToPrint = string.Empty;//""

            for (int i = 0; i < myArray.Length; i++)
            {
                if (GetIndexOf(myArray[i], arrayToPrint) == -1)
                {
                    index++;
                    arrayToPrint[index] = myArray[i];
                }
            }
            // 1. [1,2,0,5]
            //2. How can we get rid of the trailing 0s SOLVED
            for (int i = 0; i < index; i++)
            {
                Console.WriteLine($"{arrayToPrint[i]}, ");
            }
        }

        public static int GetIndexOf(int element, int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (element == array[i])
                {
                    return i;
                }
            }
            return -1;
        }

        //get the index of the element

        //smallest element in array
        public static void SmallestElement()
        {
            var myArray = GetArrayFromUser();
            var min = myArray[0];

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] < min)
                {
                    min = myArray[i];
                }
            }
            Console.WriteLine($"Min is : {min}");
        }

        //largest element in array
        public static void LargestElement()
        {
            var myArray = GetArrayFromUser();
            var max = myArray[0];

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] > max)
                {
                    max = myArray[i];
                }
            }
            Console.WriteLine($"Max is : {max}");
        }
        // one is larger then the other


        //sort ascending and descending
        
        //public static void Desc()
        //{
        //    var myArray = GetArrayFromUser();
        //    for (int i = 0; i < myArray.Length-1; i++)
        //    {
        //        for (int j = i+1; j < myArray.Length; j++)
        //        {
        //            if(myArray[i] > myArray[j])
        //            {
        //                temp = myArray[i];
        //                myArray[i] = myArray[j];
        //                myArray[j] = temp;
        //            }
        //        }
        //    }
        //}

        public static void Multidimensional()
        {
            int[,] myArray = new int[2, 3];//2=number of rows 3=number of columns
            myArray[0, 0] = 1;
            myArray[0, 1] = 2;
            myArray[0, 2] = 3;

            myArray[1, 0] = 4;
            myArray[1, 1] = 5;
            myArray[1, 2] = 6;
            int[,] myArray2 =
            {
                {1, 2, 3 },
                {4, 5, 6 }
            };

            for(int row = 0; row < myArray.GetLength(0); row++)
            {
                for(int col = 0; col < myArray.GetLength(1); col++)
                {
                    Console.WriteLine($" myArray[{row},{col}] = {myArray[row, col]}");
                }
            }

            // read multidimensional array from keyboard
            int numbersOfRows = int.Parse(Console.ReadLine());
            int numbersOfCols = int.Parse(Console.ReadLine());
            int[,] myArray3 = new int[numbersOfRows, numbersOfCols];

            for(int rows = 0; rows < numbersOfRows; rows++)
            {
                for(int cols = 0; cols < numbersOfCols; cols++)
                {
                    Console.WriteLine($"Add element for myarray3[{rows},{cols}]");
                     myArray3[rows, cols] = int.Parse(Console.ReadLine());
                }
            }

            for (int rows = 0; rows < myArray3.GetLength(0); rows++)
            {
                for (int cols = 0; cols < myArray3.GetLength(1); cols++)
                {
                    Console.WriteLine($"myArray3[{rows},{cols}] = {myArray3[rows, cols]}");
                }
            }
        }

        public static void CalcSum()
        {
            int[,] myArray =
            {
                {1, 2, 3 },
                {4, 5, 6 },
                {7, 8, 9 }
            };

            for(int rows = 0; rows < myArray.GetLength(0); rows++)
            {
                var sum = 0;
                for(int cols = 0; cols < myArray.GetLength(1); cols++)
                {
                    sum += myArray[rows, cols];
                }
                Console.WriteLine($"Sum of myArray[{rows}] = {sum}");
            }
        }

        public static void CalcDiagonally()
        {
            int[,] myArray =
            {
                {1, 2, 3 },
                {4, 5, 6 },
                {7, 8, 9 }
            };
            var sum = 0;


            for(int rows = 0; rows < myArray.GetLength(0); rows++)
            {
                for(int cols = 0; cols < myArray.GetLength(1); cols++)
                {
                    if(rows == cols)
                    {
                        sum += myArray[rows, cols];
                    }

                }
            }
            Console.WriteLine($"Sum diagonally = {sum}");
        }
        public static void CalcDiagonally2()
        {
            int[,] myArray =
            {
                {1, 2, 3 },
                {4, 5, 6 },
                {3, 8, 9 }
            };
            var sum = 0;


            for (int rows = 0; rows < myArray.GetLength(0); rows++)
            {
                for (int cols = 0; cols < myArray.GetLength(1); cols++)
                {
                    if (rows == myArray.GetLength(1) - 1 - cols)
                    {
                        sum += myArray[rows, cols];
                    }

                }
            }
            Console.WriteLine($"Sum diagonally2 = {sum}");
        }
    }
}
