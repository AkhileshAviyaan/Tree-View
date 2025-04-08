using Avalonia.Controls;
using Tree_View.ViewModels;

namespace Tree_View.Views
{
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			DataContext = new MainWindowViewModel();
		}
	}
}