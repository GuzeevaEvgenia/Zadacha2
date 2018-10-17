using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class SecondClass : FirstClass
    {
        public bool _p { get; set; }
        public int _t { get; set; }

        public SecondClass(string type, int cableCorse, int diameter, bool p) : base(type, cableCorse, diameter)
        {
            _p = p;
        }

        public override void Quality()
        {
            base.Quality();
            if (_p == false) //наличие оплётки
                base._q = 2 * _q;
            else
                base._q = 0.7 * _q;
        }
    }
}