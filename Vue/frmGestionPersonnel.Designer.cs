namespace MediaTek86.Vue
{
    partial class frmGestionPersonnel
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
            this.lblPersonnel = new System.Windows.Forms.Label();
            this.lblAdministration = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblService = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.cboServices = new System.Windows.Forms.ComboBox();
            this.btnVider = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnAbsences = new System.Windows.Forms.Button();
            this.lblGestionPersonnel = new System.Windows.Forms.Label();
            this.dgvPersonnels = new System.Windows.Forms.DataGridView();
            this.lblListePersonnel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnels)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPersonnel
            // 
            this.lblPersonnel.AutoSize = true;
            this.lblPersonnel.BackColor = System.Drawing.Color.Transparent;
            this.lblPersonnel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonnel.ForeColor = System.Drawing.Color.White;
            this.lblPersonnel.Location = new System.Drawing.Point(57, 325);
            this.lblPersonnel.Name = "lblPersonnel";
            this.lblPersonnel.Size = new System.Drawing.Size(178, 19);
            this.lblPersonnel.TabIndex = 0;
            this.lblPersonnel.Text = "Informations personnelles";
            // 
            // lblAdministration
            // 
            this.lblAdministration.AutoSize = true;
            this.lblAdministration.BackColor = System.Drawing.Color.Transparent;
            this.lblAdministration.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdministration.ForeColor = System.Drawing.Color.White;
            this.lblAdministration.Location = new System.Drawing.Point(512, 325);
            this.lblAdministration.Name = "lblAdministration";
            this.lblAdministration.Size = new System.Drawing.Size(104, 19);
            this.lblAdministration.TabIndex = 1;
            this.lblAdministration.Text = "Administration";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.BackColor = System.Drawing.Color.Transparent;
            this.lblNom.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(58, 355);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(38, 18);
            this.lblNom.TabIndex = 2;
            this.lblNom.Text = "Nom";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.BackColor = System.Drawing.Color.Transparent;
            this.lblPrenom.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.Location = new System.Drawing.Point(160, 355);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(57, 18);
            this.lblPrenom.TabIndex = 3;
            this.lblPrenom.Text = "Prénom";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.BackColor = System.Drawing.Color.Transparent;
            this.lblTel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.Location = new System.Drawing.Point(58, 407);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(26, 18);
            this.lblTel.TabIndex = 4;
            this.lblTel.Text = "Tel";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.BackColor = System.Drawing.Color.Transparent;
            this.lblMail.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Location = new System.Drawing.Point(58, 434);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(35, 18);
            this.lblMail.TabIndex = 5;
            this.lblMail.Text = "Mail";
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.BackColor = System.Drawing.Color.Transparent;
            this.lblService.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblService.Location = new System.Drawing.Point(58, 461);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(53, 18);
            this.lblService.TabIndex = 6;
            this.lblService.Text = "Service";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(61, 376);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(85, 20);
            this.txtNom.TabIndex = 7;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(163, 376);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(85, 20);
            this.txtPrenom.TabIndex = 8;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(132, 407);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(116, 20);
            this.txtTel.TabIndex = 9;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(132, 434);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(116, 20);
            this.txtMail.TabIndex = 10;
            // 
            // cboServices
            // 
            this.cboServices.FormattingEnabled = true;
            this.cboServices.Location = new System.Drawing.Point(132, 461);
            this.cboServices.Name = "cboServices";
            this.cboServices.Size = new System.Drawing.Size(116, 21);
            this.cboServices.TabIndex = 11;
            // 
            // btnVider
            // 
            this.btnVider.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVider.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(204)))), ((int)(((byte)(252)))));
            this.btnVider.Location = new System.Drawing.Point(254, 459);
            this.btnVider.Name = "btnVider";
            this.btnVider.Size = new System.Drawing.Size(87, 23);
            this.btnVider.TabIndex = 12;
            this.btnVider.Text = "Réinitialiser";
            this.btnVider.UseVisualStyleBackColor = false;
            this.btnVider.Click += new System.EventHandler(this.btnVider_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAjouter.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(204)))), ((int)(((byte)(252)))));
            this.btnAjouter.Location = new System.Drawing.Point(501, 355);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(115, 29);
            this.btnAjouter.TabIndex = 13;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModifier.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(204)))), ((int)(((byte)(252)))));
            this.btnModifier.Location = new System.Drawing.Point(501, 390);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(115, 29);
            this.btnModifier.TabIndex = 14;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSupprimer.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(204)))), ((int)(((byte)(252)))));
            this.btnSupprimer.Location = new System.Drawing.Point(501, 425);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(115, 31);
            this.btnSupprimer.TabIndex = 15;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnAbsences
            // 
            this.btnAbsences.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAbsences.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbsences.ForeColor = System.Drawing.Color.Black;
            this.btnAbsences.Location = new System.Drawing.Point(488, 462);
            this.btnAbsences.Name = "btnAbsences";
            this.btnAbsences.Size = new System.Drawing.Size(140, 23);
            this.btnAbsences.TabIndex = 16;
            this.btnAbsences.Text = "Gestion des absences";
            this.btnAbsences.UseVisualStyleBackColor = false;
            this.btnAbsences.Click += new System.EventHandler(this.btnAbsences_Click);
            // 
            // lblGestionPersonnel
            // 
            this.lblGestionPersonnel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(204)))), ((int)(((byte)(252)))));
            this.lblGestionPersonnel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionPersonnel.ForeColor = System.Drawing.Color.White;
            this.lblGestionPersonnel.Location = new System.Drawing.Point(251, 297);
            this.lblGestionPersonnel.Name = "lblGestionPersonnel";
            this.lblGestionPersonnel.Size = new System.Drawing.Size(197, 25);
            this.lblGestionPersonnel.TabIndex = 17;
            this.lblGestionPersonnel.Text = "Administration du personnel";
            this.lblGestionPersonnel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvPersonnels
            // 
            this.dgvPersonnels.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.dgvPersonnels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonnels.Location = new System.Drawing.Point(61, 76);
            this.dgvPersonnels.Name = "dgvPersonnels";
            this.dgvPersonnels.Size = new System.Drawing.Size(600, 218);
            this.dgvPersonnels.TabIndex = 18;
            this.dgvPersonnels.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersonnel_CellContentClick);
            this.dgvPersonnels.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersonnels_CellEnter);
            // 
            // lblListePersonnel
            // 
            this.lblListePersonnel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(204)))), ((int)(((byte)(252)))));
            this.lblListePersonnel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListePersonnel.ForeColor = System.Drawing.Color.White;
            this.lblListePersonnel.Location = new System.Drawing.Point(251, 60);
            this.lblListePersonnel.Name = "lblListePersonnel";
            this.lblListePersonnel.Size = new System.Drawing.Size(197, 25);
            this.lblListePersonnel.TabIndex = 19;
            this.lblListePersonnel.Text = "Liste du personnel";
            this.lblListePersonnel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmGestionPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MediaTek86.Properties.Resources.frmGestionPersonnel_background;
            this.ClientSize = new System.Drawing.Size(700, 508);
            this.Controls.Add(this.lblListePersonnel);
            this.Controls.Add(this.dgvPersonnels);
            this.Controls.Add(this.lblGestionPersonnel);
            this.Controls.Add(this.btnAbsences);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnVider);
            this.Controls.Add(this.cboServices);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblService);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblAdministration);
            this.Controls.Add(this.lblPersonnel);
            this.Name = "frmGestionPersonnel";
            this.Text = "Gestion du personnel";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnels)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPersonnel;
        private System.Windows.Forms.Label lblAdministration;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.ComboBox cboServices;
        private System.Windows.Forms.Button btnVider;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnAbsences;
        private System.Windows.Forms.Label lblGestionPersonnel;
        private System.Windows.Forms.DataGridView dgvPersonnels;
        private System.Windows.Forms.Label lblListePersonnel;
    }
}