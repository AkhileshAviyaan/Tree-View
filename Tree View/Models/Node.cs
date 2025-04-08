using System.Collections.ObjectModel;

namespace AvaloniaControls.Models
{
	public class Node
	{
		public ObservableCollection<Node>? SubNodes { get; set; }
		public string Title { get; set; }

		public Node(string title)
		{
			Title = title;
		}

		public Node(string title, ObservableCollection<Node> subNodes)
		{
			Title = title;
			SubNodes = subNodes;
		}
	}
	public class SubNode:Node
	{
		public bool IsChecked { get; set; }
		public SubNode(string title):base(title)
		{
			Title = title;
		}

		public SubNode(string title, ObservableCollection<Node> subNodes):base(title,subNodes)
		{
			Title = title;
			SubNodes = subNodes;
		}
	}
}