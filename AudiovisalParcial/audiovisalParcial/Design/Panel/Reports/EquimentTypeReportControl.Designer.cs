
namespace audiovisalParcial.Design.Panel.Reports
{
    partial class EquimentTypeReportControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(431, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(530, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Exportar reporte para Excel";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(486, 473);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(404, 116);
            this.button3.TabIndex = 3;
            this.button3.Text = "General Archivo";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // EquimentTypeReportControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Name = "EquimentTypeReportControl";
            this.Size = new System.Drawing.Size(1376, 1084);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
    }
}
