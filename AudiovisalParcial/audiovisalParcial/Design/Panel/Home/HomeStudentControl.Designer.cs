﻿
namespace audiovisalParcial.Design.Panel.Home
{
    partial class HomeStudentControl
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
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 25.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(838, 78);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bienvenido Estudiante";
            // 
            // label4
            // 
            this.label4.Image = global::audiovisalParcial.Properties.Resources.student;
            this.label4.Location = new System.Drawing.Point(347, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(706, 568);
            this.label4.TabIndex = 7;
            // 
            // HomeStudentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "HomeStudentControl";
            this.Size = new System.Drawing.Size(1474, 1092);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}
