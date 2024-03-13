namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int x, y;
            //Console.WriteLine("enter the classes number");
            //x = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter the columns number");
            //y = int.Parse(Console.ReadLine());
            //int[,] a = new int[x, y];
            //if (x != y)
            //{
            //    Console.WriteLine("there is no main diameter");
            //}
            //else
            //{
            //    for (int i = 0; i < x; i++)                                                   //بطلب منه يدخل عناصر المصفوفه
            //    {
            //        for (int j = 0; j < y; j++)
            //        {
            //            Console.WriteLine("enter the element: {0},{1}", i + 1, j + 1);
            //            a[i, j] = int.Parse(Console.ReadLine());

            //        }
            //    }
            //    for (int i = 0; i < x; i++)
            //    {

            //        for (int j = 0; j < y; j++)
            //        {
            //            Console.Write("    " + a[i, j]);                             //بيطبع عناصر المصفوفه بدون اي تعديل عليها
            //        }
            //        Console.WriteLine();
            //        Console.WriteLine();
            //    }

            //    Console.Write("*************************************************************");           //خط يفصل بين المصفوفه قبل التعديل وبعد التعديل

            //    for (int i = 0; i < x; i++)
            //    {
            //        Console.WriteLine();
            //        Console.WriteLine();
            //        for (int j = 0; j < y; j++)                                   //بيطبع المصفوفه بعد التعديل
            //        {
            //            if (i <= j)
            //            {
            //                a[i, j] = 0;
            //            }
            //            Console.Write("    " + a[i, j]);

            //        }

            //    }
            //}









            //****************************************************************************************************************




            ////برنامج يبدل قيمتين عندما تكون الاولي اكبر من الثانيه
            //int x, y, z;
            //Console.Write("enter the first number :");
            //x = int.Parse(Console.ReadLine());
            //Console.Write("enter the second number :");
            //y = int.Parse(Console.ReadLine());
            //if (x > y)
            //{
            //    z = x;
            //    x = y;
            //    y = z;
            //}
            //Console.WriteLine(x);
            //Console.WriteLine(y);




            //*********************************************************************************


            ////برنامج يميز الحروف المتحركه من الساكنه
            //Console.Write("enter your letter :");
            //char x = char.Parse(Console.ReadLine());

            //if (x == 'a' || x == 'A' || x == 'e' || x == 'E' || x == 'i' || x == 'I' || x == 'o' || x == 'O' || x == 'u' || x == 'U')
            //{
            //    Console.WriteLine("this letter is vowel");
            //}
            //else
            //{
            //    Console.WriteLine("this letter isn't vowel");
            //}



            //************************************************************************************



            ////محيط ومساحه مثلث مختلف الاضلاع بمعلوميه اطوال اضلاعه
            //int x, y, z, perimeter;
            //double h, area;
            //Console.Write("enter the first sided :");
            //x = int.Parse(Console.ReadLine());
            //Console.Write("enter the second sided :");
            //y = int.Parse(Console.ReadLine());
            //Console.Write("enter the base length is a triangle:");        //بطلب منه طول القاعده وهي الضلع الثالث
            //z = int.Parse(Console.ReadLine());
            //perimeter = x + y + z;
            //h = Math.Sqrt(Math.Pow(x, 2) - Math.Pow(0.5 * z, 2));
            //area = h * (0.5 * z);

            //Console.Write("the perimeter is :");
            //Console.WriteLine(perimeter);
            //Console.Write("the area is :");
            //Console.WriteLine(area);



            //****************************************************************



            ////برنامج يخرج اكبر عدد في 3 اعداد
            //int x, y, z;
            //Console.Write("enter the first number :");
            //x = int.Parse(Console.ReadLine());
            //Console.Write("enter the second number :");
            //y = int.Parse(Console.ReadLine());
            //Console.Write("enter the third number :");
            //z = int.Parse(Console.ReadLine());

            //if (x >= y && x >= z)
            //{
            //    Console.Write("the maximum is :");
            //    Console.WriteLine(x);
            //}
            //else if (y >= z)
            //{
            //    Console.Write("the maximum is :");
            //    Console.WriteLine(y);
            //}
            //else
            //{
            //    Console.Write("the maximum is :");
            //    Console.WriteLine(z);
            //}





            //***********************************************


            ////برنامج يخرج اصغر عدد في 3 اعداد
            //int x, y, z;
            //Console.Write("enter the first number :");
            //x = int.Parse(Console.ReadLine());
            //Console.Write("enter the second number :");
            //y = int.Parse(Console.ReadLine());
            //Console.Write("enter the third number :");
            //z = int.Parse(Console.ReadLine());

            //if (x <= y && x <= z)
            //{
            //    Console.Write("the minimum is :");
            //    Console.WriteLine(x);
            //}
            //else if (y <= z)
            //{
            //    Console.Write("the minimum is :");
            //    Console.WriteLine(y);
            //}
            //else
            //{
            //    Console.Write("the minimum is :");
            //    Console.WriteLine(z);
            //}






            //******************************************************


            ////برنامج يطبع جذور المعادله التربيعيه
            //Double A, B, C, X1, X2, D;
            //A = Double.Parse(Console.ReadLine());
            //B = Double.Parse(Console.ReadLine());
            //C = Double.Parse(Console.ReadLine());
            //D = Math.Pow(B, 2) - 4 * A * C;
            //if (D < 0)
            //{ Console.WriteLine("undefinded"); }
            //else if (D == 0)
            //{
            //    X1 = X2 = -B / (2 * A);
            //    Console.WriteLine("X1=X2= {0}", X1);
            //}


            //else
            //{
            //    X1 = (-B + Math.Sqrt(D)) / (2 * A);
            //    X2 = (-B + Math.Sqrt(D) / (2 * A));
            //    Console.WriteLine("X1={0} &X2={1}", X1, X2);
            //}



            //******************************************************************



            ////برنامج يطبع مجموع ومتوصط 5 قيم يدخلها المستخدم
            //int a, b, c, d, e, sum, avg;
            //Console.Write("enter the first number");
            //a = int.Parse(Console.ReadLine());
            //Console.Write("enter the second number");
            //b = int.Parse(Console.ReadLine());
            //Console.Write("enter the third number");
            //c = int.Parse(Console.ReadLine());
            //Console.Write("enter the fourth number");
            //d = int.Parse(Console.ReadLine());
            //Console.Write("enter the fifth number");
            //e = int.Parse(Console.ReadLine());
            //sum = a + b + c + d + e;
            //avg = (sum) / 5;
            //Console.Write("the summation is :");
            //Console.WriteLine(sum);
            //Console.Write("the average is :");
            //Console.WriteLine(avg);




            //*****************************************************



            //Console.WriteLine("Zeyad Ashraf Enab");
            //int m, n, i;
            //Console.WriteLine("enter m :");
            //m = int.Parse(Console.ReadLine());
            //Console.WriteLine("ENTER n :");
            //n = int.Parse(Console.ReadLine());
            //double sum = 0;
            //for (i = n; n < m; n++)
            //{
            //    if (n % 4 != 0)
            //    {
            //        sum = sum + (Math.Pow(i, 3)) + (Math.Sqrt(Math.Pow(i, 2)) + 1) / Math.Sin(i);
            //        continue;

            //    }
            //    break;
            //}
            //Console.WriteLine(sum);




            //*****************************************************



            //Console.WriteLine("Zeyad Ashraf Enab");
            //int i;
            //int n;
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter n :");
            //n = int.Parse(Console.ReadLine());
            //double sum;
            //for (i = -n; i < num; i++) ;
            //{
            //    if (num % i == 0) ;
            //    {
            //        sum = (Math.Sqrt(i + (5 * i))) / (7 * i);

            //    }

            //}

            //Console.WriteLine(sum);




            //****************************************************



            //Double A, B, C, X1, X2, D;
            //A = Double.Parse(Console.ReadLine());
            //B = Double.Parse(Console.ReadLine());
            //C = Double.Parse(Console.ReadLine());
            //D = Math.Pow(B, 2) - 4 * A * C;
            //if (D < 0)
            //{ Console.WriteLine("undefinded"); }
            //else if (D == 0)
            //{
            //    X1 = X2 = -B / (2 * A);
            //    Console.WriteLine("X1=X2= {0}", X1);
            //}


            //else
            //{
            //    X1 = (-B + Math.Sqrt(D)) / (2 * A);
            //    X2 = (-B + Math.Sqrt(D) / (2 * A));
            //    Console.WriteLine("X1={0} &X2={1}", X1, X2);
            //}





            //********************************************************************


            //Console.WriteLine("Please enter the size : ");
            //int size = int.Parse(Console.ReadLine());
            //Char[,] arr = new char[size, size];
            //for (int i = 0; i < size; i++)
            //{
            //    Console.WriteLine();
            //    for (int j = 0; j < size; j++)
            //    {
            //        if (i == j)
            //        {
            //            arr[i, j] = '\\';
            //        }
            //        else if ((i + j) == (size - 1))
            //        {
            //            arr[i, j] = '/';
            //        }
            //        else
            //            arr[i, j] = '*';
            //        if (size % 2 != 0)
            //        {
            //            arr[size / 2, size / 2] = 'X';
            //        }
            //        Console.Write(arr[i, j]);
            //    }
            //}




            //*************************************************************

            //string name, division;
            //int level;
            //double A, B, C, D, E, F;

            //Console.Write("your name");
            //name = Console.ReadLine();

            //Console.Write("your division");
            //division = Console.ReadLine();

            //Console.Write("your level");
            //level = int.Parse(Console.ReadLine());

            //Console.Write("your first degree");
            //A = double.Parse(Console.ReadLine());

            //Console.Write("your second degree");
            //B = double.Parse(Console.ReadLine());

            //Console.Write("your third degree");
            //C = double.Parse(Console.ReadLine());

            //Console.Write("your fourth degree");
            //D = double.Parse(Console.ReadLine());

            //Console.Write("your fifth degree");
            //E = double.Parse(Console.ReadLine());

            //F = (((A + B + C + D + E) / 500) * 100);
            //Console.WriteLine(F);

            //if (F >= 85) Console.Write("EXCELANT");


            //else if (F >= 75) Console.Write("VERY GOOD");

            //else if (F >= 65) Console.Write("GOOD");

            //else if (F >= 55) Console.Write("ACCEPTABLE");

            //else Console.Write("fail");



            //*************************************************




            //int z, x, y, sum, avg;
            //Console.WriteLine("enter your number");
            //x = int.Parse(Console.ReadLine());
            //z = 0;
            //for (y = 0; y < x; y++) ;
            //{
            //    sum = x + y;
            //    z += y;

            //    Console.WriteLine("{0}+{1}={2}", x, y, sum);

            //}

            //avg = z / y;
            //Console.WriteLine("{0}/{1}={2}", z, y, avg);




            //*****************************************************************



            //List<int> list = new List<int>();
            //int[] arr = new int[] { 20, 5, 25, 48, 35, 247, 28, 5, 0, -5, -55, 99, -111 };
            //// list.AddRange(arr);
            //int biggest = 0;
            //int smallest = list[0];
            //int sum = 0;
            //double average;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    list.Add(arr[i]);
            //}
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Enter element {i + 1} of three number : ");
            //    list.Add(int.Parse(Console.ReadLine()));
            //}
            //for (int i = 0; i < list.Count; i++)
            //{
            //    sum = sum + list[i];
            //    if (list[i] > biggest)
            //        biggest = list[i];
            //    if (list[i] < smallest)
            //        smallest = list[i];
            //}
            //average = sum / list.Count;
            //Console.WriteLine($"Average = {average} , Summation = {sum} , biggest num = {biggest} , smallest num = {smallest}");




            //***********************************************************





            //Console.WriteLine("Hello: Zeyad");
            //Console.WriteLine("*****************************************************************");




            //Console.Write("Enter number1 :");
            //double num1=double.Parse(Console.ReadLine());
            //Console.Write("Enter number2 :");
            //double num2 =double.Parse(Console.ReadLine());
            //Console.WriteLine($"Sum={num1+num2}");
            //Console.WriteLine("***********************************************************************");





            //Console.Write("Enter number1 :");
            //double num1 = double.Parse(Console.ReadLine());
            //Console.Write("Enter number2 :");
            //double num2 = double.Parse(Console.ReadLine());
            //Console.WriteLine($"Sum={num1 / num2}");
            //Console.WriteLine("*****************************************************************************");





            //Console.WriteLine(-1+4*6);
            //Console.WriteLine((35+5)%7);
            //Console.WriteLine(14 + -4 * 6 / 11);
            //Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
            //Console.WriteLine("******************************************************************************8");






            //Console.Write("num1=");
            //int num1=int.Parse(Console.ReadLine());
            //Console.Write("num2=");
            //int num2 =int.Parse(Console.ReadLine());
            //int swap = 0;
            //swap = num1;
            //num1 = num2;
            //num2 = swap;
            //Console.WriteLine(num1);
            //Console.WriteLine(num2);
            //Console.WriteLine("******************************************************************************");





            //Console.Write("num1=");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.Write("num2=");
            //int num2 = int.Parse(Console.ReadLine());
            //Console.Write("num3=");
            //int num3 = int.Parse(Console.ReadLine());
            //Console.WriteLine(num1*num2*num3);
            //Console.WriteLine("************************************************************************************");






            //Console.Write("num1=");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.Write("num2=");
            //int num2 = int.Parse(Console.ReadLine());
            //Console.WriteLine($"{num1}*{num2}= {num1 * num2}");
            //Console.WriteLine($"{num1}/{num2}= {num1 / num2}");
            //Console.WriteLine($"{num1}+{num2}= {num1 + num2}");
            //Console.WriteLine($"{num1}-{num2}= {num1 - num2}");
            //Console.WriteLine($"{num1}%{num2}= {num1 % num2}");
            //Console.WriteLine("********************************************************************************");
            //8
            //Console.Write("Num = :");
            //int num1=int.Parse(Console.ReadLine());
            //for(int i = 0; i < 11; i++)
            //{
            //    Console.WriteLine($"{num1}*{i} = {num1*(i)}");
            //}
            //Console.WriteLine("********************************************************************");





            //Console.Write("Num1 = ");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.Write("Num2 = ");
            //int num2 = int.Parse(Console.ReadLine());
            //Console.Write("Num3 = ");
            //int num3 = int.Parse(Console.ReadLine());
            //Console.Write("Num4 = ");
            //int num4 = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Average = {(num1+num2+num3+num4)/4}");
            //Console.WriteLine("******************************************************************");





            //Console.Write("Num1 = ");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.Write("Num2 = ");
            //int num2 = int.Parse(Console.ReadLine());
            //Console.Write("Num3 = ");
            //int num3 = int.Parse(Console.ReadLine());
            //Console.WriteLine((num1+num2)*num3);
            //Console.WriteLine((num1*num2)+(num2*num3))
            //Console.WriteLine("***********************************************************************");





            //Console.Write("Enter Your Age : ");
            //int age=int.Parse(Console.ReadLine());
            //Console.WriteLine("You look older than 20 *_*");
            //Console.WriteLine("*************************************************************************");





            //Console.Write("Num = ");
            //int Num=int.Parse(Console.ReadLine());
            //Console.WriteLine($"{Num} {Num} {Num} {Num}");
            //Console.WriteLine($"{Num}{Num}{Num}{Num}");
            //Console.WriteLine($"{Num} {Num} {Num} {Num}");
            //Console.WriteLine($"{Num}{Num}{Num}{Num}");
            //Console.WriteLine("******************************************************************************");







            //Console.Write("Num = ");
            //int Num=int.Parse(Console.ReadLine());
            //Console.WriteLine($"{Num}{Num}{Num}");
            //Console.WriteLine($"{Num} {Num}");
            //Console.WriteLine($"{Num} {Num}");
            //Console.WriteLine($"{Num} {Num}");
            //Console.WriteLine($"{Num}{Num}{Num}");
            //Console.WriteLine("******************************************************************************");





            //Console.Write("Enter the degree of selizus : ");
            //int degree=int.Parse(Console.ReadLine());
            //Console.WriteLine($"Kelvin = {degree + 273}");
            //Console.WriteLine($"Fahrenheit = {((degree + 40) * 1.8) - 40}");
            //Console.WriteLine("*********************************************************************************");
            //Console.Write("Enter text :");
            //string text= Console.ReadLine();
            //char x = text[0];
            //Console.WriteLine($"{x}{text}{x}");
            //Console.WriteLine("*************************************************************************************");





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





            //Console.Write("Num1 = ");
            //int num1=int.Parse(Console.ReadLine());
            //Console.Write("Num2 = ");
            //int num2=int.Parse(Console.ReadLine());
            //if (num1==num2)
            //    Console.WriteLine(Math.Pow((num1+num2),3));
            //else
            //    Console.WriteLine(num1+num2);
            //Console.WriteLine("****************************************************************************");





            //Console.Write("Num1 = ");
            //double num1 = int.Parse(Console.ReadLine());
            //Console.Write("Num2 = ");
            //double num2 = int.Parse(Console.ReadLine());
            //if(num1>num2)
            //    Console.WriteLine(num1);
            //else
            //    Console.WriteLine(num2);
            //Console.WriteLine("***********************************************************************");




            //Console.Write("Num1 = ");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.Write("Num2 = ");
            //int num2 = int.Parse(Console.ReadLine());
            //if (num1==20 || num2==20 || num1 + num2 == 20)
            //    Console.WriteLine("True");
            //else
            //    Console.WriteLine("False");
            //Console.WriteLine("*********************************************************************");





            //Console.Write("Enter num : ");
            //int num=int.Parse(Console.ReadLine());
            //if (num >= 20 && num <= 100)
            //    Console.WriteLine("This number between 20 , 100");
            //else if (num >= 20 && num <= 200)
            //    Console.WriteLine("This number between 20 and 200");
            //else

            //    Console.WriteLine("False");
            //Console.WriteLine("**********************************************************************");





            //Console.Write("Enter Text : ");
            //string text=Console.ReadLine();
            //Console.WriteLine(text.ToLower());
            //Console.WriteLine("*************************************");





            //for (int i = 0; i < 100; i++)
            //{
            //    if(i%2 != 0)
            //        Console.WriteLine(i);
            //}
            //Console.WriteLine("*********************************************************");
            //26
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
            //Console.WriteLine("*************************************************");





            //Console.Write("Enter Text : ");
            //string text=Console.ReadLine();
            //Console.WriteLine(text.Length);
            //Console.WriteLine("********************************************");





            //Console.Write("Enter size : ");
            //int Size=int.Parse(Console.ReadLine());
            //int[]arr1= new int[Size];
            //int[]arr2= new int[Size];
            //int[]multi= new int[Size];
            //for(int i=0; i<Size; i++)
            //{
            //    Console.WriteLine("Enter the number {0} in the first array",i+1);
            //    arr1[i] = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter the number {0} in the second array", i + 1);
            //    arr2[i] = int.Parse(Console.ReadLine());
            //    multi[i] = arr1[i] * arr2[i];
            //}
            //for(int i=0; i<Size;i++)
            //{
            //    Console.Write(multi[i] + "    ");
            //}






            //Console.WriteLine("***********************************************************");






            //Console.Write("Enter Text : ");
            //string text=Console.ReadLine();
            //string cut;
            //cut = text.Substring(4, text.Length-4);
            //Console.WriteLine($"{cut}{cut}{cut}{cut}");





            //Console.WriteLine("********************************************************************");





            //Console.Write("Enter number : ");
            //int num=int.Parse(Console.ReadLine());
            //if (num % 3 == 0 || num % 7 == 0)
            //    Console.WriteLine("True");
            //else
            //    Console.WriteLine("False");





            //Console.WriteLine("***************************************************");





            //Console.Write("Enter Text : ");
            //string text=Console.ReadLine();
            //if (text.Substring(0, 5) == "Hello") 
            //    Console.WriteLine("True");
            //else
            //    Console.WriteLine("False");





            //Console.WriteLine("************************************************");





            //Console.Write("Enter num1 : ");
            //int num1=int.Parse(Console.ReadLine());
            //Console.Write("Enter num2 : ");
            //int num2 = int.Parse(Console.ReadLine());
            //if (num1 > 200 && num2 < 100 || num2 > 200 && num1 < 100)
            //    Console.WriteLine("True");
            //else
            //    Console.WriteLine("False");






            //Console.WriteLine("*****************************************");






            //Console.Write("Enter num1 : ");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.Write("Enter num2 : ");
            //int num2 = int.Parse(Console.ReadLine());
            //if (num1 > -10 && num1 < 10 && num2 > -10 && num2 < 10)
            //    Console.WriteLine("True");
            //else
            //    Console.WriteLine("False");





            //Console.WriteLine("*******************************************************");





            // Console.Write("Enter Text : ");
            // string text=Console.ReadLine();
            //text= text.Replace("HP", "");
            // Console.WriteLine(text);





            // Console.WriteLine("************************************************************");





            //Console.Write("Enter text : ");
            //string text= Console.ReadLine();
            //bool T = text.Contains('T');
            //bool H =text.Contains('H');
            //if (T == true && H == true)
            //    Console.WriteLine("TH");
            //else
            //    Console.WriteLine(text);






            //Console.WriteLine("***********************************************************");






            //Console.Write("Enter num1 : ");
            //int num1=int.Parse(Console.ReadLine());
            //Console.Write("Enter num2 : ");
            //int num2 = int.Parse(Console.ReadLine());
            //Console.Write("Enter num3 : ");
            //int num3 = int.Parse(Console.ReadLine());
            //if (num1 >= num2 && num1 >= num3)
            //{
            //    Console.WriteLine($"The largest number = {num1}");
            //    if (num2 >= num3)
            //        Console.WriteLine($"The smallest number = {num3}");
            //    else
            //        Console.WriteLine($"The smallest number = {num2}");
            //}
            //else if(num2>= num3)
            //{
            //    Console.WriteLine($"The largest number = {num2}");
            //    if (num3 >= num1)
            //        Console.WriteLine($"The smallest number = {num1}");
            //    else
            //        Console.WriteLine($"The smallest number = {num3}");
            //}
            //else
            //{
            //    Console.WriteLine($"The largest number = {num3}");
            //    if(num2>=num1)
            //        Console.WriteLine($"The smallest number = {num1}");
            //    else
            //        Console.WriteLine($"The smallest number = {num2}");

            //}






            //Console.WriteLine("***********************************************************");





            // Console.Write("Enter num1 : ");
            // int num1 = int.Parse(Console.ReadLine());
            // Console.Write("Enter num2 : ");
            // int num2 = int.Parse(Console.ReadLine());
            // if (num1 >= 20)
            // {
            //     if (num2 >= 20)
            //     {
            //         if (num1 - 20 >= num2 - 20)
            //         {
            //             Console.WriteLine(num2);
            //         }
            //         else
            //         {
            //             Console.WriteLine(num1);
            //         }
            //     }
            //     else
            //     {
            //         if (num1 - 20 >= 20 - num2) 
            //         {
            //             Console.WriteLine(num2);
            //         }
            //         else
            //         { Console.WriteLine(num1);}
            //     }
            // }
            //else if (num2 >= 20)
            // {
            //     if (num1 >= 20)
            //     {
            //         if (num2 - 20 >= num1 - 20)
            //         {
            //             Console.WriteLine(num1);
            //         }
            //         else
            //         {
            //             Console.WriteLine(num2);
            //         }
            //     }
            //     else
            //     {
            //         if (num2 - 20 >= 20 - num1)
            //         {
            //             Console.WriteLine(num1);
            //         }
            //         else
            //         { Console.WriteLine(num2); }
            //     }
            //}
            // else
            // {
            //     if(20-num1 >= 20-num2) 
            //     {
            //         Console.WriteLine(num2);
            //     }
            //     else
            //     {
            //         Console.WriteLine(num1); 
            //     }
            // }





            //Console.WriteLine("**********************************************");




            //Console.WriteLine("Enter text : ");
            //string text=Console.ReadLine();
            //int temp = 0;
            //for (int i = 0; i < text.Length; i++)
            //{
            //    if (text[i]=='W')
            //        temp++;
            //}
            //if (temp == 1||temp==2||temp==3)
            //    Console.WriteLine("True");
            //else
            //    Console.WriteLine("False");





            //Console.WriteLine("*****************************************************");





            //Console.Write("Enter text : ");
            //string text=Console.ReadLine();
            //string cut=null;

            //if (text.Length < 4)
            //{
            //    text = text.ToUpper();
            //}
            //else
            //{
            //    cut = text.Substring(0, 4);
            //    cut = cut.ToLower();
            //}
            //text=text.Remove(0, 4);
            //Console.WriteLine(cut+text);













        }
    }
}