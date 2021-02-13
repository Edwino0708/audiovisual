
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
            this.pFootear = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pBody = new System.Windows.Forms.Panel();
            this.pMenu = new System.Windows.Forms.Panel();
            this.pBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // pFootear
            // 
            this.pFootear.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pFootear.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pFootear.Location = new System.Drawing.Point(0, 1175);
            this.pFootear.Name = "pFootear";
            this.pFootear.Size = new System.Drawing.Size(1583, 96);
            this.pFootear.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1583, 131);
            this.panel1.TabIndex = 2;
            // 
            // pBody
            // 
            this.pBody.BackColor = System.Drawing.SystemColors.Info;
            this.pBody.Controls.Add(this.pMenu);
            this.pBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBody.Location = new System.Drawing.Point(0, 0);
            this.pBody.Name = "pBody";
            this.pBody.Size = new System.Drawing.Size(1583, 1175);
            this.pBody.TabIndex = 2;
            // 
            // pMenu
            // 
            this.pMenu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pMenu.Location = new System.Drawing.Point(0, 0);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(173, 1175);
            this.pMenu.TabIndex = 1;
            this.pMenu.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1583, 1271);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pBody);
            this.Controls.Add(this.pFootear);
            this.Location = new System.Drawing.Point(2, 0);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pFootear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pBody;
        private System.Windows.Forms.Panel pMenu;
    }
}

