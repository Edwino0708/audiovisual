
namespace audiovisalParcial.Design.Panel.Brand
{
    partial class Brand
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
            this.btnBrandAgregar = new System.Windows.Forms.Button();
            this.btnBrandBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBrandBuscar = new System.Windows.Forms.TextBox();
            this.dvgBrand = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgBrand)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnBrandAgregar);
            this.panel1.Controls.Add(this.btnBrandBuscar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtBrandBuscar);
            this.panel1.Location = new System.Drawing.Point(12, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 384);
            this.panel1.TabIndex = 0;
            // 
            // btnBrandAgregar
            // 
            this.btnBrandAgregar.Location = new System.Drawing.Point(105, 152);
            this.btnBrandAgregar.Name = "btnBrandAgregar";
            this.btnBrandAgregar.Size = new System.Drawing.Size(83, 72);
            this.btnBrandAgregar.TabIndex = 5;
            this.btnBrandAgregar.Text = "Agregar";
            this.btnBrandAgregar.UseVisualStyleBackColor = true;
            this.btnBrandAgregar.Click += new System.EventHandler(this.btnBrandAgregar_Click);
            // 
            // btnBrandBuscar
            // 
            this.btnBrandBuscar.Location = new System.Drawing.Point(13, 152);
            this.btnBrandBuscar.Name = "btnBrandBuscar";
            this.btnBrandBuscar.Size = new System.Drawing.Size(83, 72);
            this.btnBrandBuscar.TabIndex = 4;
            this.btnBrandBuscar.Text = "Buscar";
            this.btnBrandBuscar.UseVisualStyleBackColor = true;
            this.btnBrandBuscar.Click += new System.EventHandler(this.btnBrandBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Texto a buscar";
            // 
            // txtBrandBuscar
            // 
            this.txtBrandBuscar.Location = new System.Drawing.Point(13, 43);
            this.txtBrandBuscar.Name = "txtBrandBuscar";
            this.txtBrandBuscar.Size = new System.Drawing.Size(175, 20);
            this.txtBrandBuscar.TabIndex = 2;
            // 
            // dvgBrand
            // 
            this.dvgBrand.AllowUserToAddRows = false;
            this.dvgBrand.AllowUserToDeleteRows = false;
            this.dvgBrand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgBrand.Location = new System.Drawing.Point(14, 14);
            this.dvgBrand.Name = "dvgBrand";
            this.dvgBrand.ReadOnly = true;
            this.dvgBrand.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgBrand.Size = new System.Drawing.Size(546, 353);
            this.dvgBrand.TabIndex = 1;
            this.dvgBrand.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgBrand_CellDoubleClick);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dvgBrand);
            this.panel2.Location = new System.Drawing.Point(238, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(576, 384);
            this.panel2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 72);
            this.button1.TabIndex = 6;
            this.button1.Text = "Editar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(105, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 72);
            this.button2.TabIndex = 7;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Brand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 415);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Brand";
            this.Text = "Marcas";
            this.Activated += new System.EventHandler(this.Brand_Activated);
            this.Load += new System.EventHandler(this.Brand_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgBrand)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBrandAgregar;
        private System.Windows.Forms.Button btnBrandBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBrandBuscar;
        private System.Windows.Forms.DataGridView dvgBrand;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}