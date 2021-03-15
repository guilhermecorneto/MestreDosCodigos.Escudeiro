using System;

namespace MestreDosCodigos.Escudeiro.POO
{
    public class Televisao
    {
        public int Volume { get; set; }
        public int Canal { get; set; }
        public ControleRemoto ControleRemoto { get; private set; }

        public Televisao(ControleRemoto controleRemoto)
        {
            ControleRemoto = controleRemoto;
            ControleRemoto.ConfigurarTelevisao(this);
        }

        public int AumentarVolume()
        {
            if (Volume < 99)
                Volume++;
            return Volume;
        }

        public int DiminuirVolume()
        {
            if (Volume > 0)
                Volume--;
            return Volume;
        }

        public int AumentarCanal()
        {
            if (Canal < 99)
                Canal++;
            return Canal;
        }

        public int DiminuirCanal()
        {
            if (Canal > 1)
                Canal--;
            return Canal;
        }

        public int IrParaCanal(int canal)
        {
            Canal = canal;
            return canal;
        }
    }
}
