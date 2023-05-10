using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPOO_OO
{
    class VehiculeMotorise
    {
        public string NomVehicule { get; set; }
        public string Marque { get; set; }
        public double Prix { get; set; }
        public Moteur Moteur { get; set; }      
        public VehiculeMotorise(string nomVehicule, string marque, double prix, Moteur moteur)
        {
            NomVehicule = nomVehicule;
            Marque = marque;
            Prix = prix;
            Moteur = moteur;
        }

        public VehiculeMotorise()
        {

        }

        public override string ToString()
        {
            return $"NOM: {NomVehicule} |\nMARQUE: {Marque} |\nPRIX: {Prix} |\nMOTEUR: {Moteur} ";
        }
    }
}
