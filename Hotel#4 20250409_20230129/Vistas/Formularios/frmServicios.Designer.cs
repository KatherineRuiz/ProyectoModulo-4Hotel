namespace Vistas.Formularios
{
    partial class frmServicios
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
            this.panel9 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.dgvServicios = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBuscar = new Vistas.Clases.RedondearBoton();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.gbServicios = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtNombreServicio = new System.Windows.Forms.TextBox();
            this.lblNombreServicio = new System.Windows.Forms.Label();
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
            this.pbUsuarios = new System.Windows.Forms.PictureBox();
            this.lblServicios = new System.Windows.Forms.Label();
            this.tlpAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.panel9.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.gbServicios.SuspendLayout();
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
            this.panel9.Location = new System.Drawing.Point(0, 460);
            this.panel9.Margin = new System.Windows.Forms.Padding(4);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(53, 25, 53, 25);
            this.panel9.Size = new System.Drawing.Size(1373, 466);
            this.panel9.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel10);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(46)))), ((int)(((byte)(84)))));
            this.groupBox1.Location = new System.Drawing.Point(53, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.groupBox1.Size = new System.Drawing.Size(1267, 416);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Servicios";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.dgvServicios);
            this.panel10.Controls.Add(this.tableLayoutPanel4);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(13, 39);
            this.panel10.Margin = new System.Windows.Forms.Padding(4);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1241, 365);
            this.panel10.TabIndex = 2;
            // 
            // dgvServicios
            // 
            this.dgvServicios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvServicios.Location = new System.Drawing.Point(0, 71);
            this.dgvServicios.Margin = new System.Windows.Forms.Padding(4);
            this.dgvServicios.Name = "dgvServicios";
            this.dgvServicios.ReadOnly = true;
            this.dgvServicios.RowHeadersVisible = false;
            this.dgvServicios.RowHeadersWidth = 51;
            this.dgvServicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServicios.Size = new System.Drawing.Size(1241, 294);
            this.dgvServicios.TabIndex = 4;
            this.dgvServicios.DoubleClick += new System.EventHandler(this.dgvServicios_DoubleClick);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.75654F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.24346F));
            this.tableLayoutPanel4.Controls.Add(this.btnBuscar, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtBuscar, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1241, 71);
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
            this.btnBuscar.Location = new System.Drawing.Point(869, 6);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(53, 6, 53, 9);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(319, 56);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(100, 16);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(615, 38);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.WordWrap = false;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.gbServicios);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 186);
            this.panel8.Margin = new System.Windows.Forms.Padding(4);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(53, 25, 53, 25);
            this.panel8.Size = new System.Drawing.Size(1373, 274);
            this.panel8.TabIndex = 5;
            // 
            // gbServicios
            // 
            this.gbServicios.Controls.Add(this.tableLayoutPanel1);
            this.gbServicios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbServicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbServicios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(46)))), ((int)(((byte)(84)))));
            this.gbServicios.Location = new System.Drawing.Point(53, 25);
            this.gbServicios.Margin = new System.Windows.Forms.Padding(4);
            this.gbServicios.Name = "gbServicios";
            this.gbServicios.Padding = new System.Windows.Forms.Padding(4);
            this.gbServicios.Size = new System.Drawing.Size(1267, 224);
            this.gbServicios.TabIndex = 0;
            this.gbServicios.TabStop = false;
            this.gbServicios.Text = "Administrar Servicios";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.87122F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.12878F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 31);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1259, 189);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.84298F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.15702F));
            this.tableLayoutPanel2.Controls.Add(this.txtNombreServicio, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblNombreServicio, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.03846F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(682, 181);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // txtNombreServicio
            // 
            this.txtNombreServicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombreServicio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreServicio.Location = new System.Drawing.Point(280, 71);
            this.txtNombreServicio.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreServicio.MaxLength = 30;
            this.txtNombreServicio.Multiline = true;
            this.txtNombreServicio.Name = "txtNombreServicio";
            this.txtNombreServicio.Size = new System.Drawing.Size(385, 38);
            this.txtNombreServicio.TabIndex = 0;
            this.tlpAyuda.SetToolTip(this.txtNombreServicio, "Escribe el nombre de tu servicio");
            this.txtNombreServicio.WordWrap = false;
            this.txtNombreServicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreServicio_KeyPress);
            // 
            // lblNombreServicio
            // 
            this.lblNombreServicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombreServicio.AutoSize = true;
            this.lblNombreServicio.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreServicio.Location = new System.Drawing.Point(69, 74);
            this.lblNombreServicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreServicio.Name = "lblNombreServicio";
            this.lblNombreServicio.Size = new System.Drawing.Size(125, 33);
            this.lblNombreServicio.TabIndex = 0;
            this.lblNombreServicio.Text = "Servicio:";
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
            this.tableLayoutPanel3.Location = new System.Drawing.Point(694, 4);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.34014F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.65986F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(561, 181);
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
            this.btnEliminar.Font = new System.Drawing.Font("Britannic Bold", 15.75F);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(300, 109);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(20, 18, 20, 18);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(241, 54);
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
            this.btnLimpiar.Font = new System.Drawing.Font("Britannic Bold", 15.75F);
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(20, 109);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(20, 18, 20, 18);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(240, 54);
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
            this.btnAgregar.Font = new System.Drawing.Font("Britannic Bold", 15.75F);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(20, 18);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(20, 18, 20, 18);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(240, 55);
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
            this.btnEditar.Font = new System.Drawing.Font("Britannic Bold", 15.75F);
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(300, 18);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(20, 18, 20, 18);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(241, 55);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
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
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(53, 49, 53, 49);
            this.panel2.Size = new System.Drawing.Size(1373, 186);
            this.panel2.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(63)))), ((int)(((byte)(128)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(668, 49);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 4, 13, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(13, 88);
            this.panel7.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(655, 49);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 4, 13, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(13, 88);
            this.panel6.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(63)))), ((int)(((byte)(128)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(638, 49);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 13, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(17, 88);
            this.panel5.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(625, 49);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 13, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(13, 88);
            this.panel4.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(63)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lblServicios);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(53, 49);
            this.panel1.Margin = new System.Windows.Forms.Padding(13, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(572, 88);
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
            this.panel3.Size = new System.Drawing.Size(151, 88);
            this.panel3.TabIndex = 1;
            // 
            // pbUsuarios
            // 
            this.pbUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbUsuarios.Image = global::Vistas.Properties.Resources.logoServicios;
            this.pbUsuarios.Location = new System.Drawing.Point(13, 12);
            this.pbUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.pbUsuarios.Name = "pbUsuarios";
            this.pbUsuarios.Size = new System.Drawing.Size(125, 64);
            this.pbUsuarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUsuarios.TabIndex = 0;
            this.pbUsuarios.TabStop = false;
            // 
            // lblServicios
            // 
            this.lblServicios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblServicios.AutoSize = true;
            this.lblServicios.Font = new System.Drawing.Font("Britannic Bold", 36F);
            this.lblServicios.ForeColor = System.Drawing.Color.White;
            this.lblServicios.Location = new System.Drawing.Point(223, 13);
            this.lblServicios.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServicios.Name = "lblServicios";
            this.lblServicios.Size = new System.Drawing.Size(268, 67);
            this.lblServicios.TabIndex = 0;
            this.lblServicios.Text = "Servicios";
            // 
            // frmServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1373, 777);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmServicios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmServicios";
            this.Load += new System.EventHandler(this.frmServicios_Load);
            this.panel9.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.gbServicios.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.GroupBox gbServicios;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtNombreServicio;
        private System.Windows.Forms.Label lblNombreServicio;
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
        private System.Windows.Forms.Label lblServicios;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.DataGridView dgvServicios;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private Clases.RedondearBoton btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ToolTip tlpAyuda;
    }
}