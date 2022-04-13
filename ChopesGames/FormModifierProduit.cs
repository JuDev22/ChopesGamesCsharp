using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
namespace ChopesGames
{
    public partial class FormModifierProduit : Form
    {
        private MySqlConnection maCnx;
        private Regex regexPrixHTTauxTVA = new Regex(@"^-?(?:\d+|\d{1,3}(?:,\d{3})+)(?:(\.|,)\d+)?$");
        private bool prixHTEstValide, tauxTVAEstValide; // controle
        public FormModifierProduit()
        {
            InitializeComponent();
            maCnx = new MySqlConnection("SERVER=127.0.0.1; DATABASE=chopesgames; UID=root; PASSWORD=; Convert Zero Datetime = true;");
        }

        private void FormModifierProduit_Load(object sender, EventArgs e)
        {
            try
            {
                lblPublie.Visible = false;
                lblDate.Visible = false;
                string requête;
                int noCategorie;
                string libelle;
                MySqlDataReader jeuEnr = null;
                maCnx.Open(); // on se connecte
                requête = "Select * from Categorie";
                var maCde = new MySqlCommand(requête, maCnx);
                jeuEnr = maCde.ExecuteReader();

                while (jeuEnr.Read())
                {
                    noCategorie = jeuEnr.GetInt32("NOCATEGORIE");
                    libelle = jeuEnr.GetString("LIBELLE");
                    cmbCategorie.Items.Add(new Categorie(noCategorie, libelle));
                }
            }
            catch (MySqlException erreur)
            {
                MessageBox.Show("Erreur chargement catégories : " + erreur.ToString());
            }
            finally
            {
                if (maCnx is object & maCnx.State == ConnectionState.Open)
                {
                    maCnx.Close(); // on se déconnecte
                }
            }

            // Chargement des marques dans cmbMarque
            try
            {
                string requête;
                int noMarque;
                string nom;
                MySqlDataReader jeuEnr = null;
                maCnx.Open(); // on se connecte
                requête = "Select * from Marque";
                var maCde = new MySqlCommand(requête, maCnx);
                jeuEnr = maCde.ExecuteReader();

                while (jeuEnr.Read())
                {
                    noMarque = jeuEnr.GetInt32("NOMARQUE");
                    nom = jeuEnr.GetString("NOM");
                    cmbMarque.Items.Add(new Marque(noMarque, nom)); 
                }
            }
            catch (MySqlException erreur)
            {
                MessageBox.Show("Erreur chargement marques : " + erreur.ToString());
            }
            finally
            {
                if (maCnx is object & maCnx.State == ConnectionState.Open)
                {
                    maCnx.Close(); // on se déconnecte
                }
            }
            try
            {
                string requête;
                int noProduit, noCategorie, noMarque, quantiteEnStock;
                bool vitrine, disponibilite;
                string libelle, detail, nomImage;
                double prixHT, tauxTVA;
                DateTime dateAjout;
                MySqlDataReader jeuEnr = null;
                maCnx.Open(); // on se connecte
                requête = "Select * from Produit";
                var maCde = new MySqlCommand(requête, maCnx);
                jeuEnr = maCde.ExecuteReader();

                while (jeuEnr.Read())
                {
                    noProduit = jeuEnr.GetInt32("NOPRODUIT");
                    noCategorie = jeuEnr.GetInt32("NOCATEGORIE");
                    noMarque = jeuEnr.GetInt32("NOMARQUE");
                    quantiteEnStock = jeuEnr.GetInt32("QUANTITEENSTOCK");
                    disponibilite = jeuEnr.GetBoolean("DISPONIBLE");
                    vitrine = jeuEnr.GetBoolean("VITRINE");
                    libelle = jeuEnr.GetString("LIBELLE");
                    detail = jeuEnr.GetString("DETAIL");
                    nomImage = jeuEnr.GetString("NOMIMAGE");
                    prixHT = jeuEnr.GetDouble("PRIXHT");
                    tauxTVA = jeuEnr.GetDouble("TAUXTVA");
                    dateAjout = jeuEnr.GetDateTime("DATEAJOUT").Date;
                    cmbProduit.Items.Add(new Produit(noProduit, noCategorie, noMarque, quantiteEnStock, disponibilite, vitrine, libelle, detail, nomImage, prixHT, tauxTVA, dateAjout));
                }
            }
            catch (MySqlException erreur)
            {
                MessageBox.Show("Erreur chargement produits : " + erreur.ToString());
            }
            finally
            {
                if (maCnx is object & maCnx.State == ConnectionState.Open)
                {
                    maCnx.Close(); // on se déconnecte
                }
            }

        }

