using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ChartByMathieu {

	public class GanttChart : Chart {

		#region initializer
		
		static GanttChart() {
			DefaultStyleKeyProperty.OverrideMetadata(typeof(GanttChart), new FrameworkPropertyMetadata(typeof(GanttChart)));
		}

		#endregion

		#region dependencyProperties




		#endregion

		#region properties




		#endregion

		#region constructor

		public GanttChart() {

		}

		~GanttChart() {

		}

		#endregion

	}
}
