namespace Vistas.Formularios
{
    partial class frmHabitaciones
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBuscar = new Vistas.Clases.RedondearBoton();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgvHabitacion = new System.Windows.Forms.DataGridView();
            this.panel8 = new System.Windows.Forms.Panel();
            this.gbHabitaciones = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.txtCamas = new System.Windows.Forms.TextBox();
            this.lblNumCamas = new System.Windows.Forms.Label();
            this.txtNombreHabitacion = new System.Windows.Forms.TextBox();
            this.lblNombreHabitacion = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.MaskedTextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnEliminar = new Vistas.Clases.RedondearBoton();
            this.btnLimpiar = new Vistas.Clases.RedondearBoton();
            this.btnAgregar = new Vistas.Clases.RedondearBoton();
            this.btnEditar = new Vistas.Clases.RedondearBoton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblHabitaciones = new System.Windows.Forms.Label();
            this.pbUsuarios = new System.Windows.Forms.PictureBox();
            this.panel9.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitacion)).BeginInit();
            this.panel8.SuspendLayout();
            this.gbHabitaciones.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.groupBox1);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 409);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(40, 20, 40, 20);
            this.panel9.Size = new System.Drawing.Size(1013, 467);
            this.panel9.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel4);
            this.groupBox1.Controls.Add(this.dgvHabitacion);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Moving", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(46)))), ((int)(((byte)(84)))));
            this.groupBox1.Location = new System.Drawing.Point(40, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(933, 427);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Habitaciones";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.75654F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.24346F));
            this.tableLayoutPanel4.Controls.Add(this.btnBuscar, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtBuscar, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(10, 34);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(913, 56);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(146)))), ((int)(((byte)(207)))));
            this.btnBuscar.BorderColor = System.Drawing.Color.Aquamarine;
            this.btnBuscar.BorderRadius = 30;
            this.btnBuscar.BorderSize = 0;
            this.btnBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Britannic Bold", 15.75F);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(640, 5);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(40, 5, 40, 7);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(233, 44);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(69, 12);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(462, 32);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.WordWrap = false;
            // 
            // dgvHabitacion
            // 
            this.dgvHabitacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHabitacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHabitacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHabitacion.Location = new System.Drawing.Point(10, 34);
            this.dgvHabitacion.Name = "dgvHabitacion";
            this.dgvHabitacion.Size = new System.Drawing.Size(913, 383);
            this.dgvHabitacion.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.gbHabitaciones);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 152);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(40, 20, 40, 20);
            this.panel8.Size = new System.Drawing.Size(1013, 257);
            this.panel8.TabIndex = 5;
            // 
            // gbHabitaciones
            // 
            this.gbHabitaciones.Controls.Add(this.tableLayoutPanel1);
            this.gbHabitaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbHabitaciones.Font = new System.Drawing.Font("Moving", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbHabitaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(46)))), ((int)(((byte)(84)))));
            this.gbHabitaciones.Location = new System.Drawing.Point(40, 20);
            this.gbHabitaciones.Name = "gbHabitaciones";
            this.gbHabitaciones.Size = new System.Drawing.Size(933, 217);
            this.gbHabitaciones.TabIndex = 0;
            this.gbHabitaciones.TabStop = false;
            this.gbHabitaciones.Text = "Administrar Habitaciones";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.87122F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.12878F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(927, 187);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.84298F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.15702F));
            this.tableLayoutPanel2.Controls.Add(this.txtUbicacion, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblUbicacion, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtCamas, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblNumCamas, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtNombreHabitacion, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblNombreHabitacion, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblPrecio, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtPrecio, 1, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.03846F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.96154F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(502, 181);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUbicacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUbicacion.Location = new System.Drawing.Point(206, 99);
            this.txtUbicacion.Multiline = true;
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(284, 32);
            this.txtUbicacion.TabIndex = 7;
            this.txtUbicacion.WordWrap = false;
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUbicacion.Location = new System.Drawing.Point(38, 103);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(117, 24);
            this.lblUbicacion.TabIndex = 6;
            this.lblUbicacion.Text = "Ubicacion:";
            // 
            // txtCamas
            // 
            this.txtCamas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCamas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCamas.Location = new System.Drawing.Point(206, 55);
            this.txtCamas.Multiline = true;
            this.txtCamas.Name = "txtCamas";
            this.txtCamas.Size = new System.Drawing.Size(284, 32);
            this.txtCamas.TabIndex = 4;
            this.txtCamas.WordWrap = false;
            // 
            // lblNumCamas
            // 
            this.lblNumCamas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNumCamas.AutoSize = true;
            this.lblNumCamas.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumCamas.Location = new System.Drawing.Point(39, 59);
            this.lblNumCamas.Name = "lblNumCamas";
            this.lblNumCamas.Size = new System.Drawing.Size(116, 24);
            this.lblNumCamas.TabIndex = 3;
            this.lblNumCamas.Text = "N° camas:";
            // 
            // txtNombreHabitacion
            // 
            this.txtNombreHabitacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombreHabitacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreHabitacion.Location = new System.Drawing.Point(206, 7);
            this.txtNombreHabitacion.Multiline = true;
            this.txtNombreHabitacion.Name = "txtNombreHabitacion";
            this.txtNombreHabitacion.Size = new System.Drawing.Size(284, 32);
            this.txtNombreHabitacion.TabIndex = 0;
            this.txtNombreHabitacion.WordWrap = false;
            // 
            // lblNombreHabitacion
            // 
            this.lblNombreHabitacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombreHabitacion.AutoSize = true;
            this.lblNombreHabitacion.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreHabitacion.Location = new System.Drawing.Point(20, 11);
            this.lblNombreHabitacion.Name = "lblNombreHabitacion";
            this.lblNombreHabitacion.Size = new System.Drawing.Size(153, 24);
            this.lblNombreHabitacion.TabIndex = 0;
            this.lblNombreHabitacion.Text = "N° o nombre: ";
            // 
            // lblPrecio
            // 
            this.lblPrecio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(58, 146);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(78, 24);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "Precio:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(197, 139);
            this.txtPrecio.Mask = "00000";
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 31);
            this.txtPrecio.TabIndex = 5;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btnEliminar, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnLimpiar, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnAgregar, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnEditar, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(511, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.36709F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.63291F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(413, 181);
            this.tableLayoutPanel3.TabIndex = 1;
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
            this.btnEliminar.Location = new System.Drawing.Point(226, 109);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(20);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(167, 52);
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
            this.btnLimpiar.Location = new System.Drawing.Point(20, 109);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(20);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(166, 52);
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
            this.btnAgregar.Location = new System.Drawing.Point(20, 20);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(20);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(166, 49);
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
            this.btnEditar.Location = new System.Drawing.Point(226, 20);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(20);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(167, 49);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
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
            this.panel2.Size = new System.Drawing.Size(1013, 152);
            this.panel2.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(63)))), ((int)(((byte)(128)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(502, 40);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 72);
            this.panel7.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(492, 40);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 72);
            this.panel6.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(63)))), ((int)(((byte)(128)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(479, 40);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(13, 72);
            this.panel5.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(469, 40);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 72);
            this.panel4.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(63)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lblHabitaciones);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(40, 40);
            this.panel1.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 72);
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
            this.panel3.Size = new System.Drawing.Size(113, 72);
            this.panel3.TabIndex = 1;
            // 
            // lblHabitaciones
            // 
            this.lblHabitaciones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHabitaciones.AutoSize = true;
            this.lblHabitaciones.Font = new System.Drawing.Font("Britannic Bold", 36F);
            this.lblHabitaciones.ForeColor = System.Drawing.Color.White;
            this.lblHabitaciones.Location = new System.Drawing.Point(128, 9);
            this.lblHabitaciones.Name = "lblHabitaciones";
            this.lblHabitaciones.Size = new System.Drawing.Size(295, 53);
            this.lblHabitaciones.TabIndex = 0;
            this.lblHabitaciones.Text = "Habitaciones";
            // 
            // pbUsuarios
            // 
            this.pbUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbUsuarios.Image = global::Vistas.Properties.Resources.logoHabitacion;
            this.pbUsuarios.Location = new System.Drawing.Point(10, 10);
            this.pbUsuarios.Name = "pbUsuarios";
            this.pbUsuarios.Size = new System.Drawing.Size(93, 52);
            this.pbUsuarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUsuarios.TabIndex = 0;
            this.pbUsuarios.TabStop = false;
            // 
            // frmHabitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(900, 609);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1030, 631);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel2);
            this.Name = "frmHabitaciones";
            this.Text = "frmHabitaciones";
            this.panel9.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitacion)).EndInit();
            this.panel8.ResumeLayout(false);
            this.gbHabitaciones.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvHabitacion;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.GroupBox gbHabitaciones;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtCamas;
        private System.Windows.Forms.Label lblNumCamas;
        private System.Windows.Forms.TextBox txtNombreHabitacion;
        private System.Windows.Forms.Label lblNombreHabitacion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Clases.RedondearBoton btnEliminar;
        private Clases.RedondearBoton btnLimpiar;
        private Clases.RedondearBoton btnAgregar;
        private Clases.RedondearBoton btnEditar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pbUsuarios;
        private System.Windows.Forms.Label lblHabitaciones;
        private System.Windows.Forms.MaskedTextBox txtPrecio;
        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.Label lblUbicacion;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private Clases.RedondearBoton btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
    }
}