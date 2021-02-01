using System;
using System.Collections.Generic;
using System.Text;

namespace MestreDosCodigos.Escudeiro.POO
{
    public class ControleRemoto
    {
        public Televisao Televisao { get; private set; }

        public void ConfigurarTelevisao(Televisao televisao)
        {
            Televisao = televisao;
        }

        public void AumentarVolume()
        {
            Televisao.AumentarVolume();
        }

        public void DiminuirVolume()
        {
            Televisao.DiminuirVolume();
        }
    }
}
