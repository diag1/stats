using System;

namespace Stats
{
	public interface Fachada
	{
		String getVelMedTot();
		String getVelMedDay(String day);
		String getNumStpsTot();
		String getNumStpsDay(String day);
		String getNumHourTot();
		String getNumHourDay(String day);
	}
}

