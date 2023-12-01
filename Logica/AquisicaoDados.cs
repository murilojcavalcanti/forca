using jogoDaForca.interfaceForca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace jogoDaForca.Logica
{
    internal class AquisicaoDados
    {
       
        public string[] chavesForca = new string[]
        {
            "Animal",
            "Profissão",
            "Objeto",
            "flor",
            "Instrumento",
            "meio de transporte",
            "jogo",
            "fruta"
        };


        public Dictionary<string, string> BancoPalavras = new Dictionary<string, string>()
        {
            {"Animal","elefante" },
            {"Profissão","advogado" },
            {"Objeto","bocharra" },
            {"flor","girassol" },
            {"Instrumento","violino" },
            {"meio de transporte","carro" },
            {"jogo","xadrez" },
            {"fruta","abacaxi" }
        };

        

    }
}
