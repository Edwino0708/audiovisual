
namespace audiovisalParcial.Design.Panel.Brand
{
    partial class BrandForm
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
            this.btnAddEquipmentType = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxState = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(408, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 49);
            this.label1.TabIndex = 13;
            this.label1.Text = "Agregar marca";
            // 
            // btnAddEquipmentType
            // 
            this.btnAddEquipmentType.BackgroundImage = global::audiovisalParcial.Properties.Resources.save;
            this.btnAddEquipmentType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddEquipmentType.Location = new System.Drawing.Point(517, 463);
            this.btnAddEquipmentType.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddEquipmentType.Name = "btnAddEquipmentType";
            this.btnAddEquipmentType.Size = new System.Drawing.Size(96, 67);
            this.btnAddEquipmentType.TabIndex = 14;
            this.btnAddEquipmentType.UseVisualStyleBackColor = true;
            this.btnAddEquipmentType.Click += new System.EventHandler(this.btnAddEquipmentType_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxState);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtDescription);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(231, 162);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(675, 277);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // cbxState
            // 
            this.cbxState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxState.FormattingEnabled = true;
            this.cbxState.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbxState.Location = new System.Drawing.Point(200, 160);
            this.cbxState.Margin = new System.Windows.Forms.Padding(6);
            this.cbxState.Name = "cbxState";
            this.cbxState.Size = new System.Drawing.Size(364, 33);
            this.cbxState.TabIndex = 7;
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
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(200, 73);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(6);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(364, 31);
            this.txtDescription.TabIndex = 3;
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
            // FormBrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 588);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddEquipmentType);
            this.Controls.Add(this.groupBox2);
            this.Name = "FormBrand";
            this.Text = "FormBrand";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddEquipmentType;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbxState;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label2;
    }
}