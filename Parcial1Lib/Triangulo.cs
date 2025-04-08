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
		public Triangulo(double base_, double altura)
		{
			this.base_ = base_;
			this.altura = altura;
		}
		public override double Area()
		{
			return (base_ * altura) / 2;
		}
		public override double Perimetro()
		{
			return 3*base_;
		}
	}
}
