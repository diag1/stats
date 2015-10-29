using System;

namespace Stats
{
	public interface Fachada
	{	
		String getDistTot();
		String getDistDay(String day);
		String getVelMedTot();
		String getVelMedDay(String day);
		String getNumStpsTot();
		String getNumStpsDay(String day);
		String getNumHourTot();
		String getNumHourDay(String day);
		String getActWeight();
		String getWeightDay(String day);
	}
}

