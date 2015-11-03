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
		/// Introduce this instance.
		/// </summary>
		private void introduce (){
			String op1 = this.en1.Text ;
			this.setDia(Convert.ToDateTime (op1));
			build();
		}
		/// <summary>
		/// Sets the dia.
		/// </summary>
		/// <param name="en">En.</param>
		private void setDia(DateTime en){
			dia = en;
		}
	}
}

