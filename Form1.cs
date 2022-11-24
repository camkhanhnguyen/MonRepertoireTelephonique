/**
 * titre: Mon Répertoire Téléphonique
 * desription: créer une list contact
 * auteur: Khanh NGUYEN
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Globalization;

namespace MonRepertoireTelephonique
{
    public partial class frmMonReTe : Form
    {
        protected int resultat;

        // crée la list de contacts
        private List<Contacts> lesContacts = new List<Contacts>();
        private String nomFichier = "sauveApplicationSport";

        /// <summary>
        /// initialisation le programme
        /// </summary>
        private void DebutProgramme()
        {
            // instale le défaut sur le bouton radio particulier
            rdbFamille.Checked = true;

            // déactive le group box du contact
            gpbAjouterContact.Enabled = false;

            // invisible la lable photo
            lblPhoto.Visible = false;

            // affichage une photo blanc
            ptbPhoto.Image = Properties.Resources.vide;

            // reposition sur bouton NouveauContact
            btnNouveauContact.Enabled = true;
            btnNouveauContact.Focus();

        }

        /// <summary>
        /// mis à jour la list contact
        /// </summary>
        public void MisAJourContacts()
        {
            // vide la list des contacts
            lstContacts.Items.Clear();

            // remplir la list des contacts
            for (int k = 0; k < lesContacts.Count; k++)
            {
                lstContacts.Items.Add(lesContacts[k].info());
            }

            // récupération le fichier précédent
            Serialise.Sauve(nomFichier, lesContacts);
        }

        /// <summary>
        /// contrôle uniquement les lettres sont acceptés
        /// affichage un message d'erreur
        /// </summary>
        /// <param name="e"></param>
        private static void ControleSaisieLettre(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Entrez uniquement la lettre !!!", "Erreur de saisie");
            }
        }

        /// <summary>
        /// contrôle uniquement les lettres sont acceptés
        /// affichage un message d'erreur
        /// </summary>
        /// <param name="e"></param>
        private static void ControleSaisieChiffre(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Entrez uniquement le nombre entier !!!", "Erreur de saisie");
            }
        }

        /// <summary>
        /// vide la groupe contact
        /// </summary>
        private void ViderAjouterContact()
        {
            txtNom.Text = "";
            txtPrenom.Text = "";
            txtTel.Text = "";
            txtAdresse.Text = "";
            txtEmail.Text = "";
        }

        /// <summary>
        /// affichage une photo inconnu
        /// </summary>
        private void AffichagePhotoInconnu()
        {
            // visible la label photo
            lblPhoto.Visible = true;

            // affichage une photo
            ptbPhoto.Image = Properties.Resources.inconnu;
        }

        // boite de dialogue pour sélectionner un fichier
        OpenFileDialog rechercheFichier = new OpenFileDialog();

        /// <summary>
        /// contrôle la choix de fichier
        /// </summary>
        private void SelectionFichier()
        {
            // nom du boite de dialogue
            rechercheFichier.Title = "Choisir une photo";

            // ouvir le fichier dans la disque C
            rechercheFichier.InitialDirectory = "c:\\";

            /**
             *trie le type de fichier en jpg et en png 
             *donc il sera inutile d'utiliser try, catch pour contrôle la choix si il y a un erreur
             */
            rechercheFichier.Filter = "Image fichiers (*.jpg, *.png)|*.jpg;*.png";

            // memorise le path d'un fichier précédent
            rechercheFichier.RestoreDirectory = true;
        }

        /// <summary>
        /// change un contact
        /// supprime le contact est chosie
        /// </summary>
        public void ChangementContact()
        {
            lesContacts.RemoveAt(lstContacts.SelectedIndex);
            MisAJourContacts();
        }

        /// <summary>
        /// initialisation programme graphic
        /// </summary>
        public frmMonReTe()
        {
            InitializeComponent();
        }

        /// <summary>
        /// clic sur bouton radio amis
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdbAmis_CheckedChanged(object sender, EventArgs e)
        {
            lblAdresse.Visible = rdbAmis.Checked;
            txtAdresse.Visible = rdbAmis.Checked;
        }

        /// <summary>
        /// clic sur bouton radio professionnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdbProfessionnel_CheckedChanged_1(object sender, EventArgs e)
        {
            lblEmail.Visible = rdbProfessionnel.Checked;
            txtEmail.Visible = rdbProfessionnel.Checked;
        }

        /// <summary>
        /// clic sur bouton nouveau contact
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNouveauContact_Click(object sender, EventArgs e)
        {
            gpbAjouterContact.Enabled = true;
            AffichagePhotoInconnu();
        }

        /// <summary>
        /// clic sur bouton ajouter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            gpbAjouterContact.Enabled = true;

            // si clic sur bouton radio famille
            if (rdbFamille.Checked)
            {
                // si la zone du contact est vidée
                if (txtNom.Text == "" || txtPrenom.Text == "" || txtTel.Text == "")
                {
                    MessageBox.Show("Ce champ est obligatoire");
                }
                else
                {
                    
                    TextInfo prenom = CultureInfo.CurrentCulture.TextInfo;
                    lesContacts.Add(new Famille(txtNom.Text.ToUpper(), prenom.ToTitleCase(txtPrenom.Text), txtTel.Text.Aggregate("", (result, c) => result += ((!string.IsNullOrEmpty(result) && (result.Length + 1) % 3 == 0) ? " " : "") + c.ToString()), ptbPhoto.Image));
                }
            }
            // si clic sur bouton radio amis
            else if (rdbAmis.Checked)
            {
                // si la zone du contact est vidée
                if (txtNom.Text == "" || txtPrenom.Text == "" || txtTel.Text == "" || txtAdresse.Text == "")
                {
                    MessageBox.Show("Ce champ est obligatoire");
                }
                else
                {
                    TextInfo prenom = CultureInfo.CurrentCulture.TextInfo;
                    lesContacts.Add(new Amis(txtNom.Text.ToUpper(), prenom.ToTitleCase(txtPrenom.Text), txtTel.Text.Aggregate("", (result, c) => result += ((!string.IsNullOrEmpty(result) && (result.Length + 1) % 3 == 0) ? " " : "") + c.ToString()), txtAdresse.Text, ptbPhoto.Image));
                }
            }
            else
            {
                // si la zone du contact est vidée
                if (txtNom.Text == "" || txtPrenom.Text == "" || txtTel.Text == "" || txtEmail.Text == "")
                {
                    MessageBox.Show("Ce champ est obligatoire");
                }
                else
                {
                    TextInfo prenom = CultureInfo.CurrentCulture.TextInfo;
                    lesContacts.Add(new Professionnel(txtNom.Text.ToUpper(), prenom.ToTitleCase(txtPrenom.Text), txtTel.Text.Aggregate("", (result, c) => result += ((!string.IsNullOrEmpty(result) && (result.Length + 1) % 3 == 0) ? " " : "") + c.ToString()), txtEmail.Text, ptbPhoto.Image));
                }
            }

            // trie le nom et le prenom dans la list contact
            lesContacts.Sort();

            // mis à jour la list du contact
            MisAJourContacts();

            // vide et reposition sur la zone de contact
            ViderAjouterContact();

            // recommence un nouveau procéddure
            DebutProgramme();
        }

        /// <summary>
        /// clic sur bouton annuler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            // affichage un message pour confirmer le commande d'utilisateur
            if (MessageBox.Show("Voulez-vous annuler ce programme ?", "Pouvez-vous confirmer votre commande ?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ViderAjouterContact();
            }
        }

        /// <summary>
        /// clic sur bouton modifier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifier_Click(object sender, EventArgs e)
        {
            // si une ligne est chosie dans la liste contact
            if (lstContacts.SelectedIndex != -1)
            {
                // récuperation la photo
                btnNouveauContact.Enabled = false;
                lblPhoto.Visible = true;
                // MessageBox.Show("Une fois vous cliquez sur cette bouton, les information sont supprimés","ATTENTION !!!");

                //remplir le nom concerné 
                txtNom.Text = lesContacts[lstContacts.SelectedIndex].getNom();

                //remplir le prénom concerné 
                txtPrenom.Text = lesContacts[lstContacts.SelectedIndex].getPrenom();

                // remplir adresse concerné
                if (lesContacts[lstContacts.SelectedIndex] is Amis)
                {
                    txtAdresse.Text = ((Amis)lesContacts[lstContacts.SelectedIndex]).getAdresse();
                    rdbAmis.Checked = true;
                }
                // remplir email concerné
                else if (lesContacts[lstContacts.SelectedIndex] is Professionnel)
                {
                    txtEmail.Text = ((Professionnel)lesContacts[lstContacts.SelectedIndex]).getEmail();
                    rdbProfessionnel.Checked = true;
                }

                // repmir téléphone concerné
                txtTel.Text = lesContacts[lstContacts.SelectedIndex].getTel();

                // récuperation la photo
                ptbPhoto.Image = lesContacts[lstContacts.SelectedIndex].getPhoto();

                // trier le nom dans la list contact
                lesContacts.Sort();

                //supprimer la ligne est selectioné
                ChangementContact();

                // active la groupe ajoute contact
                gpbAjouterContact.Enabled = true;
            }
        }

        /// <summary>
        /// clic sur bouton supprimer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            // si une ligne est choisie dans la liste contact
            if (lstContacts.SelectedIndex != -1)
            {
                if (MessageBox.Show("Voulez-vous vraimment supprimer ?\nVous ne pouvez pas récupérer les information suprimés", "ATTENTION !!!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ChangementContact();
                    // supprimer la photo et la label photo
                    ptbPhoto.Image = null;
                    lblPhoto.Visible = false;
                }
            }
        }

        /// <summary>
        /// clic sur un contact dans la list
        /// affichage sa photo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstContacts_Click(object sender, EventArgs e)
        {

            if (lstContacts.SelectedIndex != -1)
            {
                ptbPhoto.Image = lesContacts[lstContacts.SelectedIndex].getPhoto();
                gpbAjouterContact.Enabled = false;
            }
        }

        /// <summary>
        /// chargement la fenêtre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMonReTe_Load(object sender, EventArgs e)
        {
            // commence le programme
            DebutProgramme();

            // récupération un fichier
            Object obj = Serialise.Recup(nomFichier);
            if (obj != null)
            {
                lesContacts = (List<Contacts>)obj;
                MisAJourContacts();
            }
        }

        /// <summary>
        /// choisi une photo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblPhoto_Click(object sender, EventArgs e)
        {
            // choisie un fichier
            SelectionFichier();

            // si un fichier est sélectioné
            if (rechercheFichier.ShowDialog() == DialogResult.OK)
            {
                // récuperer le fichier
                string nomFichier = rechercheFichier.FileName;

                // affichage une photo
                ptbPhoto.Image = Image.FromFile(nomFichier);

            }
            // si un fichier n'est pas sélectioné
            else
            {
                MessageBox.Show("Choisir une photo type de .jpg ou .png", "Erreur");
            }
        }

        /// <summary>
        /// contrôle la saisie du nom
        /// accepte uniquement les lettres
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControleSaisieLettre(e);
        }

        /// <summary>
        /// contrôle la saisie du prénom
        /// accepte uniquement les lettres
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPrenom_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControleSaisieLettre(e);
        }

        /// <summary>
        /// contrôle la saisie de la numéro téléphone
        /// accepte uniquement les chiffres
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControleSaisieChiffre(e);
        }

        private void lstContacts_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();

            // récupérer les contacts
            Contacts unContact = lesContacts[e.Index];

            // récupérer la couleur du bouton radio correspond
            Color couleur;
            if(unContact is Famille)
            {
                couleur =rdbFamille.ForeColor;
            }
            else if(unContact is Amis)
            {
                couleur = rdbAmis.ForeColor;
            }
            else
            {
                couleur = rdbProfessionnel.ForeColor;
            }

            //définier la couleur du pinceau
            Brush myBrush = new SolidBrush(couleur);

            e.Graphics.DrawString(lstContacts.Items[e.Index].ToString(), e.Font, myBrush, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }
    }
}
    


