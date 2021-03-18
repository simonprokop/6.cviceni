using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
	abstract class Object3D : GrObject
	{
		public abstract double CalculateSurface();
		public abstract double CalculateVolume();
	}
}

