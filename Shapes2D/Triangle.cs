using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects.Shapes
{
	class Triangle : Object2D
	{
		public double A { get; protected set; }
		public double B { get; protected set; }
		public double C { get; protected set; }

		public Triangle(double sideA, double sideB, double sideC)
		{
			A = sideA;
			B = sideB;
			C = sideC;

		}

		public override double CalculateContent()
		{
			if (A + B > C || B + C > A || C + A > B) //Triangle check
			{
				double S = (A + B + C) / 2;
				return Math.Sqrt(S * (S - A) * (S - B) * (S - C));
			}
			else
			{
				throw new Exception("Wrong size of triangle sides");

			}

		}


		public override void Write()
		{
			Console.WriteLine("Content of Triangle: {0}\n", CalculateContent());
		}
	}
}
