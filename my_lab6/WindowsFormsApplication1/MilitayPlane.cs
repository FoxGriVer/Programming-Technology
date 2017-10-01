using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class MilitaryPlane : AbstractPlane
    {
        private int type_of_aviation;
        private int type_of_ammunition;
        private int number_of_ammo;

        public void Shoot()
        {
            throw new System.NotImplementedException();
        }

        public override void GoUp()
        {
            throw new NotImplementedException();
        }

        public override void GoDown()
        {
            throw new NotImplementedException();
        }
    }
}
