namespace CotizarArticulos.UI.Registros
{
    partial class RArticulos
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.IDnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DescripciontextBox = new System.Windows.Forms.TextBox();
            this.CantidadnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.FechaVencidodateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.PrecionumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ExitencianumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecionumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitencianumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Exitencia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cantidad a Cotizar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha De Vencimiento";
            // 
            // IDnumericUpDown
            // 
            this.IDnumericUpDown.Location = new System.Drawing.Point(145, 23);
            this.IDnumericUpDown.Name = "IDnumericUpDown";
            this.IDnumericUpDown.Size = new System.Drawing.Size(77, 20);
            this.IDnumericUpDown.TabIndex = 7;
            // 
            // DescripciontextBox
            // 
            this.DescripciontextBox.Location = new System.Drawing.Point(145, 67);
            this.DescripciontextBox.Name = "DescripciontextBox";
            this.DescripciontextBox.Size = new System.Drawing.Size(229, 20);
            this.DescripciontextBox.TabIndex = 8;
            // 
            // CantidadnumericUpDown
            // 
            this.CantidadnumericUpDown.Location = new System.Drawing.Point(145, 186);
            this.CantidadnumericUpDown.Name = "CantidadnumericUpDown";
            this.CantidadnumericUpDown.Size = new System.Drawing.Size(229, 20);
            this.CantidadnumericUpDown.TabIndex = 11;
            // 
            // FechaVencidodateTimePicker
            // 
            this.FechaVencidodateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaVencidodateTimePicker.Location = new System.Drawing.Point(145, 223);
            this.FechaVencidodateTimePicker.Name = "FechaVencidodateTimePicker";
            this.FechaVencidodateTimePicker.Size = new System.Drawing.Size(103, 20);
            this.FechaVencidodateTimePicker.TabIndex = 12;
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Location = new System.Drawing.Point(33, 273);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 48);
            this.Nuevobutton.TabIndex = 13;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(173, 273);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 48);
            this.Guardarbutton.TabIndex = 14;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Location = new System.Drawing.Point(300, 273);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 48);
            this.Eliminarbutton.TabIndex = 15;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Location = new System.Drawing.Point(239, 5);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 53);
            this.Buscarbutton.TabIndex = 16;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // PrecionumericUpDown
            // 
            this.PrecionumericUpDown.Location = new System.Drawing.Point(145, 109);
            this.PrecionumericUpDown.Name = "PrecionumericUpDown";
            this.PrecionumericUpDown.Size = new System.Drawing.Size(229, 20);
            this.PrecionumericUpDown.TabIndex = 17;
            // 
            // ExitencianumericUpDown
            // 
            this.ExitencianumericUpDown.Location = new System.Drawing.Point(145, 148);
            this.ExitencianumericUpDown.Name = "ExitencianumericUpDown";
            this.ExitencianumericUpDown.Size = new System.Drawing.Size(229, 20);
            this.ExitencianumericUpDown.TabIndex = 18;
            // 
            // RArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 343);
            this.Controls.Add(this.ExitencianumericUpDown);
            this.Controls.Add(this.PrecionumericUpDown);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.FechaVencidodateTimePicker);
            this.Controls.Add(this.CantidadnumericUpDown);
            this.Controls.Add(this.DescripciontextBox);
            this.Controls.Add(this.IDnumericUpDown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RArticulos";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecionumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitencianumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown IDnumericUpDown;
        private System.Windows.Forms.TextBox DescripciontextBox;
        private System.Windows.Forms.NumericUpDown CantidadnumericUpDown;
        private System.Windows.Forms.DateTimePicker FechaVencidodateTimePicker;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.NumericUpDown ExitencianumericUpDown;
        private System.Windows.Forms.NumericUpDown PrecionumericUpDown;
    }
}