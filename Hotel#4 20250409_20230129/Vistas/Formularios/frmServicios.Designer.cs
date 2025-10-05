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
            this.panel9 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBuscar = new Vistas.Clases.RedondearBoton();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgvServicios = new System.Windows.Forms.DataGridView();
            this.panel8 = new System.Windows.Forms.Panel();
            this.gbServicios = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txttxtNombreServicio = new System.Windows.Forms.TextBox();
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
            this.lblServicios = new System.Windows.Forms.Label();
            this.pbUsuarios = new System.Windows.Forms.PictureBox();
            this.panel9.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel10.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).BeginInit();
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
            this.panel9.Location = new System.Drawing.Point(0, 374);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(40, 20, 40, 20);
            this.panel9.Size = new System.Drawing.Size(1030, 379);
            this.panel9.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel10);
            this.groupBox1.Controls.Add(this.dgvServicios);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Moving", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(46)))), ((int)(((byte)(84)))));
            this.groupBox1.Location = new System.Drawing.Point(40, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(950, 339);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Servicios";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.tableLayoutPanel4);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(10, 34);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(930, 58);
            this.panel10.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.75654F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.24346F));
            this.tableLayoutPanel4.Controls.Add(this.btnBuscar, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtBuscar, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(930, 58);
            this.tableLayoutPanel4.TabIndex = 0;
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
            this.btnBuscar.Location = new System.Drawing.Point(651, 5);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(40, 5, 40, 7);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(239, 46);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(74, 13);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(462, 32);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.WordWrap = false;
            // 
            // dgvServicios
            // 
            this.dgvServicios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvServicios.Location = new System.Drawing.Point(10, 34);
            this.dgvServicios.Name = "dgvServicios";
            this.dgvServicios.Size = new System.Drawing.Size(930, 295);
            this.dgvServicios.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.gbServicios);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 151);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(40, 20, 40, 20);
            this.panel8.Size = new System.Drawing.Size(1030, 223);
            this.panel8.TabIndex = 5;
            // 
            // gbServicios
            // 
            this.gbServicios.Controls.Add(this.tableLayoutPanel1);
            this.gbServicios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbServicios.Font = new System.Drawing.Font("Moving", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbServicios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(46)))), ((int)(((byte)(84)))));
            this.gbServicios.Location = new System.Drawing.Point(40, 20);
            this.gbServicios.Name = "gbServicios";
            this.gbServicios.Size = new System.Drawing.Size(950, 183);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(944, 153);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.84298F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.15702F));
            this.tableLayoutPanel2.Controls.Add(this.txttxtNombreServicio, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblNombreServicio, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.03846F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(511, 147);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // txttxtNombreServicio
            // 
            this.txttxtNombreServicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txttxtNombreServicio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttxtNombreServicio.Location = new System.Drawing.Point(209, 57);
            this.txttxtNombreServicio.Multiline = true;
            this.txttxtNombreServicio.Name = "txttxtNombreServicio";
            this.txttxtNombreServicio.Size = new System.Drawing.Size(290, 32);
            this.txttxtNombreServicio.TabIndex = 0;
            this.txttxtNombreServicio.WordWrap = false;
            // 
            // lblNombreServicio
            // 
            this.lblNombreServicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombreServicio.AutoSize = true;
            this.lblNombreServicio.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreServicio.Location = new System.Drawing.Point(53, 61);
            this.lblNombreServicio.Name = "lblNombreServicio";
            this.lblNombreServicio.Size = new System.Drawing.Size(92, 24);
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
            this.tableLayoutPanel3.Location = new System.Drawing.Point(520, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.34014F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.65986F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(421, 147);
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
            this.btnEliminar.Location = new System.Drawing.Point(225, 89);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(15);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(181, 43);
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
            this.btnLimpiar.Font = new System.Drawing.Font("Britannic Bold", 15.75F);
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(15, 89);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(15);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(180, 43);
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
            this.btnAgregar.Location = new System.Drawing.Point(15, 15);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(15);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(180, 44);
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
            this.btnEditar.Font = new System.Drawing.Font("Britannic Bold", 15.75F);
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(225, 15);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(15);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(181, 44);
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
            this.panel2.Size = new System.Drawing.Size(1030, 151);
            this.panel2.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(63)))), ((int)(((byte)(128)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(502, 40);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 71);
            this.panel7.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(492, 40);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 71);
            this.panel6.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(63)))), ((int)(((byte)(128)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(479, 40);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(13, 71);
            this.panel5.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(469, 40);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 71);
            this.panel4.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(63)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lblServicios);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(40, 40);
            this.panel1.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 71);
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
            this.panel3.Size = new System.Drawing.Size(113, 71);
            this.panel3.TabIndex = 1;
            // 
            // lblServicios
            // 
            this.lblServicios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblServicios.AutoSize = true;
            this.lblServicios.Font = new System.Drawing.Font("Britannic Bold", 36F);
            this.lblServicios.ForeColor = System.Drawing.Color.White;
            this.lblServicios.Location = new System.Drawing.Point(167, 10);
            this.lblServicios.Name = "lblServicios";
            this.lblServicios.Size = new System.Drawing.Size(213, 53);
            this.lblServicios.TabIndex = 0;
            this.lblServicios.Text = "Servicios";
            // 
            // pbUsuarios
            // 
            this.pbUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbUsuarios.Image = global::Vistas.Properties.Resources.logoServicios;
            this.pbUsuarios.Location = new System.Drawing.Point(10, 10);
            this.pbUsuarios.Name = "pbUsuarios";
            this.pbUsuarios.Size = new System.Drawing.Size(93, 51);
            this.pbUsuarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUsuarios.TabIndex = 0;
            this.pbUsuarios.TabStop = false;
            // 
            // frmServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1030, 631);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel2);
            this.Name = "frmServicios";
            this.Text = "frmServicios";
            this.panel9.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvServicios;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.GroupBox gbServicios;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txttxtNombreServicio;
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private Clases.RedondearBoton btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
    }
}