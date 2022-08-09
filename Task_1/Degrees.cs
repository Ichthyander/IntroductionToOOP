using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Degrees
    {
        int gradus;
        int min;
        int sec;

        public int Gradus
        {
            get
            {
                return gradus;
            }
            set
            {
                gradus = value % 360;
            }
        }
        public int Min
        {
            get
            {
                return min;
            }
            set
            {
                Gradus += value / 60;
                min = value % 60;
            }
        }
        public int Sec
        {
            get
            {
                return sec;
            }
            set
            {
                Min += value / 60;
                sec = value % 60;
            }
        }

        public Degrees(int gradus, int min, int sec)
        {
            Gradus = gradus;
            Min = min;
            Sec = sec;
        }

        public double ToRadians()
        {
            double decimalDegrees = (double)Gradus + (double)Min / 60 + (double)Sec / (60 * 60);
            return decimalDegrees * Math.PI / 180;
        }
    }
}
