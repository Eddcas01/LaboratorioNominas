namespace Lab2Vista
{
    partial class Nomina
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgb_nomina = new System.Windows.Forms.DataGridView();
            this.Gb_encab = new System.Windows.Forms.GroupBox();
            this.Dtp_fechalim = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.Lbl_date = new System.Windows.Forms.Label();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.grb_detalle = new System.Windows.Forms.GroupBox();
            this.cmb_emp = new CapaVista.Combo();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_orden = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_concepto = new CapaVista.Combo();
            this.cod = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_emp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtvalorconcepto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgb_nomina)).BeginInit();
            this.Gb_encab.SuspendLayout();
            this.grb_detalle.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(138)))), ((int)(((byte)(210)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.7792F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.2208F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(753, 93);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(138)))), ((int)(((byte)(210)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(626, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 87);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(138)))), ((int)(((byte)(210)))));
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(617, 93);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nomina";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgb_nomina
            // 
            this.dgb_nomina.AllowUserToAddRows = false;
            this.dgb_nomina.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgb_nomina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgb_nomina.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c,
            this.cod_emp,
            this.Column1,
            this.Column2});
            this.dgb_nomina.Location = new System.Drawing.Point(10, 497);
            this.dgb_nomina.Name = "dgb_nomina";
            this.dgb_nomina.ReadOnly = true;
            this.dgb_nomina.RowHeadersWidth = 51;
            this.dgb_nomina.RowTemplate.Height = 24;
            this.dgb_nomina.Size = new System.Drawing.Size(723, 145);
            this.dgb_nomina.TabIndex = 19;
            // 
            // Gb_encab
            // 
            this.Gb_encab.Controls.Add(this.cod);
            this.Gb_encab.Controls.Add(this.label9);
            this.Gb_encab.Controls.Add(this.tableLayoutPanel2);
            this.Gb_encab.Controls.Add(this.Dtp_fechalim);
            this.Gb_encab.Controls.Add(this.label6);
            this.Gb_encab.Controls.Add(this.Lbl_date);
            this.Gb_encab.Controls.Add(this.lbl_fecha);
            this.Gb_encab.Location = new System.Drawing.Point(12, 99);
            this.Gb_encab.Name = "Gb_encab";
            this.Gb_encab.Size = new System.Drawing.Size(721, 168);
            this.Gb_encab.TabIndex = 20;
            this.Gb_encab.TabStop = false;
            this.Gb_encab.Text = "Encabezado";
            // 
            // Dtp_fechalim
            // 
            this.Dtp_fechalim.Location = new System.Drawing.Point(194, 104);
            this.Dtp_fechalim.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.Dtp_fechalim.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.Dtp_fechalim.Name = "Dtp_fechalim";
            this.Dtp_fechalim.Size = new System.Drawing.Size(204, 25);
            this.Dtp_fechalim.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 18);
            this.label6.TabIndex = 25;
            this.label6.Text = "Fecha Limite";
            // 
            // Lbl_date
            // 
            this.Lbl_date.AutoSize = true;
            this.Lbl_date.Location = new System.Drawing.Point(194, 73);
            this.Lbl_date.Name = "Lbl_date";
            this.Lbl_date.Size = new System.Drawing.Size(51, 18);
            this.Lbl_date.TabIndex = 24;
            this.Lbl_date.Text = "fecha";
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Location = new System.Drawing.Point(21, 73);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(58, 18);
            this.lbl_fecha.TabIndex = 23;
            this.lbl_fecha.Text = "Fecha ";
            // 
            // grb_detalle
            // 
            this.grb_detalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grb_detalle.Controls.Add(this.label8);
            this.grb_detalle.Controls.Add(this.txtvalorconcepto);
            this.grb_detalle.Controls.Add(this.cmb_concepto);
            this.grb_detalle.Controls.Add(this.tableLayoutPanel3);
            this.grb_detalle.Controls.Add(this.cmb_emp);
            this.grb_detalle.Controls.Add(this.tableLayoutPanel5);
            this.grb_detalle.Controls.Add(this.label7);
            this.grb_detalle.Controls.Add(this.lbl_cantidad);
            this.grb_detalle.ForeColor = System.Drawing.Color.Black;
            this.grb_detalle.Location = new System.Drawing.Point(12, 287);
            this.grb_detalle.Name = "grb_detalle";
            this.grb_detalle.Size = new System.Drawing.Size(721, 180);
            this.grb_detalle.TabIndex = 21;
            this.grb_detalle.TabStop = false;
            this.grb_detalle.Text = "Detalle";
            // 
            // cmb_emp
            // 
            this.cmb_emp.Location = new System.Drawing.Point(168, 50);
            this.cmb_emp.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.cmb_emp.Name = "cmb_emp";
            this.cmb_emp.Size = new System.Drawing.Size(156, 33);
            this.cmb_emp.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "Empleado";
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.Location = new System.Drawing.Point(19, 97);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(83, 18);
            this.lbl_cantidad.TabIndex = 0;
            this.lbl_cantidad.Text = "Concepto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(96, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 50);
            this.label4.TabIndex = 16;
            this.label4.Text = "Eliminar ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 50);
            this.label3.TabIndex = 15;
            this.label3.Text = "Agregar";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(60)))), ((int)(((byte)(192)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(96, 53);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 40);
            this.button4.TabIndex = 12;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(60)))), ((int)(((byte)(192)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(3, 53);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 40);
            this.button3.TabIndex = 11;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.47368F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.52632F));
            this.tableLayoutPanel5.Controls.Add(this.button3, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.button4, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(388, 62);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(190, 100);
            this.tableLayoutPanel5.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 56);
            this.label1.TabIndex = 14;
            this.label1.Text = "Enviar Orden";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(60)))), ((int)(((byte)(192)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(3, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 38);
            this.button2.TabIndex = 10;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.button2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(606, 62);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(96, 100);
            this.tableLayoutPanel3.TabIndex = 21;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btn_orden, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(535, 39);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(96, 100);
            this.tableLayoutPanel2.TabIndex = 27;
            // 
            // btn_orden
            // 
            this.btn_orden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.btn_orden.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_orden.FlatAppearance.BorderSize = 0;
            this.btn_orden.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(60)))), ((int)(((byte)(192)))));
            this.btn_orden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_orden.ForeColor = System.Drawing.Color.Black;
            this.btn_orden.Location = new System.Drawing.Point(3, 59);
            this.btn_orden.Name = "btn_orden";
            this.btn_orden.Size = new System.Drawing.Size(90, 38);
            this.btn_orden.TabIndex = 10;
            this.btn_orden.UseVisualStyleBackColor = false;
            this.btn_orden.Click += new System.EventHandler(this.Btn_orden_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 56);
            this.label2.TabIndex = 14;
            this.label2.Text = "Generar Orden";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_concepto
            // 
            this.cmb_concepto.Location = new System.Drawing.Point(168, 97);
            this.cmb_concepto.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.cmb_concepto.Name = "cmb_concepto";
            this.cmb_concepto.Size = new System.Drawing.Size(156, 29);
            this.cmb_concepto.TabIndex = 22;
            // 
            // cod
            // 
            this.cod.AutoSize = true;
            this.cod.Location = new System.Drawing.Point(192, 39);
            this.cod.Name = "cod";
            this.cod.Size = new System.Drawing.Size(40, 18);
            this.cod.TabIndex = 29;
            this.cod.Text = "Cod";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 18);
            this.label9.TabIndex = 28;
            this.label9.Text = "Cod Encabezado";
            // 
            // c
            // 
            this.c.HeaderText = "cod_nomina";
            this.c.MinimumWidth = 6;
            this.c.Name = "c";
            this.c.ReadOnly = true;
            // 
            // cod_emp
            // 
            this.cod_emp.HeaderText = "Codigo empleado";
            this.cod_emp.MinimumWidth = 6;
            this.cod_emp.Name = "cod_emp";
            this.cod_emp.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo_concepto";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Valor Nomina";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // txtvalorconcepto
            // 
            this.txtvalorconcepto.Location = new System.Drawing.Point(168, 132);
            this.txtvalorconcepto.Name = "txtvalorconcepto";
            this.txtvalorconcepto.Size = new System.Drawing.Size(156, 25);
            this.txtvalorconcepto.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 18);
            this.label8.TabIndex = 24;
            this.label8.Text = "Valor Concepto";
            // 
            // Nomina
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(753, 681);
            this.Controls.Add(this.grb_detalle);
            this.Controls.Add(this.Gb_encab);
            this.Controls.Add(this.dgb_nomina);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.8F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Nomina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nomina";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgb_nomina)).EndInit();
            this.Gb_encab.ResumeLayout(false);
            this.Gb_encab.PerformLayout();
            this.grb_detalle.ResumeLayout(false);
            this.grb_detalle.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgb_nomina;
        private System.Windows.Forms.GroupBox Gb_encab;
        private System.Windows.Forms.Label cod;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_orden;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker Dtp_fechalim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Lbl_date;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.GroupBox grb_detalle;
        private CapaVista.Combo cmb_concepto;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private CapaVista.Combo cmb_emp;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn c;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_emp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtvalorconcepto;
    }
}