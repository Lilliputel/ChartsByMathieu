using System.Windows;

namespace DemoApplication {

	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();
		}

		private void Button_Click( object sender, RoutedEventArgs e ) {
			this.TestCard.IsDetailed = !this.TestCard.IsDetailed;
		}
	}
}
