namespace Lab12
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BotonAgregar = new System.Windows.Forms.Button();
            this.carbtxt = new System.Windows.Forms.TextBox();
            this.carb = new System.Windows.Forms.Label();
            this.grasatxt = new System.Windows.Forms.TextBox();
            this.grasa = new System.Windows.Forms.Label();
            this.protetxt = new System.Windows.Forms.TextBox();
            this.prote = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.EliminarBoton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ComidasList = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BotonAgregar);
            this.panel1.Controls.Add(this.carbtxt);
            this.panel1.Controls.Add(this.carb);
            this.panel1.Controls.Add(this.grasatxt);
            this.panel1.Controls.Add(this.grasa);
            this.panel1.Controls.Add(this.protetxt);
            this.panel1.Controls.Add(this.prote);
            this.panel1.Controls.Add(this.Nombre);
            this.panel1.Controls.Add(this.nametxt);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 219);
            this.panel1.TabIndex = 0;
            // 
            // BotonAgregar
            // 
            this.BotonAgregar.Location = new System.Drawing.Point(7, 164);
            this.BotonAgregar.Name = "BotonAgregar";
            this.BotonAgregar.Size = new System.Drawing.Size(100, 23);
            this.BotonAgregar.TabIndex = 8;
            this.BotonAgregar.Text = "Agregar";
            this.BotonAgregar.UseVisualStyleBackColor = true;
            this.BotonAgregar.Click += new System.EventHandler(this.BotonAgregar_Click);
            // 
            // carbtxt
            // 
            this.carbtxt.Location = new System.Drawing.Point(7, 137);
            this.carbtxt.Name = "carbtxt";
            this.carbtxt.Size = new System.Drawing.Size(100, 20);
            this.carbtxt.TabIndex = 7;
            // 
            // carb
            // 
            this.carb.AutoSize = true;
            this.carb.Location = new System.Drawing.Point(4, 121);
            this.carb.Name = "carb";
            this.carb.Size = new System.Drawing.Size(72, 13);
            this.carb.TabIndex = 6;
            this.carb.Text = "Carbohidratos";
            // 
            // grasatxt
            // 
            this.grasatxt.Location = new System.Drawing.Point(7, 98);
            this.grasatxt.Name = "grasatxt";
            this.grasatxt.Size = new System.Drawing.Size(100, 20);
            this.grasatxt.TabIndex = 5;
            // 
            // grasa
            // 
            this.grasa.AutoSize = true;
            this.grasa.Location = new System.Drawing.Point(4, 82);
            this.grasa.Name = "grasa";
            this.grasa.Size = new System.Drawing.Size(40, 13);
            this.grasa.TabIndex = 4;
            this.grasa.Text = "Grasas";
            // 
            // protetxt
            // 
            this.protetxt.Location = new System.Drawing.Point(7, 59);
            this.protetxt.Name = "protetxt";
            this.protetxt.Size = new System.Drawing.Size(100, 20);
            this.protetxt.TabIndex = 3;
            // 
            // prote
            // 
            this.prote.AutoSize = true;
            this.prote.Location = new System.Drawing.Point(4, 43);
            this.prote.Name = "prote";
            this.prote.Size = new System.Drawing.Size(51, 13);
            this.prote.TabIndex = 2;
            this.prote.Text = "Proteinas";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(4, 4);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(44, 13);
            this.Nombre.TabIndex = 1;
            this.Nombre.Text = "Nombre";
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(7, 20);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(100, 20);
            this.nametxt.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.EliminarBoton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.ComidasList);
            this.panel2.Location = new System.Drawing.Point(140, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(774, 219);
            this.panel2.TabIndex = 1;
            // 
            // EliminarBoton
            // 
            this.EliminarBoton.Location = new System.Drawing.Point(319, 193);
            this.EliminarBoton.Name = "EliminarBoton";
            this.EliminarBoton.Size = new System.Drawing.Size(155, 23);
            this.EliminarBoton.TabIndex = 2;
            this.EliminarBoton.Text = "Eliminar";
            this.EliminarBoton.UseVisualStyleBackColor = true;
            this.EliminarBoton.Click += new System.EventHandler(this.EliminarBoton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Listado";
            // 
            // ComidasList
            // 
            this.ComidasList.FormattingEnabled = true;
            this.ComidasList.Location = new System.Drawing.Point(4, 20);
            this.ComidasList.Name = "ComidasList";
            this.ComidasList.Size = new System.Drawing.Size(756, 173);
            this.ComidasList.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 241);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BotonAgregar;
        private System.Windows.Forms.TextBox carbtxt;
        private System.Windows.Forms.Label carb;
        private System.Windows.Forms.TextBox grasatxt;
        private System.Windows.Forms.Label grasa;
        private System.Windows.Forms.TextBox protetxt;
        private System.Windows.Forms.Label prote;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button EliminarBoton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ComidasList;
    }
}

