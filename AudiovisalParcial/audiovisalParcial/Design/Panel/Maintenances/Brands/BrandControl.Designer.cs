
namespace audiovisalParcial.Design.Panel.Maintenances.Brands
{
    partial class BrandControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRefreshMarca = new System.Windows.Forms.Button();
            this.btnAddMarca = new System.Windows.Forms.Button();
            this.btnUpdateMarca = new System.Windows.Forms.Button();
            this.btnDeleteMarca = new System.Windows.Forms.Button();
            this.dgvMarca = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearchMarca = new System.Windows.Forms.Button();
            this.txtBuscarMarca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxCriterioMarca = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lTitle = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarca)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnRefreshMarca);
            this.panel2.Controls.Add(this.btnAddMarca);
            this.panel2.Controls.Add(this.btnUpdateMarca);
            this.panel2.Controls.Add(this.btnDeleteMarca);
            this.panel2.Controls.Add(this.dgvMarca);
            this.panel2.Location = new System.Drawing.Point(4, 281);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1440, 1012);
            this.panel2.TabIndex = 11;
            // 
            // btnRefreshMarca
            // 
            this.btnRefreshMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnRefreshMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefreshMarca.Image = global::audiovisalParcial.Properties.Resources.refresh;
            this.btnRefreshMarca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefreshMarca.Location = new System.Drawing.Point(-2, 50);
            this.btnRefreshMarca.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnRefreshMarca.Name = "btnRefreshMarca";
            this.btnRefreshMarca.Size = new System.Drawing.Size(182, 69);
            this.btnRefreshMarca.TabIndex = 5;
            this.btnRefreshMarca.Text = "Refrescar";
            this.btnRefreshMarca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefreshMarca.UseVisualStyleBackColor = false;
            this.btnRefreshMarca.Click += new System.EventHandler(this.btnRefreshMarca_Click);
            // 
            // btnAddMarca
            // 
            this.btnAddMarca.BackColor = System.Drawing.Color.Teal;
            this.btnAddMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddMarca.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddMarca.Image = global::audiovisalParcial.Properties.Resources.add;
            this.btnAddMarca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddMarca.Location = new System.Drawing.Point(838, 50);
            this.btnAddMarca.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAddMarca.Name = "btnAddMarca";
            this.btnAddMarca.Size = new System.Drawing.Size(186, 69);
            this.btnAddMarca.TabIndex = 10;
            this.btnAddMarca.Text = "Agregar";
            this.btnAddMarca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddMarca.UseVisualStyleBackColor = false;
            this.btnAddMarca.Click += new System.EventHandler(this.btnAddMarca_Click);
            // 
            // btnUpdateMarca
            // 
            this.btnUpdateMarca.BackColor = System.Drawing.Color.Blue;
            this.btnUpdateMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateMarca.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdateMarca.Image = global::audiovisalParcial.Properties.Resources.update;
            this.btnUpdateMarca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateMarca.Location = new System.Drawing.Point(1034, 50);
            this.btnUpdateMarca.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnUpdateMarca.Name = "btnUpdateMarca";
            this.btnUpdateMarca.Size = new System.Drawing.Size(204, 69);
            this.btnUpdateMarca.TabIndex = 9;
            this.btnUpdateMarca.Text = "Actualizar";
            this.btnUpdateMarca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateMarca.UseVisualStyleBackColor = false;
            this.btnUpdateMarca.Click += new System.EventHandler(this.btnUpdateMarca_Click);
            // 
            // btnDeleteMarca
            // 
            this.btnDeleteMarca.BackColor = System.Drawing.Color.Red;
            this.btnDeleteMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteMarca.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteMarca.Image = global::audiovisalParcial.Properties.Resources.delete;
            this.btnDeleteMarca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteMarca.Location = new System.Drawing.Point(1252, 50);
            this.btnDeleteMarca.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDeleteMarca.Name = "btnDeleteMarca";
            this.btnDeleteMarca.Size = new System.Drawing.Size(188, 69);
            this.btnDeleteMarca.TabIndex = 5;
            this.btnDeleteMarca.Text = "Eliminar";
            this.btnDeleteMarca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteMarca.UseVisualStyleBackColor = false;
            this.btnDeleteMarca.Click += new System.EventHandler(this.btnDeleteMarca_Click);
            // 
            // dgvMarca
            // 
            this.dgvMarca.AllowUserToAddRows = false;
            this.dgvMarca.AllowUserToDeleteRows = false;
            this.dgvMarca.AllowUserToResizeColumns = false;
            this.dgvMarca.AllowUserToResizeRows = false;
            this.dgvMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMarca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarca.Location = new System.Drawing.Point(6, 131);
            this.dgvMarca.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgvMarca.Name = "dgvMarca";
            this.dgvMarca.ReadOnly = true;
            this.dgvMarca.RowHeadersWidth = 82;
            this.dgvMarca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMarca.Size = new System.Drawing.Size(1428, 894);
            this.dgvMarca.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnSearchMarca);
            this.groupBox1.Controls.Add(this.txtBuscarMarca);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbxCriterioMarca);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 140);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(1448, 131);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscador";
            // 
            // btnSearchMarca
            // 
            this.btnSearchMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSearchMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchMarca.Image = global::audiovisalParcial.Properties.Resources.search;
            this.btnSearchMarca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchMarca.Location = new System.Drawing.Point(1310, 50);
            this.btnSearchMarca.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSearchMarca.Name = "btnSearchMarca";
            this.btnSearchMarca.Size = new System.Drawing.Size(134, 69);
            this.btnSearchMarca.TabIndex = 4;
            this.btnSearchMarca.Text = "Buscar";
            this.btnSearchMarca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearchMarca.UseVisualStyleBackColor = false;
            this.btnSearchMarca.Click += new System.EventHandler(this.btnSearchMarca_Click);
            // 
            // txtBuscarMarca
            // 
            this.txtBuscarMarca.Location = new System.Drawing.Point(824, 54);
            this.txtBuscarMarca.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtBuscarMarca.Name = "txtBuscarMarca";
            this.txtBuscarMarca.Size = new System.Drawing.Size(368, 31);
            this.txtBuscarMarca.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(652, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor a buscar";
            // 
            // cbxCriterioMarca
            // 
            this.cbxCriterioMarca.FormattingEnabled = true;
            this.cbxCriterioMarca.Items.AddRange(new object[] {
            "Descripcion"});
            this.cbxCriterioMarca.Location = new System.Drawing.Point(300, 58);
            this.cbxCriterioMarca.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbxCriterioMarca.Name = "cbxCriterioMarca";
            this.cbxCriterioMarca.Size = new System.Drawing.Size(238, 33);
            this.cbxCriterioMarca.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Criterio";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lTitle);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1440, 129);
            this.panel1.TabIndex = 10;
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("Constantia", 14F, System.Drawing.FontStyle.Bold);
            this.lTitle.Location = new System.Drawing.Point(414, 38);
            this.lTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(645, 46);
            this.lTitle.TabIndex = 0;
            this.lTitle.Text = "Mantenimiento de Tipos de Marcas";
            // 
            // BrandControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "BrandControl";
            this.Size = new System.Drawing.Size(1448, 1296);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarca)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRefreshMarca;
        private System.Windows.Forms.Button btnAddMarca;
        private System.Windows.Forms.Button btnUpdateMarca;
        private System.Windows.Forms.Button btnDeleteMarca;
        private System.Windows.Forms.DataGridView dgvMarca;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearchMarca;
        private System.Windows.Forms.TextBox txtBuscarMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxCriterioMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lTitle;
    }
}
