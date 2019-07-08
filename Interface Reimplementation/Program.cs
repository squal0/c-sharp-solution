using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Reimplementation
{
    interface IMath
    {
        void Area();
    }

    class Program : IMath
    {
        public const float PI = 3.142F;
        protected float radius;
        protected double areaOfCircle;

        public virtual void Area()
        {
            areaOfCircle = (PI * radius * radius);
        }

        class Sphere : Program
        {
            double areaOfSphere;
            public override void Area()
            {
                base.Area();
                areaOfSphere = (areaOfCircle * 4);

            }
            static void Main(string[] args)
            {
                Sphere objSphere = new Sphere();
                objSphere.radius = 14;
                objSphere.Area();
                Console.WriteLine("The area of the Sphere:" + objSphere.areaOfSphere);
                Console.ReadLine();
            }
        }
    }
}
