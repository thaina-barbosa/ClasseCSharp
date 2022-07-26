using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais.Src
{
    public class ListaAnimais
    {

        public string Animal { get; set; }
        public string  Nome { get; set; }
        public string Raca { get; set; }
        public string Porte { get; set; }
        public string Cor { get; set; }


        public ListaAnimais(string animal, string nome, string raca, string porte, string cor)
        {
            Animal = animal;
            Nome = nome;
            Raca = raca;
            Porte = porte;
            Cor = cor;
            
        }

        public override string ToString()
        {
            return $" Animal:{Animal} \n"+
                   $" Nome:{Nome} \n" +
                   $" Raça:{Raca}  \n" +
                   $" Porte:{Porte} \n"+
                   $" Cor:{Cor} \n";

        }
        
            
        
            

    
    }
}
