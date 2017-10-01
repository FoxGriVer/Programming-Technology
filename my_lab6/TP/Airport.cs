using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TP
{
    public class Airport
    {
        private int number_of_planes = 0;
        private int number_of_pas_planes = 0;
        private int reserved_pasangers;

        protected List<AbstractCivilPlane> list_of_planes = new List<AbstractCivilPlane>();              

        public int Number_of_planes
        {
            get
            {
                return number_of_planes;

            }

            set
            {
                number_of_planes = value;
            }
        }

        public int Number_of_pas_planes
        {
            get { return number_of_pas_planes; }
            set { number_of_pas_planes = value; }
        }

        public int Reserved_pasangers
        {
            get
            {
                return reserved_pasangers;
            }

            set
            {
                reserved_pasangers = value;
            }
        }

        public void Show_number_of_planes()
        {
            Console.WriteLine();
            Console.WriteLine(Number_of_planes);
        }

        public int CountPassangers()
        {
            reserved_pasangers = 0;
            for (int i = 0; i < list_of_planes.Count; i++)
            {
                if (list_of_planes[i].Sphere_of_application == "Passenger")
                {
                    Reserved_pasangers += list_of_planes[i].ShowPassangers();
                }

                if (list_of_planes[i].Sphere_of_application == "Transport")
                {
                    Reserved_pasangers += list_of_planes[i].ShowPassangers();
                }
            }
            return Reserved_pasangers;
        }

        public void AddPlane(AbstractCivilPlane _ourplane)
        {
            list_of_planes.Add(_ourplane);
            number_of_planes += 1;
        }

        public void ShowPlanes()
        {
           for ( int i = 0; i < list_of_planes.Count; i++)
            {
                Console.WriteLine("Самолёт с названием : " + list_of_planes[i].Name + " везет на борту " + list_of_planes[i].ShowPassangers() + " пассажиров" );                                                  
            }
        }       
    }
}