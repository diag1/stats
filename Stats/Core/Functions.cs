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
		public String getVelMedTot(){
			
		}

		String getVelMedDay(String day);
		String getNumStpsTot();
		String getNumStpsDay(String day);
		String getNumHourTot();
		String getNumHourDay(String day);
		private int getDurTot(List<Session> lt){
			int toret;
			foreach(Session k in lt){
				toret+= k.duration;
			}
			return toret;
		}
	}
}

