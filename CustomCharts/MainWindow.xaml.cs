using System.Windows;

namespace CustomCharts {

	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();
		}

		private void Button_Click( object sender, RoutedEventArgs e ) {
			this.Hello.isDetailed = !this.Hello.isDetailed;
		}
	}
}
