namespace Inventario_Laboratorios_2._0
{
    partial class Menú
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menú));
            this.btn_labi = new System.Windows.Forms.Button();
            this.btn_labc = new System.Windows.Forms.Button();
            this.btn_volver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_labi
            // 
            this.btn_labi.BackColor = System.Drawing.Color.Maroon;
            this.btn_labi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_labi.ForeColor = System.Drawing.Color.White;
            this.btn_labi.Location = new System.Drawing.Point(58, 23);
            this.btn_labi.Name = "btn_labi";
            this.btn_labi.Size = new System.Drawing.Size(97, 40);
            this.btn_labi.TabIndex = 0;
            this.btn_labi.Text = "Laboratorio de idiomas";
            this.btn_labi.UseVisualStyleBackColor = false;
            this.btn_labi.Click += new System.EventHandler(this.btn_labi_Click);
            // 
            // btn_labc
            // 
            this.btn_labc.BackColor = System.Drawing.Color.Maroon;
            this.btn_labc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_labc.ForeColor = System.Drawing.Color.White;
            this.btn_labc.Location = new System.Drawing.Point(58, 93);
            this.btn_labc.Name = "btn_labc";
            this.btn_labc.Size = new System.Drawing.Size(97, 40);
            this.btn_labc.TabIndex = 1;
            this.btn_labc.Text = "Laboratorio de cómputo";
            this.btn_labc.UseVisualStyleBackColor = false;
            this.btn_labc.Click += new System.EventHandler(this.btn_labc_Click);
            // 
            // btn_volver
            // 
            this.btn_volver.BackColor = System.Drawing.Color.Maroon;
            this.btn_volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_volver.ForeColor = System.Drawing.Color.White;
            this.btn_volver.Location = new System.Drawing.Point(58, 167);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(97, 40);
            this.btn_volver.TabIndex = 2;
            this.btn_volver.Text = "Cerrar sesión";
            this.btn_volver.UseVisualStyleBackColor = false;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // Menú
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(220, 236);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.btn_labc);
            this.Controls.Add(this.btn_labi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menú";
            this.Text = "Menú";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_labi;
        private System.Windows.Forms.Button btn_labc;
        private System.Windows.Forms.Button btn_volver;
    }
}