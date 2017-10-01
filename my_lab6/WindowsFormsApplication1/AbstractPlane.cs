using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
        public abstract class AbstractPlane
    {
        private string name;
        private int speed;
        private int number_of_plane;
        private int weight;

        public abstract void GoUp();
        public abstract void GoDown();


        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int Number_of_pilots
        {
            get
            {
                return number_of_plane;
            }

            set
            {
                number_of_plane = value;
            }
        }

        public int Speed
        {
            get
            {
                return speed;
            }

            set
            {
                speed = value;
            }
        }

        public int Weight
        {
            get
            {
                return weight;
            }

            set
            {
                weight = value;
            }
        }

        public AbstractPlane(string _name = "our_base", int _speed = 300, int _number_of_plane = 0, int _weight = 2000)
        {
            Name = _name;
            Speed = _speed;
            Number_of_pilots = _number_of_plane;
            Weight = _weight;
        }
        
    }
}
