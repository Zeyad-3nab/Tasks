namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1- Write a c# program to find the sum of left diagonals 

            //Console.Write("Enter length of column array :");
            //int x=int.Parse(Console.ReadLine());
            //int[,] arr= new int[x,x];
            //int sum = 0;
            //for(int i=0; i<x; i++)
            //{
            //    for(int j=0; j < x; j++)
            //    {
            //        Console.Write($"Enter the element number {i+j+1} : ");
            //        arr[i,j]=int.Parse(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        if (i == j)
            //        {
            //            sum+= arr[i,j];
            //        }
            //    }
            //}
            //Console.WriteLine(sum);



            //*********************************************************************************


            // 2- Write a c# program to print or display the lower tringular of a given matrix


            //Console.Write("Enter length of column array :");
            //int x = int.Parse(Console.ReadLine());
            //int[,] arr = new int[x, x];
            //for (int i = 0; i < x; i++)
            //{
            //    for (int j = 0; j < x; j++)
            //    {
            //        Console.Write($"Enter the element number {i + j + 1} : ");
            //        arr[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        if (i>j)
            //        {
            //            arr[i, j] = 0;

            //        }
            //    }
            //}
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        Console.Write(arr[i,j]+" ");

            //    }
            //    Console.WriteLine();
            //}


            //*************************************************************************



            // 3- Write a c# program to accept two matrix and check equivalent

            //Console.Write("Enter length of column array :");
            //int x = int.Parse(Console.ReadLine());
            //int[,] arr1 = new int[x, x];
            //int[,] arr2 = new int[x, x];
            //bool flag = true;
            //for (int i = 0; i < x; i++)
            //{
            //    for (int j = 0; j < x; j++)
            //    {
            //        Console.Write($"Enter the element number {i + j + 1} in array1 : ");
            //        arr1[i, j] = int.Parse(Console.ReadLine());
            //        Console.Write($"Enter the element number {i + j + 1} in array2 : ");
            //        arr2[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < x; i++)
            //{
            //    for (int j = 0; j < x; j++)
            //    {
            //        if (arr1[i, j] != arr2[i,j])
            //        {
            //            flag = false;
            //        }
            //    }
            //}
            //if(flag)
            //    Console.WriteLine("Equivalent");
            //else
            //    Console.WriteLine("Not Equivalent");



            //**********************************************************

            // 4- Write a c# program to Find the odd values in matrix

            //Console.Write("Enter length of column array :");
            //int x = int.Parse(Console.ReadLine());
            //int[,] arr = new int[x, x];
            //List<int> list = new List<int>();
            //for (int i = 0; i < x; i++)
            //{
            //    for (int j = 0; j < x; j++)
            //    {
            //        Console.Write($"Enter the element number {i + j + 1} : ");
            //        arr[i, j] = int.Parse(Console.ReadLine());
            //        if (arr[i, j] % 2 != 0)
            //            list.Add(arr[i, j]);
            //    }
            //}
            //foreach (int i in list)
            //    Console.WriteLine(i);


            //***************************************************************


            // 5- Write a c# program to accept the array and return it without duplicated 

            //Console.Write("Enter The length of array : ");
            //int x=int.Parse(Console.ReadLine());
            //int[]arr = new int[x];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"Enter the element number {i+1} : ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0;i < arr.Length; i++)
            //{
            //    for (int j = i+1;j<arr.Length;j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            arr[j] = 0;
            //        }
            //    }
            //}
            //for(int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //} 



            //*************************************************************


            //6- Write a c# to find the largest of three number 

            //Console.Write("Enter num 1 :");
            //int num1=int.Parse(Console.ReadLine());
            //Console.Write("Enter num 1 :");
            //int num2=int.Parse(Console.ReadLine());
            //Console.Write("Enter num 1 :");
            //int num3=int.Parse(Console.ReadLine());
            //if (num1 >= num2 && num1 >= num3)
            //    Console.WriteLine($"The largest number is {num1}");
            //else if (num2 >= num1 && num2 >= num3)
            //    Console.WriteLine($"The largest number is {num2}");
            //else
            //    Console.WriteLine($"The largest number is {num3}");


            //***************************************************************


            //7- Write a c# program to print unique elements in array

            //Console.Write("Enter the length of array : ");
            //int x=int.Parse(Console.ReadLine());
            //bool[]arr2 = new bool[x];
            //int[] arr = new int[x];
            //for (int i = 0; i < arr.Length; i++) 
            //{
            //    Console.Write($"Enter the element number {i+1} : ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = i+1;j<arr.Length;j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            arr2[i] = true;
            //            arr2[j] = true;
            //        }
            //    }
            //}
            //for(int i = 0;i< arr.Length; i++)
            //{
            //    if (arr2[i]==false)
            //        Console.WriteLine(arr[i]);
            //}



            //*********************************************************************

            //7

            //Console.Write("Enter the length of array : ");
            //int x = int.Parse(Console.ReadLine());
            //int[] arr1 = new int[x];
            //int[] arr2 = new int[x];
            //int[] MergeArr= new int[x+x];
            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    Console.Write($"Enter the element number {i + 1} in array 1 : ");
            //    arr1[i] = int.Parse(Console.ReadLine());
            //    Console.Write($"Enter the element number {i + 1} in array 2 : ");
            //    arr2[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 1; i < 3; i++) 
            //{
            //    for (int j = 1; j < arr1.Length; j++)
            //    {
            //        if (i == 1)
            //            MergeArr[(i *j)-1] = arr1[j];
            //        else
            //            MergeArr[(i * j) - 1+arr2.Length] = arr2[j];

            //    }
            //}

            //for (int i = 0; i < MergeArr.Length; i++)
            //{
            //    Console.WriteLine(MergeArr[i]);
            //}



            //************************************************

            // 8- Write a c# program to find the maximum and minimum in arr


            //Console.Write("Enter the length of array : ");
            //int x = int.Parse(Console.ReadLine());
            //int[]arr=new int[x];
            //int max;
            //int min;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"Enter Element number {i+1} : ");
            //    arr[i]=int.Parse(Console.ReadLine());
            //}
            //min = arr[0];
            //max = 0;
            //for (int i = 0;i < arr.Length; i++)
            //{
            //    if (arr[i] > max)
            //        max = arr[i];
            //    if (arr[i] < min)
            //        min = arr[i];

            //}
            //Console.WriteLine($"Minimum number is {min}");
            //Console.WriteLine($"Maximum number is {max}");

            //*********************************************************


            //9- Write a c# prog to sort an array
            //Console.Write("Enter the length of array : ");
            //int x = int.Parse(Console.ReadLine());
            //int[] arr = new int[x];
            //int swap = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"Enter Element number {i + 1} : ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for(int j = i;j<arr.Length;j++)
            //    {
            //        if (arr[i] > arr[j])
            //        {
            //            swap = arr[i];
            //            arr[i] = arr[j];
            //            arr[j] = swap;
            //        }
            //    }
            //}
            //for(int i = 0;i < arr.Length;i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}


            //*******************************************************

            //10- Write a c# prog to insert an additional value in array
            //Console.Write("Enter the length of array : ");
            //int x = int.Parse(Console.ReadLine());
            //int[] arr = new int[x];
            //int swap = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"Enter Element number {i + 1} : ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = i; j < arr.Length; j++)
            //    {
            //        if (arr[i] > arr[j])
            //        {
            //            swap = arr[i];
            //            arr[i] = arr[j];
            //            arr[j] = swap;
            //        }
            //    }
            //}
            //int first = arr[0];
            //int last = arr[arr.Length - 1];
            //arr=new int[last-first+1];
            //for(int i = 0;i < arr.Length; i++)
            //{
            //    arr[i]=first;
            //    first++;

            //}
            //for(int i = 0;i < arr.Length;i++)
            //    Console.WriteLine(arr[i]);


            //****************************************************



            //11- Write a c# program to check the triangle is equivilant or not
            //Console.Write("Enter Length :");
            //double length=double.Parse(Console.ReadLine()); 
            //Console.Write("Enter Width :");
            //double width=double.Parse(Console.ReadLine());
            //Console.Write("Enter Height :");
            //double height=double.Parse(Console.ReadLine());
            //if (length == width && length == height)
            //    Console.WriteLine("equivilant");
            //else
            //    Console.WriteLine("Not equivilant");


            //**********************************************


            //12
            //Console.Write("Num = ");
            //int Num=int.Parse(Console.ReadLine());
            //Console.WriteLine($"{Num} {Num} {Num} {Num}");
            //Console.WriteLine($"{Num}{Num}{Num}{Num}");
            //Console.WriteLine($"{Num} {Num} {Num} {Num}");
            //Console.WriteLine($"{Num}{Num}{Num}{Num}");



            //Console.WriteLine("******************************************************************************");

            //13
            //Console.Write("Num = ");
            //int Num=int.Parse(Console.ReadLine());
            //Console.WriteLine($"{Num}{Num}{Num}");
            //Console.WriteLine($"{Num} {Num}");
            //Console.WriteLine($"{Num} {Num}");
            //Console.WriteLine($"{Num} {Num}");
            //Console.WriteLine($"{Num}{Num}{Num}");



            //Console.WriteLine("******************************************************************************");




            //14
            //Console.Write("Enter the degree of selizus : ");
            //int degree=int.Parse(Console.ReadLine());
            //Console.WriteLine($"Kelvin = {degree + 273}");
            //Console.WriteLine($"Fahrenheit = {((degree + 40) * 1.8) - 40}");



            //Console.WriteLine("*********************************************************************************");


            //15
            //Console.Write("Enter text :");
            //string text= Console.ReadLine();
            //char x = text[0];
            //Console.WriteLine($"{x}{text}{x}");



            //Console.WriteLine("*************************************************************************************");


            //16
            //Console.Write("Enter num1 : ");
            //int num1=int.Parse(Console.ReadLine());
            //Console.Write("Enter num2 : ");
            //int num2 = int.Parse(Console.ReadLine());
            //if (num1 < 0 || num2 < 0)
            //{
            //    if(num1>0||num2>0)
            //    {
            //        Console.WriteLine("True");
            //    }
            //    else
            //    {
            //        Console.WriteLine("False");
            //    }
            //}
            //else if (num1 > 0 || num2 > 0)
            //{
            //    if (num1 < 0 || num2 < 0)
            //    {
            //        Console.WriteLine("True");
            //    }
            //    else
            //    {
            //        Console.WriteLine("False");
            //    }
            //}



            //Console.WriteLine("**************************************************************************************");



            //17
            //Console.Write("Num1 = ");
            //int num1=int.Parse(Console.ReadLine());
            //Console.Write("Num2 = ");
            //int num2=int.Parse(Console.ReadLine());
            //if (num1==num2)
            //    Console.WriteLine(Math.Pow((num1+num2),3));
            //else
            //    Console.WriteLine(num1+num2);



            //Console.WriteLine("****************************************************************************");


            //18
            //Console.Write("Num1 = ");
            //double num1 = int.Parse(Console.ReadLine());
            //Console.Write("Num2 = ");
            //double num2 = int.Parse(Console.ReadLine());
            //if(num1>num2)
            //    Console.WriteLine(num1);
            //else
            //    Console.WriteLine(num2);
            //Console.WriteLine("***********************************************************************");



            //19
            //Console.Write("Num1 = ");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.Write("Num2 = ");
            //int num2 = int.Parse(Console.ReadLine());
            //if (num1==20 || num2==20 || num1 + num2 == 20)
            //    Console.WriteLine("True");
            //else
            //    Console.WriteLine("False");
            //Console.WriteLine("*********************************************************************");




            //20
            //Console.Write("Enter num : ");
            //int num=int.Parse(Console.ReadLine());
            //if (num >= 20 && num <= 100)
            //    Console.WriteLine("This number between 20 , 100");
            //else if (num >= 20 && num <= 200)
            //    Console.WriteLine("This number between 20 and 200");
            //else

            //    Console.WriteLine("False");
            //Console.WriteLine("**********************************************************************");




            //21
            //Console.Write("Enter Text : ");
            //string text=Console.ReadLine();
            //Console.WriteLine(text.ToLower());
            //Console.WriteLine("*************************************");




            //22
            //for (int i = 0; i < 100; i++)
            //{
            //    if(i%2 != 0)
            //        Console.WriteLine(i);
            //}
            //Console.WriteLine("*********************************************************");



            //23
            //for (int i = 2; i < 500; i++)
            //{
            //    if (i == 2 || i == 3 || i == 5 || i == 7)
            //        Console.WriteLine(i);
            //    else if (i % 2 != 0 && i % 3 != 0 && i % 4 != 0 && i % 5 != 0 )  //&& i % 6 != 0 && i % 7 != 0 && i % 8 != 0 && i % 9 != 0)
            //        Console.WriteLine(i);
            //    else
            //        continue;
            //}
            //Console.WriteLine("*********************************************************");





            //24
            //string text =Console.ReadLine();
            //string[] arr=new string[text.Length];
            //int x = 0;
            //int y = 0;
            //for (int i = 0;i<text.Length;i++)
            //{
            //    if (text[i]==' ')
            //    {
            //        x = y;
            //        y = i;
            //        arr[i] = text.Substring( x , y);
            //    }
            //}
            //Array.Reverse(arr);
            //for (int i = 0; i<arr.Length;i++)
            //{
            //    Console.Write(arr[i]);
            //}







        }
    }
}
