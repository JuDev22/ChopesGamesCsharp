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
        //private Regex regexPrixHTTauxTVA = new Regex(@"^-?(?:\d+|\d{1,3}(?:,\d{3})+)(?:(\.|,)\d+)?$");
        //private bool prixHTEstValide, tauxTVAEstValide; // controle
        public FormModifierProduit()
        {
            InitializeComponent();
            maCnx = new MySqlConnection("SERVER=127.0.0.1; DATABASE=chopesgames; UID=root; PASSWORD=");
        }

        private void FormModifierProduit_Load(object sender, EventArgs e)
        {
            try
            {
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
                int noProduit;
                float prixHT, tauxTVA;
                string libelle;
                MySqlDataReader jeuEnr = null;
                maCnx.Open(); // on se connecte
                requête = "Select * from Produit";
                var maCde = new MySqlCommand(requête, maCnx);
                jeuEnr = maCde.ExecuteReader();

                while (jeuEnr.Read())
                {
                    noProduit = jeuEnr.GetInt32("NOPRODUIT");
                    libelle = jeuEnr.GetString("LIBELLE");
                    prixHT = jeuEnr.GetFloat("PRIXHT");
                    tauxTVA = jeuEnr.GetFloat("TAUXTVA");
                    cmbProduit.Items.Add(new Produit(noProduit, libelle, prixHT, tauxTVA));
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
         //   string produitToModify = e.GetNoProduit();
        }
    }
    }