        private void cmbProduit_SelectedIndexChanged(object sender, EventArgs e)
        {
            int noProduit = ((Produit)(cmbProduit.SelectedItem)).GetNoProduit();
            int noCategorie = ((Produit)(cmbProduit.SelectedItem)).GetNoCategorie();
            int noMarque = ((Produit)(cmbProduit.SelectedItem)).GetNoMarque();
            foreach (Categorie categorie in cmbCategorie.Items)
            {
                if (categorie.GetNoCategorie() == noCategorie)
                {
                    cmbCategorie.SelectedItem = categorie;
                }
            }
            foreach (Marque marque in cmbMarque.Items)
            {
                if (marque.GetNoMarque() == noMarque)
                {
                    cmbMarque.SelectedItem = marque;
                }
            }
            foreach (Produit produit in cmbProduit.Items)
            {
                if (produit.GetNoProduit() == noProduit)
                {
                    tbxLibelle.Text = ((Produit)(cmbProduit.SelectedItem)).GetLibelle();
                    tbxDetail.Text = ((Produit)(cmbProduit.SelectedItem)).GetDetail();
                    tbxPrixHT.Text = ((Produit)(cmbProduit.SelectedItem)).GetPrixHT().ToString();
                    tbxTauxTVA.Text = ((Produit)(cmbProduit.SelectedItem)).GetTauxTVA().ToString();
                    tbxNomimage.Text = ((Produit)(cmbProduit.SelectedItem)).GetNomImage();
                    numericQuantite.Value = ((Produit)(cmbProduit.SelectedItem)).GetQuantite();
                    lblPublie.Visible = true;
                    lblDate.Visible = true;
                    lblDate.Text = ((Produit)(cmbProduit.SelectedItem)).GetDateAJout().ToString();
                    if (((Produit)(cmbProduit.SelectedItem)).GetDispo())
                    {
                        ckbDisponibiliteNon.Checked = false;
                        ckbDisponibiliteOui.Checked = true;
                    } else
                    {
                        ckbDisponibiliteNon.Checked = true;
                        ckbDisponibiliteOui.Checked = false;
                    }
                    if (((Produit)(cmbProduit.SelectedItem)).GetVitrine())
                    {
                        ckbVitrineNon.Checked = false;
                        ckbVitrineOui.Checked = true;
                    }
                    else
                    {
                        ckbVitrineOui.Checked = false;
                        ckbVitrineNon.Checked = true;
                    }
                }
            }
        }

        private void ckbDisponibiliteNon_Click(object sender, EventArgs e)
        {
            ckbDisponibiliteOui.Checked = false;
            ckbDisponibiliteNon.Checked = true;
        }

        private void ckbDisponibiliteOui_Click(object sender, EventArgs e)
        {
            if (numericQuantite.Value != 0)
            {
                ckbDisponibiliteOui.Checked = true;
                ckbDisponibiliteNon.Checked = false;
            }
            else
            {
                ckbDisponibiliteOui.Checked = false;
                MessageBox.Show("Vous ne pouvez pas activité la disponibilitée d'un produit sans en avoir en stock !");
            }

        }

        private void ckbVitrineNon_Click(object sender, EventArgs e)
        {
            ckbVitrineNon.Checked = true;
            ckbVitrineOui.Checked = false;
        }

