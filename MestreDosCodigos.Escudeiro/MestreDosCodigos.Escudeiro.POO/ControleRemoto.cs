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

        public string AumentarVolume()
        {
            return "Volume: " + Televisao.AumentarVolume();
        }

        public string DiminuirVolume()
        {
            return "Volume: " + Televisao.DiminuirVolume();
        }

        public string DiminuirCanal()
        {
            return "Canal: " + Televisao.DiminuirCanal();
        }

        public string AumentarCanal()
        {
            return "Canal: " + Televisao.AumentarCanal();
        }

        public string ConferirVolumeECanal()
        {
            return
                "Volume atual: " + Televisao.Volume + "\n" +
                "Canal atual: " + Televisao.Canal;
        }

        public int LerCanal()
        {
            var canalValido = false;
            do
            {
                Console.Write("Digite um canal entre 1 e 99: ");
                var leitura = Console.ReadLine();
                if (int.TryParse(leitura, out var canal))
                {
                    if (canal > 0 && canal < 100)
                        return canal;
                }
                Console.WriteLine("Canal inválido!");
                Console.WriteLine("");
            } while (!canalValido);
            return 1;
        }

        public string IrParaCanal(int canal)
        {
            return "Canal: " + Televisao.IrParaCanal(canal);
        }
    }
}
