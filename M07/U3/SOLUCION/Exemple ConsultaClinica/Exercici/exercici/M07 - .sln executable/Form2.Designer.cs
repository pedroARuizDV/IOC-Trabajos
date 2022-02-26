namespace M07Examen2
{
    partial class Form2
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageDG = new System.Windows.Forms.TabPage();
            this.tabPageIP = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.buttonVD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSexe = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxCognom = new System.Windows.Forms.TextBox();
            this.textBoxNacion = new System.Windows.Forms.TextBox();
            this.radioButtonH = new System.Windows.Forms.RadioButton();
            this.radioButtonM = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBoxHist = new System.Windows.Forms.RichTextBox();
            this.toolStripButtonReturn = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.tabControl1.SuspendLayout();
            this.tabPageDG.SuspendLayout();
            this.tabPageIP.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageDG);
            this.tabControl1.Controls.Add(this.tabPageIP);
            this.tabControl1.Location = new System.Drawing.Point(-1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(463, 456);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageDG
            // 
            this.tabPageDG.Controls.Add(this.radioButtonM);
            this.tabPageDG.Controls.Add(this.radioButtonH);
            this.tabPageDG.Controls.Add(this.textBoxNacion);
            this.tabPageDG.Controls.Add(this.textBoxCognom);
            this.tabPageDG.Controls.Add(this.textBoxNom);
            this.tabPageDG.Controls.Add(this.label4);
            this.tabPageDG.Controls.Add(this.labelSexe);
            this.tabPageDG.Controls.Add(this.label2);
            this.tabPageDG.Controls.Add(this.label1);
            this.tabPageDG.Controls.Add(this.buttonVD);
            this.tabPageDG.Controls.Add(this.toolStrip1);
            this.tabPageDG.Location = new System.Drawing.Point(4, 22);
            this.tabPageDG.Name = "tabPageDG";
            this.tabPageDG.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDG.Size = new System.Drawing.Size(455, 430);
            this.tabPageDG.TabIndex = 0;
            this.tabPageDG.Text = "Dades Generals";
            this.tabPageDG.UseVisualStyleBackColor = true;
            // 
            // tabPageIP
            // 
            this.tabPageIP.Controls.Add(this.richTextBoxHist);
            this.tabPageIP.Controls.Add(this.label3);
            this.tabPageIP.Location = new System.Drawing.Point(4, 22);
            this.tabPageIP.Name = "tabPageIP";
            this.tabPageIP.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageIP.Size = new System.Drawing.Size(455, 430);
            this.tabPageIP.TabIndex = 1;
            this.tabPageIP.Text = "Informació Pacient";
            this.tabPageIP.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonReturn,
            this.toolStripButtonSave});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(449, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // buttonVD
            // 
            this.buttonVD.Location = new System.Drawing.Point(346, 362);
            this.buttonVD.Name = "buttonVD";
            this.buttonVD.Size = new System.Drawing.Size(93, 45);
            this.buttonVD.TabIndex = 1;
            this.buttonVD.Text = "Visualitzar Dades";
            this.buttonVD.UseVisualStyleBackColor = true;
            this.buttonVD.Click += new System.EventHandler(this.ButtonVD_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "NOM:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "COGNOM:";
            // 
            // labelSexe
            // 
            this.labelSexe.AutoSize = true;
            this.labelSexe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSexe.Location = new System.Drawing.Point(28, 192);
            this.labelSexe.Name = "labelSexe";
            this.labelSexe.Size = new System.Drawing.Size(43, 13);
            this.labelSexe.TabIndex = 4;
            this.labelSexe.Text = "SEXE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "NACIONALITAT:";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(129, 49);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(202, 20);
            this.textBoxNom.TabIndex = 6;
            // 
            // textBoxCognom
            // 
            this.textBoxCognom.Location = new System.Drawing.Point(129, 114);
            this.textBoxCognom.Name = "textBoxCognom";
            this.textBoxCognom.Size = new System.Drawing.Size(202, 20);
            this.textBoxCognom.TabIndex = 7;
            // 
            // textBoxNacion
            // 
            this.textBoxNacion.Location = new System.Drawing.Point(129, 264);
            this.textBoxNacion.Name = "textBoxNacion";
            this.textBoxNacion.Size = new System.Drawing.Size(202, 20);
            this.textBoxNacion.TabIndex = 8;
            // 
            // radioButtonH
            // 
            this.radioButtonH.AutoSize = true;
            this.radioButtonH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonH.Location = new System.Drawing.Point(129, 190);
            this.radioButtonH.Name = "radioButtonH";
            this.radioButtonH.Size = new System.Drawing.Size(34, 17);
            this.radioButtonH.TabIndex = 9;
            this.radioButtonH.TabStop = true;
            this.radioButtonH.Text = "H";
            this.radioButtonH.UseVisualStyleBackColor = true;
            // 
            // radioButtonM
            // 
            this.radioButtonM.AutoSize = true;
            this.radioButtonM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonM.Location = new System.Drawing.Point(195, 190);
            this.radioButtonM.Name = "radioButtonM";
            this.radioButtonM.Size = new System.Drawing.Size(35, 17);
            this.radioButtonM.TabIndex = 10;
            this.radioButtonM.TabStop = true;
            this.radioButtonM.Text = "M";
            this.radioButtonM.UseVisualStyleBackColor = true;
            this.radioButtonM.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "HISTORIAL CLINIC";
            // 
            // richTextBoxHist
            // 
            this.richTextBoxHist.Location = new System.Drawing.Point(22, 47);
            this.richTextBoxHist.Name = "richTextBoxHist";
            this.richTextBoxHist.Size = new System.Drawing.Size(422, 373);
            this.richTextBoxHist.TabIndex = 1;
            this.richTextBoxHist.Text = "";
            this.richTextBoxHist.TextChanged += new System.EventHandler(this.RichTextBox1_TextChanged);
            // 
            // toolStripButtonReturn
            // 
            this.toolStripButtonReturn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonReturn.Image = global::M07Examen2.Properties.Resources.icona_TornarEnrere;
            this.toolStripButtonReturn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonReturn.Name = "toolStripButtonReturn";
            this.toolStripButtonReturn.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonReturn.Text = "return";
            this.toolStripButtonReturn.Click += new System.EventHandler(this.ToolStripButtonReturn_Click);
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSave.Image = global::M07Examen2.Properties.Resources.icona_GuardarDades;
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSave.Text = "toolStripButtonSave";
            this.toolStripButtonSave.Click += new System.EventHandler(this.ToolStripButton2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 454);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.tabControl1.ResumeLayout(false);
            this.tabPageDG.ResumeLayout(false);
            this.tabPageDG.PerformLayout();
            this.tabPageIP.ResumeLayout(false);
            this.tabPageIP.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageDG;
        private System.Windows.Forms.RadioButton radioButtonM;
        private System.Windows.Forms.RadioButton radioButtonH;
        private System.Windows.Forms.TextBox textBoxNacion;
        private System.Windows.Forms.TextBox textBoxCognom;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelSexe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonVD;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TabPage tabPageIP;
        private System.Windows.Forms.ToolStripButton toolStripButtonReturn;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.RichTextBox richTextBoxHist;
        private System.Windows.Forms.Label label3;
    }
}