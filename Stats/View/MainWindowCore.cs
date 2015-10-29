using System;
using Gtk;
namespace Stats
{
	public partial class MainWindow
	{
		private void OnClose(){
			Gtk.Application.Quit ();
		}
		private String getPeso(){
			return fa.getActWeight ();
		}

	}
}

