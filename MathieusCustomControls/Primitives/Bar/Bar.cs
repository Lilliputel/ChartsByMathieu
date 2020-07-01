using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace MathieusCustomControls {

	public class Bar : ContentControl {

		#region initializer

		static Bar() {
			DefaultStyleKeyProperty.OverrideMetadata(typeof(Bar), new FrameworkPropertyMetadata(typeof(Bar)));
		}

		#endregion

		#region dependencyProperties

		public static readonly DependencyProperty StartValueProperty =
			DependencyProperty.Register(nameof(StartValue), typeof(double), typeof(Bar), new PropertyMetadata(0.0));

		public static readonly DependencyProperty EndValueProperty =
			DependencyProperty.Register(nameof(EndValue), typeof(double), typeof(Bar), new PropertyMetadata(1.0));

		public static readonly DependencyProperty BarColorProperty =
			DependencyProperty.Register(nameof(BarColor), typeof(SolidColorBrush), typeof(Bar), new PropertyMetadata(new SolidColorBrush(Colors.White)));

		public static readonly DependencyProperty CornerRadiusProperty =
			DependencyProperty.Register(nameof(CornerRadius), typeof(CornerRadius), typeof(Bar), new PropertyMetadata(new CornerRadius(0)));

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
