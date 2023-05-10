using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPOO_OO
{
    class Concessionnaire
    {
        public string Nom { get; set; }
        public List<Motomarine> VehiculesMarin { get; set; }
        public List<VTT> VTTs { get; set; }
        public double MontantArgent { get; set; }
        public List<Facture> Factures { get; set; }
        public List<VehiculeMotorise> VehiculeMotorises { get; set; }

        public Concessionnaire()
        {
            VehiculesMarin = new List<Motomarine>();
            VTTs = new List<VTT>();
            Factures = new List<Facture>();
            VehiculeMotorises = new List<VehiculeMotorise>();
            RemplirInventaireMotomarine();
            RemplirInventaireVTT();
        }

        public void AcheterVehiculeMarin(Motomarine vehicule)
        {
            VehiculesMarin.Add(vehicule);
            MontantArgent -= vehicule.Prix;
            VehiculeMotorises.Add(vehicule);
        }
        public void VendreVehiculeMarin(Motomarine vehicule)
        {
            VehiculesMarin.Remove(vehicule);
            MontantArgent += vehicule.Prix;
            VehiculeMotorises.Remove(vehicule);
        }
        public void AcheterVehiculeVTT(VTT vehicule)
        {
            VTTs.Add(vehicule);
            MontantArgent -= vehicule.Prix;
            VehiculeMotorises.Add(vehicule);
        }
        public void VendreVehiculeVTT(VTT vehicule)
        {
            VTTs.Remove(vehicule);
            MontantArgent += vehicule.Prix;
            VehiculeMotorises.Remove(vehicule);

        }

        public void GetInfoVehicule()
        {
            foreach(VehiculeMotorise vehicule in VehiculeMotorises)
            {
                Console.WriteLine(vehicule);
            }
        }

        private void RemplirInventaireMotomarine()
        {
            VehiculesMarin.Add(new Motomarine("Bruh3145", "BRUH", 6000, new Moteur("BRUH ?!", 50, Type_Refroid.Air)));
            VehiculesMarin.Add(new Motomarine("Apollo11232", "NASA", 9000, new Moteur("MISO", 100, Type_Refroid.Liquide)));
            VehiculesMarin.Add(new Motomarine("Starcitizen2", "STARLINK", 15000, new Moteur("STARBRUH", 200, Type_Refroid.Air)));
            VehiculesMarin.Add(new Motomarine("Nimbus2000", "CANADIANTIRE", 30000, new Moteur("Tirecad", 300, Type_Refroid.Liquide)));
            VehiculesMarin.Add(new Motomarine("Robert2000", "ROBERTORESTO", 40000, new Moteur("Resto", 500, Type_Refroid.Liquide)));
            VehiculesMarin.Add(new Motomarine("YAMAXA", "YAMAMOTO", 7000, new Moteur("Yama", 75, Type_Refroid.Air)));
            foreach(Motomarine marine in VehiculesMarin)
            {
                VehiculeMotorises.Add(marine);
            }
        }

        private void RemplirInventaireVTT()
        { 
            VTTs.Add(new VTT("Spark nano", "SPARK", 10000, new Moteur("Etincelle", 120, Type_Refroid.Liquide)));
            VTTs.Add(new VTT("orange34", "APPLE", 12000, new Moteur("Bleuet", 150, Type_Refroid.Air)));
            VTTs.Add(new VTT("Pouchepouche en cacan", "ROMANOFAFAR", 15000, new Moteur("GougouneTriste", 250, Type_Refroid.Air)));
            VTTs.Add(new VTT("GOODBYE23", "HELLO", 20000, new Moteur("WHAT?!", 275, Type_Refroid.Liquide)));
            VTTs.Add(new VTT("MIT675", "MITSU", 30000, new Moteur("TSU", 300, Type_Refroid.Liquide)));
            VTTs.Add(new VTT("Ford f-150", "FORD", 7000, new Moteur("Black Sabat", 70, Type_Refroid.Air)));
            foreach (VTT vtt in VTTs)
            {
                VehiculeMotorises.Add(vtt);
            }
        }

        public override string ToString()
        {
            return $"";
        }
    }
}
