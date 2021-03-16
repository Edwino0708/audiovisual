
namespace audiovisalParcial
{
    partial class HomeControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeControl));
            this.pMenu = new System.Windows.Forms.Panel();
            this.pMenuOptions = new System.Windows.Forms.Panel();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnMenuService = new System.Windows.Forms.Button();
            this.btnMenuMantinance = new System.Windows.Forms.Button();
            this.pMenuHeader = new System.Windows.Forms.Panel();
            this.lMenuTitle = new System.Windows.Forms.Label();
            this.lLogo = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pBody = new System.Windows.Forms.Panel();
            this.pSubBody = new System.Windows.Forms.Panel();
            this.pHeader = new System.Windows.Forms.Panel();
            this.pHeaderMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pMenu.SuspendLayout();
            this.pMenuOptions.SuspendLayout();
            this.pMenuHeader.SuspendLayout();
            this.pBody.SuspendLayout();
            this.pHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pMenu
            // 
            this.pMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pMenu.Controls.Add(this.pMenuOptions);
            this.pMenu.Controls.Add(this.pMenuHeader);
            this.pMenu.Controls.Add(this.btnExit);
            this.pMenu.Controls.Add(this.splitter2);
            this.pMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pMenu.Location = new System.Drawing.Point(0, 0);
            this.pMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(259, 389);
            this.pMenu.TabIndex = 0;
            // 
            // pMenuOptions
            // 
            this.pMenuOptions.Controls.Add(this.btnReport);
            this.pMenuOptions.Controls.Add(this.btnMenuService);
            this.pMenuOptions.Controls.Add(this.btnMenuMantinance);
            this.pMenuOptions.Location = new System.Drawing.Point(2, 156);
            this.pMenuOptions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pMenuOptions.Name = "pMenuOptions";
            this.pMenuOptions.Size = new System.Drawing.Size(256, 240);
            this.pMenuOptions.TabIndex = 8;
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnReport.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold);
            this.btnReport.Image = ((System.Drawing.Image)(resources.GetObject("btnReport.Image")));
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(2, 171);
            this.btnReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(253, 54);
            this.btnReport.TabIndex = 3;
            this.btnReport.Text = "Reportes";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Visible = false;
            this.btnReport.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnMenuService
            // 
            this.btnMenuService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMenuService.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold);
            this.btnMenuService.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuService.Image")));
            this.btnMenuService.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuService.Location = new System.Drawing.Point(3, 95);
            this.btnMenuService.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMenuService.Name = "btnMenuService";
            this.btnMenuService.Size = new System.Drawing.Size(253, 54);
            this.btnMenuService.TabIndex = 2;
            this.btnMenuService.Text = "Servicios";
            this.btnMenuService.UseVisualStyleBackColor = false;
            this.btnMenuService.Visible = false;
            // 
            // btnMenuMantinance
            // 
            this.btnMenuMantinance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMenuMantinance.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold);
            this.btnMenuMantinance.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuMantinance.Image")));
            this.btnMenuMantinance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuMantinance.Location = new System.Drawing.Point(1, 18);
            this.btnMenuMantinance.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMenuMantinance.Name = "btnMenuMantinance";
            this.btnMenuMantinance.Size = new System.Drawing.Size(253, 54);
            this.btnMenuMantinance.TabIndex = 1;
            this.btnMenuMantinance.Text = "Mantenimientos";
            this.btnMenuMantinance.UseVisualStyleBackColor = false;
            this.btnMenuMantinance.Visible = false;
            this.btnMenuMantinance.Click += new System.EventHandler(this.button1_Click);
            // 
            // pMenuHeader
            // 
            this.pMenuHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pMenuHeader.Controls.Add(this.lMenuTitle);
            this.pMenuHeader.Controls.Add(this.lLogo);
            this.pMenuHeader.Location = new System.Drawing.Point(0, 0);
            this.pMenuHeader.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pMenuHeader.Name = "pMenuHeader";
            this.pMenuHeader.Size = new System.Drawing.Size(259, 152);
            this.pMenuHeader.TabIndex = 5;
            // 
            // lMenuTitle
            // 
            this.lMenuTitle.AutoSize = true;
            this.lMenuTitle.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMenuTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lMenuTitle.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lMenuTitle.Location = new System.Drawing.Point(38, 100);
            this.lMenuTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lMenuTitle.Name = "lMenuTitle";
            this.lMenuTitle.Size = new System.Drawing.Size(191, 19);
            this.lMenuTitle.TabIndex = 6;
            this.lMenuTitle.Text = "Sistema de Audivisuales";
            this.lMenuTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lLogo
            // 
            this.lLogo.Image = ((System.Drawing.Image)(resources.GetObject("lLogo.Image")));
            this.lLogo.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lLogo.Location = new System.Drawing.Point(112, 36);
            this.lLogo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lLogo.Name = "lLogo";
            this.lLogo.Size = new System.Drawing.Size(58, 46);
            this.lLogo.TabIndex = 5;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Gray;
            this.btnExit.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold);
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(37, 475);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(182, 58);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Cerrar Sección";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(0, 0);
            this.splitter2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(2, 389);
            this.splitter2.TabIndex = 4;
            this.splitter2.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(259, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(2, 389);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // pBody
            // 
            this.pBody.AutoScroll = true;
            this.pBody.Controls.Add(this.pSubBody);
            this.pBody.Controls.Add(this.pHeader);
            this.pBody.Controls.Add(this.panel1);
            this.pBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBody.Location = new System.Drawing.Point(261, 0);
            this.pBody.Name = "pBody";
            this.pBody.Size = new System.Drawing.Size(424, 389);
            this.pBody.TabIndex = 3;
            // 
            // pSubBody
            // 
            this.pSubBody.AutoScroll = true;
            this.pSubBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pSubBody.Location = new System.Drawing.Point(0, 97);
            this.pSubBody.Name = "pSubBody";
            this.pSubBody.Size = new System.Drawing.Size(424, 292);
            this.pSubBody.TabIndex = 2;
            // 
            // pHeader
            // 
            this.pHeader.AutoSize = true;
            this.pHeader.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pHeader.Controls.Add(this.pHeaderMenu);
            this.pHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pHeader.Location = new System.Drawing.Point(0, 0);
            this.pHeader.Name = "pHeader";
            this.pHeader.Size = new System.Drawing.Size(424, 97);
            this.pHeader.TabIndex = 1;
            // 
            // pHeaderMenu
            // 
            this.pHeaderMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pHeaderMenu.AutoSize = true;
            this.pHeaderMenu.Location = new System.Drawing.Point(54, 12);
            this.pHeaderMenu.Name = "pHeaderMenu";
            this.pHeaderMenu.Size = new System.Drawing.Size(306, 70);
            this.pHeaderMenu.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 0);
            this.panel1.TabIndex = 0;
            // 
            // HomeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(685, 389);
            this.Controls.Add(this.pBody);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pMenu);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "HomeControl";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.pMenu.ResumeLayout(false);
            this.pMenuOptions.ResumeLayout(false);
            this.pMenuHeader.ResumeLayout(false);
            this.pMenuHeader.PerformLayout();
            this.pBody.ResumeLayout(false);
            this.pBody.PerformLayout();
            this.pHeader.ResumeLayout(false);
            this.pHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pMenu;
        private System.Windows.Forms.Panel pMenuHeader;
        private System.Windows.Forms.Label lMenuTitle;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label lLogo;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pMenuOptions;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnMenuService;
        private System.Windows.Forms.Button btnMenuMantinance;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pHeader;
        private System.Windows.Forms.Panel pHeaderMenu;
        private System.Windows.Forms.Panel pBody;
        private System.Windows.Forms.Panel pSubBody;
    }
}

