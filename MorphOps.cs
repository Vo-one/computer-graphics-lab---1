﻿namespace Lab1_kg_
{
	internal class MorphOps : MatrixFilter
	{
		public static float[,] mask = null;
		public MorphOps()
		{
			setNewKernel(mask.GetLength(0), mask.GetLength(1));
		}
		protected void setNewKernel(int l, int h)
		{
			kernel = new float[l, h];
			for (int i = 0; i < l; ++i)
			{
				for (int j = 0; j < h; ++j)
				{
					kernel[i, j] = mask[i, j];
				}
			}
		}
		public static void setMask(int x, int y, int val)
		{
			mask[x, y] = val;
		}
	}
}
