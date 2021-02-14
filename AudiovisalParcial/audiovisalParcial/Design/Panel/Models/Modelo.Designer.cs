
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnModeloEliminar = new System.Windows.Forms.Button();
            this.btnModeloEditar = new System.Windows.Forms.Button();
            this.btnModeloAgregar = new System.Windows.Forms.Button();
            this.btnModeloBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtModeloBuscar = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgModelo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dvgModelo);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtModeloBuscar);
            this.panel2.Location = new System.Drawing.Point(255, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(576, 384);
            this.panel2.TabIndex = 6;
            // 
            // dvgModelo
            // 
            this.dvgModelo.AllowUserToAddRows = false;
            this.dvgModelo.AllowUserToDeleteRows = false;
            this.dvgModelo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgModelo.Location = new System.Drawing.Point(14, 40);
            this.dvgModelo.Name = "dvgModelo";
            this.dvgModelo.ReadOnly = true;
            this.dvgModelo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgModelo.Size = new System.Drawing.Size(546, 327);
            this.dvgModelo.TabIndex = 1;
            this.dvgModelo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgModelo_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbxMarca);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnModeloEliminar);
            this.panel1.Controls.Add(this.btnModeloEditar);
            this.panel1.Controls.Add(this.btnModeloAgregar);
            this.panel1.Controls.Add(this.btnModeloBuscar);
            this.panel1.Location = new System.Drawing.Point(12, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 384);
            this.panel1.TabIndex = 5;
            // 
            // cbxMarca
            // 
            this.cbxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(44, 18);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(114, 21);
            this.cbxMarca.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Marca";
            // 
            // btnModeloEliminar
            // 
            this.btnModeloEliminar.Location = new System.Drawing.Point(129, 84);
            this.btnModeloEliminar.Name = "btnModeloEliminar";
            this.btnModeloEliminar.Size = new System.Drawing.Size(83, 72);
            this.btnModeloEliminar.TabIndex = 7;
            this.btnModeloEliminar.Text = "Eliminar";
            this.btnModeloEliminar.UseVisualStyleBackColor = true;
            this.btnModeloEliminar.Click += new System.EventHandler(this.btnModeloEliminar_Click);
            // 
            // btnModeloEditar
            // 
            this.btnModeloEditar.Location = new System.Drawing.Point(75, 174);
            this.btnModeloEditar.Name = "btnModeloEditar";
            this.btnModeloEditar.Size = new System.Drawing.Size(83, 72);
            this.btnModeloEditar.TabIndex = 6;
            this.btnModeloEditar.Text = "Editar";
            this.btnModeloEditar.UseVisualStyleBackColor = true;
            this.btnModeloEditar.Click += new System.EventHandler(this.btnModeloEditar_Click);
            // 
            // btnModeloAgregar
            // 
            this.btnModeloAgregar.Location = new System.Drawing.Point(9, 84);
            this.btnModeloAgregar.Name = "btnModeloAgregar";
            this.btnModeloAgregar.Size = new System.Drawing.Size(83, 72);
            this.btnModeloAgregar.TabIndex = 5;
            this.btnModeloAgregar.Text = "Agregar";
            this.btnModeloAgregar.UseVisualStyleBackColor = true;
            this.btnModeloAgregar.Click += new System.EventHandler(this.btnModeloAgregar_Click);
            // 
            // btnModeloBuscar
            // 
            this.btnModeloBuscar.Location = new System.Drawing.Point(164, 19);
            this.btnModeloBuscar.Name = "btnModeloBuscar";
            this.btnModeloBuscar.Size = new System.Drawing.Size(58, 20);
            this.btnModeloBuscar.TabIndex = 4;
            this.btnModeloBuscar.Text = "Buscar";
            this.btnModeloBuscar.UseVisualStyleBackColor = true;
            this.btnModeloBuscar.Click += new System.EventHandler(this.btnModeloBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Texto a buscar";
            // 
            // txtModeloBuscar
            // 
            this.txtModeloBuscar.Location = new System.Drawing.Point(95, 11);
            this.txtModeloBuscar.Name = "txtModeloBuscar";
            this.txtModeloBuscar.Size = new System.Drawing.Size(465, 20);
            this.txtModeloBuscar.TabIndex = 2;
            this.txtModeloBuscar.TextChanged += new System.EventHandler(this.txtModeloBuscar_TextChanged);
            // 
            // Modelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
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