using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;

namespace DemoApplication {

	public partial class MainWindow : Window {

		public List<TestClass> TestListe { get; set; }
		public TestClass TestKlasse { get; set; }

		public MainWindow() {
			InitializeComponent();
			GenerateObjects();

			this.TestCard.DataContext = TestKlasse;
			this.CardView.DataContext = TestListe;
		}

		private void GenerateObjects() {

			TestKlasse = new TestClass() {
				Titel = "Gelb_2-4",
				Start = 2.0,
				Ende = 4.0,
				Farbe = Colors.Yellow
			};


			TestListe = new List<TestClass>();
			TestListe.Add(new TestClass() {
				Titel = "Rot_2-4",
				Start = 2.0,
				Ende = 4.0,
				Farbe = Colors.Red
			});
			TestListe.Add(new TestClass() {
				Titel = "Grün_0-3.2",
				Start = 0.0,
				Ende = 3.2,
				Farbe = Colors.Green
			});
			TestListe.Add(new TestClass() {
				Titel = "Blau_4-6.5",
				Start = 4.0,
				Ende = 6.5,
				Farbe = Colors.Blue
			});
		}
	}
}
