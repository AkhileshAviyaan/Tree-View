using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

public static class BitmapHelper
{
	public static Avalonia.Media.Imaging.Bitmap GetPointTypeBitmap()
	{
		using var gdiBitmap = new System.Drawing.Bitmap(16, 16);
		using (Graphics g = Graphics.FromImage(gdiBitmap))
		{
			g.SmoothingMode = SmoothingMode.AntiAlias;
			using SolidBrush brush = new SolidBrush(System.Drawing.Color.Red);
			g.FillEllipse(brush, 2, 2, 12, 12);
		}

		using var ms = new MemoryStream();
		gdiBitmap.Save(ms, ImageFormat.Png); 
		ms.Seek(0, SeekOrigin.Begin);      

		return new Avalonia.Media.Imaging.Bitmap(ms);
	}
}
