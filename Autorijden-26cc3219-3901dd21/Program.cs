namespace rijbewijs
{
    internal class Program
    {

        static void Main(string[] args)
        {
            bool check = true;
            while (check)
            {
                Console.WriteLine("Hoe oud ben je?");
                float leeftijd = float.Parse(Console.ReadLine());

                if (leeftijd < 16.5)
                {
                    Console.WriteLine("Je mag nog geen auto rijden!");
                }
                else
                {
                    Console.WriteLine("Je mag auto rijden!");
                }



            }
        }
    }
}