namespace BibliotecaInterfaces
{
    partial class FrmLibro
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbBxUbicacion = new System.Windows.Forms.ComboBox();
            this.TxtBxTitulo = new System.Windows.Forms.TextBox();
            this.TxtBxID = new System.Windows.Forms.TextBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "TITULO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "UBICACION";
            // 
            // CmbBxUbicacion
            // 
            this.CmbBxUbicacion.AllowDrop = true;
            this.CmbBxUbicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBxUbicacion.FormattingEnabled = true;
            this.CmbBxUbicacion.Items.AddRange(new object[] {
            "Sala",
            "Alamacen"});
            this.CmbBxUbicacion.Location = new System.Drawing.Point(143, 121);
            this.CmbBxUbicacion.MaxDropDownItems = 2;
            this.CmbBxUbicacion.Name = "CmbBxUbicacion";
            this.CmbBxUbicacion.Size = new System.Drawing.Size(203, 21);
            this.CmbBxUbicacion.TabIndex = 8;
            // 
            // TxtBxTitulo
            // 
            this.TxtBxTitulo.Location = new System.Drawing.Point(143, 46);
            this.TxtBxTitulo.Name = "TxtBxTitulo";
            this.TxtBxTitulo.Size = new System.Drawing.Size(203, 20);
            this.TxtBxTitulo.TabIndex = 9;
            // 
            // TxtBxID
            // 
            this.TxtBxID.Location = new System.Drawing.Point(143, 81);
            this.TxtBxID.Name = "TxtBxID";
            this.TxtBxID.Size = new System.Drawing.Size(203, 20);
            this.TxtBxID.TabIndex = 10;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(143, 190);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(114, 33);
            this.BtnGuardar.TabIndex = 11;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // FrmLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 252);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.TxtBxID);
            this.Controls.Add(this.TxtBxTitulo);
            this.Controls.Add(this.CmbBxUbicacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "FrmLibro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLibro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbBxUbicacion;
        private System.Windows.Forms.TextBox TxtBxTitulo;
        private System.Windows.Forms.TextBox TxtBxID;
        private System.Windows.Forms.Button BtnGuardar;
    }
}