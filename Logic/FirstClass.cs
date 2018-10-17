using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class FirstClass
    {
        public string _type { get; set; }
        public int _cableCores { get; set; } //кол-во жил кабеля
        public int _diameter { get; set; }
        public double _q { get; set; }

        public FirstClass(string type, int cableCores, int diameter)
        {
            _type = type;
            _cableCores = cableCores;
            _diameter = diameter;
        }

        public virtual void Quality()
        {
            _q = _cableCores / _diameter;
        }

        public string ShowInf()
        {
            StringBuilder builder = new StringBuilder();
            string delimeter = " ";
            builder.Append(_type);
            builder.Append(delimeter);
            builder.Append(_cableCores);
            builder.Append(delimeter);
            builder.Append(_diameter);
            builder.Append(delimeter);
            builder.Append(_q);
            return builder.ToString();
        }
    }
}