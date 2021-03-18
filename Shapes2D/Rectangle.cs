using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects.Shapes
{
	class Rectangle : Object2D
	{
		public double A { get; protected set; }
		public double B { get; protected set; }

		public Rectangle(double sideA, double sideB)
		{
			this.A = sideA;
			this.B = sideB;
		}
		public override double CalculateContent()
		{

			if (A < 0 || B < 0)
			{
				throw new Exception("Wrong size of rectangle side");
			}
			else
			{
				return A * B;

			}
		}

		public override void Write()
		{
			Console.WriteLine("Content of Rectangle: {0}\n", CalculateContent());
		}
	}
}
