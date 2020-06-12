using System.Windows;
using System.Windows.Controls;

namespace ChartByMathieu {

	public class Card : Control {

		#region initializer

		static Card() {
			DefaultStyleKeyProperty.OverrideMetadata(typeof(Card), new FrameworkPropertyMetadata(typeof(Card)));
		}

		#endregion

		#region dependencyProperties

		public FrameworkElement Content {
			get { return (FrameworkElement)GetValue(ContentProperty); }
			set { SetValue(ContentProperty, value); }
		}
		public static DependencyProperty ContentProperty =
			DependencyProperty.Register(nameof(Content), typeof(FrameworkElement), typeof(Card), new PropertyMetadata());

		public FrameworkElement Front {
			get { return (FrameworkElement)GetValue(FrontProperty); }
			set { SetValue(FrontProperty, value); }
		}
		public static DependencyProperty FrontProperty =
			DependencyProperty.Register(nameof(Front), typeof(FrameworkElement), typeof(Card), new PropertyMetadata());

		public FrameworkElement Back {
			get { return (FrameworkElement)GetValue(BackProperty); }
			set { SetValue(BackProperty, value); }
		}
		public static DependencyProperty BackProperty =
			DependencyProperty.Register(nameof(Back), typeof(FrameworkElement), typeof(Card), new PropertyMetadata());



		public bool isDetailed {
			get { return (bool)GetValue(isDetailedProperty); }
			set { SetValue(isDetailedProperty, value); }
		}
		public static readonly DependencyProperty isDetailedProperty =
			DependencyProperty.Register(nameof(isDetailed), typeof(bool), typeof(Card), new PropertyMetadata(false));



		public CornerRadius CornerRadius {
			get { return (CornerRadius)GetValue(CornerRadiusProperty); }
			set { SetValue(CornerRadiusProperty, value); }
		}
		public static readonly DependencyProperty CornerRadiusProperty =
			DependencyProperty.Register(nameof(CornerRadius), typeof(CornerRadius), typeof(Card));

		#endregion

		#region constructor

		#endregion

	}
}
