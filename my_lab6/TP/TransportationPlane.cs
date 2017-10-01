using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP
{
    public class TransportationPlane : AbstractCivilPlane
    {
        private int carrying_capacity;
        private int staff;

        public int Staff
        {
            get
            {
                return staff;
            }

            set
            {
                staff = value;
            }
        }

        public int Carrying_capacity
        {
            get
            {
                return carrying_capacity;
            }

            set
            {
                carrying_capacity = value;
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

        public TransportationPlane(string _name = "our_base", int _speed = 300, int _number_of_pilots = 2, int _weight = 2000,
           string _sphere = "Transport", int _carrying_capacity = 10000, int _staff = 0): base(_name, _speed, _number_of_pilots, _weight,_sphere)
        {
            Carrying_capacity = _carrying_capacity;
            Staff = _staff;
        }
      
        public override int ShowPassangers()
        {
            return this.Staff;
        }
    }
}