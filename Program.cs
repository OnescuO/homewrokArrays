using System;

namespace HomeworkArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Matrix();
            // AdditionMatrix();
            //AddNewElement();
            RemoveItem();
        }
        public static void Matrix()
        {
            int i, j;
            int[,] myArray = new int[3, 3];
            Console.WriteLine("Input elements in the matrix: ");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write($"element [{i},{j}]");
                    myArray[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("\nThe matrix is: \n");
            for (i = 0; i < 3; i++)
            {
                Console.Write("\n");
                for (j = 0; j < 3; j++)
                    Console.Write("{0}\t", myArray[i, j]);
            }
            Console.Write("\n\n");
        }
        public static void AdditionMatrix()
        {
            int i, j, n;
            int[,] arr1 = new int[50, 50];
            int[,] brr1 = new int[50, 50];
            int[,] crr1 = new int[50, 50];
            Console.Write("Input the size of the square matrix (less than 5): ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input elements in the first matrix :\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write($"element - [{i},{j}] : ");
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("Input elements in the second matrix :\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write($"element - [{i},{j}] : ");
                    brr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("\nThe first matrix is: \n");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                {
                    Console.Write("{0}\t", arr1[i, j]);
                }

            }
            Console.Write("\nThe Second matrix is :\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                {
                    Console.Write("{0}\t", brr1[i, j]);
                }

            }
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    crr1[i, j] = arr1[i, j] + brr1[i, j];
                }
            }
            Console.Write("\nThe Addition of two matrix is : \n");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                {
                    Console.Write("{0}\t", crr1[i, j]);
                }
            }
            Console.Write("\n\n");
        }
        //Write a method to insert a new item before the second element in an existing array
        public static void AddNewElement()
        {
            int[] myArray = new int[5];
            int i, n, x, p = 0;
            Console.Write("\n\nInsert New value in the sorted array :\n");
            Console.Write("Input the size of array : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Input {n} elements in the array in ascending order:\n");

            for (i = 0; i < n; i++)
            {

                Console.WriteLine($"MyArray{i} = {myArray[i]}");
                myArray[i] = Convert.ToInt32(Console.ReadLine());
            }


            Console.WriteLine("Input the value to be inserted : ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("The exist array list is :\n ");
            for (i = 0; i < n; i++)
            {
                Console.Write($"{myArray[i]} ");
            }

            for (i = 0; i < n; i++)
            {
                if (x < myArray[i])
                {
                    p = i;
                    break;
                }
            }
            for (i = n; i >= p; i--)
            {
                myArray[i] = myArray[i - 1];
                myArray[p] = x;
            }
            Console.WriteLine("After Insert the element the new list is : ");
            for (i = 0; i <= n; i++)
            {
                Console.WriteLine($"{myArray[i]}");
            }

        }
        //Write a method to remove a specified item using the index from an array.
        public static void RemoveItem()
        {
            int i, pos, n;
            int[] myArray = new int[5];
            
            Console.Write("Input the size of array : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Input {n} elements in the array in ascending order:\n");
            for (i = 0; i < n; i++)
            {
                Console.Write($"element - {i}:");
                myArray[i] = Convert.ToInt32(Console.ReadLine());
                   
            }
            Console.Write("\nInput the position where to delete: ");
            pos = Convert.ToInt32(Console.ReadLine());
            i = 0;
            while (i != pos - 1)
            {
                i++;
            }
            while (i < n)
            {
                myArray[i] = myArray[i + 1];
                i++;
            }
            n--;
            Console.Write("\nThe new list is : ");
            for (i = 0; i < n; i++)
            {
                Console.Write($"{myArray[i]}");
            }
            Console.Write("\n\n");
        }



    }

}

  
    

  
