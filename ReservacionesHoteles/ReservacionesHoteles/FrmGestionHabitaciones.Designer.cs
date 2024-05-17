namespace ReservacionesHoteles
{
    partial class FrmGestionHabitaciones
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
            this.lblNumHabita = new System.Windows.Forms.Label();
            this.txtNumHabita = new System.Windows.Forms.TextBox();
            this.txtTipoHabita = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.dtgvHabitaciones = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHabitaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumHabita
            // 
            this.lblNumHabita.AutoSize = true;
            this.lblNumHabita.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumHabita.Location = new System.Drawing.Point(21, 48);
            this.lblNumHabita.Name = "lblNumHabita";
            this.lblNumHabita.Size = new System.Drawing.Size(167, 18);
            this.lblNumHabita.TabIndex = 1;
            this.lblNumHabita.Text = "Numero de habitacion:";
            // 
            // txtNumHabita
            // 
            this.txtNumHabita.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumHabita.Location = new System.Drawing.Point(194, 45);
            this.txtNumHabita.Name = "txtNumHabita";
            this.txtNumHabita.Size = new System.Drawing.Size(74, 25);
            this.txtNumHabita.TabIndex = 2;
            // 
            // txtTipoHabita
            // 
            this.txtTipoHabita.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoHabita.Location = new System.Drawing.Point(172, 89);
            this.txtTipoHabita.Name = "txtTipoHabita";
            this.txtTipoHabita.Size = new System.Drawing.Size(172, 25);
            this.txtTipoHabita.TabIndex = 4;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(21, 92);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(145, 18);
            this.lblTipo.TabIndex = 3;
            this.lblTipo.Text = "Tipo de Habitacion:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(80, 129);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(178, 25);
            this.txtPrecio.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Precio:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(43, 171);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(145, 26);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Disponibilidad";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Descripcion:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(24, 248);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(320, 139);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // dtgvHabitaciones
            // 
            this.dtgvHabitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHabitaciones.Location = new System.Drawing.Point(370, 12);
            this.dtgvHabitaciones.Name = "dtgvHabitaciones";
            this.dtgvHabitaciones.ReadOnly = true;
            this.dtgvHabitaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvHabitaciones.Size = new System.Drawing.Size(767, 322);
            this.dtgvHabitaciones.TabIndex = 0;
            // 
            // FrmGestionHabitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTipoHabita);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.txtNumHabita);
            this.Controls.Add(this.lblNumHabita);
            this.Controls.Add(this.dtgvHabitaciones);
            this.Name = "FrmGestionHabitaciones";
            this.Text = "Gestion de Habitaciones";
            this.Load += new System.EventHandler(this.FrmGestionHabitaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHabitaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNumHabita;
        private System.Windows.Forms.TextBox txtNumHabita;
        private System.Windows.Forms.TextBox txtTipoHabita;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataGridView dtgvHabitaciones;
    }
}