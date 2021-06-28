using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Lesson_4
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Q2

            //int[] arr = new int[10];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = i + 10;
            //}
            //int counterSum = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine($"Please guess value no.{i + 1} of the array:");
            //    int counter = 1; // הבדיקה בלולאה בעצם מתחילה כבר בבדיקה הראשונה
            //    counterSum++;    // והלולאה לא מופעלת בבדיקה האחרונה לכן צריך לספור בדיקה אחת מחוץ ללולאה
            //    while (Array.IndexOf(arr, int.Parse(Console.ReadLine())) != i && counterSum < 31)
            //    {
            //        Console.WriteLine("Wrong. Try again");
            //        counter++;
            //        counterSum++;
            //    }
            //    if (counterSum < 31)
            //    {
            //        Console.WriteLine($"Congartulations! You've guessed correctly after {counter} times");
            //        Console.WriteLine();
            //        Console.WriteLine("--------------------------------------------------------------------------------------------");
            //        Console.WriteLine();
            //    }
            //    else
            //    {
            //        Console.WriteLine("You've tried over 30 times. Game Over.");
            //        break;
            //    }
            //}
            //if (counterSum < 31)
            //{
            //    Console.WriteLine($"You've succeded after {counterSum} times overall");
            //}

            #endregion

            #region Q3

            //int[,] arr = new int[5, 5];
            //int counter = 1;
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        arr[i, j] = counter++;
            //        if (counter > 10)
            //        {
            //            counter = 1;
            //        }
            //    }
            //}
            //Console.WriteLine("please enter number");
            //int num = int.Parse(Console.ReadLine());
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        if(arr[i,j] == num)
            //        {
            //            Console.WriteLine($"your number is in arr[{i}, {j}]");
            //        }
            //    }
            //}

            #endregion

            #region Q4

            //int[,] kefel = new int[10, 10];

            //for (int i = 0; i < kefel.GetLength(0); i++)
            //{
            //    for (int j = 0; j < kefel.GetLength(1); j++)
            //    {
            //        kefel[i, j] = (i + 1) * (j + 1);
            //        if (kefel[i, j] < 10)
            //        {
            //            Console.Write(" ");
            //        }
            //        Console.Write(" " + kefel[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Q5 - Submarines

            //int[,] submarines = new int[3, 3];

            //submarines[0, 0] = 1; // 1 = hidden submarine
            //submarines[0, 1] = 0; // 0 = empty slot
            //submarines[0, 2] = 1;

            //submarines[1, 0] = 1;
            //submarines[1, 1] = 1;
            //submarines[1, 2] = 0;

            //submarines[2, 0] = 0;
            //submarines[2, 1] = 0;
            //submarines[2, 2] = 1;

            //bool flag = true;
            //int row, column, counter = 0;

            //while (flag)
            //{
            //    flag = false; // בהמשך אעבור על הלולאה ואם נשארו צוללות:     flag = true

            //    Console.WriteLine("Pick a row (1-3) and a column (1-3) to hit the submarine:");
            //    Console.Write("row: ");
            //    row = int.Parse(Console.ReadLine());
            //    row--;                 // הצגתי בפני המשתמש טבלה של 1-3 וכמובן שאצלי במערך זה 0-2...
            //    Console.Write("column: ");
            //    column = int.Parse(Console.ReadLine());
            //    column--;              // הצגתי בפני המשתמש טבלה של 1-3 וכמובן שאצלי במערך זה 0-2...
            //    counter++;

            //    Console.WriteLine();
            //    if (submarines[row, column] == 1)
            //    {
            //        submarines[row, column] = 2; // 2 = verified hit
            //        Console.WriteLine("B-O-O-M");
            //    }
            //    else if (submarines[row, column] == 0)
            //    {
            //        submarines[row, column] = 3; // 3 = verified miss
            //        Console.WriteLine("Miss");
            //    }
            //    else if (submarines[row, column] == 2 || submarines[row, column] == 3)
            //    {
            //        Console.WriteLine("You've already hit there");
            //    }

            //    Console.WriteLine();
            //    Console.WriteLine("  1 2 3 ");
            //    Console.WriteLine();
            //    for (int i = 0; i < 3; i++)
            //    {
            //        Console.Write($"{i + 1} ");
            //        for (int j = 0; j < 3; j++)
            //        {
            //            if (submarines[i, j] == 0)
            //            {
            //                Console.Write("? ");
            //            }
            //            else if (submarines[i, j] == 1)
            //            {
            //                Console.Write("? ");
            //                flag = true;                // כל עוד יש צוללת חבויה איפשהו במערך המשחק ממשיך
            //            }
            //            else if (submarines[i, j] == 2)
            //            {
            //                Console.Write("X ");
            //            }
            //            else if (submarines[i, j] == 3)
            //            {
            //                Console.Write("O ");
            //            }
            //        }
            //        Console.WriteLine();
            //    }
            //    Console.WriteLine();
            //    Console.WriteLine("------------------------------------------------------------------------");
            //    Console.WriteLine();

            //}

            //Console.WriteLine($"You've won after {counter} attempts");

            #endregion

            #region Q6

            //int[,,] arr = new int[3, 3, 3];
            //Console.WriteLine("please enter values for the array:");
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        for (int k = 0; k < 3; k++)
            //        {
            //            Console.Write($"arr[{i}, {j}, {k}] = ");
            //            arr[i, j, k] = int.Parse(Console.ReadLine());
            //        }
            //    }
            //}

            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        for (int k = 0; k < arr.GetLength(2); k++)
            //        {
            //            Console.WriteLine($"arr[{i}, {j}, {k}] = {arr[i, j, k]}");
            //        }
            //    }
            //}

            #endregion

            #region Q7

            //char[,] arr = new char[4, 6];
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        arr[i, j] = '*';
            //        Console.Write(arr[i,j]);
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Q8

            //int[][] arr = new int[3][];
            //arr[0] = new int[2];
            //arr[1] = new int[5];
            //arr[2] = new int[4];

            //Console.WriteLine("please enter values for the array:");

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = 0; j < arr[i].Length; j++)
            //    {
            //        Console.Write($"arr[{i}][{j}] = ");
            //        arr[i][j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //Console.WriteLine();

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = 0; j < arr[i].Length; j++)
            //    {
            //        Console.WriteLine($"arr[{i}][{j}] = {arr[i][j]}");
            //    }
            //}

            #endregion

            #region Q9

            //Console.WriteLine("How many classes are there in your school?");

            //int classes = int.Parse(Console.ReadLine());
            //int[][] grades = new int[classes][];
            //int students;
            //for (int i = 0; i < classes; i++)
            //{
            //    Console.WriteLine($"How many students are there in class no. {i + 1}");
            //    students = int.Parse(Console.ReadLine());
            //    grades[i] = new int[students];
            //}
            //for (int i = 0; i < grades.Length; i++)
            //{
            //    Console.WriteLine();
            //    Console.WriteLine($"Enter the students' grades in class no. {i + 1}");
            //    for (int j = 0; j < grades[i].Length; j++)
            //    {
            //        Console.Write($"student no. {j + 1} = ");
            //        grades[i][j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //float avg = 0, highAvg = 0;
            //int index = 0;

            //for (int i = 0; i < grades.Length; i++)
            //{
            //    for (int j = 0; j < grades[i].Length; j++)
            //    {
            //        avg += grades[i][j];
            //    }
            //    if (grades[i].Length != 0)
            //    {
            //        avg = avg / grades[i].Length;
            //    }
            //    if (avg > highAvg)
            //    {
            //        highAvg = avg;
            //        index = i;
            //    }
            //    avg = 0;
            //}
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine($"The best class is class {index + 1} with an average of {highAvg}");
            
            #endregion.

        }
    }
}