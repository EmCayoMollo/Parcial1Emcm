using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1Lib
{
	public class Circulo: FiguraGeometrica
	{
		public double radio { get; set; }
		public override double Area()
		{
			return 3.14 + radio * radio;
		}
		public override double Perimetro()
		{
			return 2 * 3.14 * radio;
		}
	}
}
