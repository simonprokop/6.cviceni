using Objects.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
	class Program
	{
		static void Main(string[] args)
		{

			GrObject[] field = new GrObject[]
			{
				// 2D Objects
					new Circle(radius: 2),
					new Elipse(lenghtA: 3,lengthB: 5),
					new Rectangle(sideA: 4,sideB: 7),
					new Triangle(sideA: 3, sideB: 4, sideC: 5),

				// 3D Objects
					new Pyramid(sideA: 5,heightV: 10,numberofsidesN: 4),
					new Ball(radius: 5),
					new Block(sideA: 2,sideB: 4,sideC: 8),
					new Cylinder(heightV: 3, Radius: 12)
			};


			foreach (GrObject member in field)
			{
				

				if (member is Object2D d0)
				{
					d0.Write();

				}

				if (member is Object3D d1)
				{
					d1.Write();
				
				}

			}

			Console.ReadLine();

		}
	}

}
