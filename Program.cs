namespace Character_Is_Alphabet_Or_Not
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the character to check it is Alphabet:");

            char alphabet = Convert.ToChar(Console.ReadLine());
            if ((alphabet >= 'a' && alphabet <= 'z') || (alphabet >= 'A' && alphabet <= 'Z'))
            {

                Console.WriteLine($"{alphabet}:is a alphabet");
            }
            else 
            {
                Console.WriteLine($"{alphabet}: is not a alphabet");
            }
        }
    }
}