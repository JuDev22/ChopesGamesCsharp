
namespace ChopesGames
{
    partial class FormModifierProduit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numericQuantite = new System.Windows.Forms.NumericUpDown();
            this.ckbVitrineNon = new System.Windows.Forms.CheckBox();
            this.ckbVitrineOui = new System.Windows.Forms.CheckBox();
            this.dateTimeAjout = new System.Windows.Forms.DateTimePicker();
            this.lblDateAjout = new System.Windows.Forms.Label();
            this.lblVitrine = new System.Windows.Forms.Label();
            this.ckbDisponibiliteNon = new System.Windows.Forms.CheckBox();
            this.ckbDisponibiliteOui = new System.Windows.Forms.CheckBox();
            this.lblDisponibilite = new System.Windows.Forms.Label();
            this.lblQuantiteEnStock = new System.Windows.Forms.Label();
            this.tbxNomimage = new System.Windows.Forms.TextBox();
            this.lblNomimage = new System.Windows.Forms.Label();
            this.btnCreer = new System.Windows.Forms.Button();
            this.tbxTauxTVA = new System.Windows.Forms.TextBox();
            this.tbxPrixHT = new System.Windows.Forms.TextBox();
            this.tbxDetail = new System.Windows.Forms.TextBox();
            this.tbxLibelle = new System.Windows.Forms.TextBox();
            this.cmbMarque = new System.Windows.Forms.ComboBox();
            this.cmbCategorie = new System.Windows.Forms.ComboBox();
            this.lblTauxTVA = new System.Windows.Forms.Label();
            this.lblPrixHT = new System.Windows.Forms.Label();
            this.lblDetail = new System.Windows.Forms.Label();
            this.lblLibelle = new System.Windows.Forms.Label();
            this.lblMarque = new System.Windows.Forms.Label();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.lblChoisirProduit = new System.Windows.Forms.Label();
            this.cmbProduit = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantite)).BeginInit();
            this.SuspendLayout();
            // 
            // numericQuantite
            // 
            this.numericQuantite.Location = new System.Drawing.Point(158, 419);
            this.numericQuantite.Name = "numericQuantite";
            this.numericQuantite.Size = new System.Drawing.Size(47, 20);
            this.numericQuantite.TabIndex = 51;
            // 
            // ckbVitrineNon
            // 
            this.ckbVitrineNon.AutoSize = true;
            this.ckbVitrineNon.Checked = true;
            this.ckbVitrineNon.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbVitrineNon.Location = new System.Drawing.Point(206, 476);
            this.ckbVitrineNon.Name = "ckbVitrineNon";
            this.ckbVitrineNon.Size = new System.Drawing.Size(46, 17);
            this.ckbVitrineNon.TabIndex = 50;
            this.ckbVitrineNon.Text = "Non";
            this.ckbVitrineNon.UseVisualStyleBackColor = true;
            // 
            // ckbVitrineOui
            // 
            this.ckbVitrineOui.AutoSize = true;
            this.ckbVitrineOui.Location = new System.Drawing.Point(158, 474);
            this.ckbVitrineOui.Name = "ckbVitrineOui";
            this.ckbVitrineOui.Size = new System.Drawing.Size(42, 17);
            this.ckbVitrineOui.TabIndex = 49;
            this.ckbVitrineOui.Text = "Oui";
            this.ckbVitrineOui.UseVisualStyleBackColor = true;
            // 
            // dateTimeAjout
            // 
            this.dateTimeAjout.Location = new System.Drawing.Point(158, 390);
            this.dateTimeAjout.Name = "dateTimeAjout";
            this.dateTimeAjout.Size = new System.Drawing.Size(147, 20);
            this.dateTimeAjout.TabIndex = 48;
            // 
            // lblDateAjout
            // 
            this.lblDateAjout.AutoSize = true;
            this.lblDateAjout.Location = new System.Drawing.Point(28, 390);
            this.lblDateAjout.Name = "lblDateAjout";
            this.lblDateAjout.Size = new System.Drawing.Size(64, 13);
            this.lblDateAjout.TabIndex = 47;
            this.lblDateAjout.Text = "Date d\'ajout";
            // 
            // lblVitrine
            // 
            this.lblVitrine.AutoSize = true;
            this.lblVitrine.Location = new System.Drawing.Point(28, 480);
            this.lblVitrine.Name = "lblVitrine";
            this.lblVitrine.Size = new System.Drawing.Size(36, 13);
            this.lblVitrine.TabIndex = 46;
            this.lblVitrine.Text = "Vitrine";
            // 
            // ckbDisponibiliteNon
            // 
            this.ckbDisponibiliteNon.AutoSize = true;
            this.ckbDisponibiliteNon.Checked = true;
            this.ckbDisponibiliteNon.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbDisponibiliteNon.Location = new System.Drawing.Point(206, 451);
            this.ckbDisponibiliteNon.Name = "ckbDisponibiliteNon";
            this.ckbDisponibiliteNon.Size = new System.Drawing.Size(46, 17);
            this.ckbDisponibiliteNon.TabIndex = 45;
            this.ckbDisponibiliteNon.Text = "Non";
            this.ckbDisponibiliteNon.UseVisualStyleBackColor = true;
            // 
            // ckbDisponibiliteOui
            // 
            this.ckbDisponibiliteOui.AutoSize = true;
            this.ckbDisponibiliteOui.Location = new System.Drawing.Point(158, 451);
            this.ckbDisponibiliteOui.Name = "ckbDisponibiliteOui";
            this.ckbDisponibiliteOui.Size = new System.Drawing.Size(42, 17);
            this.ckbDisponibiliteOui.TabIndex = 44;
            this.ckbDisponibiliteOui.Text = "Oui";
            this.ckbDisponibiliteOui.UseVisualStyleBackColor = true;
            // 
            // lblDisponibilite
            // 
            this.lblDisponibilite.AutoSize = true;
            this.lblDisponibilite.Location = new System.Drawing.Point(28, 451);
            this.lblDisponibilite.Name = "lblDisponibilite";
            this.lblDisponibilite.Size = new System.Drawing.Size(65, 13);
            this.lblDisponibilite.TabIndex = 43;
            this.lblDisponibilite.Text = "Displonibilité";
            // 
            // lblQuantiteEnStock
            // 
            this.lblQuantiteEnStock.AutoSize = true;
            this.lblQuantiteEnStock.Location = new System.Drawing.Point(28, 419);
            this.lblQuantiteEnStock.Name = "lblQuantiteEnStock";
            this.lblQuantiteEnStock.Size = new System.Drawing.Size(97, 13);
            this.lblQuantiteEnStock.TabIndex = 42;
            this.lblQuantiteEnStock.Text = "Quantitée en stock";
            // 
            // tbxNomimage
            // 
            this.tbxNomimage.Location = new System.Drawing.Point(158, 361);
            this.tbxNomimage.Name = "tbxNomimage";
            this.tbxNomimage.Size = new System.Drawing.Size(147, 20);
            this.tbxNomimage.TabIndex = 41;
            // 
            // lblNomimage
            // 
            this.lblNomimage.AutoSize = true;
            this.lblNomimage.Location = new System.Drawing.Point(28, 361);
            this.lblNomimage.Name = "lblNomimage";
            this.lblNomimage.Size = new System.Drawing.Size(57, 13);
            this.lblNomimage.TabIndex = 40;
            this.lblNomimage.Text = "Nomimage";
            // 
            // btnCreer
            // 
            this.btnCreer.Location = new System.Drawing.Point(184, 509);
            this.btnCreer.Name = "btnCreer";
            this.btnCreer.Size = new System.Drawing.Size(121, 23);
            this.btnCreer.TabIndex = 39;
            this.btnCreer.Text = "Créer";
            this.btnCreer.UseVisualStyleBackColor = true;
            // 
            // tbxTauxTVA
            // 
            this.tbxTauxTVA.Location = new System.Drawing.Point(158, 329);
            this.tbxTauxTVA.Name = "tbxTauxTVA";
            this.tbxTauxTVA.Size = new System.Drawing.Size(147, 20);
            this.tbxTauxTVA.TabIndex = 38;
            // 
            // tbxPrixHT
            // 
            this.tbxPrixHT.Location = new System.Drawing.Point(158, 292);
            this.tbxPrixHT.Name = "tbxPrixHT";
            this.tbxPrixHT.Size = new System.Drawing.Size(147, 20);
            this.tbxPrixHT.TabIndex = 37;
            // 
            // tbxDetail
            // 
            this.tbxDetail.Location = new System.Drawing.Point(158, 158);
            this.tbxDetail.Multiline = true;
            this.tbxDetail.Name = "tbxDetail";
            this.tbxDetail.Size = new System.Drawing.Size(147, 116);
            this.tbxDetail.TabIndex = 36;
            // 
            // tbxLibelle
            // 
            this.tbxLibelle.Location = new System.Drawing.Point(158, 121);
            this.tbxLibelle.Name = "tbxLibelle";
            this.tbxLibelle.Size = new System.Drawing.Size(147, 20);
            this.tbxLibelle.TabIndex = 35;
            // 
            // cmbMarque
            // 
            this.cmbMarque.FormattingEnabled = true;
            this.cmbMarque.Location = new System.Drawing.Point(158, 74);
            this.cmbMarque.Name = "cmbMarque";
            this.cmbMarque.Size = new System.Drawing.Size(147, 21);
            this.cmbMarque.TabIndex = 34;
            // 
            // cmbCategorie
            // 
            this.cmbCategorie.FormattingEnabled = true;
            this.cmbCategorie.Location = new System.Drawing.Point(158, 41);
            this.cmbCategorie.Name = "cmbCategorie";
            this.cmbCategorie.Size = new System.Drawing.Size(147, 21);
            this.cmbCategorie.TabIndex = 33;
            // 
            // lblTauxTVA
            // 
            this.lblTauxTVA.AutoSize = true;
            this.lblTauxTVA.Location = new System.Drawing.Point(28, 329);
            this.lblTauxTVA.Name = "lblTauxTVA";
            this.lblTauxTVA.Size = new System.Drawing.Size(55, 13);
            this.lblTauxTVA.TabIndex = 32;
            this.lblTauxTVA.Text = "Taux TVA";
            // 
            // lblPrixHT
            // 
            this.lblPrixHT.AutoSize = true;
            this.lblPrixHT.Location = new System.Drawing.Point(28, 292);
            this.lblPrixHT.Name = "lblPrixHT";
            this.lblPrixHT.Size = new System.Drawing.Size(42, 13);
            this.lblPrixHT.TabIndex = 31;
            this.lblPrixHT.Text = "Prix HT";
            // 
            // lblDetail
            // 
            this.lblDetail.AutoSize = true;
            this.lblDetail.Location = new System.Drawing.Point(33, 158);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(34, 13);
            this.lblDetail.TabIndex = 30;
            this.lblDetail.Text = "Détail";
            // 
            // lblLibelle
            // 
            this.lblLibelle.AutoSize = true;
            this.lblLibelle.Location = new System.Drawing.Point(33, 121);
            this.lblLibelle.Name = "lblLibelle";
            this.lblLibelle.Size = new System.Drawing.Size(37, 13);
            this.lblLibelle.TabIndex = 29;
            this.lblLibelle.Text = "Libellé";
            // 
            // lblMarque
            // 
            this.lblMarque.AutoSize = true;
            this.lblMarque.Location = new System.Drawing.Point(33, 82);
            this.lblMarque.Name = "lblMarque";
            this.lblMarque.Size = new System.Drawing.Size(43, 13);
            this.lblMarque.TabIndex = 28;
            this.lblMarque.Text = "Marque";
            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Location = new System.Drawing.Point(33, 50);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(52, 13);
            this.lblCategorie.TabIndex = 27;
            this.lblCategorie.Text = "Catégorie";
            // 
            // lblChoisirProduit
            // 
            this.lblChoisirProduit.AutoSize = true;
            this.lblChoisirProduit.Location = new System.Drawing.Point(33, 15);
            this.lblChoisirProduit.Name = "lblChoisirProduit";
            this.lblChoisirProduit.Size = new System.Drawing.Size(88, 13);
            this.lblChoisirProduit.TabIndex = 52;
            this.lblChoisirProduit.Text = "Produit à modifier";
            // 
            // cmbProduit
            // 
            this.cmbProduit.FormattingEnabled = true;
            this.cmbProduit.Location = new System.Drawing.Point(158, 12);
            this.cmbProduit.Name = "cmbProduit";
            this.cmbProduit.Size = new System.Drawing.Size(147, 21);
            this.cmbProduit.TabIndex = 53;
            this.cmbProduit.SelectedIndexChanged += new System.EventHandler(this.cmbProduit_SelectedIndexChanged);
            // 
            // FormModifierProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 541);
            this.Controls.Add(this.cmbProduit);
            this.Controls.Add(this.lblChoisirProduit);
            this.Controls.Add(this.numericQuantite);
            this.Controls.Add(this.ckbVitrineNon);
            this.Controls.Add(this.ckbVitrineOui);
            this.Controls.Add(this.dateTimeAjout);
            this.Controls.Add(this.lblDateAjout);
            this.Controls.Add(this.lblVitrine);
            this.Controls.Add(this.ckbDisponibiliteNon);
            this.Controls.Add(this.ckbDisponibiliteOui);
            this.Controls.Add(this.lblDisponibilite);
            this.Controls.Add(this.lblQuantiteEnStock);
            this.Controls.Add(this.tbxNomimage);
            this.Controls.Add(this.lblNomimage);
            this.Controls.Add(this.btnCreer);
            this.Controls.Add(this.tbxTauxTVA);
            this.Controls.Add(this.tbxPrixHT);
            this.Controls.Add(this.tbxDetail);
            this.Controls.Add(this.tbxLibelle);
            this.Controls.Add(this.cmbMarque);
            this.Controls.Add(this.cmbCategorie);
            this.Controls.Add(this.lblTauxTVA);
            this.Controls.Add(this.lblPrixHT);
            this.Controls.Add(this.lblDetail);
            this.Controls.Add(this.lblLibelle);
            this.Controls.Add(this.lblMarque);
            this.Controls.Add(this.lblCategorie);
            this.Name = "FormModifierProduit";
            this.Text = "Modifier un produit";
            this.Load += new System.EventHandler(this.FormModifierProduit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericQuantite;
        private System.Windows.Forms.CheckBox ckbVitrineNon;
        private System.Windows.Forms.CheckBox ckbVitrineOui;
        private System.Windows.Forms.DateTimePicker dateTimeAjout;
        private System.Windows.Forms.Label lblDateAjout;
        private System.Windows.Forms.Label lblVitrine;
        private System.Windows.Forms.CheckBox ckbDisponibiliteNon;
        private System.Windows.Forms.CheckBox ckbDisponibiliteOui;
        private System.Windows.Forms.Label lblDisponibilite;
        private System.Windows.Forms.Label lblQuantiteEnStock;
        private System.Windows.Forms.TextBox tbxNomimage;
        private System.Windows.Forms.Label lblNomimage;
        private System.Windows.Forms.Button btnCreer;
        private System.Windows.Forms.TextBox tbxTauxTVA;
        private System.Windows.Forms.TextBox tbxPrixHT;
        private System.Windows.Forms.TextBox tbxDetail;
        private System.Windows.Forms.TextBox tbxLibelle;
        private System.Windows.Forms.ComboBox cmbMarque;
        private System.Windows.Forms.ComboBox cmbCategorie;
        private System.Windows.Forms.Label lblTauxTVA;
        private System.Windows.Forms.Label lblPrixHT;
        private System.Windows.Forms.Label lblDetail;
        private System.Windows.Forms.Label lblLibelle;
        private System.Windows.Forms.Label lblMarque;
        private System.Windows.Forms.Label lblCategorie;
        private System.Windows.Forms.Label lblChoisirProduit;
        private System.Windows.Forms.ComboBox cmbProduit;
    }
}