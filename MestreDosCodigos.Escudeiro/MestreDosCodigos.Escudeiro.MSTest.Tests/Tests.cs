using Bogus;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework.Internal;
using System.Collections.Generic;

namespace MestreDosCodigos.Escudeiro.MSTest.Tests
{
    [TestClass]
    public class Tests
    {
        private readonly Faker _faker;

        public Tests()
        {
            _faker = new Faker();
        }

        [TestMethod]
        public void DeveIdentificarParouImpar()
        {
            var valor = _faker.Random.Int(min: 0);
            var paridade = valor % 2 == 0 ? "PAR" : "ÍMPAR";

            var parOuImpar = Program.ParOuImpar(valor);

            Assert.AreEqual(paridade, parOuImpar);
        }

        [TestMethod]
        public void DeveRetornarElementosDaListaSeparadosPorVirgula()
        {
            var count = _faker.Random.Int(min: 1, max: 99);
            var lista = new List<int>();
            for (var i = 0; i < count; i++)
                lista.Add(_faker.Random.Int());
            var str = string.Join(", ", lista);

            var listaStr = Program.ImprimirLista(lista);

            Assert.AreEqual(str, listaStr);
        }
    }
}
