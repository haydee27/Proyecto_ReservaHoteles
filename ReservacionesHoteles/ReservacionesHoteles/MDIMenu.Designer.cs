namespace ReservacionesHoteles
{
    partial class MDIMenu
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIMenu));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.gestionDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacionDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeHabitacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InformacionDeHabitacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.dtgvHabitaciones = new System.Windows.Forms.DataGridView();
            this.checkDisponi = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.txtIdHotel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.descript = new System.Windows.Forms.RichTextBox();
            this.lblNumHabita = new System.Windows.Forms.Label();
            this.txtNumHabita = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtTipoHabita = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHabitaID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHabitaciones)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDeClientesToolStripMenuItem,
            this.gestionDeHabitacionesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1325, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // gestionDeClientesToolStripMenuItem
            // 
            this.gestionDeClientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informacionDeClientesToolStripMenuItem});
            this.gestionDeClientesToolStripMenuItem.Name = "gestionDeClientesToolStripMenuItem";
            this.gestionDeClientesToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.gestionDeClientesToolStripMenuItem.Text = "Gestion de Clientes";
            // 
            // informacionDeClientesToolStripMenuItem
            // 
            this.informacionDeClientesToolStripMenuItem.Name = "informacionDeClientesToolStripMenuItem";
            this.informacionDeClientesToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.informacionDeClientesToolStripMenuItem.Text = "Informacion de Clientes";
            this.informacionDeClientesToolStripMenuItem.Click += new System.EventHandler(this.informacionDeClientesToolStripMenuItem_Click);
            // 
            // gestionDeHabitacionesToolStripMenuItem
            // 
            this.gestionDeHabitacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InformacionDeHabitacionesToolStripMenuItem});
            this.gestionDeHabitacionesToolStripMenuItem.Name = "gestionDeHabitacionesToolStripMenuItem";
            this.gestionDeHabitacionesToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.gestionDeHabitacionesToolStripMenuItem.Text = "Gestion de Reserva";
            // 
            // InformacionDeHabitacionesToolStripMenuItem
            // 
            this.InformacionDeHabitacionesToolStripMenuItem.Name = "InformacionDeHabitacionesToolStripMenuItem";
            this.InformacionDeHabitacionesToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.InformacionDeHabitacionesToolStripMenuItem.Text = "Informacion de Habitaciones";
            this.InformacionDeHabitacionesToolStripMenuItem.Click += new System.EventHandler(this.InformacionDeHabitacionesToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.salirToolStripMenuItem.Text = "Cerrar sesion";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(0, 0);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip.Size = new System.Drawing.Size(1325, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // dtgvHabitaciones
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvHabitaciones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvHabitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvHabitaciones.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvHabitaciones.Location = new System.Drawing.Point(471, 88);
            this.dtgvHabitaciones.Name = "dtgvHabitaciones";
            this.dtgvHabitaciones.ReadOnly = true;
            this.dtgvHabitaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvHabitaciones.Size = new System.Drawing.Size(813, 569);
            this.dtgvHabitaciones.TabIndex = 11;
            this.dtgvHabitaciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvHabitaciones_CellClick);
            this.dtgvHabitaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvHabitaciones_CellContentClick);
            // 
            // checkDisponi
            // 
            this.checkDisponi.AutoSize = true;
            this.checkDisponi.BackColor = System.Drawing.Color.White;
            this.checkDisponi.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkDisponi.Location = new System.Drawing.Point(45, 225);
            this.checkDisponi.Name = "checkDisponi";
            this.checkDisponi.Size = new System.Drawing.Size(145, 26);
            this.checkDisponi.TabIndex = 18;
            this.checkDisponi.Text = "Disponibilidad";
            this.checkDisponi.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtHabitaID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.BtnBuscar);
            this.groupBox1.Controls.Add(this.txtIdHotel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.descript);
            this.groupBox1.Controls.Add(this.lblNumHabita);
            this.groupBox1.Controls.Add(this.txtNumHabita);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblTipo);
            this.groupBox1.Controls.Add(this.checkDisponi);
            this.groupBox1.Controls.Add(this.txtTipoHabita);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(28, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 538);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Location = new System.Drawing.Point(137, 451);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(90, 42);
            this.BtnBuscar.TabIndex = 26;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // txtIdHotel
            // 
            this.txtIdHotel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdHotel.Location = new System.Drawing.Point(215, 79);
            this.txtIdHotel.Name = "txtIdHotel";
            this.txtIdHotel.Size = new System.Drawing.Size(130, 25);
            this.txtIdHotel.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 24;
            this.label3.Text = "ID Hotel";
            // 
            // descript
            // 
            this.descript.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descript.Location = new System.Drawing.Point(45, 307);
            this.descript.Name = "descript";
            this.descript.Size = new System.Drawing.Size(300, 117);
            this.descript.TabIndex = 20;
            this.descript.Text = "";
            // 
            // lblNumHabita
            // 
            this.lblNumHabita.AutoSize = true;
            this.lblNumHabita.BackColor = System.Drawing.Color.White;
            this.lblNumHabita.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumHabita.Location = new System.Drawing.Point(42, 113);
            this.lblNumHabita.Name = "lblNumHabita";
            this.lblNumHabita.Size = new System.Drawing.Size(167, 18);
            this.lblNumHabita.TabIndex = 12;
            this.lblNumHabita.Text = "Numero de habitacion:";
            // 
            // txtNumHabita
            // 
            this.txtNumHabita.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumHabita.Location = new System.Drawing.Point(215, 110);
            this.txtNumHabita.Name = "txtNumHabita";
            this.txtNumHabita.Size = new System.Drawing.Size(130, 25);
            this.txtNumHabita.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Descripcion:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.BackColor = System.Drawing.Color.White;
            this.lblTipo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(42, 157);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(145, 18);
            this.lblTipo.TabIndex = 14;
            this.lblTipo.Text = "Tipo de Habitacion:";
            // 
            // txtTipoHabita
            // 
            this.txtTipoHabita.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoHabita.Location = new System.Drawing.Point(193, 154);
            this.txtTipoHabita.Name = "txtTipoHabita";
            this.txtTipoHabita.Size = new System.Drawing.Size(152, 25);
            this.txtTipoHabita.TabIndex = 15;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(101, 194);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(244, 25);
            this.txtPrecio.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Precio:";
            // 
            // txtHabitaID
            // 
            this.txtHabitaID.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHabitaID.Location = new System.Drawing.Point(215, 48);
            this.txtHabitaID.Name = "txtHabitaID";
            this.txtHabitaID.Size = new System.Drawing.Size(130, 25);
            this.txtHabitaID.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 18);
            this.label4.TabIndex = 29;
            this.label4.Text = "Habitacion ID";
            // 
            // MDIMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1325, 749);
            this.Controls.Add(this.dtgvHabitaciones);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MDIMenu";
            this.Text = "MDIMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MDIMenu_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHabitaciones)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem gestionDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeHabitacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacionDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InformacionDeHabitacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.DataGridView dtgvHabitaciones;
        private System.Windows.Forms.CheckBox checkDisponi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNumHabita;
        private System.Windows.Forms.TextBox txtNumHabita;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtTipoHabita;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox descript;
        private System.Windows.Forms.TextBox txtIdHotel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox txtHabitaID;
        private System.Windows.Forms.Label label4;
    }
}



