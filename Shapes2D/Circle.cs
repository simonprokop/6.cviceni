using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects.Shapes
{
	class Circle : Object2D
	{

		public double Radius
		{ get; protected set; }

		public Circle(double radius)
		{
			Radius = radius;
		}

		public override double CalculateContent()
		{
			if (Radius > 0)
			{
				return Math.PI * Radius * Radius; 
			}
			else 
			{ 
				throw new Exception("Wrong size of radius"); 
			}
		}

		public override void Write()
		{
			Console.WriteLine("Content of Circle: {0} \n", CalculateContent());
		}


	}
}
