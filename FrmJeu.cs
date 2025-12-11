using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tpSynthese
{
    public partial class FrmJeu : Form
    {
        private List<Joueur> listeJoueurs;

        public FrmJeu(List<Joueur> listeJoueur)
        {
            InitializeComponent();
        }

        private void FrmJeu_Load(object sender, EventArgs e)
        {

        }
    }
}
