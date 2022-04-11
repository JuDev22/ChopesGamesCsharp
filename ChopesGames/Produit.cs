using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChopesGames
{
    class Produit
    {
        // NOPRODUIT, LIBELLE, PRIXHT, TAUXTVA
        private int noProduit, noCategorie, noMarque, quantiteEnStock;
        private string libelle, detail, nomImage/*, dateAjout*/;
        private double prixHT, tauxTVA;
        bool vitrine, disponibilite;
        DateTime dateAjout;
        public Produit(int noProduit, int noCategorie, int noMarque, int quantiteEnStock, bool disponibilite, bool vitrine, string libelle, string detail, string nomImage, double prixHT, double tauxTVA/*, DateTime dateAjout*/)
        {
            this.noProduit = noProduit;
            this.noCategorie = noCategorie;
            this.noMarque = noMarque;
            this.quantiteEnStock = quantiteEnStock;
            this.disponibilite = disponibilite;
            this.vitrine = vitrine;
            this.detail = detail;
            this.nomImage = nomImage;
            this.prixHT = prixHT;
            this.tauxTVA = tauxTVA;
            this.libelle = libelle;
            /*this.dateAjout = dateAjout;*/
            /*this.dateAjout = dateAjout.Date;*/
        }
        public int GetNoProduit()
        {
            return noProduit;
        }
        public int GetNoMarque()
        {
            return noMarque;
        }
        public int GetNoCategorie()
        {
            return noCategorie;
        }
        public string GetLibelle()
        {
            return libelle;
        }
        public int GetQuantite()
        {
            return quantiteEnStock;
        }
        public string GetNomImage()
        {
            return nomImage;
        }
        public bool GetVitrine()
        {
            return vitrine;
        }
        public bool GetDispo()
        {
            return disponibilite;
        }
        public string GetDetail()
        {
            return detail;
        }
        public double GetPrixHT()
        {
            return prixHT;
        }
        public double GetTauxTVA()
        {
            return tauxTVA;
        }
/*        public DateTime GetDateAJout()
        {
            return dateAjout.Date;
        }*/
        public override string ToString()
        {
            return noProduit.ToString() + " - " + libelle + " - " + prixHT.ToString();
        }
    }
}
