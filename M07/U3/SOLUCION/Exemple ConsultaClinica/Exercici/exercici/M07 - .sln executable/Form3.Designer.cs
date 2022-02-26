namespace M07Examen2
{
    partial class Form3
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
            this.listViewPa = new System.Windows.Forms.ListView();
            this.Nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cognom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sexe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nacio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelFiltre = new System.Windows.Forms.Label();
            this.comboBoxSexe = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listViewPa
            // 
            this.listViewPa.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nom,
            this.Cognom,
            this.Sexe,
            this.Nacio,
            this.Hist});
            this.listViewPa.ForeColor = System.Drawing.Color.Black;
            this.listViewPa.FullRowSelect = true;
            this.listViewPa.GridLines = true;
            this.listViewPa.Location = new System.Drawing.Point(34, 12);
            this.listViewPa.Name = "listViewPa";
            this.listViewPa.Size = new System.Drawing.Size(717, 285);
            this.listViewPa.TabIndex = 0;
            this.listViewPa.UseCompatibleStateImageBehavior = false;
            this.listViewPa.View = System.Windows.Forms.View.Details;
            this.listViewPa.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            // 
            // Nom
            // 
            this.Nom.Text = "NOM";
            this.Nom.Width = 89;
            // 
            // Cognom
            // 
            this.Cognom.Text = "COGNOM";
            this.Cognom.Width = 118;
            // 
            // Sexe
            // 
            this.Sexe.Text = "SEXE";
            this.Sexe.Width = 81;
            // 
            // Nacio
            // 
            this.Nacio.Text = "Nacionalitat";
            this.Nacio.Width = 110;
            // 
            // Hist
            // 
            this.Hist.Text = "Historial";
            this.Hist.Width = 315;
            // 
            // labelFiltre
            // 
            this.labelFiltre.AutoSize = true;
            this.labelFiltre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFiltre.Location = new System.Drawing.Point(34, 324);
            this.labelFiltre.Name = "labelFiltre";
            this.labelFiltre.Size = new System.Drawing.Size(35, 13);
            this.labelFiltre.TabIndex = 1;
            this.labelFiltre.Text = "Filtre";
            // 
            // comboBoxSexe
            // 
            this.comboBoxSexe.FormattingEnabled = true;
            this.comboBoxSexe.Items.AddRange(new object[] {
            "H",
            "M",
            "Tots"});
            this.comboBoxSexe.Location = new System.Drawing.Point(37, 360);
            this.comboBoxSexe.Name = "comboBoxSexe";
            this.comboBoxSexe.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSexe.TabIndex = 2;
            this.comboBoxSexe.Text = "Tots";
            this.comboBoxSexe.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSexe_SelectedIndexChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxSexe);
            this.Controls.Add(this.labelFiltre);
            this.Controls.Add(this.listViewPa);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewPa;
        private System.Windows.Forms.ColumnHeader Nom;
        private System.Windows.Forms.ColumnHeader Cognom;
        private System.Windows.Forms.ColumnHeader Sexe;
        private System.Windows.Forms.ColumnHeader Nacio;
        private System.Windows.Forms.ColumnHeader Hist;
        private System.Windows.Forms.Label labelFiltre;
        private System.Windows.Forms.ComboBox comboBoxSexe;
    }
}