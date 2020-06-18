using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace MathieusCustomControls {

	public class WatermarkedTextBox : TextBox {

		static WatermarkedTextBox() {
			DefaultStyleKeyProperty.OverrideMetadata(typeof(WatermarkedTextBox), new FrameworkPropertyMetadata(typeof(WatermarkedTextBox)));
		}

		#region dependency properties

		public string WatermarkText {
			get { return (string)GetValue(WatermarkTextProperty); }
			set { SetValue(WatermarkTextProperty, value); }
		}
		public static readonly DependencyProperty WatermarkTextProperty =
			DependencyProperty.Register("WatermarkText", typeof(string), typeof(WatermarkedTextBox), new PropertyMetadata("Hier schreiben: ..."));

		public SolidColorBrush WatermarkColor {
			get { return (SolidColorBrush)GetValue(WatermarkColorProperty); }
			set { SetValue(WatermarkColorProperty, value); }
		}
		public static readonly DependencyProperty WatermarkColorProperty =
			DependencyProperty.Register("WatermarkColor", typeof(SolidColorBrush), typeof(WatermarkedTextBox), new PropertyMetadata(new SolidColorBrush(Colors.Gainsboro)));

		#endregion

	}

}
