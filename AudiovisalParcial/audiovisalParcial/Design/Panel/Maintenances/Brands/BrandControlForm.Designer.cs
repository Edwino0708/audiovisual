
namespace audiovisalParcial.Design.Panel.Maintenances.Brands
{
    partial class BrandControlForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddMarca = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxStateMarca = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescriptionMarca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(336, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 49);
            this.label1.TabIndex = 13;
            this.label1.Text = "Agregar Marca";
            // 
            // btnAddMarca
            // 
            this.btnAddMarca.BackgroundImage = global::audiovisalParcial.Properties.Resources.save;
            this.btnAddMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddMarca.Enabled = false;
            this.btnAddMarca.Location = new System.Drawing.Point(414, 415);
            this.btnAddMarca.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAddMarca.Name = "btnAddMarca";
            this.btnAddMarca.Size = new System.Drawing.Size(96, 67);
            this.btnAddMarca.TabIndex = 14;
            this.btnAddMarca.UseVisualStyleBackColor = true;
            this.btnAddMarca.Click += new System.EventHandler(this.btnAddMarca_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxStateMarca);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtDescriptionMarca);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(100, 117);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Size = new System.Drawing.Size(676, 263);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // cbxStateMarca
            // 
            this.cbxStateMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStateMarca.FormattingEnabled = true;
            this.cbxStateMarca.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbxStateMarca.Location = new System.Drawing.Point(200, 160);
            this.cbxStateMarca.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbxStateMarca.Name = "cbxStateMarca";
            this.cbxStateMarca.Size = new System.Drawing.Size(364, 33);
            this.cbxStateMarca.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 167);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Estado";
            // 
            // txtDescriptionMarca
            // 
            this.txtDescriptionMarca.Location = new System.Drawing.Point(200, 73);
            this.txtDescriptionMarca.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtDescriptionMarca.Name = "txtDescriptionMarca";
            this.txtDescriptionMarca.Size = new System.Drawing.Size(364, 31);
            this.txtDescriptionMarca.TabIndex = 3;
            this.txtDescriptionMarca.TextChanged += new System.EventHandler(this.txtDescriptionMarca_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripcion";
            // 
            // BrandControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 531);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddMarca);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "BrandControlForm";
            this.Text = "BrandControlForm";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddMarca;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbxStateMarca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescriptionMarca;
        private System.Windows.Forms.Label label2;
    }
}