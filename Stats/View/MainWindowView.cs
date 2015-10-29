using System;
using Gtk;
namespace Stats
{
	public partial class MainWindow: Gtk.Window
	{
		public MainWindow ()
			:base(Gtk.WindowType.Toplevel)
		{
			fa=new Functions(".");
			this.build ();
			/*this.vBoxIntroducir.Visible = false;
			this.vBoxListar.Visible = false;
			fa = new AutobusesGTK.Core.Fachada ();*/
		}
		private void build(){
			SetDefaultSize(250, 200);
			vBoxMain = new Gtk.VBox (false, 5);
			//widgets
			this.lb1 = new Gtk.Label("ESTADISTICAS");
			this.lb2 = new Gtk.Label("Peso: "+getPeso());
			//vBox
			vBoxMain.PackStart(this.lb1,true,false,5);
			this.DeleteEvent += (o, args) =>this.OnClose() ;

			var a =  new Gtk.VBox (false, 5);
			this.vBoxMain.Visible = true;
			a.PackStart (vBoxMain);

			this.Add (a);
			a.ShowAll ();
			//events
			this.DeleteEvent += (o, args) =>this.OnClose() ;
		}

		private Gtk.Label lb1;
		private Gtk.Label lb2;
		private Gtk.Label lb3;
		private Gtk.Label lb4;
		private Gtk.VBox vBoxMain;
		private Fachada fa;
	}
}

