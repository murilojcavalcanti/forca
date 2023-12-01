using jogoDaForca.interfaceForca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaForca.Logica
{
    internal class VerificaPalavra
    {
        public static void VerificaPalavraForca(char[] palavraEscondida, char[] palavraForca, string DicaForca)
        {
            int acertos = 0;
            int erros = 0;
            List<char> letrascorretas = new List<char>();
            while (erros < 5 && acertos < palavraForca.Length)
            {
                Console.WriteLine($"A palavra tem {palavraEscondida.Length} letras");
                Console.WriteLine($"DICA da palavra é: {DicaForca}");

                Console.Write("Digite uma letra: ");
                
                char letra = Console.ReadKey().KeyChar;
                
                Console.WriteLine(" ");

                if (palavraForca.Contains(letra))
                {
                    Console.WriteLine("\nvocê acertou!");
                    for (int i = 0; i < palavraForca.Length; i++)
                    {
                        if (palavraForca[i] == letra)
                        {
                            palavraEscondida[i] = letra;
                            acertos++;
                            letrascorretas.Add(letra);
                        }
                    }
                    for (int i = 0; i < palavraForca.Length; i++)
                    {
                        Console.Write(palavraEscondida[i]);
                    }
                    Console.WriteLine(" ");

                }
                else
                {
                    erros++;
                    ApresentaBoneco.Apresenta(erros,letra);
                }
            }
            if (palavraForca.Equals(palavraForca))
            {
                Forca.acertou();
            }

        }
    }
}
