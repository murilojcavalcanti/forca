using jogoDaForca.interfaceForca;
using jogoDaForca.Logica;
using JogoDaForca.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogoDaForca.MenuForca
{
    internal class MenuForca
    {
       
        public static void Apresenta()
        {
            Console.WriteLine("\r\n░░░░░██╗░█████╗░░██████╗░░█████╗░  ██████╗░░█████╗░  ███████╗░█████╗░██████╗░░█████╗░░█████╗░\r\n░░░░░██║██╔══██╗██╔════╝░██╔══██╗  ██╔══██╗██╔══██╗  ██╔════╝██╔══██╗██╔══██╗██╔══██╗██╔══██╗\r\n░░░░░██║██║░░██║██║░░██╗░██║░░██║  ██║░░██║███████║  █████╗░░██║░░██║██████╔╝██║░░╚═╝███████║\r\n██╗░░██║██║░░██║██║░░╚██╗██║░░██║  ██║░░██║██╔══██║  ██╔══╝░░██║░░██║██╔══██╗██║░░██╗██╔══██║\r\n╚█████╔╝╚█████╔╝╚██████╔╝╚█████╔╝  ██████╔╝██║░░██║  ██║░░░░░╚█████╔╝██║░░██║╚█████╔╝██║░░██║\r\n░╚════╝░░╚════╝░░╚═════╝░░╚════╝░  ╚═════╝░╚═╝░░╚═╝  ╚═╝░░░░░░╚════╝░╚═╝░░╚═╝░╚════╝░╚═╝░░╚═╝");
            Console.Write("Digite 1 para jogar sozinho ou 2 para jogar com alguém:");
            int.TryParse(Console.ReadLine(), out int op);
            Recebeopcao(op);
        }

        public static void Recebeopcao(int opcao)
        {
            switch (opcao)
            {
                case 1:
                    AquisicaoDados ad = new AquisicaoDados();

                    Forca.ForcaUmaPessoa(ad.chavesForca, ad.BancoPalavras);
                    break;

                    case 2:
                    Forca.ForcaDuasPessoas();
                    break;
                default:
                    Console.WriteLine("Opção invalida!");
                    break;
            }
        }

    }
}
