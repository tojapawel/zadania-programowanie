using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace przyklad {
    internal class Opel : Samochod {
        public Opel() { }

        public override bool Brudny { get; internal set; }

        internal override void RozbijamSie() {
            Console.WriteLine("AP jedzie na kebaba");
        }
    }
}
