
namespace audiovisalParcial.Design.Panel.Home
{
    partial class HomeTeacherControl
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
            this.label1.Location = new System.Drawing.Point(342, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(763, 78);
            this.label1.TabIndex = 8;
            this.label1.Text = "Bienvenido Profesor";
            // 
            // label4
            // 
            this.label4.Image = global::audiovisalParcial.Properties.Resources.teacher;
            this.label4.Location = new System.Drawing.Point(253, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(881, 665);
            this.label4.TabIndex = 9;
            // 
            // HomeTeacherControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "HomeTeacherControl";
            this.Size = new System.Drawing.Size(1474, 1092);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}
