using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPOO_OO
{
    enum Type_MotoMarine
    {
        Jetski,
        SeaDoo
    }
    class Motomarine : VehiculeMotorise
    {
        public Type_MotoMarine Type { get; set; }

        public Motomarine(string nomVehicule, string marque, double prix, Moteur moteur) : base(nomVehicule, marque, prix, moteur)
        {
            Type = Type_MotoMarine.SeaDoo;
        }

        public override string ToString()
        {
            return "----------------MOTOMARINE----------------\n"+base.ToString();
        }
    }
}
