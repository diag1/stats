using System;
using Gtk;
namespace Stats
{
	public partial class MainWindow
	{
		/// <summary>
		/// Raises the close event.
		/// </summary>
		private void OnClose(){
			Gtk.Application.Quit ();
		}
		/// <summary>
		/// Gets the peso.
		/// </summary>
		/// <returns>The peso.</returns>
		private String getPeso(){
			return fa.getActWeight ();
		}
	}
}

