namespace BibliotecaInterfaces
{
    partial class FrmUsuario
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
            this.lbTop = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTipo = new System.Windows.Forms.Label();
            this.lbDept = new System.Windows.Forms.Label();
            this.lbFecha = new System.Windows.Forms.Label();
            this.mskFecha = new System.Windows.Forms.MaskedTextBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.txtDpt = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTop
            // 
            this.lbTop.AutoSize = true;
            this.lbTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTop.Location = new System.Drawing.Point(37, 29);
            this.lbTop.Name = "lbTop";
            this.lbTop.Size = new System.Drawing.Size(51, 25);
            this.lbTop.TabIndex = 0;
            this.lbTop.Text = "Tipo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 85);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbTipo
            // 
            this.lbTipo.AutoSize = true;
            this.lbTipo.Location = new System.Drawing.Point(101, 185);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbTipo.Size = new System.Drawing.Size(28, 13);
            this.lbTipo.TabIndex = 2;
            this.lbTipo.Text = "Tipo";
            this.lbTipo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbDept
            // 
            this.lbDept.AutoSize = true;
            this.lbDept.Location = new System.Drawing.Point(55, 133);
            this.lbDept.Name = "lbDept";
            this.lbDept.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbDept.Size = new System.Drawing.Size(74, 13);
            this.lbDept.TabIndex = 3;
            this.lbDept.Text = "Departamento";
            this.lbDept.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Location = new System.Drawing.Point(50, 237);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbFecha.Size = new System.Drawing.Size(79, 13);
            this.lbFecha.TabIndex = 3;
            this.lbFecha.Text = "Fecha Sanción";
            this.lbFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mskFecha
            // 
            this.mskFecha.Location = new System.Drawing.Point(204, 233);
            this.mskFecha.Mask = "00/00/0000";
            this.mskFecha.Name = "mskFecha";
            this.mskFecha.Size = new System.Drawing.Size(100, 20);
            this.mskFecha.TabIndex = 4;
            this.mskFecha.ValidatingType = typeof(System.DateTime);
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "profesor",
            "alumno",
            "pas",
            "Tipo ususario"});
            this.cmbTipo.Location = new System.Drawing.Point(204, 181);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipo.TabIndex = 5;
            // 
            // txtDpt
            // 
            this.txtDpt.Location = new System.Drawing.Point(204, 129);
            this.txtDpt.Name = "txtDpt";
            this.txtDpt.Size = new System.Drawing.Size(100, 20);
            this.txtDpt.TabIndex = 6;
            this.txtDpt.Text = " ";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(204, 81);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // btnAceptar
            // 
            this.btnAceptar.AutoSize = true;
            this.btnAceptar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAceptar.Location = new System.Drawing.Point(146, 291);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(58, 23);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "AÑADIR";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 345);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDpt);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.mskFecha);
            this.Controls.Add(this.lbFecha);
            this.Controls.Add(this.lbDept);
            this.Controls.Add(this.lbTipo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTop);
            this.Name = "FrmUsuario";
            this.Text = "FrmUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTipo;
        private System.Windows.Forms.Label lbDept;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.MaskedTextBox mskFecha;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.TextBox txtDpt;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAceptar;
    }
}