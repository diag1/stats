using System;
using Gtk;
namespace Stats
{
	public partial class MainWindow: Gtk.Window
	{
		public MainWindow ()
			:base(Gtk.WindowType.Toplevel)
		{
			this.build ();
			Application.Init ();
			ColourExample ();
			Application.Run ();
			/*this.vBoxIntroducir.Visible = false;
			this.vBoxListar.Visible = false;
			fa = new AutobusesGTK.Core.Fachada ();*/
		}
		private void build(){
			SetDefaultSize(250, 200);
			vBoxMain = new Gtk.VBox (false, 5);
			//widgets
			this.lb1 = new Gtk.Label("ESTADISTICAS");
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
		public void ColourExample(){
			win = new Window ("Colour Example");
			win.SetDefaultSize (400, 300);
			win.DeleteEvent += (o, args) =>OnClose();

			da = new DrawingArea();
			da.ExposeEvent += OnExposed;

			Gdk.Color col = new Gdk.Color();
			Gdk.Color.Parse("red", ref col);
			win.ModifyBg(StateType.Normal, col);
			da.ModifyBg(StateType.Normal, col);

			win.Add (da);
			win.ShowAll ();
		}
		private Gtk.Label lb1;
		private Gtk.VBox vBoxMain;
		private DrawingArea da;
		private Window win;
	}
}

