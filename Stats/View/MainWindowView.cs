using System;
using Gtk;
namespace Stats
{
	public partial class MainWindow: Gtk.Window
	{
		public MainWindow ()
			:base(Gtk.WindowType.Toplevel)
		{
			fa=new Functions("./json");
			this.build ();
			/*this.vBoxIntroducir.Visible = false;
			this.vBoxListar.Visible = false;
			fa = new AutobusesGTK.Core.Fachada ();*/
		}
		/// <summary>
		/// Build this instance.
		/// </summary>
		private void build(){
			SetDefaultSize(250, 200);
			vBoxMain = new Gtk.VBox (false, 5);
			//widgets
			this.lb1 = new Gtk.Label("ESTADISTICAS");
			this.lb2 = new Gtk.Label("Peso: "+fa.getActWeight());
			this.lb3 = new Gtk.Label("Distancia: "+fa.getDistTot());
			this.lb4 = new Gtk.Label("Pasos: "+fa.getNumStpsTot());
			this.lb5 = new Gtk.Label("Horas: "+fa.getNumHourTot());
			this.lb6 = new Gtk.Label("Velocidad Media: "+fa.getVelMedTot());
			//vBox
			vBoxMain.PackStart(this.lb1,true,false,5);
			vBoxMain.PackStart(this.lb2,true,false,5);
			vBoxMain.PackStart(this.lb3,true,false,5);
			vBoxMain.PackStart(this.lb4,true,false,5);
			vBoxMain.PackStart(this.lb5,true,false,5);
			vBoxMain.PackStart(this.lb6,true,false,5);
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
		private Gtk.Label lb5;
		private Gtk.Label lb6;
		private Gtk.VBox vBoxMain;
		private Fachada fa;
	}
}

