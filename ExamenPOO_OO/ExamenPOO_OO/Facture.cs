using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPOO_OO
{
    class Facture
    {
        public string NomClient { get; set; }
        public DateTime Date { get; set; }
        public VehiculeMotorise VehiculeAcheter { get; set; }

        public Facture(string nomClient, VehiculeMotorise vehicule)
        {
            vehicule = new VehiculeMotorise();
            VehiculeAcheter = vehicule;
            NomClient = nomClient;
            Date = DateTime.Now;
        }

        public override string ToString()
        {
            return $"*****************INFORMATION FACTURE*****************\n Date : {Date} \n Nom Client : {NomClient} \n Nom Véhicule : {VehiculeAcheter}";
        }
    }
}
