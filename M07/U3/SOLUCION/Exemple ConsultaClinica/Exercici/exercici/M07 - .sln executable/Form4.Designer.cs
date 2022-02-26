namespace M07Examen2
{
    partial class Form4
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
            this.buttonRP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRP
            // 
            this.buttonRP.Location = new System.Drawing.Point(228, 396);
            this.buttonRP.Name = "buttonRP";
            this.buttonRP.Size = new System.Drawing.Size(89, 59);
            this.buttonRP.TabIndex = 0;
            this.buttonRP.Text = "Resum Pacients";
            this.buttonRP.UseVisualStyleBackColor = true;
            this.buttonRP.Click += new System.EventHandler(this.ButtonRP_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 467);
            this.Controls.Add(this.buttonRP);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dades Pacients";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRP;
    }
}