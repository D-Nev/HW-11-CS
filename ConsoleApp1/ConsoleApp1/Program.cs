using MorseSharp;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var converter = Morse.GetConverter().ForLanguage(Language.Russian);

            Console.WriteLine("1. Обычный текст → Азбука Морза");
            Console.WriteLine("2. Азбука Морза → Обычный текст");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Введите текст: ");
                    string TextIntup = Console.ReadLine();
                    string MorseCode = converter.ToMorse(TextIntup).Encode();
                    Console.WriteLine($"Текст в азбуке Морза: {MorseCode}");
                    break;

                case "2":
                    Console.Write("Введите код Морза: ");
                    string inputMorse = Console.ReadLine();
                    string decodedText = converter.Decode(inputMorse);
                    Console.WriteLine($"Расшифрованный текст: {decodedText}");
                    break;
            }
        }

        
    }
}
