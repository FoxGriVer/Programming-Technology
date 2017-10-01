using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
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
        public abstract void OurChanges(string _name, int _number, int _capacity);

        public AbstractCivilPlane(string _name = "our_base", int _speed = 300, int _number_of_plane = 0, int _weight = 2000, string _sphere = "Transport") : base(_name, _speed, _number_of_plane, _weight)
        {
            Sphere_of_application = _sphere;
        }
    }
}
