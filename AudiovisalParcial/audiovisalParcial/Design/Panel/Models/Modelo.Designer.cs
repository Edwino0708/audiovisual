
namespace audiovisalParcial.Design.Panel.Models
{
    partial class Modelo
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dvgModelo = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtModeloBuscar = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnModeloEliminar = new System.Windows.Forms.Button();
            this.btnModeloEditar = new System.Windows.Forms.Button();
            this.btnModeloAgregar = new System.Windows.Forms.Button();
            this.btnModeloBuscar = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgModelo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dvgModelo);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtModeloBuscar);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(576, 384);
            this.panel2.TabIndex = 6;
            // 
            // dvgModelo
            // 
            this.dvgModelo.AllowUserToAddRows = false;
            this.dvgModelo.AllowUserToDeleteRows = false;
            this.dvgModelo.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dvgModelo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgModelo.Location = new System.Drawing.Point(14, 40);
            this.dvgModelo.Name = "dvgModelo";
            this.dvgModelo.ReadOnly = true;
            this.dvgModelo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgModelo.Size = new System.Drawing.Size(546, 327);
            this.dvgModelo.TabIndex = 1;
            this.dvgModelo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgModelo_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Buscar por descripcion";
            // 
            // txtModeloBuscar
            // 
            this.txtModeloBuscar.Location = new System.Drawing.Point(170, 13);
            this.txtModeloBuscar.Name = "txtModeloBuscar";
            this.txtModeloBuscar.Size = new System.Drawing.Size(390, 20);
            this.txtModeloBuscar.TabIndex = 2;
            this.txtModeloBuscar.TextChanged += new System.EventHandler(this.txtModeloBuscar_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbxMarca);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnModeloEliminar);
            this.panel1.Controls.Add(this.btnModeloEditar);
            this.panel1.Controls.Add(this.btnModeloAgregar);
            this.panel1.Controls.Add(this.btnModeloBuscar);
            this.panel1.Location = new System.Drawing.Point(605, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 384);
            this.panel1.TabIndex = 5;
            // 
            // cbxMarca
            // 
            this.cbxMarca.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cbxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(53, 13);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(131, 21);
            this.cbxMarca.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Marca";
            // 
            // btnModeloEliminar
            // 
            this.btnModeloEliminar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnModeloEliminar.BackgroundImage = global::audiovisalParcial.Properties.Resources.delete;
            this.btnModeloEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModeloEliminar.Location = new System.Drawing.Point(84, 261);
            this.btnModeloEliminar.Name = "btnModeloEliminar";
            this.btnModeloEliminar.Size = new System.Drawing.Size(83, 72);
            this.btnModeloEliminar.TabIndex = 7;
            this.btnModeloEliminar.UseVisualStyleBackColor = false;
            this.btnModeloEliminar.Click += new System.EventHandler(this.btnModeloEliminar_Click);
            // 
            // btnModeloEditar
            // 
            this.btnModeloEditar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnModeloEditar.BackgroundImage = global::audiovisalParcial.Properties.Resources.edit;
            this.btnModeloEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModeloEditar.Location = new System.Drawing.Point(84, 154);
            this.btnModeloEditar.Name = "btnModeloEditar";
            this.btnModeloEditar.Size = new System.Drawing.Size(83, 72);
            this.btnModeloEditar.TabIndex = 6;
            this.btnModeloEditar.UseVisualStyleBackColor = false;
            this.btnModeloEditar.Click += new System.EventHandler(this.btnModeloEditar_Click);
            // 
            // btnModeloAgregar
            // 
            this.btnModeloAgregar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnModeloAgregar.BackgroundImage = global::audiovisalParcial.Properties.Resources.plus;
            this.btnModeloAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModeloAgregar.Location = new System.Drawing.Point(84, 55);
            this.btnModeloAgregar.Name = "btnModeloAgregar";
            this.btnModeloAgregar.Size = new System.Drawing.Size(83, 72);
            this.btnModeloAgregar.TabIndex = 5;
            this.btnModeloAgregar.UseVisualStyleBackColor = false;
            this.btnModeloAgregar.Click += new System.EventHandler(this.btnModeloAgregar_Click);
            // 
            // btnModeloBuscar
            // 
            this.btnModeloBuscar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnModeloBuscar.BackgroundImage = global::audiovisalParcial.Properties.Resources.search;
            this.btnModeloBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModeloBuscar.Location = new System.Drawing.Point(190, 3);
            this.btnModeloBuscar.Name = "btnModeloBuscar";
            this.btnModeloBuscar.Size = new System.Drawing.Size(67, 46);
            this.btnModeloBuscar.TabIndex = 4;
            this.btnModeloBuscar.UseVisualStyleBackColor = false;
            this.btnModeloBuscar.Click += new System.EventHandler(this.btnModeloBuscar_Click);
            // 
            // Modelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(893, 432);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Modelo";
            this.Text = "Modelo";
            this.Activated += new System.EventHandler(this.Modelo_Activated);
            this.Load += new System.EventHandler(this.Modelo_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgModelo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dvgModelo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnModeloEliminar;
        private System.Windows.Forms.Button btnModeloEditar;
        private System.Windows.Forms.Button btnModeloAgregar;
        private System.Windows.Forms.Button btnModeloBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtModeloBuscar;
    }
}