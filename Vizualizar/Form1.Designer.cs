
namespace Vizualizar
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
            this.buttoncerrar = new System.Windows.Forms.Button();
            this.buttonbuscar = new System.Windows.Forms.Button();
            this.textBoxemail = new System.Windows.Forms.TextBox();
            this.textBoxsemestre = new System.Windows.Forms.TextBox();
            this.textBoxapellidoM = new System.Windows.Forms.TextBox();
            this.textBoxapellidoP = new System.Windows.Forms.TextBox();
            this.textBoxnombre = new System.Windows.Forms.TextBox();
            this.textBoxnocontrol = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttoncerrar
            // 
            this.buttoncerrar.Location = new System.Drawing.Point(149, 359);
            this.buttoncerrar.Name = "buttoncerrar";
            this.buttoncerrar.Size = new System.Drawing.Size(75, 23);
            this.buttoncerrar.TabIndex = 28;
            this.buttoncerrar.Text = "Cerrar";
            this.buttoncerrar.UseVisualStyleBackColor = true;
            this.buttoncerrar.Click += new System.EventHandler(this.buttoncerrar_Click);
            // 
            // buttonbuscar
            // 
            this.buttonbuscar.Location = new System.Drawing.Point(300, 49);
            this.buttonbuscar.Name = "buttonbuscar";
            this.buttonbuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonbuscar.TabIndex = 27;
            this.buttonbuscar.Text = "Buscar";
            this.buttonbuscar.UseVisualStyleBackColor = true;
            this.buttonbuscar.Click += new System.EventHandler(this.buttonbuscar_Click);
            // 
            // textBoxemail
            // 
            this.textBoxemail.Location = new System.Drawing.Point(158, 280);
            this.textBoxemail.Name = "textBoxemail";
            this.textBoxemail.Size = new System.Drawing.Size(133, 20);
            this.textBoxemail.TabIndex = 26;
            // 
            // textBoxsemestre
            // 
            this.textBoxsemestre.Location = new System.Drawing.Point(158, 233);
            this.textBoxsemestre.Name = "textBoxsemestre";
            this.textBoxsemestre.Size = new System.Drawing.Size(133, 20);
            this.textBoxsemestre.TabIndex = 25;
            // 
            // textBoxapellidoM
            // 
            this.textBoxapellidoM.Location = new System.Drawing.Point(158, 188);
            this.textBoxapellidoM.Name = "textBoxapellidoM";
            this.textBoxapellidoM.Size = new System.Drawing.Size(133, 20);
            this.textBoxapellidoM.TabIndex = 24;
            // 
            // textBoxapellidoP
            // 
            this.textBoxapellidoP.Location = new System.Drawing.Point(158, 142);
            this.textBoxapellidoP.Name = "textBoxapellidoP";
            this.textBoxapellidoP.Size = new System.Drawing.Size(133, 20);
            this.textBoxapellidoP.TabIndex = 23;
            // 
            // textBoxnombre
            // 
            this.textBoxnombre.Location = new System.Drawing.Point(158, 95);
            this.textBoxnombre.Name = "textBoxnombre";
            this.textBoxnombre.Size = new System.Drawing.Size(133, 20);
            this.textBoxnombre.TabIndex = 22;
            // 
            // textBoxnocontrol
            // 
            this.textBoxnocontrol.Location = new System.Drawing.Point(158, 49);
            this.textBoxnocontrol.Name = "textBoxnocontrol";
            this.textBoxnocontrol.Size = new System.Drawing.Size(100, 20);
            this.textBoxnocontrol.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Apellido Materno";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Correo Electronico";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Semestre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Apellido Paterno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "No.Control";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 450);
            this.Controls.Add(this.buttoncerrar);
            this.Controls.Add(this.buttonbuscar);
            this.Controls.Add(this.textBoxemail);
            this.Controls.Add(this.textBoxsemestre);
            this.Controls.Add(this.textBoxapellidoM);
            this.Controls.Add(this.textBoxapellidoP);
            this.Controls.Add(this.textBoxnombre);
            this.Controls.Add(this.textBoxnocontrol);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttoncerrar;
        private System.Windows.Forms.Button buttonbuscar;
        private System.Windows.Forms.TextBox textBoxemail;
        private System.Windows.Forms.TextBox textBoxsemestre;
        private System.Windows.Forms.TextBox textBoxapellidoM;
        private System.Windows.Forms.TextBox textBoxapellidoP;
        private System.Windows.Forms.TextBox textBoxnombre;
        private System.Windows.Forms.TextBox textBoxnocontrol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

