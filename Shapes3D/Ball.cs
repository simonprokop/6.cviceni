using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects.Shapes
{
	class Ball : Object3D
	{
		public double Radius { get; protected set; }
		public Ball (double radius)
		{
			Radius = radius;
		}

		public override double CalculateSurface()
		{
			if (Radius > 0) { return 4 * Math.PI * Radius * Radius; }
			else { throw new Exception("Wrong size of radius"); }

			
		}

		public override double CalculateVolume()
		{
			if (Radius > 0)
			{
				return 4 / 3 * Math.PI * Radius * Radius * Radius;
			}
			else { throw new Exception("Wrong size of radius"); }
		}

		public override void Write()
		{
			Console.WriteLine("Surface of Ball: {0}", CalculateSurface());
			Console.WriteLine("Volume of Ball: {0}\n", CalculateVolume());
		}
	}
}
