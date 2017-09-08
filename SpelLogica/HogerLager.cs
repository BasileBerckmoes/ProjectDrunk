using System;
using System.Collections.Generic;

namespace ProjectDrunk
{
	public class HogerLager
	{
        private List<String> spelers;
        int graad;
		private int getal;
		private int maximum;
		private int minimum;
		private int gokStreak;
        private String huidigeSpeler;
		
		public HogerLager(List<String> spelers, int graad)
		{
            this.spelers = spelers;
            this.graad = graad;
			gokStreak = 0;
            maximum = 10;
            minimum = 1;
            nieuweSpeler();
            NieuwGetal();

		}

        public void resetStreak(){
            gokStreak = 0;
        }

		public void NieuwGetal()
		{
			int oudGetal = getal;
			Random rnd = new Random();
			do
			{
				getal = rnd.Next(minimum, maximum);
			} while (oudGetal == getal);
		}

		public void nieuweSpeler()
		{
            huidigeSpeler = spelers[genereerGetal(0, spelers.Count)];
		}

		public int getGetal()
		{
			return getal;
		}
        public int getStreak(){
            return gokStreak;
        }

		public void SetMaximum(int maximum)
		{
			this.maximum = maximum;
		}

		public void Setminimum(int minimum)
		{
			this.minimum = minimum;
		}

		

		public int genereerGetal(int minimum, int maximum)
		{
			Random rnd = new Random();

			return rnd.Next(minimum, maximum);
		}

		public bool GokHoger()
		{
			int getal1 = getal;
            NieuwGetal();
			if (getal > getal1)
			{
				gokStreak++;
				return true;
			}
			else
			{   
                
				return false;
			}
		}

		public bool GokLager()
		{
			int getal1 = getal;
            NieuwGetal();
			if (getal < getal1){
				gokStreak++;
				return true;
			}
			else{
                
				return false;
			}
		}


        public String getSpeler(){
            return huidigeSpeler;
        }

        public int getSlokken(){
            int slokken = (getStreak() + 1);
            resetStreak();
            return slokken;
        }
	}
}
