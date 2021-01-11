namespace RequestManager.Views
{
    partial class RequestManagerView
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saisieDuneDemandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labTitre = new System.Windows.Forms.Label();
            this.labPriorité = new System.Windows.Forms.Label();
            this.labStatut = new System.Windows.Forms.Label();
            this.labDescription = new System.Windows.Forms.Label();
            this.txtTitre = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.cboxStatut = new System.Windows.Forms.ComboBox();
            this.cboxPriorité = new System.Windows.Forms.ComboBox();
            this.butNouveau = new System.Windows.Forms.Button();
            this.butSauver = new System.Windows.Forms.Button();
            this.butSupprimer = new System.Windows.Forms.Button();
            this.labStatutFiltre = new System.Windows.Forms.Label();
            this.cboxStatutFiltre = new System.Windows.Forms.ComboBox();
            this.labNumero = new System.Windows.Forms.Label();
            this.cboxNumero = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saisieDuneDemandeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(224, 28);
            // 
            // saisieDuneDemandeToolStripMenuItem
            // 
            this.saisieDuneDemandeToolStripMenuItem.Name = "saisieDuneDemandeToolStripMenuItem";
            this.saisieDuneDemandeToolStripMenuItem.Size = new System.Drawing.Size(223, 24);
            this.saisieDuneDemandeToolStripMenuItem.Text = "Saisie d\'une demande";
            // 
            // labTitre
            // 
            this.labTitre.AutoSize = true;
            this.labTitre.Location = new System.Drawing.Point(13, 13);
            this.labTitre.Name = "labTitre";
            this.labTitre.Size = new System.Drawing.Size(37, 17);
            this.labTitre.TabIndex = 1;
            this.labTitre.Text = "Titre";
            // 
            // labPriorité
            // 
            this.labPriorité.AutoSize = true;
            this.labPriorité.Location = new System.Drawing.Point(937, 15);
            this.labPriorité.Name = "labPriorité";
            this.labPriorité.Size = new System.Drawing.Size(53, 17);
            this.labPriorité.TabIndex = 2;
            this.labPriorité.Text = "Priorité";
            // 
            // labStatut
            // 
            this.labStatut.AutoSize = true;
            this.labStatut.Location = new System.Drawing.Point(790, 11);
            this.labStatut.Name = "labStatut";
            this.labStatut.Size = new System.Drawing.Size(45, 17);
            this.labStatut.TabIndex = 3;
            this.labStatut.Text = "Statut";
            // 
            // labDescription
            // 
            this.labDescription.AutoSize = true;
            this.labDescription.Location = new System.Drawing.Point(173, 13);
            this.labDescription.Name = "labDescription";
            this.labDescription.Size = new System.Drawing.Size(79, 17);
            this.labDescription.TabIndex = 4;
            this.labDescription.Text = "Description";
            // 
            // txtTitre
            // 
            this.txtTitre.Location = new System.Drawing.Point(16, 34);
            this.txtTitre.Name = "txtTitre";
            this.txtTitre.Size = new System.Drawing.Size(100, 22);
            this.txtTitre.TabIndex = 5;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(176, 34);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(529, 135);
            this.txtDescription.TabIndex = 6;
            this.txtDescription.Text = "";
            // 
            // cboxStatut
            // 
            this.cboxStatut.FormattingEnabled = true;
            this.cboxStatut.Location = new System.Drawing.Point(793, 32);
            this.cboxStatut.Name = "cboxStatut";
            this.cboxStatut.Size = new System.Drawing.Size(121, 24);
            this.cboxStatut.TabIndex = 7;
            // 
            // cboxPriorité
            // 
            this.cboxPriorité.FormattingEnabled = true;
            this.cboxPriorité.Location = new System.Drawing.Point(940, 34);
            this.cboxPriorité.Name = "cboxPriorité";
            this.cboxPriorité.Size = new System.Drawing.Size(121, 24);
            this.cboxPriorité.TabIndex = 8;
            // 
            // butNouveau
            // 
            this.butNouveau.Location = new System.Drawing.Point(939, 88);
            this.butNouveau.Name = "butNouveau";
            this.butNouveau.Size = new System.Drawing.Size(121, 23);
            this.butNouveau.TabIndex = 9;
            this.butNouveau.Text = "Nouveau";
            this.butNouveau.UseVisualStyleBackColor = true;
            // 
            // butSauver
            // 
            this.butSauver.Location = new System.Drawing.Point(939, 117);
            this.butSauver.Name = "butSauver";
            this.butSauver.Size = new System.Drawing.Size(121, 23);
            this.butSauver.TabIndex = 10;
            this.butSauver.Text = "Sauver";
            this.butSauver.UseVisualStyleBackColor = true;
            // 
            // butSupprimer
            // 
            this.butSupprimer.Location = new System.Drawing.Point(940, 146);
            this.butSupprimer.Name = "butSupprimer";
            this.butSupprimer.Size = new System.Drawing.Size(121, 23);
            this.butSupprimer.TabIndex = 11;
            this.butSupprimer.Text = "Supprimer";
            this.butSupprimer.UseVisualStyleBackColor = true;
            // 
            // labStatutFiltre
            // 
            this.labStatutFiltre.AutoSize = true;
            this.labStatutFiltre.Location = new System.Drawing.Point(13, 257);
            this.labStatutFiltre.Name = "labStatutFiltre";
            this.labStatutFiltre.Size = new System.Drawing.Size(45, 17);
            this.labStatutFiltre.TabIndex = 12;
            this.labStatutFiltre.Text = "Statut";
            // 
            // cboxStatutFiltre
            // 
            this.cboxStatutFiltre.FormattingEnabled = true;
            this.cboxStatutFiltre.Location = new System.Drawing.Point(16, 277);
            this.cboxStatutFiltre.Name = "cboxStatutFiltre";
            this.cboxStatutFiltre.Size = new System.Drawing.Size(121, 24);
            this.cboxStatutFiltre.TabIndex = 13;
            // 
            // labNumero
            // 
            this.labNumero.AutoSize = true;
            this.labNumero.Location = new System.Drawing.Point(173, 257);
            this.labNumero.Name = "labNumero";
            this.labNumero.Size = new System.Drawing.Size(156, 17);
            this.labNumero.TabIndex = 14;
            this.labNumero.Text = "Numéro de la demande";
            // 
            // cboxNumero
            // 
            this.cboxNumero.FormattingEnabled = true;
            this.cboxNumero.Location = new System.Drawing.Point(176, 277);
            this.cboxNumero.Name = "cboxNumero";
            this.cboxNumero.Size = new System.Drawing.Size(153, 24);
            this.cboxNumero.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 308);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1045, 390);
            this.dataGridView1.TabIndex = 16;
            // 
            // RequestManagerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 718);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cboxNumero);
            this.Controls.Add(this.labNumero);
            this.Controls.Add(this.cboxStatutFiltre);
            this.Controls.Add(this.labStatutFiltre);
            this.Controls.Add(this.butSupprimer);
            this.Controls.Add(this.butSauver);
            this.Controls.Add(this.butNouveau);
            this.Controls.Add(this.cboxPriorité);
            this.Controls.Add(this.cboxStatut);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtTitre);
            this.Controls.Add(this.labDescription);
            this.Controls.Add(this.labStatut);
            this.Controls.Add(this.labPriorité);
            this.Controls.Add(this.labTitre);
            this.Name = "RequestManagerView";
            this.Text = "RequestManagerView";
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saisieDuneDemandeToolStripMenuItem;
        private System.Windows.Forms.Label labTitre;
        private System.Windows.Forms.Label labPriorité;
        private System.Windows.Forms.Label labStatut;
        private System.Windows.Forms.Label labDescription;
        private System.Windows.Forms.TextBox txtTitre;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.ComboBox cboxStatut;
        private System.Windows.Forms.ComboBox cboxPriorité;
        private System.Windows.Forms.Button butNouveau;
        private System.Windows.Forms.Button butSauver;
        private System.Windows.Forms.Button butSupprimer;
        private System.Windows.Forms.Label labStatutFiltre;
        private System.Windows.Forms.ComboBox cboxStatutFiltre;
        private System.Windows.Forms.Label labNumero;
        private System.Windows.Forms.ComboBox cboxNumero;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}