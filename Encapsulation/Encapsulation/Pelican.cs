using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Pelican : Bird
    {
        private bool likesFish;

        public bool LikesFish
        {
            get { return likesFish; }
            set { likesFish = value; }
        }
        public Pelican () { }
        public Bird(string nam, int wei, int age, int win) :
            base(nam, wei, age)
        { Wingspan = win; }

        public override string Stats()
        {
            return base.Stats() + "\nLike fish = " + LikesFish;
        }
    }
}
