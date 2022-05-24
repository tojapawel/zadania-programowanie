using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace przyklad {
    internal class Golf : Samochod {
        public override bool Brudny { get; internal set; }

        internal override void RozbijamSie() {
            Console.WriteLine("Nie moge sie rozbic");
        }
        internal override void Przyspiesz() {
            for (int i = 0; i < 10; i++) {
                Console.WriteLine("Przyspieszam " + i * 10);
                Thread.Sleep(500);
            }
        }
    }
}