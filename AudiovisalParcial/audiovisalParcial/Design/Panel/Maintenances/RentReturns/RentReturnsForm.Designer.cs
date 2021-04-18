
namespace audiovisalParcial.Design.Panel.Maintenances.RentReturns
{
    partial class RentReturnsForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtComentario = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtFechaDevolucion = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtFechaPrestamo = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxUsuario = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxEquipo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxEmpleados = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNoPrestamo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(369, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 44;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "Comentario";
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(44, 277);
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(716, 114);
            this.txtComentario.TabIndex = 40;
            this.txtComentario.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(524, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Fecha Devolucion";
            // 
            // dtFechaDevolucion
            // 
            this.dtFechaDevolucion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaDevolucion.Location = new System.Drawing.Point(527, 182);
            this.dtFechaDevolucion.Name = "dtFechaDevolucion";
            this.dtFechaDevolucion.Size = new System.Drawing.Size(233, 20);
            this.dtFechaDevolucion.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(274, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Fecha Prestamo";
            // 
            // dtFechaPrestamo
            // 
            this.dtFechaPrestamo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaPrestamo.Location = new System.Drawing.Point(277, 182);
            this.dtFechaPrestamo.Name = "dtFechaPrestamo";
            this.dtFechaPrestamo.Size = new System.Drawing.Size(233, 20);
            this.dtFechaPrestamo.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Usuario";
            // 
            // cbxUsuario
            // 
            this.cbxUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUsuario.FormattingEnabled = true;
            this.cbxUsuario.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbxUsuario.Location = new System.Drawing.Point(44, 181);
            this.cbxUsuario.Name = "cbxUsuario";
            this.cbxUsuario.Size = new System.Drawing.Size(184, 21);
            this.cbxUsuario.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(524, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Equipo";
            // 
            // cbxEquipo
            // 
            this.cbxEquipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEquipo.FormattingEnabled = true;
            this.cbxEquipo.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbxEquipo.Location = new System.Drawing.Point(527, 94);
            this.cbxEquipo.Name = "cbxEquipo";
            this.cbxEquipo.Size = new System.Drawing.Size(184, 21);
            this.cbxEquipo.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Empleado";
            // 
            // cbxEmpleados
            // 
            this.cbxEmpleados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEmpleados.FormattingEnabled = true;
            this.cbxEmpleados.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbxEmpleados.Location = new System.Drawing.Point(277, 94);
            this.cbxEmpleados.Name = "cbxEmpleados";
            this.cbxEmpleados.Size = new System.Drawing.Size(184, 21);
            this.cbxEmpleados.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Numero prestamo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 26);
            this.label1.TabIndex = 28;
            this.label1.Text = "Nuevo Prestamo";
            // 
            // txtNoPrestamo
            // 
            this.txtNoPrestamo.Location = new System.Drawing.Point(44, 95);
            this.txtNoPrestamo.Name = "txtNoPrestamo";
            this.txtNoPrestamo.Size = new System.Drawing.Size(180, 20);
            this.txtNoPrestamo.TabIndex = 27;
            // 
            // RentReturnsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtComentario);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtFechaDevolucion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtFechaPrestamo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxEquipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxEmpleados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNoPrestamo);
            this.Name = "RentReturnsForm";
            this.Text = "RentReturnsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox txtComentario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtFechaDevolucion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtFechaPrestamo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxEquipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxEmpleados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNoPrestamo;
    }
}