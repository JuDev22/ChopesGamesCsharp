﻿using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ChopesGames
{
    public partial class FormCreerProduit : Form
    {
        private MySqlConnection maCnx; 
        private Regex regexPrixHTTauxTVA = new Regex(@"^-?(?:\d+|\d{1,3}(?:,\d{3})+)(?:(\.|,)\d+)?$");
        private bool prixHTEstValide, tauxTVAEstValide; // controle

        public FormCreerProduit()
        {
            InitializeComponent();
            maCnx = new MySqlConnection("SERVER=127.0.0.1; DATABASE=chopesgames; UID=root; PASSWORD=");
        }

        private void FormCreerProduit_Load(object sender, EventArgs e)
        {
            // Chargement des catégories dans cmbCategorie
            try
            {
                string requête, produit;
                int noCategorie;
                string libelle, detail, prixHt, tauxTVA, nominage, quantiteEnStock, dateAjout, disponible, vitrine;
                MySqlDataReader jeuEnr = null;
                maCnx.Open(); // on se connecte
                requête = "Select * from Categorie inner join produit on (categorie.nocategorie=produit.nocategorie)";
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
        }

        private void btnCreer_Click(object sender, EventArgs e)
        {
            if (cmbCategorie.SelectedItem is object && cmbMarque.SelectedItem is object &&
                prixHTEstValide && tauxTVAEstValide)
            {
                try
                {
                    string requête;
                    maCnx.Open(); // on se connecte
                    requête = "Insert into produit(NOCATEGORIE,NOMARQUE,LIBELLE,DETAIL,PRIXHT,TAUXTVA,NOMIMAGE,QUANTITEENSTOCK,DATEAJOUT,DISPONIBLE,VITRINE)" +
                        "values (@noCategorie,@noMarque,@libelle,@detail,@prixHT,@tauxTVA,@nomimage,@quantiteenstock,@dateajout,@disponible,@vitrine)";
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
                    maCde.Parameters.AddWithValue("@dateajout", dateTimeAjout.Value);
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
                    MessageBox.Show(nbLigneAffectées.ToString()+" produit(s) créé(s).", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    // ci-après on remet les zones de saisie à vide (pas les combo.)
                    tbxDetail.Clear();
                    tbxLibelle.Clear();
                    tbxPrixHT.Clear();
                    tbxTauxTVA.Clear();
                    cmbCategorie.Focus(); // on remet le focus sur la combo catégorie
                    tbxPrixHT.Clear();
                    tbxNomimage.Clear();
                }
                catch (MySqlException erreur)
                {
                    MessageBox.Show("Erreur lors de l'ajout : "+ erreur.ToString(), "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Saisie incomplète ou incorrecte.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        } // méthode

        // --------------------
        /* Contrôles de saisie - Nota bene : pas de contrôle sur détail et libellé */
        // --------------------
        private void tbxPrixHT_Leave(object sender, EventArgs e)
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

        private void numericQuantite_ValueChanged(object sender, EventArgs e)
        {
            if (numericQuantite.Value == 0 && ckbDisponibiliteNon.Checked == true)
            {
                ckbDisponibiliteOui.Checked = false;
                ckbDisponibiliteNon.Checked = true;
            }
            else
            {
                ckbDisponibiliteOui.Checked = true;
                ckbDisponibiliteNon.Checked = false;
            }
        }

        private void ckbDisponibiliteOui_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbDisponibiliteOui.Checked == true)
            {
                ckbDisponibiliteOui.Checked = true;
                ckbDisponibiliteNon.Checked = false;
            }
            else
            {
                ckbDisponibiliteOui.Checked = false;
                ckbDisponibiliteNon.Checked = true;
            }
        }

        private void ckbDisponibiliteOui_Click(object sender, EventArgs e)
        {

        }


        /*        private void tbxLibelle_KeyPress(object sender, KeyPressEventArgs e)
                {

                    if (tbxNomimage. == Keys.Escape)
                    {
                        tbxNomimage.Text += '_';
                    }
                    else
                    {
                        tbxNomimage.Text = tbxLibelle.Text;
                    }
                }*/

        private void tbxTauxTVA_Leave(object sender, EventArgs e)
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
    }
}
