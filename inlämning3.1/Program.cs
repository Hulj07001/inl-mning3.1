using System;
namespace inlämning3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hej! Ange din ålder för att få se om du får delta i tävlingen:");
                int ålder = int.Parse(Console.ReadLine());

                if (ålder < 16)
                {
                    Console.WriteLine("Du är för ung för att delta.");
                }
                else if (ålder > 19)
                {
                    Console.WriteLine("Du är för gammal för att delta.");
                }
                else
                {
                    Console.WriteLine("Du får delta!");
                }
            }
            catch
            {
                Console.WriteLine("Skriv in hela antal.");
            }
        }
    }
}