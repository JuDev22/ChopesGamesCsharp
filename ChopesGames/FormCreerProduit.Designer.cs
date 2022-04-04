namespace ChopesGames
{
    partial class FormCreerProduit
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
            this.lblCategorie = new System.Windows.Forms.Label();
            this.lblMarque = new System.Windows.Forms.Label();
            this.lblLibelle = new System.Windows.Forms.Label();
            this.lblDetail = new System.Windows.Forms.Label();
            this.lblPrixHT = new System.Windows.Forms.Label();
            this.lblTauxTVA = new System.Windows.Forms.Label();
            this.cmbCategorie = new System.Windows.Forms.ComboBox();
            this.cmbMarque = new System.Windows.Forms.ComboBox();
            this.tbxLibelle = new System.Windows.Forms.TextBox();
            this.tbxDetail = new System.Windows.Forms.TextBox();
            this.tbxPrixHT = new System.Windows.Forms.TextBox();
            this.tbxTauxTVA = new System.Windows.Forms.TextBox();
            this.btnCreer = new System.Windows.Forms.Button();
            this.lblNomimage = new System.Windows.Forms.Label();
            this.tbxNomimage = new System.Windows.Forms.TextBox();
            this.lblQuantiteEnStock = new System.Windows.Forms.Label();
            this.lblDisponibilite = new System.Windows.Forms.Label();
            this.ckbDisponibiliteOui = new System.Windows.Forms.CheckBox();
            this.ckbDisponibiliteNon = new System.Windows.Forms.CheckBox();
            this.lblVitrine = new System.Windows.Forms.Label();
            this.lblDateAjout = new System.Windows.Forms.Label();
            this.dateTimeAjout = new System.Windows.Forms.DateTimePicker();
            this.ckbVitrineOui = new System.Windows.Forms.CheckBox();
            this.ckbVitrineNon = new System.Windows.Forms.CheckBox();
            this.numericQuantite = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantite)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Location = new System.Drawing.Point(28, 47);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(52, 13);
            this.lblCategorie.TabIndex = 0;
            this.lblCategorie.Text = "Catégorie";
            // 
            // lblMarque
            // 
            this.lblMarque.AutoSize = true;
            this.lblMarque.Location = new System.Drawing.Point(28, 79);
            this.lblMarque.Name = "lblMarque";
            this.lblMarque.Size = new System.Drawing.Size(43, 13);
            this.lblMarque.TabIndex = 1;
            this.lblMarque.Text = "Marque";
            // 
            // lblLibelle
            // 
            this.lblLibelle.AutoSize = true;
            this.lblLibelle.Location = new System.Drawing.Point(28, 118);
            this.lblLibelle.Name = "lblLibelle";
            this.lblLibelle.Size = new System.Drawing.Size(37, 13);
            this.lblLibelle.TabIndex = 2;
            this.lblLibelle.Text = "Libellé";
            // 
            // lblDetail
            // 
            this.lblDetail.AutoSize = true;
            this.lblDetail.Location = new System.Drawing.Point(28, 155);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(34, 13);
            this.lblDetail.TabIndex = 3;
            this.lblDetail.Text = "Détail";
            // 
            // lblPrixHT
            // 
            this.lblPrixHT.AutoSize = true;
            this.lblPrixHT.Location = new System.Drawing.Point(23, 289);
            this.lblPrixHT.Name = "lblPrixHT";
            this.lblPrixHT.Size = new System.Drawing.Size(42, 13);
            this.lblPrixHT.TabIndex = 4;
            this.lblPrixHT.Text = "Prix HT";
            // 
            // lblTauxTVA
            // 
            this.lblTauxTVA.AutoSize = true;
            this.lblTauxTVA.Location = new System.Drawing.Point(23, 326);
            this.lblTauxTVA.Name = "lblTauxTVA";
            this.lblTauxTVA.Size = new System.Drawing.Size(55, 13);
            this.lblTauxTVA.TabIndex = 5;
            this.lblTauxTVA.Text = "Taux TVA";
            // 
            // cmbCategorie
            // 
            this.cmbCategorie.FormattingEnabled = true;
            this.cmbCategorie.Location = new System.Drawing.Point(153, 38);
            this.cmbCategorie.Name = "cmbCategorie";
            this.cmbCategorie.Size = new System.Drawing.Size(147, 21);
            this.cmbCategorie.TabIndex = 6;
            // 
            // cmbMarque
            // 
            this.cmbMarque.FormattingEnabled = true;
            this.cmbMarque.Location = new System.Drawing.Point(153, 71);
            this.cmbMarque.Name = "cmbMarque";
            this.cmbMarque.Size = new System.Drawing.Size(147, 21);
            this.cmbMarque.TabIndex = 7;
            // 
            // tbxLibelle
            // 
            this.tbxLibelle.Location = new System.Drawing.Point(153, 118);
            this.tbxLibelle.Name = "tbxLibelle";
            this.tbxLibelle.Size = new System.Drawing.Size(147, 20);
            this.tbxLibelle.TabIndex = 8;
            // 
            // tbxDetail
            // 
            this.tbxDetail.Location = new System.Drawing.Point(153, 155);
            this.tbxDetail.Multiline = true;
            this.tbxDetail.Name = "tbxDetail";
            this.tbxDetail.Size = new System.Drawing.Size(147, 116);
            this.tbxDetail.TabIndex = 9;
            // 
            // tbxPrixHT
            // 
            this.tbxPrixHT.Location = new System.Drawing.Point(153, 289);
            this.tbxPrixHT.Name = "tbxPrixHT";
            this.tbxPrixHT.Size = new System.Drawing.Size(147, 20);
            this.tbxPrixHT.TabIndex = 10;
            this.tbxPrixHT.Leave += new System.EventHandler(this.tbxPrixHT_Leave);
            // 
            // tbxTauxTVA
            // 
            this.tbxTauxTVA.Location = new System.Drawing.Point(153, 326);
            this.tbxTauxTVA.Name = "tbxTauxTVA";
            this.tbxTauxTVA.Size = new System.Drawing.Size(147, 20);
            this.tbxTauxTVA.TabIndex = 11;
            // 
            // btnCreer
            // 
            this.btnCreer.Location = new System.Drawing.Point(179, 506);
            this.btnCreer.Name = "btnCreer";
            this.btnCreer.Size = new System.Drawing.Size(121, 23);
            this.btnCreer.TabIndex = 12;
            this.btnCreer.Text = "Créer";
            this.btnCreer.UseVisualStyleBackColor = true;
            this.btnCreer.Click += new System.EventHandler(this.btnCreer_Click);
            // 
            // lblNomimage
            // 
            this.lblNomimage.AutoSize = true;
            this.lblNomimage.Location = new System.Drawing.Point(23, 358);
            this.lblNomimage.Name = "lblNomimage";
            this.lblNomimage.Size = new System.Drawing.Size(57, 13);
            this.lblNomimage.TabIndex = 13;
            this.lblNomimage.Text = "Nomimage";
            // 
            // tbxNomimage
            // 
            this.tbxNomimage.Location = new System.Drawing.Point(153, 358);
            this.tbxNomimage.Name = "tbxNomimage";
            this.tbxNomimage.Size = new System.Drawing.Size(147, 20);
            this.tbxNomimage.TabIndex = 14;
            // 
            // lblQuantiteEnStock
            // 
            this.lblQuantiteEnStock.AutoSize = true;
            this.lblQuantiteEnStock.Location = new System.Drawing.Point(23, 416);
            this.lblQuantiteEnStock.Name = "lblQuantiteEnStock";
            this.lblQuantiteEnStock.Size = new System.Drawing.Size(97, 13);
            this.lblQuantiteEnStock.TabIndex = 15;
            this.lblQuantiteEnStock.Text = "Quantitée en stock";
            // 
            // lblDisponibilite
            // 
            this.lblDisponibilite.AutoSize = true;
            this.lblDisponibilite.Location = new System.Drawing.Point(23, 448);
            this.lblDisponibilite.Name = "lblDisponibilite";
            this.lblDisponibilite.Size = new System.Drawing.Size(65, 13);
            this.lblDisponibilite.TabIndex = 17;
            this.lblDisponibilite.Text = "Displonibilité";
            // 
            // ckbDisponibiliteOui
            // 
            this.ckbDisponibiliteOui.AutoSize = true;
            this.ckbDisponibiliteOui.Location = new System.Drawing.Point(153, 448);
            this.ckbDisponibiliteOui.Name = "ckbDisponibiliteOui";
            this.ckbDisponibiliteOui.Size = new System.Drawing.Size(42, 17);
            this.ckbDisponibiliteOui.TabIndex = 18;
            this.ckbDisponibiliteOui.Text = "Oui";
            this.ckbDisponibiliteOui.UseVisualStyleBackColor = true;
            this.ckbDisponibiliteOui.Click += new System.EventHandler(this.ckbDisponibiliteOui_Click);
            // 
            // ckbDisponibiliteNon
            // 
            this.ckbDisponibiliteNon.AutoSize = true;
            this.ckbDisponibiliteNon.Checked = true;
            this.ckbDisponibiliteNon.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbDisponibiliteNon.Location = new System.Drawing.Point(201, 448);
            this.ckbDisponibiliteNon.Name = "ckbDisponibiliteNon";
            this.ckbDisponibiliteNon.Size = new System.Drawing.Size(46, 17);
            this.ckbDisponibiliteNon.TabIndex = 19;
            this.ckbDisponibiliteNon.Text = "Non";
            this.ckbDisponibiliteNon.UseVisualStyleBackColor = true;
            this.ckbDisponibiliteNon.Click += new System.EventHandler(this.ckbDisponibiliteNon_Click);
            // 
            // lblVitrine
            // 
            this.lblVitrine.AutoSize = true;
            this.lblVitrine.Location = new System.Drawing.Point(23, 477);
            this.lblVitrine.Name = "lblVitrine";
            this.lblVitrine.Size = new System.Drawing.Size(36, 13);
            this.lblVitrine.TabIndex = 20;
            this.lblVitrine.Text = "Vitrine";
            // 
            // lblDateAjout
            // 
            this.lblDateAjout.AutoSize = true;
            this.lblDateAjout.Location = new System.Drawing.Point(23, 387);
            this.lblDateAjout.Name = "lblDateAjout";
            this.lblDateAjout.Size = new System.Drawing.Size(64, 13);
            this.lblDateAjout.TabIndex = 22;
            this.lblDateAjout.Text = "Date d\'ajout";
            // 
            // dateTimeAjout
            // 
            this.dateTimeAjout.Location = new System.Drawing.Point(153, 387);
            this.dateTimeAjout.Name = "dateTimeAjout";
            this.dateTimeAjout.Size = new System.Drawing.Size(147, 20);
            this.dateTimeAjout.TabIndex = 23;
            // 
            // ckbVitrineOui
            // 
            this.ckbVitrineOui.AutoSize = true;
            this.ckbVitrineOui.Location = new System.Drawing.Point(153, 471);
            this.ckbVitrineOui.Name = "ckbVitrineOui";
            this.ckbVitrineOui.Size = new System.Drawing.Size(42, 17);
            this.ckbVitrineOui.TabIndex = 24;
            this.ckbVitrineOui.Text = "Oui";
            this.ckbVitrineOui.UseVisualStyleBackColor = true;
            this.ckbVitrineOui.Click += new System.EventHandler(this.ckbVitrineOui_Click);
            // 
            // ckbVitrineNon
            // 
            this.ckbVitrineNon.AutoSize = true;
            this.ckbVitrineNon.Checked = true;
            this.ckbVitrineNon.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbVitrineNon.Location = new System.Drawing.Point(201, 473);
            this.ckbVitrineNon.Name = "ckbVitrineNon";
            this.ckbVitrineNon.Size = new System.Drawing.Size(46, 17);
            this.ckbVitrineNon.TabIndex = 25;
            this.ckbVitrineNon.Text = "Non";
            this.ckbVitrineNon.UseVisualStyleBackColor = true;
            this.ckbVitrineNon.Click += new System.EventHandler(this.ckbVitrineNon_Click);
            // 
            // numericQuantite
            // 
            this.numericQuantite.Location = new System.Drawing.Point(153, 416);
            this.numericQuantite.Name = "numericQuantite";
            this.numericQuantite.Size = new System.Drawing.Size(47, 20);
            this.numericQuantite.TabIndex = 26;
            // 
            // FormCreerProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 541);
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
            this.Name = "FormCreerProduit";
            this.Text = "Créer un produit";
            this.Load += new System.EventHandler(this.FormCreerProduit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCategorie;
        private System.Windows.Forms.Label lblMarque;
        private System.Windows.Forms.Label lblLibelle;
        private System.Windows.Forms.Label lblDetail;
        private System.Windows.Forms.Label lblPrixHT;
        private System.Windows.Forms.Label lblTauxTVA;
        private System.Windows.Forms.ComboBox cmbCategorie;
        private System.Windows.Forms.ComboBox cmbMarque;
        private System.Windows.Forms.TextBox tbxLibelle;
        private System.Windows.Forms.TextBox tbxDetail;
        private System.Windows.Forms.TextBox tbxPrixHT;
        private System.Windows.Forms.TextBox tbxTauxTVA;
        private System.Windows.Forms.Button btnCreer;
        private System.Windows.Forms.Label lblNomimage;
        private System.Windows.Forms.TextBox tbxNomimage;
        private System.Windows.Forms.Label lblQuantiteEnStock;
        private System.Windows.Forms.Label lblDisponibilite;
        private System.Windows.Forms.CheckBox ckbDisponibiliteOui;
        private System.Windows.Forms.CheckBox ckbDisponibiliteNon;
        private System.Windows.Forms.Label lblVitrine;
        private System.Windows.Forms.Label lblDateAjout;
        private System.Windows.Forms.DateTimePicker dateTimeAjout;
        private System.Windows.Forms.CheckBox ckbVitrineOui;
        private System.Windows.Forms.CheckBox ckbVitrineNon;
        private System.Windows.Forms.NumericUpDown numericQuantite;
    }
}