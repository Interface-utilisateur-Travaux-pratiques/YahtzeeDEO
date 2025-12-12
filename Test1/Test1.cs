using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using tpSynthese; 

namespace TestTpSynthese
{
    [TestClass]
    public class TestPartie
    {
        private Partie partie;
        private List<Joueur> joueurs;

        [TestInitialize]
        public void Initialiser()
        {
            joueurs = new List<Joueur>();
            joueurs.Add(new Joueur("Alice", "avatar1"));
            joueurs.Add(new Joueur("Bob", "avatar2"));
            partie = new Partie(joueurs);
        }

        [TestMethod]
        public void TestCalculerYahtzee_Vrai()
        {
            int[] desYahtzee = { 5, 5, 5, 5, 5 };

            int points = partie.CalculerYahtzee(desYahtzee);

            Assert.AreEqual(50, points, "Un Yahtzee (5 dés identiques) devrait valoir 50 points.");
        }

        [TestMethod]
        public void TestCalculerYahtzee_Faux_DesDifferents()
        {
            int[] desNonYahtzee = { 1, 1, 1, 1, 2 };

            int points = partie.CalculerYahtzee(desNonYahtzee);

            Assert.AreEqual(0, points, "Des dés non identiques ne devraient pas rapporter de points Yahtzee.");
        }

        [TestMethod]
        public void TestCalculerYahtzee_Faux_DesAZero()
        {
            int[] desZero = { 0, 0, 0, 0, 0 };

            int points = partie.CalculerYahtzee(desZero);

            Assert.AreEqual(0, points, "Des dés à 0 (non lancés) ne devraient pas rapporter de points.");
        }

        [TestMethod]
        public void TestChangerTour_RotationJoueur()
        {
            Joueur joueurInitial = partie.JoueurCourant; 

            partie.ChangerTour();
            Joueur joueurSuivant = partie.JoueurCourant; 

            partie.ChangerTour();
            Joueur joueurRetour = partie.JoueurCourant; 

            Assert.AreEqual("Alice", joueurInitial.Nom);
            Assert.AreEqual("Bob", joueurSuivant.Nom);
            Assert.AreEqual("Alice", joueurRetour.Nom);
            Assert.AreNotSame(joueurInitial, joueurSuivant);
        }

        [TestMethod]
        public void TestChangerTour_ResetLancers()
        {
            partie.NbLancersRestants = 0;

            partie.ChangerTour();

            Assert.AreEqual(3, partie.NbLancersRestants, "Changer de tour devrait remettre le nombre de lancers à 3.");
        }

        [TestMethod]
        public void TestChangerTour_ResetDes()
        {
            partie.Des = new int[] { 1, 2, 3, 4, 5 };

            partie.ChangerTour();

            bool tousAZero = partie.Des.All(d => d == 0);
            Assert.IsTrue(tousAZero, "Changer de tour devrait remettre les valeurs des dés à 0.");
        }

        [TestMethod]
        public void TestProprietesJoueur()
        {
            Joueur j = new Joueur();
            j.Nom = "Test";
            j.ScorePartie = 100;

            Assert.AreEqual("Test", j.Nom);
            Assert.AreEqual(100, j.ScorePartie);
            Assert.AreEqual("Test", j.ToString(), "La méthode ToString doit retourner le nom du joueur.");
        }
    }
}