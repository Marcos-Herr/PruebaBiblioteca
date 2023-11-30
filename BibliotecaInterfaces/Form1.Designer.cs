namespace BibliotecaInterfaces
{
    partial class FrmPadre
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.PrestamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devolucionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabLibro = new System.Windows.Forms.TabPage();
            this.btnBorrarLibro = new System.Windows.Forms.Button();
            this.btnBuscarLibro = new System.Windows.Forms.Button();
            this.btnAnadirLibro = new System.Windows.Forms.Button();
            this.TxtBxTitulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LvLibro = new System.Windows.Forms.ListView();
            this.ClmUbicacion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClmTitulo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClmId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabUsuario = new System.Windows.Forms.TabPage();
            this.btnBorrarUsuario = new System.Windows.Forms.Button();
            this.btnBuscarUsuario = new System.Windows.Forms.Button();
            this.btnAnadirUsuario = new System.Windows.Forms.Button();
            this.txtBxNombreUsuario = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbUsuarios = new System.Windows.Forms.Label();
            this.lvUsuarios = new System.Windows.Forms.ListView();
            this.columnHeaderTipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDept = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSancion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPrincipal = new System.Windows.Forms.TabControl();
            this.tabMovimientos = new System.Windows.Forms.TabPage();
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscarMovimientos = new System.Windows.Forms.Button();
            this.boxOpcBusqueda = new System.Windows.Forms.ComboBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBxBuscarMovimiento = new System.Windows.Forms.TextBox();
            this.boxOpcMovimientos = new System.Windows.Forms.ComboBox();
            this.lvMovimientos = new System.Windows.Forms.ListView();
            this.columnTipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTituloLibro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnUsuario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDepartamento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.tabLibro.SuspendLayout();
            this.tabUsuario.SuspendLayout();
            this.tabPrincipal.SuspendLayout();
            this.tabMovimientos.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PrestamosToolStripMenuItem,
            this.devolucionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1045, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // PrestamosToolStripMenuItem
            // 
            this.PrestamosToolStripMenuItem.Name = "PrestamosToolStripMenuItem";
            this.PrestamosToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.PrestamosToolStripMenuItem.Text = "Prestamo";
            this.PrestamosToolStripMenuItem.Click += new System.EventHandler(this.PrestamosToolStripMenuItem_Click);
            // 
            // devolucionToolStripMenuItem
            // 
            this.devolucionToolStripMenuItem.Name = "devolucionToolStripMenuItem";
            this.devolucionToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.devolucionToolStripMenuItem.Text = "Devolucion";
            this.devolucionToolStripMenuItem.Click += new System.EventHandler(this.devolucionToolStripMenuItem_Click);
            // 
            // tabLibro
            // 
            this.tabLibro.Controls.Add(this.btnBorrarLibro);
            this.tabLibro.Controls.Add(this.btnBuscarLibro);
            this.tabLibro.Controls.Add(this.btnAnadirLibro);
            this.tabLibro.Controls.Add(this.TxtBxTitulo);
            this.tabLibro.Controls.Add(this.label1);
            this.tabLibro.Controls.Add(this.label2);
            this.tabLibro.Controls.Add(this.LvLibro);
            this.tabLibro.Location = new System.Drawing.Point(4, 22);
            this.tabLibro.Name = "tabLibro";
            this.tabLibro.Padding = new System.Windows.Forms.Padding(3);
            this.tabLibro.Size = new System.Drawing.Size(1037, 522);
            this.tabLibro.TabIndex = 2;
            this.tabLibro.Text = "Libros";
            this.tabLibro.UseVisualStyleBackColor = true;
            // 
            // btnBorrarLibro
            // 
            this.btnBorrarLibro.Location = new System.Drawing.Point(895, 68);
            this.btnBorrarLibro.Name = "btnBorrarLibro";
            this.btnBorrarLibro.Size = new System.Drawing.Size(103, 43);
            this.btnBorrarLibro.TabIndex = 12;
            this.btnBorrarLibro.Text = "BORRAR";
            this.btnBorrarLibro.UseVisualStyleBackColor = true;
            this.btnBorrarLibro.Click += new System.EventHandler(this.BtnBorrarLibro_Click);
            // 
            // btnBuscarLibro
            // 
            this.btnBuscarLibro.Location = new System.Drawing.Point(714, 49);
            this.btnBuscarLibro.Name = "btnBuscarLibro";
            this.btnBuscarLibro.Size = new System.Drawing.Size(96, 38);
            this.btnBuscarLibro.TabIndex = 11;
            this.btnBuscarLibro.Text = "BUSCAR";
            this.btnBuscarLibro.UseVisualStyleBackColor = true;
            this.btnBuscarLibro.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // btnAnadirLibro
            // 
            this.btnAnadirLibro.Location = new System.Drawing.Point(895, 19);
            this.btnAnadirLibro.Name = "btnAnadirLibro";
            this.btnAnadirLibro.Size = new System.Drawing.Size(103, 43);
            this.btnAnadirLibro.TabIndex = 10;
            this.btnAnadirLibro.Text = "AÑADIR";
            this.btnAnadirLibro.UseVisualStyleBackColor = true;
            this.btnAnadirLibro.Click += new System.EventHandler(this.BtnAnadirLibro_Click);
            // 
            // TxtBxTitulo
            // 
            this.TxtBxTitulo.Location = new System.Drawing.Point(334, 59);
            this.TxtBxTitulo.Name = "TxtBxTitulo";
            this.TxtBxTitulo.Size = new System.Drawing.Size(354, 20);
            this.TxtBxTitulo.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "TITULO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "LIBROS";
            // 
            // LvLibro
            // 
            this.LvLibro.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ClmUbicacion,
            this.ClmTitulo,
            this.ClmId});
            this.LvLibro.FullRowSelect = true;
            this.LvLibro.HideSelection = false;
            this.LvLibro.Location = new System.Drawing.Point(8, 129);
            this.LvLibro.MultiSelect = false;
            this.LvLibro.Name = "LvLibro";
            this.LvLibro.Size = new System.Drawing.Size(1021, 385);
            this.LvLibro.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.LvLibro.TabIndex = 0;
            this.LvLibro.UseCompatibleStateImageBehavior = false;
            this.LvLibro.View = System.Windows.Forms.View.Details;
            this.LvLibro.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.LvLibro_ColumnClick);
            this.LvLibro.DoubleClick += new System.EventHandler(this.LvLibro_DoubleClick);
            // 
            // ClmUbicacion
            // 
            this.ClmUbicacion.DisplayIndex = 1;
            this.ClmUbicacion.Text = "Ubicacion";
            // 
            // ClmTitulo
            // 
            this.ClmTitulo.DisplayIndex = 0;
            this.ClmTitulo.Text = "Titulo";
            this.ClmTitulo.Width = 116;
            // 
            // ClmId
            // 
            this.ClmId.Text = "ID";
            // 
            // tabUsuario
            // 
            this.tabUsuario.Controls.Add(this.btnBorrarUsuario);
            this.tabUsuario.Controls.Add(this.btnBuscarUsuario);
            this.tabUsuario.Controls.Add(this.btnAnadirUsuario);
            this.tabUsuario.Controls.Add(this.txtBxNombreUsuario);
            this.tabUsuario.Controls.Add(this.lbNombre);
            this.tabUsuario.Controls.Add(this.lbUsuarios);
            this.tabUsuario.Controls.Add(this.lvUsuarios);
            this.tabUsuario.Location = new System.Drawing.Point(4, 22);
            this.tabUsuario.Name = "tabUsuario";
            this.tabUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsuario.Size = new System.Drawing.Size(1037, 522);
            this.tabUsuario.TabIndex = 0;
            this.tabUsuario.Text = "Usuarios";
            this.tabUsuario.UseVisualStyleBackColor = true;
            // 
            // btnBorrarUsuario
            // 
            this.btnBorrarUsuario.Location = new System.Drawing.Point(895, 68);
            this.btnBorrarUsuario.Name = "btnBorrarUsuario";
            this.btnBorrarUsuario.Size = new System.Drawing.Size(103, 43);
            this.btnBorrarUsuario.TabIndex = 12;
            this.btnBorrarUsuario.Text = "BORRAR";
            this.btnBorrarUsuario.UseVisualStyleBackColor = true;
            this.btnBorrarUsuario.Click += new System.EventHandler(this.BtnBorrarUser_Click);
            // 
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.Location = new System.Drawing.Point(714, 49);
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.Size = new System.Drawing.Size(96, 38);
            this.btnBuscarUsuario.TabIndex = 11;
            this.btnBuscarUsuario.Text = "BUSCAR";
            this.btnBuscarUsuario.UseVisualStyleBackColor = true;
            this.btnBuscarUsuario.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // btnAnadirUsuario
            // 
            this.btnAnadirUsuario.Location = new System.Drawing.Point(895, 19);
            this.btnAnadirUsuario.Name = "btnAnadirUsuario";
            this.btnAnadirUsuario.Size = new System.Drawing.Size(103, 43);
            this.btnAnadirUsuario.TabIndex = 10;
            this.btnAnadirUsuario.Text = "AÑADIR";
            this.btnAnadirUsuario.UseVisualStyleBackColor = true;
            this.btnAnadirUsuario.Click += new System.EventHandler(this.BtnAnadirUser_Click);
            // 
            // txtBxNombreUsuario
            // 
            this.txtBxNombreUsuario.Location = new System.Drawing.Point(334, 59);
            this.txtBxNombreUsuario.Name = "txtBxNombreUsuario";
            this.txtBxNombreUsuario.Size = new System.Drawing.Size(354, 20);
            this.txtBxNombreUsuario.TabIndex = 7;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(253, 62);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(54, 13);
            this.lbNombre.TabIndex = 4;
            this.lbNombre.Text = "NOMBRE";
            // 
            // lbUsuarios
            // 
            this.lbUsuarios.AutoSize = true;
            this.lbUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuarios.Location = new System.Drawing.Point(3, 110);
            this.lbUsuarios.Name = "lbUsuarios";
            this.lbUsuarios.Size = new System.Drawing.Size(71, 13);
            this.lbUsuarios.TabIndex = 1;
            this.lbUsuarios.Text = "USUARIOS";
            // 
            // lvUsuarios
            // 
            this.lvUsuarios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderTipo,
            this.columnHeaderNombre,
            this.columnHeaderDept,
            this.columnHeaderSancion});
            this.lvUsuarios.FullRowSelect = true;
            this.lvUsuarios.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvUsuarios.HideSelection = false;
            this.lvUsuarios.Location = new System.Drawing.Point(6, 129);
            this.lvUsuarios.Name = "lvUsuarios";
            this.lvUsuarios.Scrollable = false;
            this.lvUsuarios.Size = new System.Drawing.Size(1023, 385);
            this.lvUsuarios.TabIndex = 0;
            this.lvUsuarios.UseCompatibleStateImageBehavior = false;
            this.lvUsuarios.View = System.Windows.Forms.View.Details;
            this.lvUsuarios.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LvUsuarios_MouseDoubleClick);
            // 
            // columnHeaderTipo
            // 
            this.columnHeaderTipo.Text = "Tipo";
            this.columnHeaderTipo.Width = 193;
            // 
            // columnHeaderNombre
            // 
            this.columnHeaderNombre.Text = "Nombre";
            this.columnHeaderNombre.Width = 275;
            // 
            // columnHeaderDept
            // 
            this.columnHeaderDept.Text = "Departamento";
            this.columnHeaderDept.Width = 233;
            // 
            // columnHeaderSancion
            // 
            this.columnHeaderSancion.Text = "Sancion";
            this.columnHeaderSancion.Width = 247;
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Controls.Add(this.tabUsuario);
            this.tabPrincipal.Controls.Add(this.tabLibro);
            this.tabPrincipal.Controls.Add(this.tabMovimientos);
            this.tabPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPrincipal.Location = new System.Drawing.Point(0, 24);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.SelectedIndex = 0;
            this.tabPrincipal.Size = new System.Drawing.Size(1045, 548);
            this.tabPrincipal.TabIndex = 1;
            // 
            // tabMovimientos
            // 
            this.tabMovimientos.Controls.Add(this.calendar);
            this.tabMovimientos.Controls.Add(this.label3);
            this.tabMovimientos.Controls.Add(this.btnBuscarMovimientos);
            this.tabMovimientos.Controls.Add(this.boxOpcBusqueda);
            this.tabMovimientos.Controls.Add(this.lblBuscar);
            this.tabMovimientos.Controls.Add(this.txtBxBuscarMovimiento);
            this.tabMovimientos.Controls.Add(this.boxOpcMovimientos);
            this.tabMovimientos.Controls.Add(this.lvMovimientos);
            this.tabMovimientos.Location = new System.Drawing.Point(4, 22);
            this.tabMovimientos.Name = "tabMovimientos";
            this.tabMovimientos.Size = new System.Drawing.Size(1037, 522);
            this.tabMovimientos.TabIndex = 3;
            this.tabMovimientos.Text = "Movimientos";
            this.tabMovimientos.UseVisualStyleBackColor = true;
            // 
            // calendar
            // 
            this.calendar.Location = new System.Drawing.Point(551, 9);
            this.calendar.MaxSelectionCount = 10;
            this.calendar.Name = "calendar";
            this.calendar.TabIndex = 20;
            this.calendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calendar_DateSelected);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "MOVIMINETOS";
            // 
            // btnBuscarMovimientos
            // 
            this.btnBuscarMovimientos.Location = new System.Drawing.Point(786, 33);
            this.btnBuscarMovimientos.Name = "btnBuscarMovimientos";
            this.btnBuscarMovimientos.Size = new System.Drawing.Size(96, 38);
            this.btnBuscarMovimientos.TabIndex = 18;
            this.btnBuscarMovimientos.Text = "BUSCAR";
            this.btnBuscarMovimientos.UseVisualStyleBackColor = true;
            this.btnBuscarMovimientos.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // boxOpcBusqueda
            // 
            this.boxOpcBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxOpcBusqueda.FormattingEnabled = true;
            this.boxOpcBusqueda.Items.AddRange(new object[] {
            "Titulo Libro",
            "Usuario",
            "Departamento",
            "Fecha"});
            this.boxOpcBusqueda.Location = new System.Drawing.Point(387, 42);
            this.boxOpcBusqueda.Name = "boxOpcBusqueda";
            this.boxOpcBusqueda.Size = new System.Drawing.Size(121, 21);
            this.boxOpcBusqueda.TabIndex = 17;
            this.boxOpcBusqueda.SelectedIndexChanged += new System.EventHandler(this.boxOpc_SelectedIndexChanged);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(331, 46);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(40, 13);
            this.lblBuscar.TabIndex = 16;
            this.lblBuscar.Text = "Buscar";
            // 
            // txtBxBuscarMovimiento
            // 
            this.txtBxBuscarMovimiento.Location = new System.Drawing.Point(526, 43);
            this.txtBxBuscarMovimiento.Name = "txtBxBuscarMovimiento";
            this.txtBxBuscarMovimiento.Size = new System.Drawing.Size(236, 20);
            this.txtBxBuscarMovimiento.TabIndex = 14;
            // 
            // boxOpcMovimientos
            // 
            this.boxOpcMovimientos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxOpcMovimientos.FormattingEnabled = true;
            this.boxOpcMovimientos.Items.AddRange(new object[] {
            "Todos",
            "Prestamos",
            "Devoluciones"});
            this.boxOpcMovimientos.Location = new System.Drawing.Point(146, 42);
            this.boxOpcMovimientos.Name = "boxOpcMovimientos";
            this.boxOpcMovimientos.Size = new System.Drawing.Size(121, 21);
            this.boxOpcMovimientos.TabIndex = 13;
            this.boxOpcMovimientos.SelectedIndexChanged += new System.EventHandler(this.boxOpc_SelectedIndexChanged);
            // 
            // lvMovimientos
            // 
            this.lvMovimientos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnTipo,
            this.columnTituloLibro,
            this.columnUsuario,
            this.columnDepartamento,
            this.columnFecha});
            this.lvMovimientos.HideSelection = false;
            this.lvMovimientos.Location = new System.Drawing.Point(8, 174);
            this.lvMovimientos.Name = "lvMovimientos";
            this.lvMovimientos.Size = new System.Drawing.Size(1021, 342);
            this.lvMovimientos.TabIndex = 12;
            this.lvMovimientos.UseCompatibleStateImageBehavior = false;
            this.lvMovimientos.View = System.Windows.Forms.View.Details;
            // 
            // columnTipo
            // 
            this.columnTipo.Text = "Tipo";
            this.columnTipo.Width = 200;
            // 
            // columnTituloLibro
            // 
            this.columnTituloLibro.Text = "Titulo Libro";
            this.columnTituloLibro.Width = 200;
            // 
            // columnUsuario
            // 
            this.columnUsuario.Text = "Usuario";
            this.columnUsuario.Width = 200;
            // 
            // columnDepartamento
            // 
            this.columnDepartamento.Text = "Departamento";
            this.columnDepartamento.Width = 200;
            // 
            // columnFecha
            // 
            this.columnFecha.Text = "Fecha";
            this.columnFecha.Width = 216;
            // 
            // FrmPadre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 572);
            this.Controls.Add(this.tabPrincipal);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPadre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPadre_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabLibro.ResumeLayout(false);
            this.tabLibro.PerformLayout();
            this.tabUsuario.ResumeLayout(false);
            this.tabUsuario.PerformLayout();
            this.tabPrincipal.ResumeLayout(false);
            this.tabMovimientos.ResumeLayout(false);
            this.tabMovimientos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem PrestamosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devolucionToolStripMenuItem;
        private System.Windows.Forms.TabPage tabLibro;
        private System.Windows.Forms.Button btnBorrarLibro;
        private System.Windows.Forms.Button btnBuscarLibro;
        private System.Windows.Forms.Button btnAnadirLibro;
        private System.Windows.Forms.TextBox TxtBxTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView LvLibro;
        private System.Windows.Forms.TabPage tabUsuario;
        private System.Windows.Forms.Button btnBorrarUsuario;
        private System.Windows.Forms.Button btnBuscarUsuario;
        private System.Windows.Forms.Button btnAnadirUsuario;
        private System.Windows.Forms.TextBox txtBxNombreUsuario;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbUsuarios;
        private System.Windows.Forms.ListView lvUsuarios;
        private System.Windows.Forms.ColumnHeader columnHeaderTipo;
        private System.Windows.Forms.ColumnHeader columnHeaderNombre;
        private System.Windows.Forms.ColumnHeader columnHeaderDept;
        private System.Windows.Forms.ColumnHeader columnHeaderSancion;
        private System.Windows.Forms.TabControl tabPrincipal;
        private System.Windows.Forms.ColumnHeader ClmTitulo;
        private System.Windows.Forms.ColumnHeader ClmUbicacion;
        private System.Windows.Forms.ColumnHeader ClmId;
        private System.Windows.Forms.TabPage tabMovimientos;
        private System.Windows.Forms.ComboBox boxOpcBusqueda;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBxBuscarMovimiento;
        private System.Windows.Forms.ComboBox boxOpcMovimientos;
        private System.Windows.Forms.ListView lvMovimientos;
        private System.Windows.Forms.ColumnHeader columnTipo;
        private System.Windows.Forms.ColumnHeader columnTituloLibro;
        private System.Windows.Forms.ColumnHeader columnUsuario;
        private System.Windows.Forms.ColumnHeader columnDepartamento;
        private System.Windows.Forms.ColumnHeader columnFecha;
        private System.Windows.Forms.Button btnBuscarMovimientos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MonthCalendar calendar;
    }
}

