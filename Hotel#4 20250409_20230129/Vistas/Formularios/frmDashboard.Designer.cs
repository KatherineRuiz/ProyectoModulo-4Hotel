namespace Vistas.Formularios
{
    partial class frmDashboard
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
            this.pnlCentral = new System.Windows.Forms.Panel();
            this.pnlMenuPrincipal = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSalir = new Vistas.Clases.RedondearBoton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnUsuarios = new Vistas.Clases.RedondearBoton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnServicios = new Vistas.Clases.RedondearBoton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnHabitaciones = new Vistas.Clases.RedondearBoton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnClientes = new Vistas.Clases.RedondearBoton();
            this.pnlMenuReservas = new System.Windows.Forms.Panel();
            this.btnVerReservas = new Vistas.Clases.RedondearBoton();
            this.btnGestionReserva = new Vistas.Clases.RedondearBoton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReservas = new Vistas.Clases.RedondearBoton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCheckInOut = new Vistas.Clases.RedondearBoton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlMenuPrincipal.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnlMenuReservas.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCentral
            // 
            this.pnlCentral.CausesValidation = false;
            this.pnlCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCentral.Location = new System.Drawing.Point(341, 0);
            this.pnlCentral.Margin = new System.Windows.Forms.Padding(4);
            this.pnlCentral.Name = "pnlCentral";
            this.pnlCentral.Size = new System.Drawing.Size(944, 644);
            this.pnlCentral.TabIndex = 7;
            this.pnlCentral.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCentral_Paint);
            // 
            // pnlMenuPrincipal
            // 
            this.pnlMenuPrincipal.AutoScroll = true;
            this.pnlMenuPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(182)))), ((int)(((byte)(242)))));
            this.pnlMenuPrincipal.Controls.Add(this.panel3);
            this.pnlMenuPrincipal.Controls.Add(this.panel7);
            this.pnlMenuPrincipal.Controls.Add(this.panel6);
            this.pnlMenuPrincipal.Controls.Add(this.panel5);
            this.pnlMenuPrincipal.Controls.Add(this.panel4);
            this.pnlMenuPrincipal.Controls.Add(this.pnlMenuReservas);
            this.pnlMenuPrincipal.Controls.Add(this.panel2);
            this.pnlMenuPrincipal.Controls.Add(this.panel1);
            this.pnlMenuPrincipal.Controls.Add(this.pictureBox1);
            this.pnlMenuPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuPrincipal.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMenuPrincipal.Name = "pnlMenuPrincipal";
            this.pnlMenuPrincipal.Size = new System.Drawing.Size(341, 644);
            this.pnlMenuPrincipal.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSalir);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 704);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.panel3.Size = new System.Drawing.Size(320, 148);
            this.panel3.TabIndex = 8;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(74)))), ((int)(((byte)(132)))));
            this.btnSalir.BorderColor = System.Drawing.Color.Aquamarine;
            this.btnSalir.BorderRadius = 30;
            this.btnSalir.BorderSize = 0;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Image = global::Vistas.Properties.Resources.exit;
            this.btnSalir.Location = new System.Drawing.Point(13, 76);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(294, 60);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Cerrar Sesión";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnUsuarios);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 629);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(40, 12, 40, 12);
            this.panel7.Size = new System.Drawing.Size(320, 75);
            this.panel7.TabIndex = 7;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(63)))), ((int)(((byte)(128)))));
            this.btnUsuarios.BorderColor = System.Drawing.Color.Aquamarine;
            this.btnUsuarios.BorderRadius = 30;
            this.btnUsuarios.BorderSize = 0;
            this.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Britannic Bold", 15.75F);
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.Location = new System.Drawing.Point(40, 12);
            this.btnUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(240, 51);
            this.btnUsuarios.TabIndex = 3;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnServicios);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 551);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(40, 12, 40, 12);
            this.panel6.Size = new System.Drawing.Size(320, 78);
            this.panel6.TabIndex = 6;
            // 
            // btnServicios
            // 
            this.btnServicios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(63)))), ((int)(((byte)(128)))));
            this.btnServicios.BorderColor = System.Drawing.Color.Aquamarine;
            this.btnServicios.BorderRadius = 30;
            this.btnServicios.BorderSize = 0;
            this.btnServicios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnServicios.FlatAppearance.BorderSize = 0;
            this.btnServicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServicios.Font = new System.Drawing.Font("Britannic Bold", 15.75F);
            this.btnServicios.ForeColor = System.Drawing.Color.White;
            this.btnServicios.Location = new System.Drawing.Point(40, 12);
            this.btnServicios.Margin = new System.Windows.Forms.Padding(4);
            this.btnServicios.Name = "btnServicios";
            this.btnServicios.Size = new System.Drawing.Size(240, 54);
            this.btnServicios.TabIndex = 2;
            this.btnServicios.Text = "Servicios";
            this.btnServicios.UseVisualStyleBackColor = false;
            this.btnServicios.Click += new System.EventHandler(this.btnServicios_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnHabitaciones);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 471);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(40, 12, 40, 12);
            this.panel5.Size = new System.Drawing.Size(320, 80);
            this.panel5.TabIndex = 5;
            // 
            // btnHabitaciones
            // 
            this.btnHabitaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(63)))), ((int)(((byte)(128)))));
            this.btnHabitaciones.BorderColor = System.Drawing.Color.Aquamarine;
            this.btnHabitaciones.BorderRadius = 30;
            this.btnHabitaciones.BorderSize = 0;
            this.btnHabitaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHabitaciones.FlatAppearance.BorderSize = 0;
            this.btnHabitaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHabitaciones.Font = new System.Drawing.Font("Britannic Bold", 15.75F);
            this.btnHabitaciones.ForeColor = System.Drawing.Color.White;
            this.btnHabitaciones.Location = new System.Drawing.Point(40, 12);
            this.btnHabitaciones.Margin = new System.Windows.Forms.Padding(4);
            this.btnHabitaciones.Name = "btnHabitaciones";
            this.btnHabitaciones.Size = new System.Drawing.Size(240, 56);
            this.btnHabitaciones.TabIndex = 1;
            this.btnHabitaciones.Text = "Habitaciones";
            this.btnHabitaciones.UseVisualStyleBackColor = false;
            this.btnHabitaciones.Click += new System.EventHandler(this.btnHabitaciones_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnClientes);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 392);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(40, 12, 40, 12);
            this.panel4.Size = new System.Drawing.Size(320, 79);
            this.panel4.TabIndex = 4;
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(63)))), ((int)(((byte)(128)))));
            this.btnClientes.BorderColor = System.Drawing.Color.Aquamarine;
            this.btnClientes.BorderRadius = 30;
            this.btnClientes.BorderSize = 0;
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Britannic Bold", 15.75F);
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.Location = new System.Drawing.Point(40, 12);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(4);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(240, 55);
            this.btnClientes.TabIndex = 2;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // pnlMenuReservas
            // 
            this.pnlMenuReservas.Controls.Add(this.btnVerReservas);
            this.pnlMenuReservas.Controls.Add(this.btnGestionReserva);
            this.pnlMenuReservas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenuReservas.Location = new System.Drawing.Point(0, 274);
            this.pnlMenuReservas.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMenuReservas.Name = "pnlMenuReservas";
            this.pnlMenuReservas.Padding = new System.Windows.Forms.Padding(47, 0, 47, 0);
            this.pnlMenuReservas.Size = new System.Drawing.Size(320, 118);
            this.pnlMenuReservas.TabIndex = 3;
            // 
            // btnVerReservas
            // 
            this.btnVerReservas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(146)))), ((int)(((byte)(207)))));
            this.btnVerReservas.BorderColor = System.Drawing.Color.Aquamarine;
            this.btnVerReservas.BorderRadius = 30;
            this.btnVerReservas.BorderSize = 0;
            this.btnVerReservas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVerReservas.FlatAppearance.BorderSize = 0;
            this.btnVerReservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerReservas.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerReservas.ForeColor = System.Drawing.Color.White;
            this.btnVerReservas.Location = new System.Drawing.Point(47, 70);
            this.btnVerReservas.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerReservas.Name = "btnVerReservas";
            this.btnVerReservas.Size = new System.Drawing.Size(226, 43);
            this.btnVerReservas.TabIndex = 6;
            this.btnVerReservas.Text = "Ver Reservas";
            this.btnVerReservas.UseVisualStyleBackColor = false;
            this.btnVerReservas.Click += new System.EventHandler(this.btnVerReservas_Click);
            // 
            // btnGestionReserva
            // 
            this.btnGestionReserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(146)))), ((int)(((byte)(207)))));
            this.btnGestionReserva.BorderColor = System.Drawing.Color.Aquamarine;
            this.btnGestionReserva.BorderRadius = 30;
            this.btnGestionReserva.BorderSize = 0;
            this.btnGestionReserva.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionReserva.FlatAppearance.BorderSize = 0;
            this.btnGestionReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionReserva.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionReserva.ForeColor = System.Drawing.Color.White;
            this.btnGestionReserva.Location = new System.Drawing.Point(47, 0);
            this.btnGestionReserva.Margin = new System.Windows.Forms.Padding(4);
            this.btnGestionReserva.Name = "btnGestionReserva";
            this.btnGestionReserva.Size = new System.Drawing.Size(226, 70);
            this.btnGestionReserva.TabIndex = 5;
            this.btnGestionReserva.Text = "Administrar Reservas";
            this.btnGestionReserva.UseVisualStyleBackColor = false;
            this.btnGestionReserva.Click += new System.EventHandler(this.btnGestionReserva_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnReservas);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 199);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(40, 12, 40, 12);
            this.panel2.Size = new System.Drawing.Size(320, 75);
            this.panel2.TabIndex = 2;
            // 
            // btnReservas
            // 
            this.btnReservas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(63)))), ((int)(((byte)(128)))));
            this.btnReservas.BorderColor = System.Drawing.Color.Aquamarine;
            this.btnReservas.BorderRadius = 30;
            this.btnReservas.BorderSize = 0;
            this.btnReservas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReservas.FlatAppearance.BorderSize = 0;
            this.btnReservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservas.Font = new System.Drawing.Font("Britannic Bold", 15.75F);
            this.btnReservas.ForeColor = System.Drawing.Color.White;
            this.btnReservas.Location = new System.Drawing.Point(40, 12);
            this.btnReservas.Margin = new System.Windows.Forms.Padding(4);
            this.btnReservas.Name = "btnReservas";
            this.btnReservas.Size = new System.Drawing.Size(240, 51);
            this.btnReservas.TabIndex = 2;
            this.btnReservas.Text = "Reservas";
            this.btnReservas.UseVisualStyleBackColor = false;
            this.btnReservas.Click += new System.EventHandler(this.btnReservas_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCheckInOut);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 123);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(40, 12, 40, 12);
            this.panel1.Size = new System.Drawing.Size(320, 76);
            this.panel1.TabIndex = 1;
            // 
            // btnCheckInOut
            // 
            this.btnCheckInOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(63)))), ((int)(((byte)(128)))));
            this.btnCheckInOut.BorderColor = System.Drawing.Color.Aquamarine;
            this.btnCheckInOut.BorderRadius = 30;
            this.btnCheckInOut.BorderSize = 0;
            this.btnCheckInOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCheckInOut.FlatAppearance.BorderSize = 0;
            this.btnCheckInOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckInOut.Font = new System.Drawing.Font("Britannic Bold", 15.75F);
            this.btnCheckInOut.ForeColor = System.Drawing.Color.White;
            this.btnCheckInOut.Location = new System.Drawing.Point(40, 12);
            this.btnCheckInOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckInOut.Name = "btnCheckInOut";
            this.btnCheckInOut.Size = new System.Drawing.Size(240, 52);
            this.btnCheckInOut.TabIndex = 0;
            this.btnCheckInOut.Text = "CheckIn/Out";
            this.btnCheckInOut.UseVisualStyleBackColor = false;
            this.btnCheckInOut.Click += new System.EventHandler(this.btnCheckInOut_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Vistas.Properties.Resources.logoHotel;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 644);
            this.Controls.Add(this.pnlCentral);
            this.Controls.Add(this.pnlMenuPrincipal);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDashboard";
            this.Text = "BoockInn";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.pnlMenuPrincipal.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.pnlMenuReservas.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCentral;
        private System.Windows.Forms.Panel pnlMenuPrincipal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlMenuReservas;
        private Clases.RedondearBoton btnReservas;
        private System.Windows.Forms.Panel panel2;
        private Clases.RedondearBoton btnHabitaciones;
        private System.Windows.Forms.Panel panel1;
        private Clases.RedondearBoton btnCheckInOut;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private Clases.RedondearBoton btnClientes;
        private Clases.RedondearBoton btnVerReservas;
        private Clases.RedondearBoton btnGestionReserva;
        private System.Windows.Forms.Panel panel7;
        private Clases.RedondearBoton btnUsuarios;
        private Clases.RedondearBoton btnServicios;
        private System.Windows.Forms.Panel panel3;
        private Clases.RedondearBoton btnSalir;
    }
}