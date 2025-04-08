using System.Collections.ObjectModel;
using System.Drawing;

namespace AvaloniaControls.Models
{
	public class Node
	{
		public ObservableCollection<Node>? Children { get; set; }
		public string Title { get; set; }

		public Node(string title)
		{
			Title = title;
		}

		public Node(string title, ObservableCollection<Node> subNodes)
		{
			Title = title;
			Children = subNodes;
		}
	}
	public class SubNode:Node
	{
		public bool IsChecked { get; set; }
		public Avalonia.Media.Imaging.Bitmap Icon { get; set; }
		public SubNode(string title):base(title)
		{
			Title = title;
			Icon = BitmapHelper.GetPointTypeBitmap();
		}

		public SubNode(string title, ObservableCollection<Node> subNodes):base(title,subNodes)
		{
			Title = title;
			Children = subNodes;
			Icon = BitmapHelper.GetPointTypeBitmap();
		}
	}
}