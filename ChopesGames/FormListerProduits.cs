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
    public partial class FormListerProduits : Form
    {
        private MySqlConnection sqlcon;
        public FormListerProduits()
        {
            InitializeComponent();
            sqlcon = new MySqlConnection("SERVER=127.0.0.1; DATABASE=chopesgames; UID=root; PASSWORD=; Convert Zero Datetime = true;");
        }
        void ChargerListeProduits(string requete)
        {
            // initialisation de la listViev lignes de commande lvProduits
            lvProduits.View = View.Details; // Mode d'affichage
            lvProduits.GridLines = true; // on affichera la grille
            lvProduits.FullRowSelect = true; // Mode de sélection : ligne
                                             // Pour le mode de selection voir aussi la property SelectionMode
            lvProduits.Columns.Add("Date", 80);
            lvProduits.Columns.Add("Libelle", 150);
            lvProduits.Columns.Add("Prix HT", 80);
            lvProduits.Columns.Add("Taux TVA", 80);
            lvProduits.Columns.Add("Quantitée", 70);
            lvProduits.Columns.Add("Disponible", 70);
            lvProduits.Columns.Add("Vitrine", 50);
            try
            {
                MySqlDataReader jeuEnr = null;
                MySqlCommand sqlcomProduits;
                sqlcon.Open();
                MessageBox.Show(requete);
                sqlcomProduits = new MySqlCommand(requete, sqlcon);                
                jeuEnr = sqlcomProduits.ExecuteReader();
                var TabItem = new string[7];
                while (jeuEnr.Read())
                {

                    TabItem[0] = jeuEnr.GetDateTime("DATEAJOUT").ToString();
                    TabItem[1] = jeuEnr.GetString("LIBELLE");
                    TabItem[2] = jeuEnr.GetDouble("PRIXHT").ToString();
                    TabItem[3] = jeuEnr.GetDouble("TAUXTVA").ToString();
                    TabItem[4] = jeuEnr.GetInt32("QUANTITEENSTOCK").ToString();
                    TabItem[5] = jeuEnr.GetInt32("DISPONIBLE").ToString();
                    TabItem[6] = jeuEnr.GetInt32("Vitrine").ToString();
                    lvProduits.Items.Add(new ListViewItem(TabItem));
                }
            }
            catch (MySqlException erreur)
            {
                MessageBox.Show("Erreur chargement des produits : " + erreur.ToString());
            }
            finally
            {
                if (sqlcon is object & sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close(); // on se déconnecte
                }
            }

        }
        // Au chargement, declaration de la requete puis envoie dans charger produit
        private void FormListerProduits_Load(object sender, EventArgs e)
        {
            try
            {
                string requête;
                int noCategorie;
                string libelle;
                MySqlDataReader jeuEnr = null;
                sqlcon.Open(); // on se connecte
                requête = "Select * from Categorie";
                var maCde = new MySqlCommand(requête, sqlcon);
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
                if (sqlcon is object & sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close(); // on se déconnecte
                }
            }

            // Chargement des marques dans cmbMarque
            try
            {
                string requête;
                int noMarque;
                string nom;
                MySqlDataReader jeuEnr = null;
                sqlcon.Open(); // on se connecte
                requête = "Select * from Marque";
                var maCde = new MySqlCommand(requête, sqlcon);
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
                if (sqlcon is object & sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close(); // on se déconnecte
                }
            }
            // Chargement des produits
            string requete = "Select DATEAJOUT,LIBELLE,PRIXHT,TAUXTVA,QUANTITEENSTOCK,DISPONIBLE,VITRINE from Produit";
            ChargerListeProduits(requete);

        }
        // Si l'élément sélectionné de la cmbCategorie est changer, envoie d'une nouvelle requete
        private void cmbCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            int noCategorie = ((Categorie)(cmbCategorie.SelectedItem)).GetNoCategorie();
            int noMarque = ((Marque)(cmbMarque.SelectedItem)).GetNoMarque();
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
            string requete;
            // Cas ou noCategorie true et noMarque false
            if (cmbCategorie.Text != null & cmbMarque.Text == null)
            {
                requete = "Select DATEAJOUT,LIBELLE,PRIXHT,TAUXTVA,QUANTITEENSTOCK,DISPONIBLE,VITRINE from Produit WHERE NOCATEGORIE = " + noCategorie;
                ChargerListeProduits(requete);
            }
            // Cas ou noCategorie false et noMarque true
            else if (cmbCategorie.Text == null & cmbMarque.Text != null)
            {
                requete = "Select DATEAJOUT,LIBELLE,PRIXHT,TAUXTVA,QUANTITEENSTOCK,DISPONIBLE,VITRINE from Produit WHERE NOMARQUE = " + noMarque;
                ChargerListeProduits(requete);
            }
            // Cas ou noCategorie true et noMarque true
            else
            {
                requete = "Select DATEAJOUT,LIBELLE,PRIXHT,TAUXTVA,QUANTITEENSTOCK,DISPONIBLE,VITRINE from Produit WHERE NOCATEGORIE = " + noCategorie + "AND NOMARQUE = " + noMarque;
                ChargerListeProduits(requete);
            }
        }

        private void cmbMarque_SelectedIndexChanged(object sender, EventArgs e)
        {
            int noCategorie = ((Categorie)(cmbCategorie.SelectedItem)).GetNoCategorie();
            int noMarque = ((Marque)(cmbMarque.SelectedItem)).GetNoMarque();
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
            string requete;
            // Cas ou noCategorie true et noMarque false
            if (cmbCategorie.Text != null & cmbMarque.Text == null)
            {
                requete = "Select DATEAJOUT,LIBELLE,PRIXHT,TAUXTVA,QUANTITEENSTOCK,DISPONIBLE,VITRINE from Produit WHERE NOCATEGORIE = " + noCategorie;
                ChargerListeProduits(requete);
            }
            // Cas ou noCategorie false et noMarque true
            else if (cmbCategorie.Text == null & cmbMarque.Text != null)
            {
                requete = "Select DATEAJOUT,LIBELLE,PRIXHT,TAUXTVA,QUANTITEENSTOCK,DISPONIBLE,VITRINE from Produit WHERE NOMARQUE = " + noMarque;
                ChargerListeProduits(requete);
            }
            // Cas ou noCategorie true et noMarque true
            else
            {
                requete = "Select DATEAJOUT,LIBELLE,PRIXHT,TAUXTVA,QUANTITEENSTOCK,DISPONIBLE,VITRINE from Produit WHERE NOCATEGORIE = " + noCategorie + "AND NOMARQUE = " + noMarque;
                ChargerListeProduits(requete);
            }
        }
    }
}
