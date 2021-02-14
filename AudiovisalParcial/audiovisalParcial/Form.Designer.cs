
namespace audiovisalParcial
{
    partial class Form1
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
            this.pMenu = new System.Windows.Forms.Panel();
            this.pMenuHeader = new System.Windows.Forms.Panel();
            this.lMenu = new System.Windows.Forms.Label();
            this.lMenuTitle = new System.Windows.Forms.Label();
            this.lLogo = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMenuOption1 = new System.Windows.Forms.Button();
            this.btnMenuOption2 = new System.Windows.Forms.Button();
            this.btnMenuOption3 = new System.Windows.Forms.Button();
            this.btnMenuOption4 = new System.Windows.Forms.Button();
            this.btnMenuOption5 = new System.Windows.Forms.Button();
            this.btnMenuOption6 = new System.Windows.Forms.Button();
            this.btnMenuOption7 = new System.Windows.Forms.Button();
            this.btnMenuOption8 = new System.Windows.Forms.Button();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pBodySub = new System.Windows.Forms.Panel();
            this.pBody = new System.Windows.Forms.Panel();
            this.pMenu.SuspendLayout();
            this.pMenuHeader.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // pMenu
            // 
            this.pMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pMenu.Controls.Add(this.pMenuHeader);
            this.pMenu.Controls.Add(this.btnExit);
            this.pMenu.Controls.Add(this.flowLayoutPanel1);
            this.pMenu.Controls.Add(this.splitter2);
            this.pMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pMenu.Location = new System.Drawing.Point(0, 0);
            this.pMenu.Margin = new System.Windows.Forms.Padding(4);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(518, 1525);
            this.pMenu.TabIndex = 0;
            // 
            // pMenuHeader
            // 
            this.pMenuHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pMenuHeader.Controls.Add(this.lMenu);
            this.pMenuHeader.Controls.Add(this.lMenuTitle);
            this.pMenuHeader.Controls.Add(this.lLogo);
            this.pMenuHeader.Location = new System.Drawing.Point(0, 0);
            this.pMenuHeader.Margin = new System.Windows.Forms.Padding(4);
            this.pMenuHeader.Name = "pMenuHeader";
            this.pMenuHeader.Size = new System.Drawing.Size(518, 293);
            this.pMenuHeader.TabIndex = 5;
            // 
            // lMenu
            // 
            this.lMenu.Image = global::audiovisalParcial.Properties.Resources.menu;
            this.lMenu.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lMenu.Location = new System.Drawing.Point(420, 0);
            this.lMenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lMenu.Name = "lMenu";
            this.lMenu.Size = new System.Drawing.Size(102, 76);
            this.lMenu.TabIndex = 7;
            // 
            // lMenuTitle
            // 
            this.lMenuTitle.AutoSize = true;
            this.lMenuTitle.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMenuTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lMenuTitle.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lMenuTitle.Location = new System.Drawing.Point(76, 193);
            this.lMenuTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lMenuTitle.Name = "lMenuTitle";
            this.lMenuTitle.Size = new System.Drawing.Size(381, 39);
            this.lMenuTitle.TabIndex = 6;
            this.lMenuTitle.Text = "Sistema de Audivisuales";
            this.lMenuTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lLogo
            // 
            this.lLogo.Image = global::audiovisalParcial.Properties.Resources.audioVisual;
            this.lLogo.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lLogo.Location = new System.Drawing.Point(198, 70);
            this.lLogo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lLogo.Name = "lLogo";
            this.lLogo.Size = new System.Drawing.Size(116, 89);
            this.lLogo.TabIndex = 5;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Gray;
            this.btnExit.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold);
            this.btnExit.Image = global::audiovisalParcial.Properties.Resources.salir;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(154, 1367);
            this.btnExit.Margin = new System.Windows.Forms.Padding(6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(186, 77);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnMenuOption1);
            this.flowLayoutPanel1.Controls.Add(this.btnMenuOption2);
            this.flowLayoutPanel1.Controls.Add(this.btnMenuOption3);
            this.flowLayoutPanel1.Controls.Add(this.btnMenuOption4);
            this.flowLayoutPanel1.Controls.Add(this.btnMenuOption5);
            this.flowLayoutPanel1.Controls.Add(this.btnMenuOption6);
            this.flowLayoutPanel1.Controls.Add(this.btnMenuOption7);
            this.flowLayoutPanel1.Controls.Add(this.btnMenuOption8);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 312);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(518, 986);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // btnMenuOption1
            // 
            this.btnMenuOption1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMenuOption1.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold);
            this.btnMenuOption1.Image = global::audiovisalParcial.Properties.Resources.tipos;
            this.btnMenuOption1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuOption1.Location = new System.Drawing.Point(3, 3);
            this.btnMenuOption1.Name = "btnMenuOption1";
            this.btnMenuOption1.Size = new System.Drawing.Size(506, 104);
            this.btnMenuOption1.TabIndex = 0;
            this.btnMenuOption1.Text = "Gestión de Tipos de Equipos​";
            this.btnMenuOption1.UseVisualStyleBackColor = false;
            this.btnMenuOption1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnMenuOption1_MouseClick);
            // 
            // btnMenuOption2
            // 
            this.btnMenuOption2.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold);
            this.btnMenuOption2.Image = global::audiovisalParcial.Properties.Resources.tipos;
            this.btnMenuOption2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuOption2.Location = new System.Drawing.Point(3, 113);
            this.btnMenuOption2.Name = "btnMenuOption2";
            this.btnMenuOption2.Size = new System.Drawing.Size(506, 104);
            this.btnMenuOption2.TabIndex = 1;
            this.btnMenuOption2.Text = "Gestión de Marcas​";
            this.btnMenuOption2.UseVisualStyleBackColor = true;
            this.btnMenuOption2.Click += new System.EventHandler(this.btnMenuOption2_Click);
            // 
            // btnMenuOption3
            // 
            this.btnMenuOption3.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold);
            this.btnMenuOption3.Image = global::audiovisalParcial.Properties.Resources.tipos;
            this.btnMenuOption3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuOption3.Location = new System.Drawing.Point(3, 223);
            this.btnMenuOption3.Name = "btnMenuOption3";
            this.btnMenuOption3.Size = new System.Drawing.Size(506, 104);
            this.btnMenuOption3.TabIndex = 2;
            this.btnMenuOption3.Text = "Gestión de Modelos​";
            this.btnMenuOption3.UseVisualStyleBackColor = true;
            this.btnMenuOption3.Click += new System.EventHandler(this.btnMenuOption3_Click);
            // 
            // btnMenuOption4
            // 
            this.btnMenuOption4.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold);
            this.btnMenuOption4.Image = global::audiovisalParcial.Properties.Resources.tipos;
            this.btnMenuOption4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuOption4.Location = new System.Drawing.Point(3, 333);
            this.btnMenuOption4.Name = "btnMenuOption4";
            this.btnMenuOption4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnMenuOption4.Size = new System.Drawing.Size(508, 113);
            this.btnMenuOption4.TabIndex = 3;
            this.btnMenuOption4.Text = " Gestión de Tecnologías y Conexión​";
            this.btnMenuOption4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuOption4.UseVisualStyleBackColor = true;
            this.btnMenuOption4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnMenuOption4_MouseClick);
            // 
            // btnMenuOption5
            // 
            this.btnMenuOption5.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold);
            this.btnMenuOption5.Image = global::audiovisalParcial.Properties.Resources.tipos;
            this.btnMenuOption5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuOption5.Location = new System.Drawing.Point(3, 452);
            this.btnMenuOption5.Name = "btnMenuOption5";
            this.btnMenuOption5.Size = new System.Drawing.Size(508, 104);
            this.btnMenuOption5.TabIndex = 4;
            this.btnMenuOption5.Text = "Gestión de Equipos​";
            this.btnMenuOption5.UseVisualStyleBackColor = true;
            this.btnMenuOption5.Click += new System.EventHandler(this.btnMenuOption5_Click);
            // 
            // btnMenuOption6
            // 
            this.btnMenuOption6.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold);
            this.btnMenuOption6.Image = global::audiovisalParcial.Properties.Resources.tipos;
            this.btnMenuOption6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuOption6.Location = new System.Drawing.Point(3, 562);
            this.btnMenuOption6.Name = "btnMenuOption6";
            this.btnMenuOption6.Size = new System.Drawing.Size(506, 104);
            this.btnMenuOption6.TabIndex = 5;
            this.btnMenuOption6.Text = "Gestión de Usuarios​";
            this.btnMenuOption6.UseVisualStyleBackColor = true;
            // 
            // btnMenuOption7
            // 
            this.btnMenuOption7.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold);
            this.btnMenuOption7.Image = global::audiovisalParcial.Properties.Resources.tipos;
            this.btnMenuOption7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuOption7.Location = new System.Drawing.Point(3, 672);
            this.btnMenuOption7.Name = "btnMenuOption7";
            this.btnMenuOption7.Size = new System.Drawing.Size(506, 104);
            this.btnMenuOption7.TabIndex = 6;
            this.btnMenuOption7.Text = "Gestión de Empleados";
            this.btnMenuOption7.UseVisualStyleBackColor = true;
            // 
            // btnMenuOption8
            // 
            this.btnMenuOption8.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold);
            this.btnMenuOption8.Image = global::audiovisalParcial.Properties.Resources.tipos;
            this.btnMenuOption8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuOption8.Location = new System.Drawing.Point(3, 782);
            this.btnMenuOption8.Name = "btnMenuOption8";
            this.btnMenuOption8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnMenuOption8.Size = new System.Drawing.Size(508, 149);
            this.btnMenuOption8.TabIndex = 7;
            this.btnMenuOption8.Text = "Proceso de Prestamo y Devolución de Equipos​";
            this.btnMenuOption8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuOption8.UseVisualStyleBackColor = true;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(0, 0);
            this.splitter2.Margin = new System.Windows.Forms.Padding(4);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(4, 1525);
            this.splitter2.TabIndex = 4;
            this.splitter2.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(518, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 1525);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // pBodySub
            // 
            this.pBodySub.AutoScroll = true;
            this.pBodySub.Location = new System.Drawing.Point(148, 87);
            this.pBodySub.Margin = new System.Windows.Forms.Padding(6);
            this.pBodySub.Name = "pBodySub";
            this.pBodySub.Size = new System.Drawing.Size(1709, 1333);
            this.pBodySub.TabIndex = 1;
            // 
            // pBody
            // 
            this.pBody.Controls.Add(this.pBodySub);
            this.pBody.Location = new System.Drawing.Point(518, 0);
            this.pBody.Margin = new System.Windows.Forms.Padding(6);
            this.pBody.Name = "pBody";
            this.pBody.Size = new System.Drawing.Size(1996, 1531);
            this.pBody.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2529, 1525);
            this.Controls.Add(this.pBody);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pMenu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.pMenu.ResumeLayout(false);
            this.pMenuHeader.ResumeLayout(false);
            this.pMenuHeader.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pMenu;
        private System.Windows.Forms.Panel pMenuHeader;
        private System.Windows.Forms.Label lMenuTitle;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label lLogo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pBodySub;
        private System.Windows.Forms.Panel pBody;
        private System.Windows.Forms.Button btnMenuOption1;
        private System.Windows.Forms.Button btnMenuOption2;
        private System.Windows.Forms.Button btnMenuOption3;
        private System.Windows.Forms.Button btnMenuOption4;
        private System.Windows.Forms.Button btnMenuOption5;
        private System.Windows.Forms.Button btnMenuOption6;
        private System.Windows.Forms.Button btnMenuOption7;
        private System.Windows.Forms.Button btnMenuOption8;
        private System.Windows.Forms.Label lMenu;
    }
}

