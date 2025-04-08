using AvaloniaControls.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing.Imaging;
using System.Security.Cryptography.X509Certificates;
namespace Tree_View.ViewModels
{
	public partial class MainWindowViewModel : ViewModelBase
	{
		public string Greeting => "Welcome to Avalonia!";
		public ObservableCollection<Node> WSPTest { get; }

		public MainWindowViewModel()
        {
			ObservableCollection<Node> SWWSPNodes = new ObservableCollection<Node>() { new SubNode("SubNode 1.1"), new SubNode("SubNode 1.2"), new SubNode("SubNode 1.3"), new SubNode("SubNode 1.4") };
			ObservableCollection<Node> SWDTMNodes = new ObservableCollection<Node>() { new SubNode("SubNode 2.1"), new SubNode("SubNode 2.2"), new SubNode("SubNode 2.3"), new SubNode("SubNode 2.4") };
			 WSPTest = new ObservableCollection<Node>() {new Node("Node1",SWWSPNodes),new Node("Node2",SWDTMNodes)};
		}
	}
}
