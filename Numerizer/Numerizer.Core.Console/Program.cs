using System;

namespace Numerizer.Core.Console
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string input = string.Empty;

            var dehumanizer = new PTBRDehumanizer();

            while (true)
            {
                try
                {
                    input = System.Console.ReadLine();

                    if (input == "sair")
                        break;

                    System.Console.WriteLine(dehumanizer.DehumanizeCardinal(input));
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex.Message);
                }

            }
        }
    }
}
