using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace TP
{    

    class Program
    {
        Airport our_airport = new Airport();
        static void Main(string[] args)
        {
                               
            Timer t = new Timer(ComputeBoundOp, 5, 0, 10000);
            Thread.Sleep(100000); 
            t.Dispose(); 

            Console.ReadKey();
        }

      
        public static void ComputeBoundOp(Object state)
        {
            Airport our_airport = new Airport();
            int number_pass_planes = 0;
            int number_tr_planes = 0;

            PassangerPlane[] mass_pas_planes = new PassangerPlane[10];
            TransportationPlane[] mass_tr_planes = new TransportationPlane[10];


            for (int i = 0; i < 10; i++)
            {
                Random rnd = new Random();
                Random rnd_name = new Random();
                int our_rnd_number = rnd.Next(1, 3);
                int our_rnd_name = rnd_name.Next(1, 100);
                Thread.Sleep(20);

                string sum_name = Convert.ToString("Plane/" + our_rnd_number + "/" + our_rnd_name);

                if (our_rnd_number == 1)
                {
                    mass_pas_planes[number_pass_planes] = new PassangerPlane();
                    mass_pas_planes[number_pass_planes].Name = sum_name;

                    Random random_passangers = new Random();
                    int rnd_passangers = random_passangers.Next(1, 2000);

                    mass_pas_planes[number_pass_planes].Reserved_seats = rnd_passangers;
                    our_airport.AddPlane(mass_pas_planes[number_pass_planes]);
                    number_pass_planes++;
                }

                else
                {
                    mass_tr_planes[number_tr_planes] = new TransportationPlane();
                    mass_tr_planes[number_tr_planes].Name = sum_name;

                    Random random_stuff = new Random();
                    int rnd_stuff = random_stuff.Next(1, 50);

                    mass_tr_planes[number_tr_planes].Staff = rnd_stuff;
                    our_airport.AddPlane(mass_tr_planes[number_tr_planes]);
                    number_tr_planes++;
                }
            }

            our_airport.ShowPlanes();
            Console.WriteLine();
            Console.WriteLine("Общее число пассажиров : "+ our_airport.CountPassangers());

            Thread.Sleep(9000); 
                                
            Console.Clear();
        }

       
    }
}
