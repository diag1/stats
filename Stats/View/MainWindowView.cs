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
			this.vBoxDia.Visible = false;
			this.vBoxMain.Visible = false;
			porMain ();
		}
		private void build(){
			this.buildMain ();
			this.buildDia();

			var a =  new Gtk.VBox (false, 5);

			this.vBoxMain.Visible = true;
			this.vBoxDia.Visible = false;
			a.PackStart (vBoxMain);
			a.PackStart (vBoxDia);

			this.Add (a);
			a.ShowAll ();
			//events
			this.DeleteEvent += (o, args) =>this.OnClose() ;

		}
		/// <summary>
		/// Build this instance.
		/// </summary>
		private void buildMain(){
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

			//events
			this.DeleteEvent += (o, args) =>this.OnClose() ;
		}
		/// <summary>
		/// Builds the dia.
		/// </summary>
		private void buildDia(){
			SetDefaultSize(250, 200);
			vBoxDia = new Gtk.VBox (false, 5);
			//widgets"01/08/2008"
			this.en1 = new Gtk.Entry("\"dd/MM/yyyy\"");
			this.en1.Alignment = 1;
			this.lb1 = new Gtk.Label("DIA CONCRETO");
			this.lb2 = new Gtk.Label("Peso: "+fa.getWeightDay(dia));
			this.lb3 = new Gtk.Label("Distancia: "+fa.getDistDay(dia));
			this.lb4 = new Gtk.Label("Pasos: "+fa.getNumStpsDay(dia));
			this.lb5 = new Gtk.Label("Horas: "+fa.getNumHourDay(dia));
			this.lb6 = new Gtk.Label("Velocidad Media: "+fa.getVelMedDay(dia));
			this.btVol = new Gtk.Button("Aceptar");
			//vBox
			vBoxMain.PackStart(this.lb1,true,false,5);
			vBoxMain.PackStart(this.lb2,true,false,5);
			vBoxMain.PackStart(this.lb3,true,false,5);
			vBoxMain.PackStart(this.lb4,true,false,5);
			vBoxMain.PackStart(this.lb5,true,false,5);
			vBoxMain.PackStart(this.lb6,true,false,5);
			vBoxMain.PackStart(this.en1,true,false,5);
			vBoxMain.PackStart(this.btVol,true,false,5);

			//events
			this.DeleteEvent += (o, args) =>this.OnClose() ;
			this.btVol.Clicked += (o, args) => this.introduce ();
		}
		/// <summary>
		/// Pors the dia.
		/// </summary>
		private void porDia(){
			vBoxMain.Visible = false;
			vBoxDia.Visible = true;
		}
		/// <summary>
		/// Pors the main.
		/// </summary>
		private void porMain(){
			vBoxMain.Visible = true;
			vBoxDia.Visible = false;
		}
		private Gtk.Button btVol;
		private Gtk.Entry en1;
		private Gtk.Label lb1;
		private Gtk.Label lb2;
		private Gtk.Label lb3;
		private Gtk.Label lb4;
		private Gtk.Label lb5;
		private Gtk.Label lb6;
		private Gtk.VBox vBoxMain;
		private Gtk.VBox vBoxDia;
		private Fachada fa;
		private DateTime dia;
	}
}

