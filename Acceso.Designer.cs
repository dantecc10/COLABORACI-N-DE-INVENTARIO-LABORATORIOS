namespace Inventario_Laboratorios_2._0
{
    partial class Acceso
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// 
        /// <param a03
        /// cecch04dg'0251'004
        /// cecch04dg'0251'004
        /// cecch04dg'0251'004
        /// 04dg'78'004
        /// cecch02'0608
        /// ="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Acceso));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.usuariotxbx = new System.Windows.Forms.TextBox();
            this.contraseñatxbx = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.CasillaNoSoyUnRobot = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(786, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Colegio de Estudios Científicos y Tecnológicos del Estado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(99, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña:";
            // 
            // usuariotxbx
            // 
            this.usuariotxbx.Location = new System.Drawing.Point(249, 60);
            this.usuariotxbx.Name = "usuariotxbx";
            this.usuariotxbx.Size = new System.Drawing.Size(265, 20);
            this.usuariotxbx.TabIndex = 3;
            // 
            // contraseñatxbx
            // 
            this.contraseñatxbx.Location = new System.Drawing.Point(249, 86);
            this.contraseñatxbx.Name = "contraseñatxbx";
            this.contraseñatxbx.PasswordChar = '*';
            this.contraseñatxbx.Size = new System.Drawing.Size(265, 20);
            this.contraseñatxbx.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(532, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 46);
            this.button1.TabIndex = 5;
            this.button1.Text = "Acceder";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CasillaNoSoyUnRobot
            // 
            this.CasillaNoSoyUnRobot.AutoSize = true;
            this.CasillaNoSoyUnRobot.Location = new System.Drawing.Point(304, 112);
            this.CasillaNoSoyUnRobot.Name = "CasillaNoSoyUnRobot";
            this.CasillaNoSoyUnRobot.Size = new System.Drawing.Size(113, 17);
            this.CasillaNoSoyUnRobot.TabIndex = 6;
            this.CasillaNoSoyUnRobot.Text = "No Soy Un Robot ";
            this.CasillaNoSoyUnRobot.UseVisualStyleBackColor = true;
            // 
            // Acceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(792, 136);
            this.Controls.Add(this.CasillaNoSoyUnRobot);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.contraseñatxbx);
            this.Controls.Add(this.usuariotxbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Acceso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de sesión";
            this.Load += new System.EventHandler(this.Acceso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox usuariotxbx;
        private System.Windows.Forms.TextBox contraseñatxbx;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox CasillaNoSoyUnRobot;
    }
}

