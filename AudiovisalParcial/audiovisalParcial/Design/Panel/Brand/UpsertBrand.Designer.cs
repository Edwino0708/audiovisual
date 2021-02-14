
namespace audiovisalParcial.Design.Panel.Brand
{
    partial class UpsertBrand
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBrandDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrandGuardar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnBrandGuardar);
            this.panel1.Controls.Add(this.txtBrandDescripcion);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(21, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 221);
            this.panel1.TabIndex = 0;
            // 
            // txtBrandDescripcion
            // 
            this.txtBrandDescripcion.Location = new System.Drawing.Point(55, 72);
            this.txtBrandDescripcion.Name = "txtBrandDescripcion";
            this.txtBrandDescripcion.Size = new System.Drawing.Size(271, 20);
            this.txtBrandDescripcion.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripcion";
            // 
            // btnBrandGuardar
            // 
            this.btnBrandGuardar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnBrandGuardar.BackgroundImage = global::audiovisalParcial.Properties.Resources.save;
            this.btnBrandGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBrandGuardar.Location = new System.Drawing.Point(133, 98);
            this.btnBrandGuardar.Name = "btnBrandGuardar";
            this.btnBrandGuardar.Size = new System.Drawing.Size(120, 92);
            this.btnBrandGuardar.TabIndex = 2;
            this.btnBrandGuardar.UseVisualStyleBackColor = false;
            this.btnBrandGuardar.Click += new System.EventHandler(this.btnBrandGuardar_Click);
            // 
            // UpsertBrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(414, 245);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UpsertBrand";
            this.Text = "UpsertBrand";
            this.Load += new System.EventHandler(this.UpsertBrand_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBrandGuardar;
        private System.Windows.Forms.TextBox txtBrandDescripcion;
        private System.Windows.Forms.Label label1;
    }
}