        private void ckbVitrineOui_Click(object sender, EventArgs e)
        {
            ckbVitrineNon.Checked = false;
            ckbVitrineOui.Checked = true;
        }
        private void tbxPrixHT_TextChanged(object sender, EventArgs e)
        {
            if (regexPrixHTTauxTVA.Match(tbxPrixHT.Text).Success & tbxPrixHT.Text != "")
            {
                prixHTEstValide = true;
                tbxPrixHT.BackColor = SystemColors.Window;
            }
            else
            {
                tbxPrixHT.BackColor = Color.Red;
                prixHTEstValide = false;
            }
        }

        private void tbxTauxTVA_TextChanged(object sender, EventArgs e)
        {
            if (regexPrixHTTauxTVA.Match(tbxTauxTVA.Text).Success & tbxTauxTVA.Text != "")
            {
                tauxTVAEstValide = true;
                tbxTauxTVA.BackColor = SystemColors.Window;
            }
            else
            {
                tbxTauxTVA.BackColor = Color.Red;
                tauxTVAEstValide = false;
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (cmbCategorie.SelectedItem is object && cmbMarque.SelectedItem is object &&
    prixHTEstValide && tauxTVAEstValide)
            {
                try
                {
                    string requête;
                    int noProduit = ((Produit)(cmbProduit.SelectedItem)).GetNoProduit();
                    maCnx.Open(); // on se connecte
                requête = "UPDATE produit SET NOCATEGORIE = @noCategorie," +
                                             "NOMARQUE = @noMarque," +
                                             "LIBELLE = @libelle," +
                                             "DETAIL = @detail," +
                                             "PRIXHT = @prixHT," +
                                             "TAUXTVA = @tauxTVA," +
                                             "NOMIMAGE = @nomimage," +
                                             "QUANTITEENSTOCK = @quantiteenstock," +
                                             "DISPONIBLE = @disponible," +
                                             "VITRINE = @vitrine" +
                          " WHERE NOPRODUIT = " + noProduit + ";";
                    var maCde = new MySqlCommand(requête, maCnx);
                    maCde.Prepare();
                    int noCategorie = ((Categorie)(cmbCategorie.SelectedItem)).GetNoCategorie();
                    int noMarque = ((Marque)(cmbMarque.SelectedItem)).GetNoMarque();
                    maCde.Parameters.AddWithValue("@noCategorie", noCategorie);
                    maCde.Parameters.AddWithValue("@noMarque", noMarque);
                    maCde.Parameters.AddWithValue("@libelle", tbxLibelle.Text);
                    maCde.Parameters.AddWithValue("@detail", tbxDetail.Text);
                    maCde.Parameters.AddWithValue("@prixHT", tbxPrixHT.Text);
                    maCde.Parameters.AddWithValue("@tauxTVA", tbxTauxTVA.Text);
                    maCde.Parameters.AddWithValue("@nomimage", tbxNomimage.Text);
                    maCde.Parameters.AddWithValue("@quantiteenstock", numericQuantite.Value);
                    if (ckbDisponibiliteOui.Checked == true)
                    {
                        maCde.Parameters.AddWithValue("@disponible", 1);
                    }
                    else
                    {
                        maCde.Parameters.AddWithValue("@disponible", 0);
                    }
                    if (ckbVitrineOui.Checked == true)
                    {
                        maCde.Parameters.AddWithValue("@vitrine", 1);
                    }
                    else
                    {
                        maCde.Parameters.AddWithValue("@vitrine", 0);
                    }
                    int nbLigneAffectées = maCde.ExecuteNonQuery();
                    MessageBox.Show(nbLigneAffectées.ToString() + " produit modifié.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException erreur)
                {
                    MessageBox.Show("Erreur lors de l'ajout : " + erreur.ToString(), "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (maCnx is object & maCnx.State == ConnectionState.Open)
                    {
                        maCnx.Close(); // on se déconnecte
                    }
                } // try
            }
            else
            {
                MessageBox.Show("Saisie incomplète ou incorrecte.", "Erreur : ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}