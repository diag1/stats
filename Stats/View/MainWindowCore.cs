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
		private void introduce (){
			String op1 = this.en1.Text ;
			String format = "dd MMM yyyy";
			this.setDia(Convert.ToDateTime (op1));
			this.porDia();
		}
		private void setDia(DateTime en){
			dia = en;
		}
		/// <summary>
		/// Gets the peso.
		/// </summary>
		/// <returns>The peso.</returns>
	}
}

