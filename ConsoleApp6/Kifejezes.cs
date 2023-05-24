using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Kifejezes
    {
        int elsoOperandus;
        string karakter;
        int masodikOperandus;

        public Kifejezes(int elsoOperandus, string karakter, int masodikOperandus)
        {
            this.elsoOperandus = elsoOperandus;
            this.karakter = karakter;
            this.masodikOperandus = masodikOperandus;
        }

        public int ElsoOperandus { get => elsoOperandus; set => elsoOperandus = value; }
        public string Karakter { get => karakter; set => karakter = value; }
        public int MasodikOperandus { get => masodikOperandus; set => masodikOperandus = value; }
    }
}
