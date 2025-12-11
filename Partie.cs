using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpSynthese
{
    internal class Partie
    {
        private int nbJoueurs;
        private string de;
        private List<Joueur> listeJoueurs;
        private static int compteurTour =0;
        private int tourActuel;


        public int NbJoueurs { get { return nbJoueurs; } set { nbJoueurs = value; } }
        public string De { get { return de; } set { de = value; } }
        public List<Joueur> ListeJoueurs { get { return listeJoueurs; } set { listeJoueurs = value; } }
        public int TourActuel { get { return tourActuel; }}

        public Partie()
        {
            nbJoueurs = 0;
            de = "";
            listeJoueurs = new List<Joueur>();
            tourActuel = ++compteurTour;
        }

        public Partie(int nbJoueurs, string de, List<Joueur> listeJoueurs)
        {
            this.nbJoueurs = nbJoueurs;
            this.de = de;
            this.listeJoueurs = listeJoueurs;
            tourActuel = ++compteurTour;
        }


        public override string ToString()
        {
            return "Partie " + tourActuel + " avec " + nbJoueurs + " joueurs.";
        }
    }
}
