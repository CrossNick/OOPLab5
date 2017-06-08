using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab5
{
	class Vector : ICloneable, IEnumerable<double>
	{
		private double[] vector;
		private int _size;
		public Vector() { }
		public Vector(int size) { }
		public Vector(Vector v) { }
		public int this[int index] { set { } get { return 0; } }
		public static Vector operator *(Vector v1, Vector v2) { return new Vector(); }
		public static Vector operator *(Vector v, double n) { return new Vector(); }
		public static Vector operator *(double n, Vector v) { return new Vector(); }
		public static Vector operator+(Vector v) { return new Vector(); }
		public static Vector operator -(Vector v) { return new Vector(); }
		public void resize(int newsize) { }
		public object Clone(){ return new Vector(); }
		public IEnumerator<double> GetEnumerator(){	throw new NotImplementedException();}
		IEnumerator IEnumerable.GetEnumerator(){	throw new NotImplementedException();}
		public static explicit operator Matrix(Vector v) { }
	}
}
