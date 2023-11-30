
namespace BibliotecaInterfaces
{
    partial class FrmDevolucion
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
            this.BtnDevolver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbUsuarios = new System.Windows.Forms.Label();
            this.LstBxUsuarios = new System.Windows.Forms.ListBox();
            this.LstBxLibros = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BtnDevolver
            // 
            this.BtnDevolver.Location = new System.Drawing.Point(330, 395);
            this.BtnDevolver.Name = "BtnDevolver";
            this.BtnDevolver.Size = new System.Drawing.Size(103, 43);
            this.BtnDevolver.TabIndex = 16;
            this.BtnDevolver.Text = "DEVOLVER";
            this.BtnDevolver.UseVisualStyleBackColor = true;
            this.BtnDevolver.Click += new System.EventHandler(this.BtnDevolver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "LIBROS";
            // 
            // lbUsuarios
            // 
            this.lbUsuarios.AutoSize = true;
            this.lbUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuarios.Location = new System.Drawing.Point(12, 16);
            this.lbUsuarios.Name = "lbUsuarios";
            this.lbUsuarios.Size = new System.Drawing.Size(71, 13);
            this.lbUsuarios.TabIndex = 15;
            this.lbUsuarios.Text = "USUARIOS";
            // 
            // LstBxUsuarios
            // 
            this.LstBxUsuarios.FormattingEnabled = true;
            this.LstBxUsuarios.Location = new System.Drawing.Point(12, 32);
            this.LstBxUsuarios.MultiColumn = true;
            this.LstBxUsuarios.Name = "LstBxUsuarios";
            this.LstBxUsuarios.Size = new System.Drawing.Size(755, 147);
            this.LstBxUsuarios.TabIndex = 13;
            this.LstBxUsuarios.SelectedIndexChanged += new System.EventHandler(this.LstBxUsuarios_SelectedIndexChanged);
            // 
            // LstBxLibros
            // 
            this.LstBxLibros.FormattingEnabled = true;
            this.LstBxLibros.Location = new System.Drawing.Point(12, 203);
            this.LstBxLibros.MultiColumn = true;
            this.LstBxLibros.Name = "LstBxLibros";
            this.LstBxLibros.Size = new System.Drawing.Size(755, 186);
            this.LstBxLibros.TabIndex = 12;
            // 
            // FrmDevolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnDevolver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbUsuarios);
            this.Controls.Add(this.LstBxUsuarios);
            this.Controls.Add(this.LstBxLibros);
            this.Name = "FrmDevolucion";
            this.Text = "FrmDevolucion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnDevolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbUsuarios;
        private System.Windows.Forms.ListBox LstBxUsuarios;
        private System.Windows.Forms.ListBox LstBxLibros;
    }
}