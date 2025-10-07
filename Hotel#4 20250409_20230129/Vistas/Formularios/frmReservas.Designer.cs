namespace Vistas.Formularios
{
    partial class frmReservas
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
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.pnlReserva = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBuscarReserva = new Vistas.Clases.RedondearBoton();
            this.txtBuscarReserva = new System.Windows.Forms.TextBox();
            this.pnlFormulario = new System.Windows.Forms.Panel();
            this.gbUsuarios = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblFechaRegistro = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblFinal = new System.Windows.Forms.Label();
            this.lblInicio = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.dtpFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAregarServicios = new Vistas.Clases.RedondearBoton();
            this.btnAgregarHabitaciones = new Vistas.Clases.RedondearBoton();
            this.btnEliminar = new Vistas.Clases.RedondearBoton();
            this.btnLimpiar = new Vistas.Clases.RedondearBoton();
            this.btnAgregar = new Vistas.Clases.RedondearBoton();
            this.btnEditar = new Vistas.Clases.RedondearBoton();
            this.pnlCliente = new System.Windows.Forms.Panel();
            this.gbClientes = new System.Windows.Forms.GroupBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBuscarCliente = new Vistas.Clases.RedondearBoton();
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pbUsuarios = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlPrincipal.SuspendLayout();
            this.pnlReserva.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            this.tableLayoutPanel7.SuspendLayout();
            this.pnlFormulario.SuspendLayout();
            this.gbUsuarios.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.pnlCliente.SuspendLayout();
            this.gbClientes.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.pnlReserva);
            this.pnlPrincipal.Controls.Add(this.pnlFormulario);
            this.pnlPrincipal.Controls.Add(this.pnlCliente);
            this.pnlPrincipal.Controls.Add(this.pnlTitulo);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlPrincipal.Margin = new System.Windows.Forms.Padding(4);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(1806, 1425);
            this.pnlPrincipal.TabIndex = 0;
            // 
            // pnlReserva
            // 
            this.pnlReserva.Controls.Add(this.groupBox1);
            this.pnlReserva.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReserva.Location = new System.Drawing.Point(0, 870);
            this.pnlReserva.Margin = new System.Windows.Forms.Padding(4);
            this.pnlReserva.Name = "pnlReserva";
            this.pnlReserva.Padding = new System.Windows.Forms.Padding(53, 0, 53, 0);
            this.pnlReserva.Size = new System.Drawing.Size(1806, 555);
            this.pnlReserva.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel12);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(46)))), ((int)(((byte)(84)))));
            this.groupBox1.Location = new System.Drawing.Point(53, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.groupBox1.Size = new System.Drawing.Size(1700, 506);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reservaciones";
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.dgvReservas);
            this.panel12.Controls.Add(this.tableLayoutPanel7);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(13, 39);
            this.panel12.Margin = new System.Windows.Forms.Padding(4);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1674, 455);
            this.panel12.TabIndex = 2;
            // 
            // dgvReservas
            // 
            this.dgvReservas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReservas.Location = new System.Drawing.Point(0, 71);
            this.dgvReservas.Margin = new System.Windows.Forms.Padding(4);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.ReadOnly = true;
            this.dgvReservas.RowHeadersWidth = 51;
            this.dgvReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservas.Size = new System.Drawing.Size(1674, 384);
            this.dgvReservas.TabIndex = 3;
            this.dgvReservas.DoubleClick += new System.EventHandler(this.dgvReservas_DoubleClick);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.75654F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.24346F));
            this.tableLayoutPanel7.Controls.Add(this.btnBuscarReserva, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.txtBuscarReserva, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(1674, 71);
            this.tableLayoutPanel7.TabIndex = 1;
            // 
            // btnBuscarReserva
            // 
            this.btnBuscarReserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(146)))), ((int)(((byte)(207)))));
            this.btnBuscarReserva.BorderColor = System.Drawing.Color.Aquamarine;
            this.btnBuscarReserva.BorderRadius = 30;
            this.btnBuscarReserva.BorderSize = 0;
            this.btnBuscarReserva.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBuscarReserva.FlatAppearance.BorderSize = 0;
            this.btnBuscarReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarReserva.Font = new System.Drawing.Font("Britannic Bold", 15.75F);
            this.btnBuscarReserva.ForeColor = System.Drawing.Color.White;
            this.btnBuscarReserva.Location = new System.Drawing.Point(1153, 6);
            this.btnBuscarReserva.Margin = new System.Windows.Forms.Padding(53, 6, 53, 9);
            this.btnBuscarReserva.Name = "btnBuscarReserva";
            this.btnBuscarReserva.Size = new System.Drawing.Size(468, 56);
            this.btnBuscarReserva.TabIndex = 2;
            this.btnBuscarReserva.Text = "Buscar";
            this.btnBuscarReserva.UseVisualStyleBackColor = false;
            this.btnBuscarReserva.Click += new System.EventHandler(this.btnBuscarReserva_Click);
            // 
            // txtBuscarReserva
            // 
            this.txtBuscarReserva.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBuscarReserva.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarReserva.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtBuscarReserva.Location = new System.Drawing.Point(242, 16);
            this.txtBuscarReserva.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarReserva.MaxLength = 60;
            this.txtBuscarReserva.Multiline = true;
            this.txtBuscarReserva.Name = "txtBuscarReserva";
            this.txtBuscarReserva.Size = new System.Drawing.Size(615, 38);
            this.txtBuscarReserva.TabIndex = 1;
            this.txtBuscarReserva.Text = "Ingrese el correo electrónico del cliente";
            this.txtBuscarReserva.WordWrap = false;
            this.txtBuscarReserva.Click += new System.EventHandler(this.txtBuscarReserva_Click);
            // 
            // pnlFormulario
            // 
            this.pnlFormulario.Controls.Add(this.gbUsuarios);
            this.pnlFormulario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFormulario.Location = new System.Drawing.Point(0, 530);
            this.pnlFormulario.Margin = new System.Windows.Forms.Padding(4);
            this.pnlFormulario.Name = "pnlFormulario";
            this.pnlFormulario.Padding = new System.Windows.Forms.Padding(53, 25, 53, 25);
            this.pnlFormulario.Size = new System.Drawing.Size(1806, 340);
            this.pnlFormulario.TabIndex = 13;
            // 
            // gbUsuarios
            // 
            this.gbUsuarios.Controls.Add(this.tableLayoutPanel2);
            this.gbUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbUsuarios.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(63)))), ((int)(((byte)(128)))));
            this.gbUsuarios.Location = new System.Drawing.Point(53, 25);
            this.gbUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.gbUsuarios.Name = "gbUsuarios";
            this.gbUsuarios.Padding = new System.Windows.Forms.Padding(4);
            this.gbUsuarios.Size = new System.Drawing.Size(1700, 290);
            this.gbUsuarios.TabIndex = 1;
            this.gbUsuarios.TabStop = false;
            this.gbUsuarios.Text = "Administrar Reservas";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.87122F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.12878F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 34);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1692, 252);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.84298F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.15702F));
            this.tableLayoutPanel3.Controls.Add(this.dtpFechaFinal, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.lblEstado, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.lblFechaRegistro, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblCliente, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblFinal, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.lblInicio, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.cbEstado, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.dtpFechaRegistro, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.dtpFechaInicio, 1, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.02299F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.97701F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(920, 244);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFechaFinal.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpFechaFinal.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaFinal.Location = new System.Drawing.Point(375, 156);
            this.dtpFechaFinal.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(527, 40);
            this.dtpFechaFinal.TabIndex = 13;
            // 
            // lblEstado
            // 
            this.lblEstado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(123, 205);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(111, 33);
            this.lblEstado.TabIndex = 10;
            this.lblEstado.Text = "Estado:";
            // 
            // lblFechaRegistro
            // 
            this.lblFechaRegistro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFechaRegistro.AutoSize = true;
            this.lblFechaRegistro.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaRegistro.Location = new System.Drawing.Point(53, 64);
            this.lblFechaRegistro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaRegistro.Name = "lblFechaRegistro";
            this.lblFechaRegistro.Size = new System.Drawing.Size(251, 33);
            this.lblFechaRegistro.TabIndex = 8;
            this.lblFechaRegistro.Text = "Fecha de registro:";
            // 
            // lblCliente
            // 
            this.lblCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(116, 12);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(125, 33);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente: ";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.11599F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.88401F));
            this.tableLayoutPanel5.Controls.Add(this.txtIdCliente, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.txtCorreo, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(361, 4);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(555, 49);
            this.tableLayoutPanel5.TabIndex = 5;
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIdCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCliente.Location = new System.Drawing.Point(456, 5);
            this.txtIdCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdCliente.Multiline = true;
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.ReadOnly = true;
            this.txtIdCliente.Size = new System.Drawing.Size(69, 38);
            this.txtIdCliente.TabIndex = 1;
            this.txtIdCliente.Visible = false;
            this.txtIdCliente.WordWrap = false;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCorreo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(4, 4);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo.Multiline = true;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.ReadOnly = true;
            this.txtCorreo.Size = new System.Drawing.Size(419, 41);
            this.txtCorreo.TabIndex = 0;
            this.txtCorreo.WordWrap = false;
            // 
            // lblFinal
            // 
            this.lblFinal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFinal.AutoSize = true;
            this.lblFinal.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinal.Location = new System.Drawing.Point(74, 159);
            this.lblFinal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(209, 33);
            this.lblFinal.TabIndex = 2;
            this.lblFinal.Text = "Fecha de final:";
            // 
            // lblInicio
            // 
            this.lblInicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.Location = new System.Drawing.Point(66, 112);
            this.lblInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(224, 33);
            this.lblInicio.TabIndex = 3;
            this.lblInicio.Text = "Fecha de inicio:";
            // 
            // cbEstado
            // 
            this.cbEstado.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(361, 203);
            this.cbEstado.Margin = new System.Windows.Forms.Padding(4);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(431, 40);
            this.cbEstado.TabIndex = 14;
            // 
            // dtpFechaRegistro
            // 
            this.dtpFechaRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpFechaRegistro.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaRegistro.Location = new System.Drawing.Point(361, 61);
            this.dtpFechaRegistro.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaRegistro.MinDate = new System.DateTime(2022, 10, 4, 0, 0, 0, 0);
            this.dtpFechaRegistro.Name = "dtpFechaRegistro";
            this.dtpFechaRegistro.Size = new System.Drawing.Size(555, 37);
            this.dtpFechaRegistro.TabIndex = 9;
            this.dtpFechaRegistro.Value = new System.DateTime(2025, 10, 4, 0, 0, 0, 0);
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFechaInicio.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpFechaInicio.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaInicio.Location = new System.Drawing.Point(373, 109);
            this.dtpFechaInicio.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(531, 40);
            this.dtpFechaInicio.TabIndex = 12;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.btnAregarServicios, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.btnAgregarHabitaciones, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.btnEliminar, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.btnLimpiar, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.btnAgregar, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnEditar, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(932, 4);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.57983F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.42017F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(756, 244);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // btnAregarServicios
            // 
            this.btnAregarServicios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(63)))), ((int)(((byte)(128)))));
            this.btnAregarServicios.BorderColor = System.Drawing.Color.Aquamarine;
            this.btnAregarServicios.BorderRadius = 30;
            this.btnAregarServicios.BorderSize = 0;
            this.btnAregarServicios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAregarServicios.FlatAppearance.BorderSize = 0;
            this.btnAregarServicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAregarServicios.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAregarServicios.ForeColor = System.Drawing.Color.White;
            this.btnAregarServicios.Location = new System.Drawing.Point(391, 156);
            this.btnAregarServicios.Margin = new System.Windows.Forms.Padding(13, 4, 13, 4);
            this.btnAregarServicios.Name = "btnAregarServicios";
            this.btnAregarServicios.Size = new System.Drawing.Size(352, 84);
            this.btnAregarServicios.TabIndex = 3;
            this.btnAregarServicios.Text = "Servicios";
            this.btnAregarServicios.UseVisualStyleBackColor = false;
            this.btnAregarServicios.Click += new System.EventHandler(this.btnAregarServicios_Click);
            // 
            // btnAgregarHabitaciones
            // 
            this.btnAgregarHabitaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(63)))), ((int)(((byte)(128)))));
            this.btnAgregarHabitaciones.BorderColor = System.Drawing.Color.Aquamarine;
            this.btnAgregarHabitaciones.BorderRadius = 30;
            this.btnAgregarHabitaciones.BorderSize = 0;
            this.btnAgregarHabitaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAgregarHabitaciones.FlatAppearance.BorderSize = 0;
            this.btnAgregarHabitaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarHabitaciones.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarHabitaciones.ForeColor = System.Drawing.Color.White;
            this.btnAgregarHabitaciones.Location = new System.Drawing.Point(13, 156);
            this.btnAgregarHabitaciones.Margin = new System.Windows.Forms.Padding(13, 4, 13, 4);
            this.btnAgregarHabitaciones.Name = "btnAgregarHabitaciones";
            this.btnAgregarHabitaciones.Size = new System.Drawing.Size(352, 84);
            this.btnAgregarHabitaciones.TabIndex = 2;
            this.btnAgregarHabitaciones.Text = "Habitaciones";
            this.btnAgregarHabitaciones.UseVisualStyleBackColor = false;
            this.btnAgregarHabitaciones.Click += new System.EventHandler(this.btnAgregarHabitaciones_Click);
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
            this.btnEliminar.Location = new System.Drawing.Point(391, 79);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(13, 4, 13, 9);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(352, 64);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            this.btnLimpiar.Location = new System.Drawing.Point(13, 79);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(13, 4, 13, 9);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(352, 64);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
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
            this.btnAgregar.Location = new System.Drawing.Point(13, 4);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(13, 4, 13, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(352, 67);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
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
            this.btnEditar.Location = new System.Drawing.Point(391, 4);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(13, 4, 13, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(352, 67);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // pnlCliente
            // 
            this.pnlCliente.Controls.Add(this.gbClientes);
            this.pnlCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCliente.Location = new System.Drawing.Point(0, 180);
            this.pnlCliente.Margin = new System.Windows.Forms.Padding(4);
            this.pnlCliente.Name = "pnlCliente";
            this.pnlCliente.Padding = new System.Windows.Forms.Padding(53, 25, 53, 25);
            this.pnlCliente.Size = new System.Drawing.Size(1806, 350);
            this.pnlCliente.TabIndex = 12;
            // 
            // gbClientes
            // 
            this.gbClientes.Controls.Add(this.panel11);
            this.gbClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbClientes.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(46)))), ((int)(((byte)(84)))));
            this.gbClientes.Location = new System.Drawing.Point(53, 25);
            this.gbClientes.Margin = new System.Windows.Forms.Padding(4);
            this.gbClientes.Name = "gbClientes";
            this.gbClientes.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.gbClientes.Size = new System.Drawing.Size(1700, 300);
            this.gbClientes.TabIndex = 2;
            this.gbClientes.TabStop = false;
            this.gbClientes.Text = "Clientes";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.dgvClientes);
            this.panel11.Controls.Add(this.tableLayoutPanel1);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(13, 42);
            this.panel11.Margin = new System.Windows.Forms.Padding(4);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1674, 246);
            this.panel11.TabIndex = 2;
            // 
            // dgvClientes
            // 
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClientes.Location = new System.Drawing.Point(0, 71);
            this.dgvClientes.Margin = new System.Windows.Forms.Padding(4);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(1674, 175);
            this.dgvClientes.TabIndex = 2;
            this.dgvClientes.DoubleClick += new System.EventHandler(this.dgvClientes_DoubleClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.75654F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.24346F));
            this.tableLayoutPanel1.Controls.Add(this.btnBuscarCliente, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtBuscarCliente, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1674, 71);
            this.tableLayoutPanel1.TabIndex = 1;
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
            this.btnBuscarCliente.Location = new System.Drawing.Point(1153, 6);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(53, 6, 53, 9);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(468, 56);
            this.btnBuscarCliente.TabIndex = 2;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBuscarCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarCliente.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtBuscarCliente.Location = new System.Drawing.Point(242, 16);
            this.txtBuscarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarCliente.MaxLength = 60;
            this.txtBuscarCliente.Multiline = true;
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(615, 38);
            this.txtBuscarCliente.TabIndex = 1;
            this.txtBuscarCliente.Text = "Ingrese el correo electrónico del cliente";
            this.txtBuscarCliente.WordWrap = false;
            this.txtBuscarCliente.Click += new System.EventHandler(this.txtBuscarCliente_Click);
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Controls.Add(this.panel7);
            this.pnlTitulo.Controls.Add(this.panel6);
            this.pnlTitulo.Controls.Add(this.panel5);
            this.pnlTitulo.Controls.Add(this.panel4);
            this.pnlTitulo.Controls.Add(this.panel1);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Padding = new System.Windows.Forms.Padding(53, 49, 53, 49);
            this.pnlTitulo.Size = new System.Drawing.Size(1806, 180);
            this.pnlTitulo.TabIndex = 11;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(63)))), ((int)(((byte)(128)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(668, 49);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 4, 13, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(13, 82);
            this.panel7.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(655, 49);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 4, 13, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(13, 82);
            this.panel6.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(63)))), ((int)(((byte)(128)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(638, 49);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 13, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(17, 82);
            this.panel5.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(625, 49);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 13, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(13, 82);
            this.panel4.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(63)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(53, 49);
            this.panel1.Margin = new System.Windows.Forms.Padding(13, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(572, 82);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(182)))), ((int)(((byte)(242)))));
            this.panel3.Controls.Add(this.pbUsuarios);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.panel3.Size = new System.Drawing.Size(151, 82);
            this.panel3.TabIndex = 1;
            // 
            // pbUsuarios
            // 
            this.pbUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbUsuarios.Image = global::Vistas.Properties.Resources.logoReserva;
            this.pbUsuarios.Location = new System.Drawing.Point(13, 12);
            this.pbUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.pbUsuarios.Name = "pbUsuarios";
            this.pbUsuarios.Size = new System.Drawing.Size(125, 58);
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
            this.label1.Location = new System.Drawing.Point(223, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reservas";
            // 
            // frmReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(900, 500);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1827, 922);
            this.Controls.Add(this.pnlPrincipal);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmReservas";
            this.Text = "frmReservas";
            this.Load += new System.EventHandler(this.frmReservas_Load);
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlReserva.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.pnlFormulario.ResumeLayout(false);
            this.gbUsuarios.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.pnlCliente.ResumeLayout(false);
            this.gbClientes.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnlTitulo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Panel pnlFormulario;
        private System.Windows.Forms.GroupBox gbUsuarios;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblFechaRegistro;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private Clases.RedondearBoton btnAregarServicios;
        private Clases.RedondearBoton btnAgregarHabitaciones;
        private Clases.RedondearBoton btnEliminar;
        private Clases.RedondearBoton btnLimpiar;
        private Clases.RedondearBoton btnAgregar;
        private Clases.RedondearBoton btnEditar;
        private System.Windows.Forms.Panel pnlCliente;
        private System.Windows.Forms.GroupBox gbClientes;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pbUsuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Panel pnlReserva;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Clases.RedondearBoton btnBuscarCliente;
        private System.Windows.Forms.TextBox txtBuscarCliente;
        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private Clases.RedondearBoton btnBuscarReserva;
        private System.Windows.Forms.TextBox txtBuscarReserva;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DateTimePicker dtpFechaRegistro;
    }
}