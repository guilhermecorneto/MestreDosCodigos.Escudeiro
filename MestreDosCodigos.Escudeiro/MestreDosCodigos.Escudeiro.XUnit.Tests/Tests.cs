using Bogus;
using System.Collections.Generic;
using Xunit;

namespace MestreDosCodigos.Escudeiro.XUnit.Tests
{
    public class Tests
    {
        private readonly Faker _faker;

        public Tests()
        {
            _faker = new Faker();
        }

        [Fact]
        public void DeveIdentificarParouImpar()
        {
            var valor = _faker.Random.Int(min: 0);
            var paridade = valor % 2 == 0 ? "PAR" : "ÍMPAR";

            var parOuImpar = Program.ParOuImpar(valor);

            Assert.Equal(paridade, parOuImpar);
        }

        [Fact]
        public void DeveRetornarElementosDaListaSeparadosPorVirgula()
        {
            var count = _faker.Random.Int(min: 1, max: 99);
            var lista = new List<int>();
            for (var i = 0; i < count; i++)
                lista.Add(_faker.Random.Int());
            var str = string.Join(", ", lista);

            var listaStr = Program.ImprimirLista(lista);

            Assert.Equal(str, listaStr);
        }
    }
}
