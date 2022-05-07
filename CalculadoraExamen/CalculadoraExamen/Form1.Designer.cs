namespace CalculadoraExamen
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.areatrabajo = new System.Windows.Forms.TextBox();
            this.numero7 = new System.Windows.Forms.Button();
            this.numero8 = new System.Windows.Forms.Button();
            this.numero9 = new System.Windows.Forms.Button();
            this.dividir = new System.Windows.Forms.Button();
            this.borrartodo = new System.Windows.Forms.Button();
            this.borrar = new System.Windows.Forms.Button();
            this.multiplicar = new System.Windows.Forms.Button();
            this.numero6 = new System.Windows.Forms.Button();
            this.numero5 = new System.Windows.Forms.Button();
            this.numero4 = new System.Windows.Forms.Button();
            this.restar = new System.Windows.Forms.Button();
            this.numero3 = new System.Windows.Forms.Button();
            this.numero2 = new System.Windows.Forms.Button();
            this.numero1 = new System.Windows.Forms.Button();
            this.suma = new System.Windows.Forms.Button();
            this.punto = new System.Windows.Forms.Button();
            this.numero0 = new System.Windows.Forms.Button();
            this.igual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // areatrabajo
            // 
            this.areatrabajo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.areatrabajo.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.areatrabajo.Location = new System.Drawing.Point(8, 17);
            this.areatrabajo.Multiline = true;
            this.areatrabajo.Name = "areatrabajo";
            this.areatrabajo.ReadOnly = true;
            this.areatrabajo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.areatrabajo.Size = new System.Drawing.Size(273, 40);
            this.areatrabajo.TabIndex = 0;
            this.areatrabajo.Text = "0";
            this.areatrabajo.TextChanged += new System.EventHandler(this.areatrabajo_TextChanged);
            // 
            // numero7
            // 
            this.numero7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numero7.Location = new System.Drawing.Point(6, 72);
            this.numero7.Name = "numero7";
            this.numero7.Size = new System.Drawing.Size(49, 45);
            this.numero7.TabIndex = 1;
            this.numero7.Text = "7";
            this.numero7.UseVisualStyleBackColor = true;
            this.numero7.Click += new System.EventHandler(this.numero7_Click);
            // 
            // numero8
            // 
            this.numero8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numero8.Location = new System.Drawing.Point(61, 72);
            this.numero8.Name = "numero8";
            this.numero8.Size = new System.Drawing.Size(49, 45);
            this.numero8.TabIndex = 2;
            this.numero8.Text = "8";
            this.numero8.UseVisualStyleBackColor = true;
            this.numero8.Click += new System.EventHandler(this.numero8_Click);
            // 
            // numero9
            // 
            this.numero9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numero9.Location = new System.Drawing.Point(116, 72);
            this.numero9.Name = "numero9";
            this.numero9.Size = new System.Drawing.Size(49, 45);
            this.numero9.TabIndex = 3;
            this.numero9.Text = "9";
            this.numero9.UseVisualStyleBackColor = true;
            this.numero9.Click += new System.EventHandler(this.numero9_Click);
            // 
            // dividir
            // 
            this.dividir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dividir.Location = new System.Drawing.Point(171, 72);
            this.dividir.Name = "dividir";
            this.dividir.Size = new System.Drawing.Size(49, 45);
            this.dividir.TabIndex = 4;
            this.dividir.Text = "/";
            this.dividir.UseVisualStyleBackColor = true;
            this.dividir.Click += new System.EventHandler(this.dividir_Click);
            // 
            // borrartodo
            // 
            this.borrartodo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.borrartodo.Location = new System.Drawing.Point(226, 72);
            this.borrartodo.Name = "borrartodo";
            this.borrartodo.Size = new System.Drawing.Size(49, 45);
            this.borrartodo.TabIndex = 5;
            this.borrartodo.Text = "CE";
            this.borrartodo.UseVisualStyleBackColor = true;
            this.borrartodo.Click += new System.EventHandler(this.borrartodo_Click);
            // 
            // borrar
            // 
            this.borrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.borrar.Location = new System.Drawing.Point(226, 123);
            this.borrar.Name = "borrar";
            this.borrar.Size = new System.Drawing.Size(49, 45);
            this.borrar.TabIndex = 10;
            this.borrar.Text = "C";
            this.borrar.UseVisualStyleBackColor = true;
            this.borrar.Click += new System.EventHandler(this.borrar_Click);
            // 
            // multiplicar
            // 
            this.multiplicar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.multiplicar.Location = new System.Drawing.Point(171, 123);
            this.multiplicar.Name = "multiplicar";
            this.multiplicar.Size = new System.Drawing.Size(49, 45);
            this.multiplicar.TabIndex = 9;
            this.multiplicar.Text = "*";
            this.multiplicar.UseVisualStyleBackColor = true;
            this.multiplicar.Click += new System.EventHandler(this.multiplicar_Click);
            // 
            // numero6
            // 
            this.numero6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numero6.Location = new System.Drawing.Point(116, 123);
            this.numero6.Name = "numero6";
            this.numero6.Size = new System.Drawing.Size(49, 45);
            this.numero6.TabIndex = 8;
            this.numero6.Text = "6";
            this.numero6.UseVisualStyleBackColor = true;
            this.numero6.Click += new System.EventHandler(this.numero6_Click);
            // 
            // numero5
            // 
            this.numero5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numero5.Location = new System.Drawing.Point(61, 123);
            this.numero5.Name = "numero5";
            this.numero5.Size = new System.Drawing.Size(49, 45);
            this.numero5.TabIndex = 7;
            this.numero5.Text = "5";
            this.numero5.UseVisualStyleBackColor = true;
            this.numero5.Click += new System.EventHandler(this.numero5_Click);
            // 
            // numero4
            // 
            this.numero4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numero4.Location = new System.Drawing.Point(6, 123);
            this.numero4.Name = "numero4";
            this.numero4.Size = new System.Drawing.Size(49, 45);
            this.numero4.TabIndex = 6;
            this.numero4.Text = "4";
            this.numero4.UseVisualStyleBackColor = true;
            this.numero4.Click += new System.EventHandler(this.numero4_Click);
            // 
            // restar
            // 
            this.restar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.restar.Location = new System.Drawing.Point(171, 174);
            this.restar.Name = "restar";
            this.restar.Size = new System.Drawing.Size(49, 45);
            this.restar.TabIndex = 14;
            this.restar.Text = "-";
            this.restar.UseVisualStyleBackColor = true;
            this.restar.Click += new System.EventHandler(this.restar_Click);
            // 
            // numero3
            // 
            this.numero3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numero3.Location = new System.Drawing.Point(116, 174);
            this.numero3.Name = "numero3";
            this.numero3.Size = new System.Drawing.Size(49, 45);
            this.numero3.TabIndex = 13;
            this.numero3.Text = "3";
            this.numero3.UseVisualStyleBackColor = true;
            this.numero3.Click += new System.EventHandler(this.numero3_Click);
            // 
            // numero2
            // 
            this.numero2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numero2.Location = new System.Drawing.Point(61, 174);
            this.numero2.Name = "numero2";
            this.numero2.Size = new System.Drawing.Size(49, 45);
            this.numero2.TabIndex = 12;
            this.numero2.Text = "2";
            this.numero2.UseVisualStyleBackColor = true;
            this.numero2.Click += new System.EventHandler(this.numero2_Click);
            // 
            // numero1
            // 
            this.numero1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numero1.Location = new System.Drawing.Point(6, 174);
            this.numero1.Name = "numero1";
            this.numero1.Size = new System.Drawing.Size(49, 45);
            this.numero1.TabIndex = 11;
            this.numero1.Text = "1";
            this.numero1.UseVisualStyleBackColor = true;
            this.numero1.Click += new System.EventHandler(this.numero1_Click);
            // 
            // suma
            // 
            this.suma.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.suma.Location = new System.Drawing.Point(171, 225);
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(49, 45);
            this.suma.TabIndex = 18;
            this.suma.Text = "+";
            this.suma.UseVisualStyleBackColor = true;
            this.suma.Click += new System.EventHandler(this.suma_Click);
            // 
            // punto
            // 
            this.punto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.punto.Location = new System.Drawing.Point(116, 225);
            this.punto.Name = "punto";
            this.punto.Size = new System.Drawing.Size(49, 45);
            this.punto.TabIndex = 17;
            this.punto.Text = ".";
            this.punto.UseVisualStyleBackColor = true;
            this.punto.Click += new System.EventHandler(this.punto_Click);
            // 
            // numero0
            // 
            this.numero0.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numero0.Location = new System.Drawing.Point(6, 225);
            this.numero0.Name = "numero0";
            this.numero0.Size = new System.Drawing.Size(104, 45);
            this.numero0.TabIndex = 15;
            this.numero0.Text = "0";
            this.numero0.UseVisualStyleBackColor = true;
            this.numero0.Click += new System.EventHandler(this.numero0_Click);
            // 
            // igual
            // 
            this.igual.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.igual.Location = new System.Drawing.Point(226, 174);
            this.igual.Name = "igual";
            this.igual.Size = new System.Drawing.Size(49, 96);
            this.igual.TabIndex = 19;
            this.igual.Text = "=";
            this.igual.UseVisualStyleBackColor = true;
            this.igual.Click += new System.EventHandler(this.igual_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(288, 283);
            this.Controls.Add(this.igual);
            this.Controls.Add(this.suma);
            this.Controls.Add(this.punto);
            this.Controls.Add(this.numero0);
            this.Controls.Add(this.restar);
            this.Controls.Add(this.numero3);
            this.Controls.Add(this.numero2);
            this.Controls.Add(this.numero1);
            this.Controls.Add(this.borrar);
            this.Controls.Add(this.multiplicar);
            this.Controls.Add(this.numero6);
            this.Controls.Add(this.numero5);
            this.Controls.Add(this.numero4);
            this.Controls.Add(this.borrartodo);
            this.Controls.Add(this.dividir);
            this.Controls.Add(this.numero9);
            this.Controls.Add(this.numero8);
            this.Controls.Add(this.numero7);
            this.Controls.Add(this.areatrabajo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox areatrabajo;
        private Button numero7;
        private Button numero8;
        private Button numero9;
        private Button dividir;
        private Button borrartodo;
        private Button borrar;
        private Button multiplicar;
        private Button numero6;
        private Button numero5;
        private Button numero4;
        private Button restar;
        private Button numero3;
        private Button numero2;
        private Button numero1;
        private Button suma;
        private Button punto;
        private Button numero0;
        private Button igual;
    }
}