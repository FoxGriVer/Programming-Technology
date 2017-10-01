using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class AirportFactory
    {
        public static Airport CreateAirport()
        {
            PassangerPlane plane1 = new PassangerPlane();
            PassangerPlane plane2 = new PassangerPlane("Plane2", 1000, 1, 10000, "Passenger", 555, 55);
            PassangerPlane plane3 = new PassangerPlane("Plane3", 1000, 2, 10000, "Passenger", 100, 96);
            TransportationPlane plane4 = new TransportationPlane("Plane4", 1000, 3, 10000, "Transport", 2000, 15);


            Airport our_airport = new Airport();

            our_airport.AddPlane(plane1);
            our_airport.AddPlane(plane2);
            our_airport.AddPlane(plane3);
            our_airport.AddPlane(plane4);

            //our_airport.ShowPlanes();
            //Console.WriteLine(our_airport.CountPassangers());

            //our_airport.Show_number_of_planes();

            return our_airport;
        }
    }
}
