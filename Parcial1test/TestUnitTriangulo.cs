using Parcial1Lib;

namespace Parcial1test
{
	[TestClass]
	public sealed class TestUnitTriangulo
	{
		[TestMethod]
		public void TestArea()
		{
			Triangulo triangulo= new Triangulo(2,2,2,2,2);
			double resultado= triangulo.Area();
			Assert.AreEqual(2,resultado);

		}
		[TestMethod]
		public void TestPerimetro() {
			Triangulo triangulo = new Triangulo(2, 2, 2, 2, 2);
			double resultado=triangulo.Perimetro();
			Assert.AreEqual(6,resultado);
		}
	}
}
