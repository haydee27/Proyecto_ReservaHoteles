namespace ReservacionesHoteles
{
    partial class FrmGestionReserva
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
            this.lblReserva = new System.Windows.Forms.Label();
            this.txtReservaID = new System.Windows.Forms.TextBox();
            this.txtClienteID = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtHabitacionID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvReserva = new System.Windows.Forms.DataGridView();
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSalida = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReserva)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReserva
            // 
            this.lblReserva.AutoSize = true;
            this.lblReserva.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReserva.Location = new System.Drawing.Point(21, 48);
            this.lblReserva.Name = "lblReserva";
            this.lblReserva.Size = new System.Drawing.Size(91, 18);
            this.lblReserva.TabIndex = 1;
            this.lblReserva.Text = "Reserva ID:";
            this.lblReserva.Click += new System.EventHandler(this.lblReserva_Click);
            // 
            // txtReservaID
            // 
            this.txtReservaID.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReservaID.Location = new System.Drawing.Point(124, 41);
            this.txtReservaID.Name = "txtReservaID";
            this.txtReservaID.Size = new System.Drawing.Size(74, 25);
            this.txtReservaID.TabIndex = 2;
            // 
            // txtClienteID
            // 
            this.txtClienteID.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClienteID.Location = new System.Drawing.Point(124, 85);
            this.txtClienteID.Name = "txtClienteID";
            this.txtClienteID.Size = new System.Drawing.Size(172, 25);
            this.txtClienteID.TabIndex = 4;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(21, 92);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(82, 18);
            this.lblTipo.TabIndex = 3;
            this.lblTipo.Text = "Cliente ID:";
            // 
            // txtHabitacionID
            // 
            this.txtHabitacionID.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHabitacionID.Location = new System.Drawing.Point(124, 125);
            this.txtHabitacionID.Name = "txtHabitacionID";
            this.txtHabitacionID.Size = new System.Drawing.Size(178, 25);
            this.txtHabitacionID.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Haitacion ID:";
            // 
            // dtgvReserva
            // 
            this.dtgvReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvReserva.Location = new System.Drawing.Point(370, 12);
            this.dtgvReserva.Name = "dtgvReserva";
            this.dtgvReserva.ReadOnly = true;
            this.dtgvReserva.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvReserva.Size = new System.Drawing.Size(912, 387);
            this.dtgvReserva.TabIndex = 0;
            this.dtgvReserva.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvHabitaciones_CellContentClick);
            // 
            // txtEntrada
            // 
            this.txtEntrada.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntrada.Location = new System.Drawing.Point(142, 156);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(178, 25);
            this.txtEntrada.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Fecha Entrada:";
            // 
            // txtSalida
            // 
            this.txtSalida.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalida.Location = new System.Drawing.Point(142, 196);
            this.txtSalida.Name = "txtSalida";
            this.txtSalida.Size = new System.Drawing.Size(178, 25);
            this.txtSalida.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Fecha Salida:";
            // 
            // FrmGestionReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 560);
            this.Controls.Add(this.txtSalida);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEntrada);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHabitacionID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtClienteID);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.txtReservaID);
            this.Controls.Add(this.lblReserva);
            this.Controls.Add(this.dtgvReserva);
            this.Name = "FrmGestionReserva";
            this.Text = "Gestion de Reserva";
            this.Load += new System.EventHandler(this.FrmGestionHabitaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReserva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblReserva;
        private System.Windows.Forms.TextBox txtReservaID;
        private System.Windows.Forms.TextBox txtClienteID;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtHabitacionID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvReserva;
        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSalida;
        private System.Windows.Forms.Label label4;
    }
}