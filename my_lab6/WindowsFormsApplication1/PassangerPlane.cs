using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class PassangerPlane : AbstractCivilPlane
    {
        private int capacity;
        private int reserved_seats;

        public int Capacity
        {
            get
            {   return capacity;    }

            set
            {   capacity = value;   }
        }

        public int Reserved_seats
        {
            get
            {
                return reserved_seats;
            }

            set
            {
                reserved_seats = value;
            }
        }

        public override void GoUp()
        {
            throw new NotImplementedException();
        }

        public override void GoDown()
        {
            throw new NotImplementedException();
        }

        public override void Load()
        {
            throw new NotImplementedException();
        }

        public override void Unload()
        {
            throw new NotImplementedException();
        }

        public PassangerPlane (string _name = "our_base", int _speed = 300, int _number_of_plane = 0, int _weight = 2000,
            string _sphere = "Passenger", int _capacity = 200, int _reserved_seats = 0): base(_name, _speed, _number_of_plane, _weight,_sphere)
        {
            Capacity = _capacity;
            Reserved_seats = _reserved_seats;
        }

        public override int ShowPassangers()
        {
            return this.Reserved_seats;
        }

        public override void OurChanges(string _name, int _number, int _capacity)
        {
            this.Name = _name;
            this.Number_of_pilots = _number;
            this.Reserved_seats = _capacity;
        }
    }
}