using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPOO_OO
{
    enum Type_Refroid
    {
        Air,
        Liquide
    }
    class Moteur
    {
        public string Marque { get; set; }
        public int Force { get; set; }
        public Type_Refroid Type { get; set; }

        public Moteur()
        {
            Marque = "Yamaha";
            Force = 50;
            Type = Type_Refroid.Air;    
        }

        public Moteur(string marque, int force, Type_Refroid type)
        {
            Marque = marque;
            Force = force;
            Type = type;
        }

        public static bool operator <(Moteur moteur1, Moteur moteur2)
        {
            return moteur2.Force > moteur1.Force;
        }
        public static bool operator >(Moteur moteur1, Moteur moteur2)
        {
            return moteur2.Force < moteur1.Force;
        }

        public override string ToString()
        {
            return $"MARQUE: {Marque} | FORCE: {Force} | TYPE: {Type} |";
        }
    }
}
