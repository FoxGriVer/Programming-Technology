using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP
{
    public class PassangerPlane : AbstractCivilPlane
    {
        private int capacity;
        private int reserved_seats;

        public int Capacity
        {
            get
            {
                return capacity;
            }

            set
            {
                capacity = value;
            }
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

        public PassangerPlane (string _name = "our_base", int _speed = 300, int _number_of_pilots = 2, int _weight = 2000,
            string _sphere = "Passenger", int _capacity = 1000, int _reserved_seats = 0): base(_name, _speed, _number_of_pilots, _weight,_sphere)
        {
            Capacity = _capacity;
            Reserved_seats = _reserved_seats;
        }

        //public void ChangeDataPassPlane(int _reserved_seats = 0)
        //{
        //    Reserved_seats = _reserved_seats;
        //}

        public override int ShowPassangers()
        {
            return this.Reserved_seats;
        }
    }
}