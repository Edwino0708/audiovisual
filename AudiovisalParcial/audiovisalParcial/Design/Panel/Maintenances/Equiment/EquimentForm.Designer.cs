﻿
namespace audiovisalParcial.Design.Panel.Equiment
{
    partial class EquimentForm
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
            this.cbxTypeTecnology = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxState = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxModel = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtServiceTag = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.lSerial = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.cxbMarca = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(236, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Agregar equipo";
            // 
            // btnAddEquipmentType
            // 
            this.btnAddEquipmentType.BackgroundImage = global::audiovisalParcial.Properties.Resources.save;
            this.btnAddEquipmentType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddEquipmentType.Location = new System.Drawing.Point(274, 454);
            this.btnAddEquipmentType.Name = "btnAddEquipmentType";
            this.btnAddEquipmentType.Size = new System.Drawing.Size(48, 35);
            this.btnAddEquipmentType.TabIndex = 17;
            this.btnAddEquipmentType.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.cbxTypeTecnology);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cbxState);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cbxType);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cbxModel);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtServiceTag);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtSerial);
            this.groupBox2.Controls.Add(this.lSerial);
            this.groupBox2.Controls.Add(this.txtDescription);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbxMarca);
            this.groupBox2.Controls.Add(this.cxbMarca);
            this.groupBox2.Location = new System.Drawing.Point(6, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(604, 332);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // cbxTypeTecnology
            // 
            this.cbxTypeTecnology.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTypeTecnology.FormattingEnabled = true;
            this.cbxTypeTecnology.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbxTypeTecnology.Location = new System.Drawing.Point(434, 102);
            this.cbxTypeTecnology.Name = "cbxTypeTecnology";
            this.cbxTypeTecnology.Size = new System.Drawing.Size(145, 21);
            this.cbxTypeTecnology.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Tecnologia conexion";
            // 
            // cbxState
            // 
            this.cbxState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxState.FormattingEnabled = true;
            this.cbxState.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbxState.Location = new System.Drawing.Point(398, 222);
            this.cbxState.Name = "cbxState";
            this.cbxState.Size = new System.Drawing.Size(184, 21);
            this.cbxState.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(322, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Estado";
            // 
            // cbxType
            // 
            this.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbxType.Location = new System.Drawing.Point(104, 98);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(184, 21);
            this.cbxType.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Tipo equipo";
            // 
            // cbxModel
            // 
            this.cbxModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxModel.FormattingEnabled = true;
            this.cbxModel.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbxModel.Location = new System.Drawing.Point(398, 35);
            this.cbxModel.Name = "cbxModel";
            this.cbxModel.Size = new System.Drawing.Size(184, 21);
            this.cbxModel.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(322, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Modelo";
            // 
            // txtServiceTag
            // 
            this.txtServiceTag.Location = new System.Drawing.Point(104, 223);
            this.txtServiceTag.Name = "txtServiceTag";
            this.txtServiceTag.Size = new System.Drawing.Size(184, 20);
            this.txtServiceTag.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Service Tag";
            // 
            // txtSerial
            // 
            this.txtSerial.Location = new System.Drawing.Point(398, 159);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(184, 20);
            this.txtSerial.TabIndex = 11;
            // 
            // lSerial
            // 
            this.lSerial.AutoSize = true;
            this.lSerial.Location = new System.Drawing.Point(322, 162);
            this.lSerial.Name = "lSerial";
            this.lSerial.Size = new System.Drawing.Size(53, 13);
            this.lSerial.TabIndex = 10;
            this.lSerial.Text = "No. Serial";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(104, 159);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(184, 20);
            this.txtDescription.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Descripción";
            // 
            // cbxMarca
            // 
            this.cbxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbxMarca.Location = new System.Drawing.Point(104, 36);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(184, 21);
            this.cbxMarca.TabIndex = 7;
            // 
            // cxbMarca
            // 
            this.cxbMarca.AutoSize = true;
            this.cxbMarca.Location = new System.Drawing.Point(28, 40);
            this.cxbMarca.Name = "cxbMarca";
            this.cxbMarca.Size = new System.Drawing.Size(37, 13);
            this.cxbMarca.TabIndex = 6;
            this.cxbMarca.Text = "Marca";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::audiovisalParcial.Properties.Resources.save;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(286, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 35);
            this.button1.TabIndex = 22;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EquimentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 389);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddEquipmentType);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EquimentForm";
            this.Text = "EquimentForm";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddEquipmentType;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbxTypeTecnology;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxState;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxModel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtServiceTag;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.Label lSerial;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.Label cxbMarca;
        private System.Windows.Forms.Button button1;
    }
}