
namespace audiovisalParcial.Design.Panel.Users
{
    partial class UsersForm
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
            this.label8 = new System.Windows.Forms.Label();
            this.cbxPersonalTtype = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbCarnet = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbIdentificationCard = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxUserType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(471, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 49);
            this.label1.TabIndex = 13;
            this.label1.Text = "Agregar usuario";
            // 
            // btnAddEquipmentType
            // 
            this.btnAddEquipmentType.BackgroundImage = global::audiovisalParcial.Properties.Resources.save;
            this.btnAddEquipmentType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddEquipmentType.Location = new System.Drawing.Point(557, 565);
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
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cbxPersonalTtype);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txbCarnet);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txbIdentificationCard);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txbLastName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbxUserType);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txbFirstName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(42, 100);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(1140, 436);
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
            this.cbxState.Location = new System.Drawing.Point(162, 344);
            this.cbxState.Margin = new System.Windows.Forms.Padding(6);
            this.cbxState.Name = "cbxState";
            this.cbxState.Size = new System.Drawing.Size(364, 33);
            this.cbxState.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 351);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Estado";
            // 
            // cbxPersonalTtype
            // 
            this.cbxPersonalTtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPersonalTtype.FormattingEnabled = true;
            this.cbxPersonalTtype.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbxPersonalTtype.Location = new System.Drawing.Point(758, 252);
            this.cbxPersonalTtype.Margin = new System.Windows.Forms.Padding(6);
            this.cbxPersonalTtype.Name = "cbxPersonalTtype";
            this.cbxPersonalTtype.Size = new System.Drawing.Size(364, 33);
            this.cbxPersonalTtype.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(606, 259);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Tipo Persona";
            // 
            // txbCarnet
            // 
            this.txbCarnet.Location = new System.Drawing.Point(758, 154);
            this.txbCarnet.Margin = new System.Windows.Forms.Padding(6);
            this.txbCarnet.Name = "txbCarnet";
            this.txbCarnet.Size = new System.Drawing.Size(364, 31);
            this.txbCarnet.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(606, 160);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "No. Carnet";
            // 
            // txbIdentificationCard
            // 
            this.txbIdentificationCard.Location = new System.Drawing.Point(162, 154);
            this.txbIdentificationCard.Margin = new System.Windows.Forms.Padding(6);
            this.txbIdentificationCard.Name = "txbIdentificationCard";
            this.txbIdentificationCard.Size = new System.Drawing.Size(364, 31);
            this.txbIdentificationCard.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 160);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cedula";
            // 
            // txbLastName
            // 
            this.txbLastName.Location = new System.Drawing.Point(758, 51);
            this.txbLastName.Margin = new System.Windows.Forms.Padding(6);
            this.txbLastName.Name = "txbLastName";
            this.txbLastName.Size = new System.Drawing.Size(364, 31);
            this.txbLastName.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(606, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Apellido";
            // 
            // cbxUserType
            // 
            this.cbxUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUserType.FormattingEnabled = true;
            this.cbxUserType.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbxUserType.Location = new System.Drawing.Point(162, 253);
            this.cbxUserType.Margin = new System.Windows.Forms.Padding(6);
            this.cbxUserType.Name = "cbxUserType";
            this.cbxUserType.Size = new System.Drawing.Size(364, 33);
            this.cbxUserType.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 260);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tipo usuario";
            // 
            // txbFirstName
            // 
            this.txbFirstName.Location = new System.Drawing.Point(162, 51);
            this.txbFirstName.Margin = new System.Windows.Forms.Padding(6);
            this.txbFirstName.Name = "txbFirstName";
            this.txbFirstName.Size = new System.Drawing.Size(364, 31);
            this.txbFirstName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 670);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddEquipmentType);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UsersForm";
            this.Text = "UsersForm";
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxPersonalTtype;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbCarnet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbIdentificationCard;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxUserType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbFirstName;
        private System.Windows.Forms.Label label2;
    }
}