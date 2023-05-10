using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPOO_OO
{
    class VTT : VehiculeMotorise
    {
        public Roue Roue { get; set; }

        public VTT(Roue roue,string nomVehicule, string marque, double prix, Moteur moteur) : base(nomVehicule, marque, prix, moteur)
        {
            Roue = roue;
        }
        public VTT(string nomVehicule, string marque, int prix, Moteur moteur) : base(nomVehicule, marque, prix, moteur)
        {
            Roue = new Roue("Gagnon", 10);
        }

        public override string ToString()
        {
            return $"----------------VTT----------------\nROUE: {Roue} \n"+ base.ToString();
        }
    }
}
