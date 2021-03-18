using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects.Shapes
{
	class Pyramid : Object3D
	{

		public double A { get; protected set; }
		public double V { get; protected set; } //size of height
		public double N { get; protected set; } //number of sides

		private double Sp;
		private double Spl;

		public Pyramid(double sideA, double heightV, double numberofsidesN)
		{
			A = sideA;
			V = heightV;
			N = numberofsidesN;

			
		}
		public override double CalculateSurface()
		{
			

			if (N == 3)
			{
				Sp = (Math.Sqrt(3) / 4) * A * A;
				Spl = (A * V) / 2;
				return Sp + Spl;

			}

			if (N == 4)
			{
				Sp = A * A;
				Spl = (A * V) / 2;
				return Sp + Spl;

			}

			if (N == 5)
			{
				Sp = ((Math.Sqrt(3) * 3) / 2) * A * A;
				Spl = (A * V) / 2;
				return Sp + Spl;

			}
			else
			{
				throw new Exception("Wrong number of sides");

			}

	
		}

		public override double CalculateVolume()
		{
			

			if (N == 3)
			{
				Sp = (Math.Sqrt(3) / 4) * A * A;
				return 1 / 3 * (Sp * V);
			}

			if (N == 4)
			{
				Sp = A * A;
				return 1 / 3 * (Sp * V);
			}

			if (N == 5)
			{
				Sp = ((Math.Sqrt(3) * 3) / 2) * A * A;
				return 1 / 3 * (Sp * V);
			}
			else
			{
				throw new Exception("Wrong number of sides");
			}
		
			
		}

		public override void Write()
		{
			Console.WriteLine("Surface of Pyramid: {0}", CalculateSurface());
			Console.WriteLine("Volume of Pyramid: {0}\n", CalculateVolume());
		}
	}
}
