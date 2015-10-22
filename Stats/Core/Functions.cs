using System;
using System.IO;
using System.Collections.Generic;

namespace Stats
{
	public class Functions:Fachada
	{
		private List<Session> lst;
		private Reader red;
		private String rout;
		public Functions (String route){
			rout = route;
			red = new Reader (rout);
			lst = red.getFile ();
		}
		/// <summary>
		/// Gets the vel media.
		/// </summary>
		/// <returns>The vel med total on m/s.</returns>
		public String getVelMedTot(){
			String toret = Convert.ToString (getDistTot () / getDurTot ())+"m/s";
		}

		String getVelMedDay(String day);
		String getNumStpsTot();
		String getNumStpsDay(String day);
		String getNumHourTot();
		String getNumHourDay(String day);
		/// <summary>
		/// Calculate total duration
		/// </summary>
		/// <returns>Total duration.</returns>
		/// <param name="lt">List of Sessions</param>
		private int getDurTot(List<Session> lt){
			int toret;
			foreach(Session k in lt){
				toret+= k.duration;
			}
			return toret;
		}
		/// <summary>
		/// Calculate total distance
		/// </summary>
		/// <returns>total distance.</returns>
		/// <param name="lt"> List of Sessions.</param>
		private int getDistTot(List<Session> lt){
			int toret;
			foreach(Session k in lt){
				toret+= k.distance;
			}
			return toret;
		}
		private int getDay(){
			
		}

	}
}

