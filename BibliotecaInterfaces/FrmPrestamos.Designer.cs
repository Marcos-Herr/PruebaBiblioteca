namespace BibliotecaInterfaces
{
    partial class FrmPrestamos
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
            this.listBoxLibros = new System.Windows.Forms.ListBox();
            this.listBoxUsuarios = new System.Windows.Forms.ListBox();
            this.lbUsuarios = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnadirUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxLibros
            // 
            this.listBoxLibros.FormattingEnabled = true;
            this.listBoxLibros.Location = new System.Drawing.Point(12, 174);
            this.listBoxLibros.MultiColumn = true;
            this.listBoxLibros.Name = "listBoxLibros";
            this.listBoxLibros.Size = new System.Drawing.Size(755, 121);
            this.listBoxLibros.TabIndex = 2;
            // 
            // listBoxUsuarios
            // 
            this.listBoxUsuarios.FormattingEnabled = true;
            this.listBoxUsuarios.Location = new System.Drawing.Point(12, 32);
            this.listBoxUsuarios.MultiColumn = true;
            this.listBoxUsuarios.Name = "listBoxUsuarios";
            this.listBoxUsuarios.Size = new System.Drawing.Size(755, 108);
            this.listBoxUsuarios.TabIndex = 3;
            // 
            // lbUsuarios
            // 
            this.lbUsuarios.AutoSize = true;
            this.lbUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuarios.Location = new System.Drawing.Point(12, 16);
            this.lbUsuarios.Name = "lbUsuarios";
            this.lbUsuarios.Size = new System.Drawing.Size(71, 13);
            this.lbUsuarios.TabIndex = 6;
            this.lbUsuarios.Text = "USUARIOS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "LIBROS";
            // 
            // btnAnadirUsuario
            // 
            this.btnAnadirUsuario.Location = new System.Drawing.Point(338, 342);
            this.btnAnadirUsuario.Name = "btnAnadirUsuario";
            this.btnAnadirUsuario.Size = new System.Drawing.Size(103, 43);
            this.btnAnadirUsuario.TabIndex = 11;
            this.btnAnadirUsuario.Text = "AÑADIR";
            this.btnAnadirUsuario.UseVisualStyleBackColor = true;
            this.btnAnadirUsuario.Click += new System.EventHandler(this.BtnAnadirUsuario_Click);
            // 
            // FrmPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAnadirUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbUsuarios);
            this.Controls.Add(this.listBoxUsuarios);
            this.Controls.Add(this.listBoxLibros);
            this.Name = "FrmPrestamos";
            this.Text = "FrmPrestamos";
            this.Load += new System.EventHandler(this.FrmPrestamos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxLibros;
        private System.Windows.Forms.ListBox listBoxUsuarios;
        private System.Windows.Forms.Label lbUsuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAnadirUsuario;
    }
}