using System;
using Gtk;
namespace Stats
{
	public partial class MainWindow
	{
		private void OnClose(){
			Gtk.Application.Quit ();
		}
		void OnExposed (object o, ExposeEventArgs args) {
			da.GdkWindow.DrawLine(da.Style.BaseGC(StateType.Normal), 0, 0, 400, 300);
		}
	}
}

