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
		/// Gets the dist day.
		/// </summary>
		/// <returns>The dist day.</returns>
		/// <param name="day">Day.</param>
		public String getDistDay(String day){
			double med=0.0;
			foreach(Session k in lst){
				if (k.day.Equals(day)) {
					med= k.distance;
				}
			}
			return Convert.ToString(med);
		}
		/// <summary>
		/// Gets the dist tot.
		/// </summary>
		/// <returns>The dist tot.</returns>
		public String getDistTot(){
			return Convert.ToString (getDistTotIn ());
		}
		/// <summary>
		/// Gets the vel media.
		/// </summary>
		/// <returns>The vel med total on m/s.</returns>
		public String getVelMedTot(){
			String toret = Convert.ToString (getDistTotIn () / getDurTot ())+"m/s";
			return toret;
		}
		/// <summary>
		/// Gets the vel med day.
		/// </summary>
		/// <returns>The vel med day.</returns>
		/// <param name="day">Day.</param>
		public String getVelMedDay(String day){
			double med=0.0;
			foreach(Session k in lst){
				if (k.day.Equals(day)) {
					med= k.distance/k.duration;
				}
			}
			return Convert.ToString(med);
		}
		/// <summary>
		/// Gets the number stps tot.
		/// </summary>
		/// <returns>The number stps tot.</returns>
		public String getNumStpsTot(){
			double distStep=0.6;
			double med = 0;
			foreach(Session k in lst){
				med+= k.distance/distStep;
			}
			return Convert.ToString(med);
		}
		/// <summary>
		/// Gets the number stps day.
		/// </summary>
		/// <returns>The number stps day.</returns>
		/// <param name="day">Day.</param>
		public String getNumStpsDay(String day){
			double distStep=0.6;
			double med = 0;
			foreach(Session k in lst){
				if (k.day.Equals(day)) {
					med= k.distance/distStep;
				}
			}
			return Convert.ToString(med);
		}
		/// <summary>
		/// Calculate Total Num of Hours
		/// </summary>
		/// <returns>The total number of hour .</returns>
		public String getNumHourTot(){
			double med = 0;
			foreach(Session k in lst){
				med+= k.duration/3600;
			}
			return Convert.ToString(med);
		}
		/// <summary>
		/// Gets the number hour of this day.
		/// </summary>
		/// <returns>The number hour of this day.</returns>
		/// <param name="day">Day.</param>
		public String getNumHourDay(String day){
			double med = 0;
			foreach(Session k in lst){
				if (k.day.Equals(day)) {
					med= k.duration/3600;
				}
			}
			return Convert.ToString(med);
		}
		/// <summary>
		/// Gets the actual weight.
		/// </summary>
		/// <returns>The actual weight.</returns>
		public String getActWeight(){
			
			return Convert.ToString (((Session)lst[lst.Count-1]).weight);
		}
		/// <summary>
		/// Gets the weight day.
		/// </summary>
		/// <returns>The weight day.</returns>
		/// <param name="day">Day.</param>
		public String getWeightDay(String day){
			double med = 0;
			foreach(Session k in lst){
				if (k.day.Equals(day)) {
					med= k.weight;
				}
			}
			return Convert.ToString(med);
		}
		/// <summary>
		/// Calculate total duration
		/// </summary>
		/// <returns>Total duration.</returns>
		/// <param name="lt">List of Sessions</param>
		private int getDurTot(){
			int toret=0;
			foreach(Session k in lst){
				toret+= k.duration;
			}
			return toret;
		}
		/// <summary>
		/// Calculate total distance
		/// </summary>
		/// <returns>total distance.</returns>
		/// <param name="lt"> List of Sessions.</param>
		private int getDistTotIn(){
			int toret=0;
			foreach(Session k in lst){
				toret+= k.distance;
			}
			return toret;
		}

	}
}

