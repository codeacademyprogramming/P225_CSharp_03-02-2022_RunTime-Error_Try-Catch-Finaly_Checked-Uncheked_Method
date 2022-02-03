using System;

namespace P225RuntimeErrorMethodFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Runtime Error Try Cach Checked finaly unChecked
            //int a = 5;
            //int b = 0;

            //Console.WriteLine(a/b);

            //string inp = Console.ReadLine();

            //string inpa = Console.ReadLine();
            //string inpb = Console.ReadLine();
            //int a = int.Parse(inpa);
            //int b = int.Parse(inpb);
            //int[] arr = { 2, 3, 5 };

            //try
            //{
            //    int index = int.Parse(inp);
            //    Console.WriteLine(arr[index]);

            //    //Console.WriteLine(a / b);
            //}
            //catch (Exception)
            //{

            //    Console.WriteLine("Xeta Var");
            //}
            //finally
            //{
            //    Console.WriteLine("Finaly Isledi");
            //}



            //checked
            //{
            //    int a = 256;
            //    byte b1 = (byte)a;
            //    Console.WriteLine(b1);
            //}

            //try
            //{
            //    checked
            //    {
            //        int maxValue = 2147483647;
            //        int b2 = maxValue + 10;
            //        Console.WriteLine(b2);
            //    }
            //}
            //catch (Exception)
            //{

            //    Console.WriteLine("Heedini Asir");
            //}

            //try
            //{
            //    checked
            //    {
            //        int a = 799;
            //        byte b1 = (byte)a;
            //        Console.WriteLine(b1);
            //    }
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
            #endregion

            int[] arr1 = { 1, 2, 3 };
            int[] arr2 = { 3, 4, 5 };

            int[] arr3 = { 35, 45, 63 };
            int[] arr4 = { 27, 63, 35 };

            Console.WriteLine("arr2 vs arr1");
            CheckSameValueByArray(arr2, arr1);

            Console.WriteLine("arr4 vs arr3");
            CheckSameValueByArray(arr4, arr3);

            int a = Calc(5, 7,"Hello World",false);

            //Console.WriteLine(a);

            ShowItem(5,7,3,9);

            Sum(3.2, 3.2);

            var aa = "";

            dynamic test = "";

            test = true;


            //sneake case Variable, method parametr
            int number_one;

            //Paskal Case//Class Addlari,  Method Addlari, Classsin Memmberleri
            int NumberOne;

            //Camel Case // privete Member -- _asd
            int evenSumTwoNumber;

            //Kebab Case
            //int number-one

        }
        static bool Sum(int a, int b)
        {
            int p225;
            Console.WriteLine(a+b);
            return true;
        }

        static void Sum(double a, double b)
        {
            int p225;
            Console.WriteLine(a + b);
        }

        static void ShowItem(params int[] arr)
        {
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
        }

        static int Calc(int a, int b, string c = "", bool d = false)
        {
            int result = a + b;

            return result;

            //if (a > 0)
            //{
            //    return b;
            //}
            //else if (b > 0)
            //{
            //    return a;
            //}
        }

        static void CheckSameValueByArray(int[] birinciarray, int[] ikinciarray)
        {
            return;
            for (int i = 0; i < birinciarray.Length; i++)
            {
                bool flag = true;
                for (int j = 0; j < ikinciarray.Length; j++)
                {
                    if (birinciarray[i] == ikinciarray[j])
                    {
                        flag = false;
                        break;
                    }
                }

                if (flag)
                {
                    Console.WriteLine(birinciarray[i]);
                }
            }
        }
    }
}
