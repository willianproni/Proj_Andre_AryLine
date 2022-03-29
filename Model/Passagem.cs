using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    internal class Passagem
    {
        public  Passageiro passageiro { get; set; }
        public  Voo voo { get; set; }

        public Passagem()
        {
        }

        public Passagem(Passageiro passageiro, Voo voo)
        {
            this.passageiro = passageiro;
            this.voo = voo;
        }


    }
}
