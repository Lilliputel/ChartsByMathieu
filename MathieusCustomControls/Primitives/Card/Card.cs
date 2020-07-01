using System.Windows;
using System.Windows.Controls;

namespace MathieusCustomControls {

	public class Card : Control {

		#region initializer

		static Card() {
			DefaultStyleKeyProperty.OverrideMetadata(typeof(Card), new FrameworkPropertyMetadata(typeof(Card)));
		}

		#endregion

		#region dependencyProperties

		public object Front {
			get { return (object)GetValue(FrontProperty); }
			set { SetValue(FrontProperty, value); }
		}
		public static readonly DependencyProperty FrontProperty =
			DependencyProperty.Register(nameof(Front), typeof(object), typeof(Card), new PropertyMetadata(null));

		public DataTemplate FrontTemplate {
			get { return (DataTemplate)GetValue(FrontTemplateProperty); }
			set { SetValue(FrontTemplateProperty, value); }
		}
		public static readonly DependencyProperty FrontTemplateProperty =
			DependencyProperty.Register(nameof(FrontTemplate), typeof(DataTemplate), typeof(Card), new PropertyMetadata(null));

		public object Back {
			get { return (object)GetValue(BackProperty); }
			set { SetValue(BackProperty, value); }
		}
		public static readonly DependencyProperty BackProperty =
			DependencyProperty.Register(nameof(Back), typeof(object), typeof(Card), new PropertyMetadata(null));

		public DataTemplate BackTemplate {
			get { return (DataTemplate)GetValue(BackTemplateProperty); }
			set { SetValue(BackTemplateProperty, value); }
		}
		public static readonly DependencyProperty BackTemplateProperty =
			DependencyProperty.Register(nameof(BackTemplate), typeof(DataTemplate), typeof(Card), new PropertyMetadata(null));



		public bool IsDetailed {
			get { return (bool)GetValue(IsDetailedProperty); }
			set { SetValue(IsDetailedProperty, value); }
		}
		public static readonly DependencyProperty IsDetailedProperty =
			DependencyProperty.Register(nameof(IsDetailed), typeof(bool), typeof(Card), new PropertyMetadata(false));



		public CornerRadius CornerRadius {
			get { return (CornerRadius)GetValue(CornerRadiusProperty); }
			set { SetValue(CornerRadiusProperty, value); }
		}
		public static readonly DependencyProperty CornerRadiusProperty =
			DependencyProperty.Register(nameof(CornerRadius), typeof(CornerRadius), typeof(Card), new PropertyMetadata( new CornerRadius(5) ));

		public new Thickness Padding {
			get { return (Thickness)GetValue(PaddingProperty); }
			set { SetValue(PaddingProperty, value); }
		}
		public static readonly new DependencyProperty PaddingProperty =
			DependencyProperty.Register("Padding", typeof(Thickness), typeof(Card), new PropertyMetadata( new Thickness(5) ));



		#endregion

		#region constructor

		#endregion

	}
}
