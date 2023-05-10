using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPOO_OO
{
    public static class Simulateur
    {
        private static Random random = new Random();
        private static Concessionnaire Concessionnaire;
        private static List<Client> Clients;
       
        public static void Simuler()
        {
            Concessionnaire = new Concessionnaire();
            Clients = new List<Client>();
            ChoisirVehicule();
            SimulerTransaction(Clients);
            AfficherFacture();
        }

        private static void AfficherFacture()
        {
            foreach(Facture facture in Concessionnaire.Factures)
            {
                Console.WriteLine(facture);
            }
        }

        private static void SimulerTransaction(List<Client> clients)
        {
            foreach(Client client in clients)
            {
                if (client.Montant < client.ChoixFinal.Prix)
                {
                    throw new Exception("Le client n'a pas assez d'argent pour acheter le véhicule");
                }
                else
                {
                    if (client.ChoixFinal == (VTT)client.ChoixFinal)
                    {
                        Concessionnaire.VendreVehiculeVTT((VTT)client.ChoixFinal);
                    }
                    else
                    {
                        Concessionnaire.VendreVehiculeMarin((Motomarine)client.ChoixFinal);
                    }
                    Concessionnaire.Factures.Add(new Facture(client.NomComplet, client.ChoixFinal)); 
                }
            }

            
        }

        private static List<Client> GenererListClient()
        {
            for (int i = 0; i < random.Next(2, 6); i++)
            {
                Clients.Add(new Client());
            }
            return Clients;
        }

        private static void ChoisirVehicule()
        {
            foreach (Client client in GenererListClient())
            {
                if(random.Next(0,1) == 0)
                {
                    client.ChoixVehicule[0] = Concessionnaire.VehiculesMarin[random.Next(0, Concessionnaire.VehiculesMarin.Count())];
                    client.ChoixVehicule[1] = Concessionnaire.VehiculesMarin[random.Next(0, Concessionnaire.VehiculesMarin.Count())];
                }
                else
                {
                    client.ChoixVehicule[0] = Concessionnaire.VTTs[random.Next(0, Concessionnaire.VTTs.Count() + 1)];
                    client.ChoixVehicule[1] = Concessionnaire.VTTs[random.Next(0, Concessionnaire.VTTs.Count() + 1)];
                }
                if (client.ChoixVehicule[0].Moteur.Force < client.ChoixVehicule[1].Moteur.Force)
                {
                    client.ChoixFinal = client.ChoixVehicule[1];
                }
                else
                {
                    client.ChoixFinal = client.ChoixVehicule[0];
                }
            }
        }
    }
}
