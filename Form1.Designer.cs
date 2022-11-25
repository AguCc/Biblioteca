
namespace BibliotecaAa
{
    partial class Form1
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
            System.Windows.Forms.Timer horaFecha;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDeLibrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaDeLibrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peticionDeLibrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queClaseDeLibroUstedOstentaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.entidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prestamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devolucionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baseDeDatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            horaFecha = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // horaFecha
            // 
            horaFecha.Enabled = true;
            horaFecha.Tick += new System.EventHandler(this.horaFecha_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem,
            this.entidadesToolStripMenuItem,
            this.baseDeDatoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1058, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaDeLibrosToolStripMenuItem,
            this.gestionDeStockToolStripMenuItem,
            this.bajaDeLibrosToolStripMenuItem,
            this.peticionDeLibrosToolStripMenuItem});
            this.testToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("testToolStripMenuItem.Image")));
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.testToolStripMenuItem.Text = "Gestion de libros";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // altaDeLibrosToolStripMenuItem
            // 
            this.altaDeLibrosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("altaDeLibrosToolStripMenuItem.Image")));
            this.altaDeLibrosToolStripMenuItem.Name = "altaDeLibrosToolStripMenuItem";
            this.altaDeLibrosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.altaDeLibrosToolStripMenuItem.Text = "Alta de libros";
            this.altaDeLibrosToolStripMenuItem.Click += new System.EventHandler(this.altaDeLibrosToolStripMenuItem_Click);
            // 
            // gestionDeStockToolStripMenuItem
            // 
            this.gestionDeStockToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("gestionDeStockToolStripMenuItem.Image")));
            this.gestionDeStockToolStripMenuItem.Name = "gestionDeStockToolStripMenuItem";
            this.gestionDeStockToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gestionDeStockToolStripMenuItem.Text = "Stock";
            this.gestionDeStockToolStripMenuItem.Click += new System.EventHandler(this.gestionDeStockToolStripMenuItem_Click);
            // 
            // bajaDeLibrosToolStripMenuItem
            // 
            this.bajaDeLibrosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bajaDeLibrosToolStripMenuItem.Image")));
            this.bajaDeLibrosToolStripMenuItem.Name = "bajaDeLibrosToolStripMenuItem";
            this.bajaDeLibrosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bajaDeLibrosToolStripMenuItem.Text = "Baja de libros";
            this.bajaDeLibrosToolStripMenuItem.Click += new System.EventHandler(this.bajaDeLibrosToolStripMenuItem_Click);
            // 
            // peticionDeLibrosToolStripMenuItem
            // 
            this.peticionDeLibrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.queClaseDeLibroUstedOstentaToolStripMenuItem1});
            this.peticionDeLibrosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("peticionDeLibrosToolStripMenuItem.Image")));
            this.peticionDeLibrosToolStripMenuItem.Name = "peticionDeLibrosToolStripMenuItem";
            this.peticionDeLibrosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.peticionDeLibrosToolStripMenuItem.Text = "Peticion de libros";
            this.peticionDeLibrosToolStripMenuItem.Click += new System.EventHandler(this.peticionDeLibrosToolStripMenuItem_Click);
            // 
            // queClaseDeLibroUstedOstentaToolStripMenuItem1
            // 
            this.queClaseDeLibroUstedOstentaToolStripMenuItem1.Name = "queClaseDeLibroUstedOstentaToolStripMenuItem1";
            this.queClaseDeLibroUstedOstentaToolStripMenuItem1.Size = new System.Drawing.Size(252, 22);
            this.queClaseDeLibroUstedOstentaToolStripMenuItem1.Text = "¿Que clase de libro usted ostenta?";
            this.queClaseDeLibroUstedOstentaToolStripMenuItem1.CheckedChanged += new System.EventHandler(this.queClaseDeLibroUstedOstentaToolStripMenuItem_Click);
            this.queClaseDeLibroUstedOstentaToolStripMenuItem1.CheckStateChanged += new System.EventHandler(this.button1_Click);
            this.queClaseDeLibroUstedOstentaToolStripMenuItem1.DropDownClosed += new System.EventHandler(this.salirToolStripMenuItem_Click);
            this.queClaseDeLibroUstedOstentaToolStripMenuItem1.DropDownOpening += new System.EventHandler(this.button1_Click);
            this.queClaseDeLibroUstedOstentaToolStripMenuItem1.DropDownOpened += new System.EventHandler(this.Form1_Load);
            this.queClaseDeLibroUstedOstentaToolStripMenuItem1.BackColorChanged += new System.EventHandler(this.testToolStripMenuItem_Click);
            this.queClaseDeLibroUstedOstentaToolStripMenuItem1.Click += new System.EventHandler(this.label1_Click);
            this.queClaseDeLibroUstedOstentaToolStripMenuItem1.DisplayStyleChanged += new System.EventHandler(this.Form1_Load);
            this.queClaseDeLibroUstedOstentaToolStripMenuItem1.DoubleClick += new System.EventHandler(this.testToolStripMenuItem_Click);
            this.queClaseDeLibroUstedOstentaToolStripMenuItem1.EnabledChanged += new System.EventHandler(this.baseDeDatoToolStripMenuItem_Click);
            this.queClaseDeLibroUstedOstentaToolStripMenuItem1.ForeColorChanged += new System.EventHandler(this.salirToolStripMenuItem_Click);
            this.queClaseDeLibroUstedOstentaToolStripMenuItem1.LocationChanged += new System.EventHandler(this.label1_Click);
            this.queClaseDeLibroUstedOstentaToolStripMenuItem1.MouseEnter += new System.EventHandler(this.queClaseDeLibroUstedOstentaToolStripMenuItem_Click);
            this.queClaseDeLibroUstedOstentaToolStripMenuItem1.MouseLeave += new System.EventHandler(this.testToolStripMenuItem_Click);
            this.queClaseDeLibroUstedOstentaToolStripMenuItem1.MouseHover += new System.EventHandler(this.label1_Click);
            this.queClaseDeLibroUstedOstentaToolStripMenuItem1.OwnerChanged += new System.EventHandler(this.queClaseDeLibroUstedOstentaToolStripMenuItem_Click);
            this.queClaseDeLibroUstedOstentaToolStripMenuItem1.RightToLeftChanged += new System.EventHandler(this.baseDeDatoToolStripMenuItem_Click);
            this.queClaseDeLibroUstedOstentaToolStripMenuItem1.TextChanged += new System.EventHandler(this.Form1_Load);
            this.queClaseDeLibroUstedOstentaToolStripMenuItem1.VisibleChanged += new System.EventHandler(this.button1_Click);
            // 
            // entidadesToolStripMenuItem
            // 
            this.entidadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prestamosToolStripMenuItem,
            this.devolucionesToolStripMenuItem});
            this.entidadesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.entidadesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("entidadesToolStripMenuItem.Image")));
            this.entidadesToolStripMenuItem.Name = "entidadesToolStripMenuItem";
            this.entidadesToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.entidadesToolStripMenuItem.Text = "Recepcion";
            this.entidadesToolStripMenuItem.Click += new System.EventHandler(this.entidadesToolStripMenuItem_Click);
            // 
            // prestamosToolStripMenuItem
            // 
            this.prestamosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("prestamosToolStripMenuItem.Image")));
            this.prestamosToolStripMenuItem.Name = "prestamosToolStripMenuItem";
            this.prestamosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.prestamosToolStripMenuItem.Text = "Prestamos";
            this.prestamosToolStripMenuItem.Click += new System.EventHandler(this.prestamosToolStripMenuItem_Click);
            // 
            // devolucionesToolStripMenuItem
            // 
            this.devolucionesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("devolucionesToolStripMenuItem.Image")));
            this.devolucionesToolStripMenuItem.Name = "devolucionesToolStripMenuItem";
            this.devolucionesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.devolucionesToolStripMenuItem.Text = "Devoluciones";
            this.devolucionesToolStripMenuItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // baseDeDatoToolStripMenuItem
            // 
            this.baseDeDatoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("baseDeDatoToolStripMenuItem.Image")));
            this.baseDeDatoToolStripMenuItem.Name = "baseDeDatoToolStripMenuItem";
            this.baseDeDatoToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.baseDeDatoToolStripMenuItem.Text = "Base de dato";
            this.baseDeDatoToolStripMenuItem.Click += new System.EventHandler(this.baseDeDatoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(32, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(297, 213);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(81)))), ((int)(((byte)(47)))));
            this.label1.Location = new System.Drawing.Point(371, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "CONSULTA";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(81)))), ((int)(((byte)(47)))));
            this.label2.Location = new System.Drawing.Point(374, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Libro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(81)))), ((int)(((byte)(47)))));
            this.label3.Location = new System.Drawing.Point(374, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Autor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(81)))), ((int)(((byte)(47)))));
            this.label4.Location = new System.Drawing.Point(374, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Genero";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(81)))), ((int)(((byte)(47)))));
            this.label5.Location = new System.Drawing.Point(374, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 26);
            this.label5.TabIndex = 7;
            this.label5.Text = "Editorial";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(231)))), ((int)(((byte)(227)))));
            this.textBox1.Location = new System.Drawing.Point(379, 203);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 20);
            this.textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(231)))), ((int)(((byte)(227)))));
            this.textBox2.Location = new System.Drawing.Point(379, 261);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(211, 20);
            this.textBox2.TabIndex = 11;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(231)))), ((int)(((byte)(227)))));
            this.textBox3.Location = new System.Drawing.Point(379, 310);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(209, 20);
            this.textBox3.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(231)))), ((int)(((byte)(227)))));
            this.textBox4.Location = new System.Drawing.Point(379, 362);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(209, 20);
            this.textBox4.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(81)))), ((int)(((byte)(47)))));
            this.label8.Location = new System.Drawing.Point(38, 467);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 19);
            this.label8.TabIndex = 14;
            this.label8.Text = "Pagina Oficial ®:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(81)))), ((int)(((byte)(47)))));
            this.label9.Location = new System.Drawing.Point(38, 495);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 19);
            this.label9.TabIndex = 15;
            this.label9.Text = "Soporte Tecnico:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(788, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 191);
            this.panel1.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(81)))), ((int)(((byte)(47)))));
            this.label6.Location = new System.Drawing.Point(919, 483);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 19);
            this.label6.TabIndex = 17;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(81)))), ((int)(((byte)(47)))));
            this.label7.Location = new System.Drawing.Point(908, 502);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 19);
            this.label7.TabIndex = 18;
            this.label7.Text = "label7";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Location = new System.Drawing.Point(164, 471);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(128, 13);
            this.linkLabel1.TabIndex = 19;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://www.unju.edu.ar/";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel2.Location = new System.Drawing.Point(164, 499);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(81, 13);
            this.linkLabel2.TabIndex = 20;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Uso de Sistema";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1058, 545);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Biblioteca Gral. Simon Bolivar";
            this.Activated += new System.EventHandler(this.label1_Click);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaDeLibrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajaDeLibrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peticionDeLibrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prestamosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devolucionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baseDeDatoToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem queClaseDeLibroUstedOstentaToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}

