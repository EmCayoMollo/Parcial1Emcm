using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1Lib
{
	public class Triangulo:FiguraGeometrica
	{
		public double base_;
		public double altura;
		public double lado1;
		public double lado2;
		public double lado3;
		public Triangulo(double base_, double altura, double lado1, double lado2, double lado3)
		{
			this.base_ = base_;
			this.altura = altura;
			this.lado1 = lado1;
			this.lado2 = lado2;
			this.lado3 = lado3;
		}
		public override double Area()
		{
			return (base_ * altura) / 2;
		}
		public override double Perimetro()
		{
			return lado1 + lado2 + lado3;
		}
	}
}
