using System;
using Gtk;
using System.Globalization;
using System.Text.RegularExpressions;
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
			if (isDate (op1)) {
				this.setDia (Convert.ToDateTime (op1));
				this.newDay ();
				this.porDia ();
			} else
				this.porMain ();

		}
		/// <summary>
		/// Sets the dia.
		/// </summary>
		/// <param name="en">En.</param>
		private void setDia(DateTime en){
			dia = en;
		}
		private bool isDate(string a) 
		{ //string estará en formato dd/mm/yyyy (dí­as < 32 y meses < 13)
			Regex Val = new Regex(@"(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)");
			return Val.IsMatch (a);
		}
	}
}

