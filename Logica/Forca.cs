using jogoDaForca.interfaceForca;
using jogoDaForca.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaForca.Logica
{
    internal class Forca
    {
        public static void ForcaDuasPessoas()
        {
            try
            {

                Console.Write("Digite a palavra que será descoberta: ");
                char[] palavraForca = Console.ReadLine().ToCharArray();

                Console.Write("Digite a dica relacionada a palavra: ");
                string DicaForca = Console.ReadLine();

                char[] palavraEscondida = CompletaPalavra(palavraForca.Length);

                VerificaPalavra.VerificaPalavraForca(palavraEscondida, palavraForca, DicaForca);
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocorreu o erro {ex.Message}");
            }


        }

        public static void ForcaUmaPessoa(string[] chavesForca, Dictionary<string, string> BancoPalavras)
        {
            try
            {
                Random random = new Random();
            int indice = random.Next(0, (chavesForca.Length - 0));
            string DicaForca = chavesForca[indice];

            char[] palavraForca = BancoPalavras[DicaForca].ToCharArray();
            char[] palavraEscondida = CompletaPalavra(palavraForca.Length);

            VerificaPalavra.VerificaPalavraForca(palavraEscondida, palavraForca, DicaForca);
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocorreu o erro {ex.Message}");
            }
        }

        public static char[] CompletaPalavra(int tamanhoPalavraforca)
        {
            char[] palavraEscondida = new char[tamanhoPalavraforca];

            for (int i = 0; i < palavraEscondida.Length; i++)
            {
                palavraEscondida[i] = '_';
            }
            return palavraEscondida;
        }


        public static void acertou()
        {
            Console.WriteLine(" \r\n█▀█ ▄▀█ █▀█ ▄▀█ █▄▄ █▀▀ █▄░█ █▀\r" +
                                 "\n█▀▀ █▀█ █▀▄ █▀█ █▄█ ██▄ █░▀█ ▄█ ");
            Console.WriteLine("\r\n█░█ █▀█ █▀▀ █▀▀   ▄▀█ █▀▀ █▀▀ █▀█ ▀█▀ █▀█ █░█\r" +
                                "\n▀▄▀ █▄█ █▄▄ ██▄   █▀█ █▄▄ ██▄ █▀▄ ░█░ █▄█ █▄█");
        }


    }
}
