using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    class Model
    {
        public List<MovingCircle> circles = new List<MovingCircle>();

        public void Evolve(double deltaT) {
            foreach (var c in circles)
            {
                c.Move(deltaT);
            }
            foreach (var c in circles)
            {
                //if (c is Bot)
                {
                    // make decision
                }
            }
            // calculate collisions
            // calculate out of field

            circles.RemoveAll((MovingCircle c) => c.IsDead);
        }
    }
}
