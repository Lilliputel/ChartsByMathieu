using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace ChartByMathieu {

	public class Bar : Control {

		#region initializer

		static Bar() {
			DefaultStyleKeyProperty.OverrideMetadata(typeof(Bar), new FrameworkPropertyMetadata(typeof(Bar)));
		}

		#endregion

		#region dependencyProperties

		public static readonly DependencyProperty StartValueProperty =
			DependencyProperty.Register("StartValue", typeof(double), typeof(Bar), new PropertyMetadata(0));

		public static readonly DependencyProperty EndValueProperty =
			DependencyProperty.Register("EndValue", typeof(double), typeof(Bar), new PropertyMetadata(0));

		public static readonly DependencyProperty AngleProperty =
			DependencyProperty.Register("Angle", typeof(double), typeof(Bar), new PropertyMetadata(0));

		public static readonly DependencyProperty BarColorProperty =
			DependencyProperty.Register("BarColor", typeof(SolidColorBrush), typeof(Bar), new PropertyMetadata(0));

		public static readonly DependencyProperty CornerRadiusProperty =
			DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(Bar), new PropertyMetadata(0));

		#endregion

		#region properties

		public double StartValue {
			get { return (double)GetValue(StartValueProperty); }
			set { SetValue(StartValueProperty, value); }
		}

		public double EndValue {
			get { return (double)GetValue(EndValueProperty); }
			set { SetValue(EndValueProperty, value); }
		}

		public double Angle {
			get { return (double)GetValue(AngleProperty); }
			set { SetValue(AngleProperty, value); }
		}

		public SolidColorBrush BarColor {
			get { return (SolidColorBrush)GetValue(BarColorProperty); }
			set { SetValue(BarColorProperty, value); }
		}

		public CornerRadius CornerRadius {
			get { return (CornerRadius)GetValue(CornerRadiusProperty); }
			set { SetValue(CornerRadiusProperty, value); }
		}

		#endregion

		#region constructor

		public Bar() {

		}

		~Bar() {

		}

		#endregion

	}
}
