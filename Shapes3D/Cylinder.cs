using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects.Shapes
{
	class Cylinder : Object3D
	{

		public double V { get; protected set; }
		public double R { get; protected set; }

		public Cylinder (double heightV, double Radius)
		{
			V = heightV;
			R = Radius;

		}
		public override double CalculateSurface()
		{
			return 2 * Math.PI * R * (R + V);
		}

		public override double CalculateVolume()
		{
			return Math.PI * R * R * V;
		}

		public override void Write()
		{
			Console.WriteLine("Surface of Cylinder: {0}", CalculateSurface());
			Console.WriteLine("Volume of Cylinder: {0}", CalculateVolume());
		}
	}
}
