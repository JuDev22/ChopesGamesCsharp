
namespace ChopesGames
{
    partial class FormListerProduits
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.lblMarque = new System.Windows.Forms.Label();
            this.cmbCategorie = new System.Windows.Forms.ComboBox();
            this.cmbMarque = new System.Windows.Forms.ComboBox();
            this.lvProduits = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recherche dans le catalogue par :";
            // 
            // lblCategorie
            // 
            this.lblCategorie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Location = new System.Drawing.Point(232, 56);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(52, 13);
            this.lblCategorie.TabIndex = 1;
            this.lblCategorie.Text = "Catégorie";
            // 
            // lblMarque
            // 
            this.lblMarque.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMarque.AutoSize = true;
            this.lblMarque.Location = new System.Drawing.Point(232, 81);
            this.lblMarque.Name = "lblMarque";
            this.lblMarque.Size = new System.Drawing.Size(43, 13);
            this.lblMarque.TabIndex = 2;
            this.lblMarque.Text = "Marque";
            // 
            // cmbCategorie
            // 
            this.cmbCategorie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCategorie.FormattingEnabled = true;
            this.cmbCategorie.Location = new System.Drawing.Point(303, 53);
            this.cmbCategorie.Name = "cmbCategorie";
            this.cmbCategorie.Size = new System.Drawing.Size(131, 21);
            this.cmbCategorie.TabIndex = 5;
            this.cmbCategorie.SelectedIndexChanged += new System.EventHandler(this.cmbCategorie_SelectedIndexChanged);
            // 
            // cmbMarque
            // 
            this.cmbMarque.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbMarque.FormattingEnabled = true;
            this.cmbMarque.Location = new System.Drawing.Point(303, 78);
            this.cmbMarque.Name = "cmbMarque";
            this.cmbMarque.Size = new System.Drawing.Size(131, 21);
            this.cmbMarque.TabIndex = 6;
            this.cmbMarque.SelectedIndexChanged += new System.EventHandler(this.cmbMarque_SelectedIndexChanged);
            // 
            // lvProduits
            // 
            this.lvProduits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lvProduits.HideSelection = false;
            this.lvProduits.Location = new System.Drawing.Point(12, 128);
            this.lvProduits.Name = "lvProduits";
            this.lvProduits.Size = new System.Drawing.Size(634, 311);
            this.lvProduits.TabIndex = 10;
            this.lvProduits.UseCompatibleStateImageBehavior = false;
            // 
            // FormListerProduits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 451);
            this.Controls.Add(this.lvProduits);
            this.Controls.Add(this.cmbMarque);
            this.Controls.Add(this.cmbCategorie);
            this.Controls.Add(this.lblMarque);
            this.Controls.Add(this.lblCategorie);
            this.Controls.Add(this.label1);
            this.Name = "FormListerProduits";
            this.Text = "Lister les produits";
            this.Load += new System.EventHandler(this.FormListerProduits_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCategorie;
        private System.Windows.Forms.Label lblMarque;
        private System.Windows.Forms.ComboBox cmbCategorie;
        private System.Windows.Forms.ComboBox cmbMarque;
        private System.Windows.Forms.ListView lvProduits;
    }
}