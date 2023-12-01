using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogoDaForca.interfaceForca
{
    internal class ApresentaBoneco
    {
        public static void Apresenta(int tentativasErradas, char letraincorreta)
        {
            List<char> letrasIncorretas = new List<char>();
            string[] Boneco = new string[]
            {
            "  ( )",
            "   |",
            """  /|\ """,
            "   |",
            """  /|\ """
            };

            Console.WriteLine("Você Errou!s");
            for (int i = 0; i <tentativasErradas; i++)
            {
                letrasIncorretas.Add(letraincorreta);

                Console.WriteLine(Boneco[i]);
                
                Console.WriteLine("As letras erradas foram: ");
                
                foreach (var letra in letrasIncorretas )
                {
                    Console.WriteLine($"{letra}, ");
                }
                if (i == Boneco.Length-1)
                {
                    Console.WriteLine("\r\n█░█ █▀█ █▀▀ █▀▀   █▀█ █▀▀ █▀█ █▀▄ █▀▀ █░█\r\n▀▄▀ █▄█ █▄▄ ██▄   █▀▀ ██▄ █▀▄ █▄▀ ██▄ █▄█");
                }
            }



        }
    }
}
