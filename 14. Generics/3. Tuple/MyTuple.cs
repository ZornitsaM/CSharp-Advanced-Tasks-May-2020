using System;
using System.Collections.Generic;
using System.Text;

namespace Tuple
{
    public class MyTuple<Titem1,Titem2>
    {
        public MyTuple(Titem1 item1, Titem2 item2)
        {
            this.Item1 = item1;
            this.Item2 = item2;
        }
        public Titem1 Item1 { get; set; }
        public Titem2 Item2 { get; set; }
        public override string ToString()
        {
            return $"{this.Item1} -> {this.Item2}";
        }
    }
}
