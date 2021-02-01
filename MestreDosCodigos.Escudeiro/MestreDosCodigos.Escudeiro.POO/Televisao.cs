using System;
using System.Collections.Generic;
using System.Text;

namespace MestreDosCodigos.Escudeiro.POO
{
    public class Televisao
    {
        public int Volume { get; set; }
        public ControleRemoto ControleRemoto { get; private set; }

        public Televisao(ControleRemoto controleRemoto)
        {
            ControleRemoto = controleRemoto;
            ControleRemoto.ConfigurarTelevisao(this);
        }

        public void AumentarVolume()
        {
            if (Volume < 99)
                Volume++;
            Console.WriteLine(Volume);
        }

        public void DiminuirVolume()
        {
            if (Volume > 0)
                Volume--;
            Console.WriteLine(Volume);
        }
    }
}
