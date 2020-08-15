namespace ProyectoTriangulo
{
    partial class Triángulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Triángulos));
            this.calcularc = new System.Windows.Forms.Button();
            this.valorcatetoc = new System.Windows.Forms.TextBox();
            this.valorcatetob = new System.Windows.Forms.TextBox();
            this.valorhipotenusa = new System.Windows.Forms.TextBox();
            this.calcularb = new System.Windows.Forms.Button();
            this.calcularhipotenusa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.valoranguloa = new System.Windows.Forms.TextBox();
            this.valorangulob = new System.Windows.Forms.TextBox();
            this.valoranguloc = new System.Windows.Forms.TextBox();
            this.calcularab = new System.Windows.Forms.Button();
            this.calcularac = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.valorarea = new System.Windows.Forms.TextBox();
            this.calculararea = new System.Windows.Forms.Button();
            this.calculartodo = new System.Windows.Forms.Button();
            this.Reiniciar = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.regresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // calcularc
            // 
            this.calcularc.Location = new System.Drawing.Point(160, 151);
            this.calcularc.Name = "calcularc";
            this.calcularc.Size = new System.Drawing.Size(75, 23);
            this.calcularc.TabIndex = 0;
            this.calcularc.Text = "Calcular";
            this.calcularc.UseVisualStyleBackColor = true;
            this.calcularc.Click += new System.EventHandler(this.calcularc_Click);
            // 
            // valorcatetoc
            // 
            this.valorcatetoc.Location = new System.Drawing.Point(111, 151);
            this.valorcatetoc.Name = "valorcatetoc";
            this.valorcatetoc.Size = new System.Drawing.Size(43, 20);
            this.valorcatetoc.TabIndex = 1;
            this.valorcatetoc.Text = "0";
            // 
            // valorcatetob
            // 
            this.valorcatetob.Location = new System.Drawing.Point(111, 180);
            this.valorcatetob.Name = "valorcatetob";
            this.valorcatetob.Size = new System.Drawing.Size(43, 20);
            this.valorcatetob.TabIndex = 2;
            this.valorcatetob.Text = "0";
            // 
            // valorhipotenusa
            // 
            this.valorhipotenusa.Location = new System.Drawing.Point(111, 206);
            this.valorhipotenusa.Name = "valorhipotenusa";
            this.valorhipotenusa.Size = new System.Drawing.Size(43, 20);
            this.valorhipotenusa.TabIndex = 3;
            this.valorhipotenusa.Text = "0";
            // 
            // calcularb
            // 
            this.calcularb.Location = new System.Drawing.Point(160, 177);
            this.calcularb.Name = "calcularb";
            this.calcularb.Size = new System.Drawing.Size(75, 23);
            this.calcularb.TabIndex = 4;
            this.calcularb.Text = "Calcular";
            this.calcularb.UseVisualStyleBackColor = true;
            this.calcularb.Click += new System.EventHandler(this.calcularb_Click);
            // 
            // calcularhipotenusa
            // 
            this.calcularhipotenusa.Location = new System.Drawing.Point(160, 206);
            this.calcularhipotenusa.Name = "calcularhipotenusa";
            this.calcularhipotenusa.Size = new System.Drawing.Size(75, 23);
            this.calcularhipotenusa.TabIndex = 5;
            this.calcularhipotenusa.Text = "Calcular";
            this.calcularhipotenusa.UseVisualStyleBackColor = true;
            this.calcularhipotenusa.Click += new System.EventHandler(this.calcularhipotenusa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Valor cateto c";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 180);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Valor cateto b";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Valor hipotenusa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ángulo A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ángulo B";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ángulo C";
            // 
            // valoranguloa
            // 
            this.valoranguloa.Enabled = false;
            this.valoranguloa.Location = new System.Drawing.Point(111, 232);
            this.valoranguloa.Name = "valoranguloa";
            this.valoranguloa.Size = new System.Drawing.Size(43, 20);
            this.valoranguloa.TabIndex = 12;
            this.valoranguloa.Text = "90";
            // 
            // valorangulob
            // 
            this.valorangulob.Location = new System.Drawing.Point(111, 261);
            this.valorangulob.Name = "valorangulob";
            this.valorangulob.Size = new System.Drawing.Size(43, 20);
            this.valorangulob.TabIndex = 13;
            this.valorangulob.Text = "0";
            // 
            // valoranguloc
            // 
            this.valoranguloc.Location = new System.Drawing.Point(111, 287);
            this.valoranguloc.Name = "valoranguloc";
            this.valoranguloc.Size = new System.Drawing.Size(43, 20);
            this.valoranguloc.TabIndex = 14;
            this.valoranguloc.Text = "0";
            // 
            // calcularab
            // 
            this.calcularab.Location = new System.Drawing.Point(160, 260);
            this.calcularab.Name = "calcularab";
            this.calcularab.Size = new System.Drawing.Size(75, 23);
            this.calcularab.TabIndex = 16;
            this.calcularab.Text = "Calcular";
            this.calcularab.UseVisualStyleBackColor = true;
            this.calcularab.Click += new System.EventHandler(this.calcularab_Click);
            // 
            // calcularac
            // 
            this.calcularac.Location = new System.Drawing.Point(160, 284);
            this.calcularac.Name = "calcularac";
            this.calcularac.Size = new System.Drawing.Size(75, 23);
            this.calcularac.TabIndex = 17;
            this.calcularac.Text = "Calcular";
            this.calcularac.UseVisualStyleBackColor = true;
            this.calcularac.Click += new System.EventHandler(this.calcularac_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Área";
            // 
            // valorarea
            // 
            this.valorarea.Location = new System.Drawing.Point(111, 313);
            this.valorarea.Name = "valorarea";
            this.valorarea.Size = new System.Drawing.Size(43, 20);
            this.valorarea.TabIndex = 20;
            this.valorarea.Text = "0";
            // 
            // calculararea
            // 
            this.calculararea.Location = new System.Drawing.Point(160, 310);
            this.calculararea.Name = "calculararea";
            this.calculararea.Size = new System.Drawing.Size(75, 23);
            this.calculararea.TabIndex = 21;
            this.calculararea.Text = "Calcular";
            this.calculararea.UseVisualStyleBackColor = true;
            this.calculararea.Click += new System.EventHandler(this.calculararea_Click);
            // 
            // calculartodo
            // 
            this.calculartodo.Location = new System.Drawing.Point(36, 339);
            this.calculartodo.Name = "calculartodo";
            this.calculartodo.Size = new System.Drawing.Size(159, 34);
            this.calculartodo.TabIndex = 22;
            this.calculartodo.Text = "Calcular Todo";
            this.calculartodo.UseVisualStyleBackColor = true;
            this.calculartodo.Click += new System.EventHandler(this.calculartodo_Click);
            // 
            // Reiniciar
            // 
            this.Reiniciar.Location = new System.Drawing.Point(36, 379);
            this.Reiniciar.Name = "Reiniciar";
            this.Reiniciar.Size = new System.Drawing.Size(159, 34);
            this.Reiniciar.TabIndex = 23;
            this.Reiniciar.Text = "Reiniciar Valores";
            this.Reiniciar.UseVisualStyleBackColor = true;
            this.Reiniciar.Click += new System.EventHandler(this.Reiniciar_Click);
            // 
            // Salir
            // 
            this.Salir.AutoSize = true;
            this.Salir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salir.Location = new System.Drawing.Point(396, 384);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(159, 29);
            this.Salir.TabIndex = 24;
            this.Salir.Text = "Salir del Programa";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(291, 24);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(216, 95);
            this.textBox1.TabIndex = 25;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // regresar
            // 
            this.regresar.AutoSize = true;
            this.regresar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regresar.Location = new System.Drawing.Point(231, 384);
            this.regresar.Name = "regresar";
            this.regresar.Size = new System.Drawing.Size(159, 29);
            this.regresar.TabIndex = 26;
            this.regresar.Text = "Regresar a inicio";
            this.regresar.UseVisualStyleBackColor = true;
            this.regresar.Click += new System.EventHandler(this.regresar_Click);
            // 
            // Triángulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 450);
            this.Controls.Add(this.regresar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Reiniciar);
            this.Controls.Add(this.calculartodo);
            this.Controls.Add(this.calculararea);
            this.Controls.Add(this.valorarea);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.calcularac);
            this.Controls.Add(this.calcularab);
            this.Controls.Add(this.valoranguloc);
            this.Controls.Add(this.valorangulob);
            this.Controls.Add(this.valoranguloa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calcularhipotenusa);
            this.Controls.Add(this.calcularb);
            this.Controls.Add(this.valorhipotenusa);
            this.Controls.Add(this.valorcatetob);
            this.Controls.Add(this.valorcatetoc);
            this.Controls.Add(this.calcularc);
            this.Name = "Triángulos";
            this.Text = "h";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Triángulos_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calcularc;
        private System.Windows.Forms.TextBox valorcatetoc;
        private System.Windows.Forms.TextBox valorcatetob;
        private System.Windows.Forms.TextBox valorhipotenusa;
        private System.Windows.Forms.Button calcularb;
        private System.Windows.Forms.Button calcularhipotenusa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox valoranguloa;
        private System.Windows.Forms.TextBox valorangulob;
        private System.Windows.Forms.TextBox valoranguloc;
        private System.Windows.Forms.Button calcularab;
        private System.Windows.Forms.Button calcularac;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox valorarea;
        private System.Windows.Forms.Button calculararea;
        private System.Windows.Forms.Button calculartodo;
        private System.Windows.Forms.Button Reiniciar;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button regresar;
    }
}

