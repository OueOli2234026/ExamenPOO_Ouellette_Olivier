using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPOO_OO
{
    class Client
    {
        public string NomComplet { get; set; }
        public double Montant { get; set; }
        public VehiculeMotorise[] ChoixVehicule { get; set; }
        public VehiculeMotorise ChoixFinal { get; set; }

        public Client(VehiculeMotorise[] choixVehicule)
        {
            ChoixFinal = new VehiculeMotorise();
            choixVehicule = new VehiculeMotorise[2] {new VehiculeMotorise(), new VehiculeMotorise()};
            NomComplet = ClientFactory.GenererNom();
            Montant = ClientFactory.GenererArgent();
            ChoixVehicule = choixVehicule;
        }

        public Client(VehiculeMotorise choixFinal)
        {
            ChoixFinal = choixFinal;
        }

        public Client()
        {

        }

        public override string ToString()
        {
            return $"NOM: {NomComplet} | MONTANT: {Montant} | CHOIX {ChoixFinal}";
        }
    }
}
