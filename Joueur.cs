using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpSynthese
{
    internal class Joueur
    {
        private string nom;
        private string avatar;
        private int scorePartie;
        private int totalPartiesJouees;
        private int scoreTotalParties;

        public string Nom { get { return nom; } set { nom = value; } }
        public string Avatar { get { return avatar; } set { avatar = value; } }
        public int ScorePartie { get { return scorePartie; } set { scorePartie = value; } }
        public int TotalPartiesJouees { get { return totalPartiesJouees; } set { totalPartiesJouees = value; } }
        public int ScoreTotalParties { get { return scoreTotalParties; } set { scoreTotalParties = value; } }

        public Joueur() { 
            nom = "";
            avatar = "";
            scorePartie = 0;
            totalPartiesJouees = 0;
            scoreTotalParties = 0;
        }

        public Joueur(string nom, string avatar) {
            this.nom = nom;
            this.avatar = avatar;
        }

        public override string ToString()
        {
            return nom;
        }
    }


}
