using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSB
{
    public partial class FrmMedicament : FrmBase
    {
        public FrmMedicament()
        {
            InitializeComponent();
        }

        #region procédures événementielles

        // Au chargement du formulaire
        private void FrmMedicaments_Load(object sender, EventArgs e)
        {
            parametrerComposant();
            afficher();
        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            afficher();
        }
        #endregion

        #region méthodes

        // Mise en forme des composants utilisés 
        private void parametrerComposant()
        {
            this.lblTitre.Text = "Consultation des medicaments";
            this.cbxMedicaments.DataSource = Globale.LesMedicaments;
            this.btnValider.Text = "";

            // Les labels
            this.lblMedicaments.Text = "Medicament";
            this.lblFamille.Text = "Famille";
            this.lblComposition.Text = "Composition";
            this.lblEffet.Text = "Effets";
            this.lblContreIndication.Text = "Contre Indication";


            // L'affichage
            this.lblAffichageFamille.Text = "";
            this.lblAffichageComposition.Text = "";
            this.lblAffichageEffet.Text = "";
            this.lblAffichageContreIndication.Text = "";

        }


        private void afficher()
        {
            Medicament unMedicament = (Medicament)cbxMedicaments.SelectedItem;
            this.lblAffichageFamille.Text = unMedicament.LaFamille.Libelle;
            this.lblAffichageComposition.Text = unMedicament.Composition;
            this.lblAffichageEffet.Text = unMedicament.Effets;
            this.lblAffichageContreIndication.Text = unMedicament.ContreIndication;
        }
        #endregion

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
