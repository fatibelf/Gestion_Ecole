namespace GestionEcole
{
    partial class Accueil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnTypePaiment = new System.Windows.Forms.Button();
            this.btnPaiment = new System.Windows.Forms.Button();
            this.btnStagaire = new System.Windows.Forms.Button();
            this.panellOGO = new System.Windows.Forms.Panel();
            this.panelTitBar = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.panelDesktopPanel = new System.Windows.Forms.Panel();
            this.btnDeplom = new System.Windows.Forms.Button();
            this.btnFilier = new System.Windows.Forms.Button();
            this.btnModule = new System.Windows.Forms.Button();
            this.brnFormateur = new System.Windows.Forms.Button();
            this.btnClasse = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelTitBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnClasse);
            this.panelMenu.Controls.Add(this.brnFormateur);
            this.panelMenu.Controls.Add(this.btnModule);
            this.panelMenu.Controls.Add(this.btnFilier);
            this.panelMenu.Controls.Add(this.btnDeplom);
            this.panelMenu.Controls.Add(this.btnTypePaiment);
            this.panelMenu.Controls.Add(this.btnPaiment);
            this.panelMenu.Controls.Add(this.btnStagaire);
            this.panelMenu.Controls.Add(this.panellOGO);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(165, 510);
            this.panelMenu.TabIndex = 1;
            // 
            // btnTypePaiment
            // 
            this.btnTypePaiment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTypePaiment.FlatAppearance.BorderSize = 0;
            this.btnTypePaiment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTypePaiment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTypePaiment.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTypePaiment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTypePaiment.Location = new System.Drawing.Point(0, 163);
            this.btnTypePaiment.Margin = new System.Windows.Forms.Padding(2);
            this.btnTypePaiment.Name = "btnTypePaiment";
            this.btnTypePaiment.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnTypePaiment.Size = new System.Drawing.Size(165, 49);
            this.btnTypePaiment.TabIndex = 3;
            this.btnTypePaiment.Text = "Type Paiment";
            this.btnTypePaiment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTypePaiment.UseVisualStyleBackColor = true;
            this.btnTypePaiment.Click += new System.EventHandler(this.btnDiplom_Click);
            // 
            // btnPaiment
            // 
            this.btnPaiment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPaiment.FlatAppearance.BorderSize = 0;
            this.btnPaiment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaiment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaiment.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPaiment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaiment.Location = new System.Drawing.Point(0, 114);
            this.btnPaiment.Margin = new System.Windows.Forms.Padding(2);
            this.btnPaiment.Name = "btnPaiment";
            this.btnPaiment.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPaiment.Size = new System.Drawing.Size(165, 49);
            this.btnPaiment.TabIndex = 2;
            this.btnPaiment.Text = "Paiment";
            this.btnPaiment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPaiment.UseVisualStyleBackColor = true;
            this.btnPaiment.Click += new System.EventHandler(this.btnEtudier_Click);
            // 
            // btnStagaire
            // 
            this.btnStagaire.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStagaire.FlatAppearance.BorderSize = 0;
            this.btnStagaire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStagaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStagaire.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnStagaire.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStagaire.Location = new System.Drawing.Point(0, 65);
            this.btnStagaire.Margin = new System.Windows.Forms.Padding(2);
            this.btnStagaire.Name = "btnStagaire";
            this.btnStagaire.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnStagaire.Size = new System.Drawing.Size(165, 49);
            this.btnStagaire.TabIndex = 1;
            this.btnStagaire.Text = "Stagaire";
            this.btnStagaire.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStagaire.UseVisualStyleBackColor = true;
            this.btnStagaire.Click += new System.EventHandler(this.btnStagaire_Click);
            // 
            // panellOGO
            // 
            this.panellOGO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panellOGO.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panellOGO.BackgroundImage")));
            this.panellOGO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panellOGO.Dock = System.Windows.Forms.DockStyle.Top;
            this.panellOGO.Location = new System.Drawing.Point(0, 0);
            this.panellOGO.Margin = new System.Windows.Forms.Padding(2);
            this.panellOGO.Name = "panellOGO";
            this.panellOGO.Size = new System.Drawing.Size(165, 65);
            this.panellOGO.TabIndex = 1;
            // 
            // panelTitBar
            // 
            this.panelTitBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitBar.Controls.Add(this.lbTitle);
            this.panelTitBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitBar.Location = new System.Drawing.Point(165, 0);
            this.panelTitBar.Margin = new System.Windows.Forms.Padding(2);
            this.panelTitBar.Name = "panelTitBar";
            this.panelTitBar.Size = new System.Drawing.Size(800, 65);
            this.panelTitBar.TabIndex = 2;
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Algerian", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(350, 24);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(89, 25);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "ACCUEI";
            // 
            // panelDesktopPanel
            // 
            this.panelDesktopPanel.AutoScroll = true;
            this.panelDesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDesktopPanel.Location = new System.Drawing.Point(165, 65);
            this.panelDesktopPanel.Margin = new System.Windows.Forms.Padding(2);
            this.panelDesktopPanel.Name = "panelDesktopPanel";
            this.panelDesktopPanel.Size = new System.Drawing.Size(800, 445);
            this.panelDesktopPanel.TabIndex = 3;
            this.panelDesktopPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktopPanel_Paint);
            // 
            // btnDeplom
            // 
            this.btnDeplom.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeplom.FlatAppearance.BorderSize = 0;
            this.btnDeplom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeplom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeplom.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDeplom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeplom.Location = new System.Drawing.Point(0, 212);
            this.btnDeplom.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeplom.Name = "btnDeplom";
            this.btnDeplom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDeplom.Size = new System.Drawing.Size(165, 49);
            this.btnDeplom.TabIndex = 4;
            this.btnDeplom.Text = "Deplom";
            this.btnDeplom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeplom.UseVisualStyleBackColor = true;
            this.btnDeplom.Click += new System.EventHandler(this.btnDeplom_Click);
            // 
            // btnFilier
            // 
            this.btnFilier.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFilier.FlatAppearance.BorderSize = 0;
            this.btnFilier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilier.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFilier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilier.Location = new System.Drawing.Point(0, 261);
            this.btnFilier.Margin = new System.Windows.Forms.Padding(2);
            this.btnFilier.Name = "btnFilier";
            this.btnFilier.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnFilier.Size = new System.Drawing.Size(165, 49);
            this.btnFilier.TabIndex = 5;
            this.btnFilier.Text = "Filier";
            this.btnFilier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFilier.UseVisualStyleBackColor = true;
            this.btnFilier.Click += new System.EventHandler(this.btnFilier_Click);
            // 
            // btnModule
            // 
            this.btnModule.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModule.FlatAppearance.BorderSize = 0;
            this.btnModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModule.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnModule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModule.Location = new System.Drawing.Point(0, 310);
            this.btnModule.Margin = new System.Windows.Forms.Padding(2);
            this.btnModule.Name = "btnModule";
            this.btnModule.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnModule.Size = new System.Drawing.Size(165, 49);
            this.btnModule.TabIndex = 6;
            this.btnModule.Text = "Module";
            this.btnModule.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModule.UseVisualStyleBackColor = true;
            this.btnModule.Click += new System.EventHandler(this.btnModule_Click);
            // 
            // brnFormateur
            // 
            this.brnFormateur.Dock = System.Windows.Forms.DockStyle.Top;
            this.brnFormateur.FlatAppearance.BorderSize = 0;
            this.brnFormateur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brnFormateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnFormateur.ForeColor = System.Drawing.Color.Gainsboro;
            this.brnFormateur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.brnFormateur.Location = new System.Drawing.Point(0, 359);
            this.brnFormateur.Margin = new System.Windows.Forms.Padding(2);
            this.brnFormateur.Name = "brnFormateur";
            this.brnFormateur.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.brnFormateur.Size = new System.Drawing.Size(165, 49);
            this.brnFormateur.TabIndex = 7;
            this.brnFormateur.Text = "Formateur";
            this.brnFormateur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.brnFormateur.UseVisualStyleBackColor = true;
            this.brnFormateur.Click += new System.EventHandler(this.brnFormateur_Click);
            // 
            // btnClasse
            // 
            this.btnClasse.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClasse.FlatAppearance.BorderSize = 0;
            this.btnClasse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClasse.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnClasse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClasse.Location = new System.Drawing.Point(0, 408);
            this.btnClasse.Margin = new System.Windows.Forms.Padding(2);
            this.btnClasse.Name = "btnClasse";
            this.btnClasse.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnClasse.Size = new System.Drawing.Size(165, 49);
            this.btnClasse.TabIndex = 8;
            this.btnClasse.Text = "Classe";
            this.btnClasse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClasse.UseVisualStyleBackColor = true;
            this.btnClasse.Click += new System.EventHandler(this.btnClasse_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(965, 510);
            this.Controls.Add(this.panelDesktopPanel);
            this.Controls.Add(this.panelTitBar);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Accueil";
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.Accueil_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelTitBar.ResumeLayout(false);
            this.panelTitBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnTypePaiment;
        private System.Windows.Forms.Button btnPaiment;
        private System.Windows.Forms.Button btnStagaire;
        private System.Windows.Forms.Panel panellOGO;
        private System.Windows.Forms.Panel panelTitBar;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel panelDesktopPanel;
        private System.Windows.Forms.Button btnClasse;
        private System.Windows.Forms.Button brnFormateur;
        private System.Windows.Forms.Button btnModule;
        private System.Windows.Forms.Button btnFilier;
        private System.Windows.Forms.Button btnDeplom;
    }
}