
namespace audiovisalParcial.Design.Panel.Reports
{
    partial class ReportControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lTitle = new System.Windows.Forms.Label();
            this.btnequipoRep = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("Constantia", 14F, System.Drawing.FontStyle.Bold);
            this.lTitle.Location = new System.Drawing.Point(352, 75);
            this.lTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(398, 46);
            this.lTitle.TabIndex = 19;
            this.lTitle.Text = "Creacion de Reportes";
            // 
            // btnequipoRep
            // 
            this.btnequipoRep.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold);
            this.btnequipoRep.Location = new System.Drawing.Point(176, 261);
            this.btnequipoRep.Name = "btnequipoRep";
            this.btnequipoRep.Size = new System.Drawing.Size(309, 89);
            this.btnequipoRep.TabIndex = 20;
            this.btnequipoRep.Text = "Equipo";
            this.btnequipoRep.UseVisualStyleBackColor = true;
            this.btnequipoRep.Click += new System.EventHandler(this.btnequipoRep_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(612, 261);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(309, 89);
            this.button2.TabIndex = 21;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ReportControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnequipoRep);
            this.Controls.Add(this.lTitle);
            this.Name = "ReportControl";
            this.Size = new System.Drawing.Size(1097, 470);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.Button btnequipoRep;
        private System.Windows.Forms.Button button2;
    }
}
