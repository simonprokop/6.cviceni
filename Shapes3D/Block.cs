using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects.Shapes
{
	class Block : Object3D
	{
		public double A { get; protected set; }
		public double B { get; protected set; }
		public double C { get; protected set; }

		public Block (double sideA, double sideB, double sideC)
		{
			A = sideA;
			B = sideB;
			C = sideC;
		}

		public override double CalculateSurface()
		{
			return 2 * ((A * B) + (B * C) + (C * A));
		}

		public override double CalculateVolume()
		{
			return A * B * C;
		}

		public override void Write()
		{
			Console.WriteLine("Surface of Block: {0}", CalculateSurface());
			Console.WriteLine("Volume of Block: {0}\n", CalculateVolume());
		}
	}
}
