using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace tpSynthese
{
    internal class Partie
    {
        private int nbJoueurs;
        private int[] des;
        private List<Joueur> listeJoueurs;
        private int indexJoueurCourant; 
        private int nbLancersRestants; 

        private static int compteurPartie = 1;
        private int idPartie;

        #region Properties
        public int NbJoueurs {get { return nbJoueurs; }set { nbJoueurs = value; }
        }

        public int[] Des { get { return des; } set { des = value; } }

        public List<Joueur> ListeJoueurs { get { return listeJoueurs; } set { listeJoueurs = value; } }

        public Joueur JoueurCourant { get { return listeJoueurs[indexJoueurCourant]; } }

        public int NbLancersRestants { get { return nbLancersRestants; } set { nbLancersRestants = value; } }
        #endregion

        public Partie()
        {
            InitialiserPartie(new List<Joueur>());
        }

        public Partie(List<Joueur> listeJoueurs)
        {
            InitialiserPartie(listeJoueurs);
        }

        private void InitialiserPartie(List<Joueur> liste)
        {
            this.listeJoueurs = liste;
            this.nbJoueurs = liste.Count;
            this.des = new int[5]; 
            this.indexJoueurCourant = 0; 
            this.nbLancersRestants = 3;
            this.idPartie = ++compteurPartie;
        }

        
        public void MettreAJourDes(int d1, int d2, int d3, int d4, int d5)
        {
            des[0] = d1;
            des[1] = d2;
            des[2] = d3;
            des[3] = d4;
            des[4] = d5;
        }

        
        public int CalculerScoreSuperieur(int ValeurOg)
        {
            int score = 0;
            foreach (int valeur in des)
            {
                if (valeur == ValeurOg)
                {
                    score += valeur;
                }
            }
            return score;
        }

       
        public int CalculerYahtzee()
        {
            int pointsYahtzee = 0;
            if (des.All(x => x == des[0]) && des[0] != 0)
            {
                pointsYahtzee = 50;
            }
            return pointsYahtzee;
        }

        
        public void ChangerTour()
        {
            indexJoueurCourant++;
            if (indexJoueurCourant >= listeJoueurs.Count)
            {
                indexJoueurCourant = 0;
            }
            nbLancersRestants = 3;
            Array.Clear(des, 0, des.Length);
        }

        public override string ToString()
        {
            return $"Partie #{idPartie} - Tour de {JoueurCourant.Nom}";
        }
    }
}