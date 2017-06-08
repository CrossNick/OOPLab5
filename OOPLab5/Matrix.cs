using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab5
{
	class Matrix : ICloneable, IEnumerable<double>
	{
		private Vector[] matrix;
		public Matrix(int size) { }
		public Matrix(Vector v) { }
		public Matrix(Vector[] v) { }
		public Matrix(double[,] m) { }
		public Matrix(Matrix m) { }
		public int this[int ind1,int ind2] { set { } get { return 0; } }
		public static Matrix operator *(Matrix v1, Matrix v2) { throw new Exception(); }
		public static Matrix operator *(Matrix v, double n) { throw new Exception(); }
		public static Matrix operator *(double n, Matrix v) { throw new Exception(); }
		public static Matrix operator +(Matrix v) { throw new Exception(); }
		public static Matrix operator -(Matrix v) { throw new Exception(); }
		public int RowsCount() { return 0; }
		public int ColumnsCount() { return 0; }
		public double FirstNorm() { return 0.0; }
		public double SecondNorm() { return 0.0; }
		public double Determinant() { return 0.0; }
		public void SwapColumns(int ind1, int ind2) { }
		public void SwapRows(int ind1, int ind2) { }
		public bool IsDegenerate() { return true; }
		public Matrix GetLowerMatrix() { throw new Exception(); }
		public Matrix GetLUpperMatrix() { throw new Exception(); }
		public Matrix Transpose() { throw new Exception(); }
		public static Matrix GetUnaryMatrix(int size) { throw new Exception(); }
		public Matrix Inverse() { throw new Exception(); }
		public object Clone(){throw new NotImplementedException();}
		public IEnumerator<double> GetEnumerator(){	throw new NotImplementedException();}
		IEnumerator IEnumerable.GetEnumerator(){	throw new NotImplementedException();}
	}
}
