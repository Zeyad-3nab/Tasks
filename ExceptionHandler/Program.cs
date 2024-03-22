namespace ExceptionHandler
{
    public class Program
    {
        static void Main(string[] args)
        {

            //We have a Try & Catch Keywords but But that are used when it is predicted that an error will occur in a specific part of the code
            ////Task 1

            //List<int> list = new List<int>();
            //int x;
            //for (int i = 0; i < 10; i++)
            //{
            //    x=int.Parse(Console.ReadLine());
            //    if(list.Count == 0)
            //    {
            //          list.Add(x);
            //    }
            //    else
            //    {
            //        for (int j = 0; j < list.Count; j++) 
            //        {
            //              if (list[j] == x)
            //              {
            //                  throw new Exception("Duplication");

            //              }

            //        }
            //    }
            //}


            //=========================================================
            //Task 2

            //CheckVowels("sdfgh");
        }
        public static void CheckVowels(string text)
        {
            text=text.ToLower();
            for(int i=0; i<text.Length; i++)
            {
                if (text[i] == 'a' || text[i] == 'e' || text[i] == 'i' || text[i] == 'o' || text[i] == 'u')
                {
                    throw new Exception($"Thats have a Vowels char {text[i]} in char number {i + 1}");
                }
            }
            Console.WriteLine("Not Have a vowels chars");
        }
    }
}