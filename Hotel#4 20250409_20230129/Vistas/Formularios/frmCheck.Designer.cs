namespace Vistas.Formularios
{
    partial class frmCheck
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
            this.panel9 = new System.Windows.Forms.Panel();
            this.gbCheck = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnEliminar = new Vistas.Clases.RedondearBoton();
            this.btnLimpiar = new Vistas.Clases.RedondearBoton();
            this.btnAgregar = new Vistas.Clases.RedondearBoton();
            this.btnEditar = new Vistas.Clases.RedondearBoton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.txtIdReserva = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.panel8 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBuscarCliente = new Vistas.Clases.RedondearBoton();
            this.txtBuscarReserva = new System.Windows.Forms.TextBox();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pbUsuarios = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel9.SuspendLayout();
            this.gbCheck.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panel8.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel11.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.gbCheck);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 501);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(40, 20, 40, 20);
            this.panel9.Size = new System.Drawing.Size(1081, 248);
            this.panel9.TabIndex = 17;
            // 
            // gbCheck
            // 
            this.gbCheck.Controls.Add(this.tableLayoutPanel2);
            this.gbCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCheck.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(63)))), ((int)(((byte)(128)))));
            this.gbCheck.Location = new System.Drawing.Point(40, 20);
            this.gbCheck.Name = "gbCheck";
            this.gbCheck.Size = new System.Drawing.Size(1001, 208);
            this.gbCheck.TabIndex = 1;
            this.gbCheck.TabStop = false;
            this.gbCheck.Text = "Administrar Check-In/Out";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.87122F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.12878F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 27);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(995, 178);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.btnEliminar, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.btnLimpiar, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.btnAgregar, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnEditar, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(548, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.65986F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.34014F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(444, 172);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(146)))), ((int)(((byte)(207)))));
            this.btnEliminar.BorderColor = System.Drawing.Color.Aquamarine;
            this.btnEliminar.BorderRadius = 30;
            this.btnEliminar.BorderSize = 0;
            this.btnEliminar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(237, 100);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(15);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(192, 57);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(146)))), ((int)(((byte)(207)))));
            this.btnLimpiar.BorderColor = System.Drawing.Color.Aquamarine;
            this.btnLimpiar.BorderRadius = 30;
            this.btnLimpiar.BorderSize = 0;
            this.btnLimpiar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(15, 100);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(15);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(192, 57);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(146)))), ((int)(((byte)(207)))));
            this.btnAgregar.BorderColor = System.Drawing.Color.Aquamarine;
            this.btnAgregar.BorderRadius = 30;
            this.btnAgregar.BorderSize = 0;
            this.btnAgregar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(15, 15);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(15);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(192, 55);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(146)))), ((int)(((byte)(207)))));
            this.btnEditar.BorderColor = System.Drawing.Color.Aquamarine;
            this.btnEditar.BorderRadius = 30;
            this.btnEditar.BorderSize = 0;
            this.btnEditar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(237, 15);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(15);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(192, 55);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.84298F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.15702F));
            this.tableLayoutPanel3.Controls.Add(this.dtpCheckOut, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.lblCheckIn, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblCliente, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblCheckOut, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.dtpCheckIn, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.10084F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.89916F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(539, 172);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpCheckOut.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpCheckOut.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCheckOut.Location = new System.Drawing.Point(212, 128);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(324, 33);
            this.dtpCheckOut.TabIndex = 11;
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckIn.Location = new System.Drawing.Point(50, 77);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(109, 24);
            this.lblCheckIn.TabIndex = 8;
            this.lblCheckIn.Text = "Check-In:";
            // 
            // lblCliente
            // 
            this.lblCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(57, 18);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(94, 24);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente: ";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.11599F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.88401F));
            this.tableLayoutPanel5.Controls.Add(this.txtIdReserva, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.txtCorreo, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(212, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(324, 55);
            this.tableLayoutPanel5.TabIndex = 5;
            // 
            // txtIdReserva
            // 
            this.txtIdReserva.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIdReserva.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdReserva.Location = new System.Drawing.Point(260, 11);
            this.txtIdReserva.Multiline = true;
            this.txtIdReserva.Name = "txtIdReserva";
            this.txtIdReserva.ReadOnly = true;
            this.txtIdReserva.Size = new System.Drawing.Size(53, 32);
            this.txtIdReserva.TabIndex = 1;
            this.txtIdReserva.Visible = false;
            this.txtIdReserva.WordWrap = false;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCorreo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(7, 11);
            this.txtCorreo.Multiline = true;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.ReadOnly = true;
            this.txtCorreo.Size = new System.Drawing.Size(235, 32);
            this.txtCorreo.TabIndex = 0;
            this.txtCorreo.WordWrap = false;
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckOut.Location = new System.Drawing.Point(40, 132);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(129, 24);
            this.lblCheckOut.TabIndex = 3;
            this.lblCheckOut.Text = "Check-Out:";
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpCheckIn.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpCheckIn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCheckIn.Location = new System.Drawing.Point(212, 72);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(324, 33);
            this.dtpCheckIn.TabIndex = 10;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.groupBox2);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 146);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(40, 20, 40, 20);
            this.panel8.Size = new System.Drawing.Size(1081, 355);
            this.panel8.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel11);
            this.groupBox2.Controls.Add(this.dgvCliente);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(46)))), ((int)(((byte)(84)))));
            this.groupBox2.Location = new System.Drawing.Point(40, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox2.Size = new System.Drawing.Size(1001, 315);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reservas";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.tableLayoutPanel1);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(10, 34);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(981, 58);
            this.panel11.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.75654F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.24346F));
            this.tableLayoutPanel1.Controls.Add(this.btnBuscarCliente, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtBuscarReserva, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(981, 58);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(146)))), ((int)(((byte)(207)))));
            this.btnBuscarCliente.BorderColor = System.Drawing.Color.Aquamarine;
            this.btnBuscarCliente.BorderRadius = 30;
            this.btnBuscarCliente.BorderSize = 0;
            this.btnBuscarCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBuscarCliente.FlatAppearance.BorderSize = 0;
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Britannic Bold", 15.75F);
            this.btnBuscarCliente.ForeColor = System.Drawing.Color.White;
            this.btnBuscarCliente.Location = new System.Drawing.Point(685, 5);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(40, 5, 40, 7);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(256, 46);
            this.btnBuscarCliente.TabIndex = 2;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            // 
            // txtBuscarReserva
            // 
            this.txtBuscarReserva.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBuscarReserva.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarReserva.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtBuscarReserva.Location = new System.Drawing.Point(91, 13);
            this.txtBuscarReserva.Multiline = true;
            this.txtBuscarReserva.Name = "txtBuscarReserva";
            this.txtBuscarReserva.Size = new System.Drawing.Size(462, 32);
            this.txtBuscarReserva.TabIndex = 1;
            this.txtBuscarReserva.Text = "Ingrese el correo electrónico del cliente";
            this.txtBuscarReserva.WordWrap = false;
            // 
            // dgvCliente
            // 
            this.dgvCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCliente.Location = new System.Drawing.Point(10, 34);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.Size = new System.Drawing.Size(981, 271);
            this.dgvCliente.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(40);
            this.panel2.Size = new System.Drawing.Size(1081, 146);
            this.panel2.TabIndex = 15;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(63)))), ((int)(((byte)(128)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(502, 40);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 66);
            this.panel7.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(492, 40);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 66);
            this.panel6.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(63)))), ((int)(((byte)(128)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(479, 40);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(13, 66);
            this.panel5.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(469, 40);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 66);
            this.panel4.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(63)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(40, 40);
            this.panel1.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 66);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(182)))), ((int)(((byte)(242)))));
            this.panel3.Controls.Add(this.pbUsuarios);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(113, 66);
            this.panel3.TabIndex = 1;
            // 
            // pbUsuarios
            // 
            this.pbUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbUsuarios.Image = global::Vistas.Properties.Resources.logoCheck;
            this.pbUsuarios.Location = new System.Drawing.Point(10, 10);
            this.pbUsuarios.Name = "pbUsuarios";
            this.pbUsuarios.Size = new System.Drawing.Size(93, 46);
            this.pbUsuarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUsuarios.TabIndex = 0;
            this.pbUsuarios.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(131, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "CheckIn/Out";
            // 
            // frmCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(900, 500);
            this.ClientSize = new System.Drawing.Size(1081, 749);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel2);
            this.Name = "frmCheck";
            this.Text = "frmCheck";
            this.panel9.ResumeLayout(false);
            this.gbCheck.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.GroupBox gbCheck;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TextBox txtIdReserva;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Clases.RedondearBoton btnBuscarCliente;
        private System.Windows.Forms.TextBox txtBuscarReserva;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pbUsuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private Clases.RedondearBoton btnEliminar;
        private Clases.RedondearBoton btnLimpiar;
        private Clases.RedondearBoton btnAgregar;
        private Clases.RedondearBoton btnEditar;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
    }
}