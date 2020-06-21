using MathieusCharts;
using System.Windows;
using System.Windows.Controls;

namespace DemoApplication {
	public class SelectorTest : StyleSelector {
		public override Style SelectStyle( object item, DependencyObject container ){
			
			if( item is TestClass && container is Card ) {


				return new Style(){
					Setters = {
						new Setter(){
							Property = Card.FrontProperty,
							Value = null
						}
					}
				};

			}

			return null;
		}
	}
}
