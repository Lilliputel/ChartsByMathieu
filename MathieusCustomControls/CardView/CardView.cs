using System.Windows;
using System.Windows.Controls;

namespace MathieusCustomControls {

	public class CardView : ItemsControl {

		#region initializer

		static CardView() {
			DefaultStyleKeyProperty.OverrideMetadata(typeof(CardView), new FrameworkPropertyMetadata(typeof(CardView)));
		}
		#endregion

		#region dependencyProperties

		#region Title

		public string Title {
			get { return (string)GetValue(TitleProperty); }
			set { SetValue(TitleProperty, value); }
		}
		public static readonly DependencyProperty TitleProperty =
				DependencyProperty.Register("Title", typeof(string), typeof(CardView), new PropertyMetadata("New CardView!"));

		public DataTemplate TitleTemplate {
			get { return (DataTemplate)GetValue(TitleTemplateProperty); }
			set { SetValue(TitleTemplateProperty, value); }
		}
		public static readonly DependencyProperty TitleTemplateProperty =
				DependencyProperty.Register("TitleTemplate", typeof(DataTemplate), typeof(CardView), new PropertyMetadata(null));

		#endregion

		#region Sides

		public object Front {
			get { return (object)GetValue(FrontProperty); }
			set { SetValue(FrontProperty, value); }
		}
		public static readonly DependencyProperty FrontProperty =
				DependencyProperty.Register("Front", typeof(object), typeof(CardView), new PropertyMetadata(null));

		public DataTemplate FrontTemplate {
			get { return (DataTemplate)GetValue(FrontTemplateProperty); }
			set { SetValue(FrontTemplateProperty, value); }
		}
		public static readonly DependencyProperty FrontTemplateProperty =
				DependencyProperty.Register("FrontTemplate", typeof(DataTemplate), typeof(CardView), new PropertyMetadata(null));



		public object Back {
			get { return (object)GetValue(BackProperty); }
			set { SetValue(BackProperty, value); }
		}
		public static readonly DependencyProperty BackProperty =
				DependencyProperty.Register("Back", typeof(object), typeof(CardView), new PropertyMetadata(null));

		public DataTemplate BackTemplate {
			get { return (DataTemplate)GetValue(BackTemplateProperty); }
			set { SetValue(BackTemplateProperty, value); }
		}
		public static readonly DependencyProperty BackTemplateProperty =
				DependencyProperty.Register("BackTemplate", typeof(DataTemplate), typeof(CardView), new PropertyMetadata(null));

		#endregion

		#region common

		public CornerRadius CornerRadius {
			get { return (CornerRadius)GetValue(CornerRadiusProperty); }
			set { SetValue(CornerRadiusProperty, value); }
		}
		public static readonly DependencyProperty CornerRadiusProperty =
			DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(CardView), new PropertyMetadata(new CornerRadius(5)));

		#endregion

		#endregion

	}
}
