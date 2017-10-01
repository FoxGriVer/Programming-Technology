using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP
{
    public abstract class AbstractCivilPlane : AbstractPlane
    {
        private string sphere_of_application;

        public string Sphere_of_application
        {
            get
            {
             return sphere_of_application;
            }

            set
            {
                sphere_of_application = value;
            }
        }

        public abstract void Load();
        public abstract void Unload();
        public abstract int ShowPassangers();

        public AbstractCivilPlane(string _name = "our_base", int _speed = 300, int _number_of_pilots = 0, int _weight = 2000, string _sphere = "Transport"): base(_name,_speed,_number_of_pilots, _weight)
        {
            Sphere_of_application = _sphere;
        }
    }
}