using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects.Shapes
{
	class Elipse : Object2D
	{

		public double A { get; protected set; }
		public double B { get; protected set; }
		public Elipse(double lenghtA, double lengthB)
		{
			A = lenghtA;
			B = lengthB;

		}

		public override double CalculateContent()
		{
			if (A > 0 & B > 0)
			{
				return Math.PI * A * B;
			}
			else
			{
				throw new Exception("Wrong size of elipse");
			}
		}

		public override void Write()
		{
			Console.WriteLine("Content of Elipse is: {0}\n", CalculateContent());
		}
	}
}
