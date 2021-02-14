
namespace audiovisalParcial.Design.Panel.Models
{
    partial class UpsertModelo
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
            this.btnBrandGuardar = new System.Windows.Forms.Button();
            this.txtModeloDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxUpsertMarcas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbxUpsertMarcas);
            this.panel1.Controls.Add(this.btnBrandGuardar);
            this.panel1.Controls.Add(this.txtModeloDescripcion);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 221);
            this.panel1.TabIndex = 1;
            // 
            // btnBrandGuardar
            // 
            this.btnBrandGuardar.Location = new System.Drawing.Point(186, 124);
            this.btnBrandGuardar.Name = "btnBrandGuardar";
            this.btnBrandGuardar.Size = new System.Drawing.Size(83, 54);
            this.btnBrandGuardar.TabIndex = 2;
            this.btnBrandGuardar.Text = "Guardar";
            this.btnBrandGuardar.UseVisualStyleBackColor = true;
            this.btnBrandGuardar.Click += new System.EventHandler(this.btnBrandGuardar_Click);
            // 
            // txtModeloDescripcion
            // 
            this.txtModeloDescripcion.Location = new System.Drawing.Point(269, 80);
            this.txtModeloDescripcion.Name = "txtModeloDescripcion";
            this.txtModeloDescripcion.Size = new System.Drawing.Size(194, 20);
            this.txtModeloDescripcion.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripcion";
            // 
            // cbxUpsertMarcas
            // 
            this.cbxUpsertMarcas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUpsertMarcas.FormattingEnabled = true;
            this.cbxUpsertMarcas.Location = new System.Drawing.Point(17, 79);
            this.cbxUpsertMarcas.Name = "cbxUpsertMarcas";
            this.cbxUpsertMarcas.Size = new System.Drawing.Size(163, 21);
            this.cbxUpsertMarcas.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Marca";
            // 
            // UpsertModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 263);
            this.Controls.Add(this.panel1);
            this.Name = "UpsertModelo";
            this.Text = "UpsertModelo";
            this.Load += new System.EventHandler(this.UpsertModelo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxUpsertMarcas;
        private System.Windows.Forms.Button btnBrandGuardar;
        private System.Windows.Forms.TextBox txtModeloDescripcion;
        private System.Windows.Forms.Label label1;
    }
}