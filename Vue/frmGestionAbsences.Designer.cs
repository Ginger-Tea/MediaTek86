namespace MediaTek86.Vue
{
    partial class frmGestionAbsences
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
            this.dgvAbsences = new System.Windows.Forms.DataGridView();
            this.lblListeAbsences = new System.Windows.Forms.Label();
            this.lblGestionAbsences = new System.Windows.Forms.Label();
            this.lblAdministrationAbs = new System.Windows.Forms.Label();
            this.lblInfosAbsences = new System.Windows.Forms.Label();
            this.btnAjouterAbs = new System.Windows.Forms.Button();
            this.btnSupprimerAbs = new System.Windows.Forms.Button();
            this.btnModifierAbs = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblDebut = new System.Windows.Forms.Label();
            this.lblFin = new System.Windows.Forms.Label();
            this.lblMotifs = new System.Windows.Forms.Label();
            this.cboMotifs = new System.Windows.Forms.ComboBox();
            this.btnVider = new System.Windows.Forms.Button();
            this.dtpDebut = new System.Windows.Forms.DateTimePicker();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAbsences
            // 
            this.dgvAbsences.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.dgvAbsences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbsences.Location = new System.Drawing.Point(161, 83);
            this.dgvAbsences.Name = "dgvAbsences";
            this.dgvAbsences.Size = new System.Drawing.Size(388, 218);
            this.dgvAbsences.TabIndex = 19;
            this.dgvAbsences.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAbsences_CellEnter);
            // 
            // lblListeAbsences
            // 
            this.lblListeAbsences.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(204)))), ((int)(((byte)(252)))));
            this.lblListeAbsences.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListeAbsences.ForeColor = System.Drawing.Color.White;
            this.lblListeAbsences.Location = new System.Drawing.Point(253, 67);
            this.lblListeAbsences.Name = "lblListeAbsences";
            this.lblListeAbsences.Size = new System.Drawing.Size(197, 25);
            this.lblListeAbsences.TabIndex = 20;
            this.lblListeAbsences.Text = "Liste des absences";
            this.lblListeAbsences.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGestionAbsences
            // 
            this.lblGestionAbsences.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(204)))), ((int)(((byte)(252)))));
            this.lblGestionAbsences.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionAbsences.ForeColor = System.Drawing.Color.White;
            this.lblGestionAbsences.Location = new System.Drawing.Point(253, 304);
            this.lblGestionAbsences.Name = "lblGestionAbsences";
            this.lblGestionAbsences.Size = new System.Drawing.Size(197, 25);
            this.lblGestionAbsences.TabIndex = 21;
            this.lblGestionAbsences.Text = "Administration des absences";
            this.lblGestionAbsences.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAdministrationAbs
            // 
            this.lblAdministrationAbs.AutoSize = true;
            this.lblAdministrationAbs.BackColor = System.Drawing.Color.Transparent;
            this.lblAdministrationAbs.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdministrationAbs.ForeColor = System.Drawing.Color.White;
            this.lblAdministrationAbs.Location = new System.Drawing.Point(511, 323);
            this.lblAdministrationAbs.Name = "lblAdministrationAbs";
            this.lblAdministrationAbs.Size = new System.Drawing.Size(104, 19);
            this.lblAdministrationAbs.TabIndex = 22;
            this.lblAdministrationAbs.Text = "Administration";
            // 
            // lblInfosAbsences
            // 
            this.lblInfosAbsences.AutoSize = true;
            this.lblInfosAbsences.BackColor = System.Drawing.Color.Transparent;
            this.lblInfosAbsences.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfosAbsences.ForeColor = System.Drawing.Color.White;
            this.lblInfosAbsences.Location = new System.Drawing.Point(47, 324);
            this.lblInfosAbsences.Name = "lblInfosAbsences";
            this.lblInfosAbsences.Size = new System.Drawing.Size(190, 18);
            this.lblInfosAbsences.TabIndex = 23;
            this.lblInfosAbsences.Text = "Informations sur les absences";
            // 
            // btnAjouterAbs
            // 
            this.btnAjouterAbs.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAjouterAbs.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterAbs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(204)))), ((int)(((byte)(252)))));
            this.btnAjouterAbs.Location = new System.Drawing.Point(500, 358);
            this.btnAjouterAbs.Name = "btnAjouterAbs";
            this.btnAjouterAbs.Size = new System.Drawing.Size(115, 29);
            this.btnAjouterAbs.TabIndex = 24;
            this.btnAjouterAbs.Text = "Ajouter";
            this.btnAjouterAbs.UseVisualStyleBackColor = false;
            this.btnAjouterAbs.Click += new System.EventHandler(this.btnAjouterAbs_Click);
            // 
            // btnSupprimerAbs
            // 
            this.btnSupprimerAbs.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSupprimerAbs.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimerAbs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(204)))), ((int)(((byte)(252)))));
            this.btnSupprimerAbs.Location = new System.Drawing.Point(500, 428);
            this.btnSupprimerAbs.Name = "btnSupprimerAbs";
            this.btnSupprimerAbs.Size = new System.Drawing.Size(115, 29);
            this.btnSupprimerAbs.TabIndex = 25;
            this.btnSupprimerAbs.Text = "Supprimer";
            this.btnSupprimerAbs.UseVisualStyleBackColor = false;
            this.btnSupprimerAbs.Click += new System.EventHandler(this.btnSupprimerAbs_Click);
            // 
            // btnModifierAbs
            // 
            this.btnModifierAbs.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModifierAbs.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifierAbs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(204)))), ((int)(((byte)(252)))));
            this.btnModifierAbs.Location = new System.Drawing.Point(500, 393);
            this.btnModifierAbs.Name = "btnModifierAbs";
            this.btnModifierAbs.Size = new System.Drawing.Size(115, 29);
            this.btnModifierAbs.TabIndex = 26;
            this.btnModifierAbs.Text = "Modifier";
            this.btnModifierAbs.UseVisualStyleBackColor = false;
            this.btnModifierAbs.Click += new System.EventHandler(this.btnModifierAbs_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRetour.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetour.ForeColor = System.Drawing.Color.Black;
            this.btnRetour.Location = new System.Drawing.Point(487, 463);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(140, 23);
            this.btnRetour.TabIndex = 27;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = false;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.BackColor = System.Drawing.Color.Transparent;
            this.lblNom.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(57, 358);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(38, 18);
            this.lblNom.TabIndex = 28;
            this.lblNom.Text = "Nom";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(60, 379);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(85, 20);
            this.txtNom.TabIndex = 29;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(161, 379);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(85, 20);
            this.txtPrenom.TabIndex = 30;
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.BackColor = System.Drawing.Color.Transparent;
            this.lblPrenom.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.Location = new System.Drawing.Point(158, 358);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(57, 18);
            this.lblPrenom.TabIndex = 31;
            this.lblPrenom.Text = "Prénom";
            // 
            // lblDebut
            // 
            this.lblDebut.AutoSize = true;
            this.lblDebut.BackColor = System.Drawing.Color.Transparent;
            this.lblDebut.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebut.Location = new System.Drawing.Point(57, 414);
            this.lblDebut.Name = "lblDebut";
            this.lblDebut.Size = new System.Drawing.Size(75, 18);
            this.lblDebut.TabIndex = 32;
            this.lblDebut.Text = "DateDebut";
            // 
            // lblFin
            // 
            this.lblFin.AutoSize = true;
            this.lblFin.BackColor = System.Drawing.Color.Transparent;
            this.lblFin.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFin.Location = new System.Drawing.Point(57, 439);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(56, 18);
            this.lblFin.TabIndex = 33;
            this.lblFin.Text = "DateFin";
            // 
            // lblMotifs
            // 
            this.lblMotifs.AutoSize = true;
            this.lblMotifs.BackColor = System.Drawing.Color.Transparent;
            this.lblMotifs.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotifs.Location = new System.Drawing.Point(57, 464);
            this.lblMotifs.Name = "lblMotifs";
            this.lblMotifs.Size = new System.Drawing.Size(41, 18);
            this.lblMotifs.TabIndex = 34;
            this.lblMotifs.Text = "Motif";
            // 
            // cboMotifs
            // 
            this.cboMotifs.FormattingEnabled = true;
            this.cboMotifs.Location = new System.Drawing.Point(130, 465);
            this.cboMotifs.Name = "cboMotifs";
            this.cboMotifs.Size = new System.Drawing.Size(116, 21);
            this.cboMotifs.TabIndex = 37;
            // 
            // btnVider
            // 
            this.btnVider.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVider.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(204)))), ((int)(((byte)(252)))));
            this.btnVider.Location = new System.Drawing.Point(256, 465);
            this.btnVider.Name = "btnVider";
            this.btnVider.Size = new System.Drawing.Size(87, 23);
            this.btnVider.TabIndex = 38;
            this.btnVider.Text = "Réinitialiser";
            this.btnVider.UseVisualStyleBackColor = false;
            this.btnVider.Click += new System.EventHandler(this.btnVider_Click);
            // 
            // dtpDebut
            // 
            this.dtpDebut.Location = new System.Drawing.Point(130, 411);
            this.dtpDebut.Name = "dtpDebut";
            this.dtpDebut.Size = new System.Drawing.Size(200, 20);
            this.dtpDebut.TabIndex = 39;
            // 
            // dtpFin
            // 
            this.dtpFin.Location = new System.Drawing.Point(130, 437);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(200, 20);
            this.dtpFin.TabIndex = 40;
            // 
            // frmGestionAbsences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MediaTek86.Properties.Resources.frmGestionAbsences_background;
            this.ClientSize = new System.Drawing.Size(700, 507);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.dtpDebut);
            this.Controls.Add(this.btnVider);
            this.Controls.Add(this.cboMotifs);
            this.Controls.Add(this.lblMotifs);
            this.Controls.Add(this.lblFin);
            this.Controls.Add(this.lblDebut);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnModifierAbs);
            this.Controls.Add(this.btnSupprimerAbs);
            this.Controls.Add(this.btnAjouterAbs);
            this.Controls.Add(this.lblInfosAbsences);
            this.Controls.Add(this.lblAdministrationAbs);
            this.Controls.Add(this.lblGestionAbsences);
            this.Controls.Add(this.lblListeAbsences);
            this.Controls.Add(this.dgvAbsences);
            this.Name = "frmGestionAbsences";
            this.Text = "Gestion des absences";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAbsences;
        private System.Windows.Forms.Label lblListeAbsences;
        private System.Windows.Forms.Label lblGestionAbsences;
        private System.Windows.Forms.Label lblAdministrationAbs;
        private System.Windows.Forms.Label lblInfosAbsences;
        private System.Windows.Forms.Button btnAjouterAbs;
        private System.Windows.Forms.Button btnSupprimerAbs;
        private System.Windows.Forms.Button btnModifierAbs;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblDebut;
        private System.Windows.Forms.Label lblFin;
        private System.Windows.Forms.Label lblMotifs;
        private System.Windows.Forms.ComboBox cboMotifs;
        private System.Windows.Forms.Button btnVider;
        private System.Windows.Forms.DateTimePicker dtpDebut;
        private System.Windows.Forms.DateTimePicker dtpFin;
    }
}