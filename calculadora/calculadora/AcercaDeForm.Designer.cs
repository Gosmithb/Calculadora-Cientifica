
namespace calculadora
{
    partial class AcercaDeForm
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
            this.acercaDe_Lbl = new System.Windows.Forms.Label();
            this.acercaDe2_Lbl = new System.Windows.Forms.Label();
            this.acercaDe3_Lbl = new System.Windows.Forms.Label();
            this.acerdaDe4_Lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // acercaDe_Lbl
            // 
            this.acercaDe_Lbl.AutoSize = true;
            this.acercaDe_Lbl.Location = new System.Drawing.Point(74, 9);
            this.acercaDe_Lbl.Name = "acercaDe_Lbl";
            this.acercaDe_Lbl.Size = new System.Drawing.Size(115, 13);
            this.acercaDe_Lbl.TabIndex = 0;
            this.acercaDe_Lbl.Text = "Desarrolado por: Bryan";
            // 
            // acercaDe2_Lbl
            // 
            this.acercaDe2_Lbl.AutoSize = true;
            this.acercaDe2_Lbl.Location = new System.Drawing.Point(90, 56);
            this.acercaDe2_Lbl.Name = "acercaDe2_Lbl";
            this.acercaDe2_Lbl.Size = new System.Drawing.Size(76, 13);
            this.acercaDe2_Lbl.TabIndex = 1;
            this.acercaDe2_Lbl.Text = "Tel: 62514858";
            // 
            // acercaDe3_Lbl
            // 
            this.acercaDe3_Lbl.AutoSize = true;
            this.acercaDe3_Lbl.Location = new System.Drawing.Point(45, 81);
            this.acercaDe3_Lbl.Name = "acercaDe3_Lbl";
            this.acercaDe3_Lbl.Size = new System.Drawing.Size(157, 13);
            this.acercaDe3_Lbl.TabIndex = 2;
            this.acercaDe3_Lbl.Text = "Email: compuloco@hotmail.com";
            // 
            // acerdaDe4_Lbl
            // 
            this.acerdaDe4_Lbl.AutoSize = true;
            this.acerdaDe4_Lbl.Location = new System.Drawing.Point(68, 107);
            this.acerdaDe4_Lbl.Name = "acerdaDe4_Lbl";
            this.acerdaDe4_Lbl.Size = new System.Drawing.Size(134, 13);
            this.acerdaDe4_Lbl.TabIndex = 3;
            this.acerdaDe4_Lbl.Text = "Direccion: Hmo, Son, Mex.";
            // 
            // AcercaDEForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 142);
            this.Controls.Add(this.acerdaDe4_Lbl);
            this.Controls.Add(this.acercaDe3_Lbl);
            this.Controls.Add(this.acercaDe2_Lbl);
            this.Controls.Add(this.acercaDe_Lbl);
            this.Name = "AcercaDEForm";
            this.Text = "Acerca de";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label acercaDe_Lbl;
        private System.Windows.Forms.Label acercaDe2_Lbl;
        private System.Windows.Forms.Label acercaDe3_Lbl;
        private System.Windows.Forms.Label acerdaDe4_Lbl;
    }
}