using System;
using System.Collections.Generic;

namespace Grad_opt
{
   

   public class Object
    {
      public  double x { get; set; }
        public double y { get; set; }
        public double r { get; set; }
        public double radian { get; set; }
    }


    public class Grad_opt
    {
        public void Iterator(Object[] _objects, double[] gradient , double h)
        { double eps = 0.01;
            while (h > eps)
            {
                for (int i = 0; i <_objects.Length; i++)
                {
                    _objects[i].x+=gradient[0]*h;
                    _objects[i].y += gradient[1] * h;
                    _objects[i].radian += gradient[2] * h;
                    _objects[i].r += gradient[3] * h;
                    h /= 2;
                }
            }
        }
    }
}
