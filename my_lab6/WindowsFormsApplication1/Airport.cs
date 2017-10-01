using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Airport
    {
        private int number_of_planes = 0;

        protected List<AbstractCivilPlane> list_of_planes = new List<AbstractCivilPlane>();
        private List<PassangerPlane> list_passenger_plane = new List<PassangerPlane>();

        private int reserved_pasangers = 0;

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
        public void ChangePassengers(string _name, int _number, int _capacity, int _plane_number)
        {
            list_of_planes[_plane_number].OurChanges(_name, _number, _capacity);
            //for (int i = 0; i < list_of_planes.Count; i++)
            //{
            //    if (list_of_planes[i].Sphere_of_application == "Passenger")
            //    {
            //        list_of_planes[i].OurChanges(_name, _number, _capacity);
            //    }

            //    if (list_of_planes[i].Sphere_of_application == "Transport")
            //    {
            //        list_of_planes[i].OurChanges(_name, _number, _capacity);
            //    }

            //}
        }
        public int CountPassangers()
        {
            Reserved_pasangers = 0;
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

        public void AddPlaneFrom2(string _name, int a1, int a2)
        {
            TransportationPlane defoult = new TransportationPlane(_name, 1000, a1, 2, "Transport", 2000, a2);
            this.AddPlane(defoult);
        }

        public void AddStandartPlane()
        {
            TransportationPlane defoult = new TransportationPlane();
            this.AddPlane(defoult);

        }
        public void ShowPlanes()
        {
            foreach (AbstractCivilPlane w in list_of_planes)
            {

            }
        }

        public string ShowPlane(int number)
        {
                       
            return list_of_planes[number].Name;
        }

        public void ShowPlanesString()
        {
            for (int i = 0; i < list_of_planes.Count; i++)
            {
                Console.WriteLine( list_of_planes[i].Name );
            }            
        }

        public void DeletePlane(int _plane_number)
        {
            //for (int i = 0; i < list_of_planes.Count; i++)
            //{
            //    if(list_of_planes[i].Number_of_pilots == _plane_number)
            //    {
                    list_of_planes.Remove(list_of_planes[_plane_number]);
                    number_of_planes -= 1;
            //    }
            //}
        }        


    }
}
