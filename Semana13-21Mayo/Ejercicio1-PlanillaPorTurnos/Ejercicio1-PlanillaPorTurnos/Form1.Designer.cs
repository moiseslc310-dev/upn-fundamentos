namespace Ejercicio1_PlanillaPorTurnos
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
            this.grpMañana = new System.Windows.Forms.GroupBox();
            this.grpTarde = new System.Windows.Forms.GroupBox();
            this.grpNoche = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbM1 = new System.Windows.Forms.TextBox();
            this.txbM2 = new System.Windows.Forms.TextBox();
            this.txbM3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txbN1 = new System.Windows.Forms.TextBox();
            this.txbT2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txbN2 = new System.Windows.Forms.TextBox();
            this.txbT1 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnDatosPrueba = new System.Windows.Forms.Button();
            this.lblTurnoMayor = new System.Windows.Forms.Label();
            this.lstResultados = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.grpMañana.SuspendLayout();
            this.grpTarde.SuspendLayout();
            this.grpNoche.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMañana
            // 
            this.grpMañana.Controls.Add(this.txbM3);
            this.grpMañana.Controls.Add(this.txbM2);
            this.grpMañana.Controls.Add(this.txbM1);
            this.grpMañana.Controls.Add(this.label5);
            this.grpMañana.Controls.Add(this.label4);
            this.grpMañana.Controls.Add(this.label3);
            this.grpMañana.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMañana.Location = new System.Drawing.Point(33, 115);
            this.grpMañana.Name = "grpMañana";
            this.grpMañana.Size = new System.Drawing.Size(244, 138);
            this.grpMañana.TabIndex = 0;
            this.grpMañana.TabStop = false;
            this.grpMañana.Text = "Turno Mañana";
            // 
            // grpTarde
            // 
            this.grpTarde.Controls.Add(this.label6);
            this.grpTarde.Controls.Add(this.txbT2);
            this.grpTarde.Controls.Add(this.txbT1);
            this.grpTarde.Controls.Add(this.label7);
            this.grpTarde.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTarde.Location = new System.Drawing.Point(297, 115);
            this.grpTarde.Name = "grpTarde";
            this.grpTarde.Size = new System.Drawing.Size(228, 138);
            this.grpTarde.TabIndex = 1;
            this.grpTarde.TabStop = false;
            this.grpTarde.Text = "Turno Tarde";
            // 
            // grpNoche
            // 
            this.grpNoche.Controls.Add(this.label8);
            this.grpNoche.Controls.Add(this.label9);
            this.grpNoche.Controls.Add(this.txbN2);
            this.grpNoche.Controls.Add(this.txbN1);
            this.grpNoche.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNoche.Location = new System.Drawing.Point(549, 115);
            this.grpNoche.Name = "grpNoche";
            this.grpNoche.Size = new System.Drawing.Size(228, 138);
            this.grpNoche.TabIndex = 2;
            this.grpNoche.TabStop = false;
            this.grpNoche.Text = "Turno Noche";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ejercicio 1: Planilla por turnos";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(30, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(787, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ingrese el sueldo de los trabajadores por turno. El programa calcula el gasto tot" +
    "al, identifica el turno más costoso y ordena los sueldos de menor a mayor uzando" +
    " burbuja";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sueldo 1: S/";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Sueldo 2: S/";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Sueldo 3: S/";
            // 
            // txbM1
            // 
            this.txbM1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbM1.Location = new System.Drawing.Point(125, 33);
            this.txbM1.Name = "txbM1";
            this.txbM1.Size = new System.Drawing.Size(100, 22);
            this.txbM1.TabIndex = 1;
            // 
            // txbM2
            // 
            this.txbM2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbM2.Location = new System.Drawing.Point(125, 67);
            this.txbM2.Name = "txbM2";
            this.txbM2.Size = new System.Drawing.Size(100, 22);
            this.txbM2.TabIndex = 1;
            // 
            // txbM3
            // 
            this.txbM3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbM3.Location = new System.Drawing.Point(125, 103);
            this.txbM3.Name = "txbM3";
            this.txbM3.Size = new System.Drawing.Size(100, 22);
            this.txbM3.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Sueldo 1: S/";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Sueldo 2: S/";
            // 
            // txbN1
            // 
            this.txbN1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbN1.Location = new System.Drawing.Point(112, 30);
            this.txbN1.Name = "txbN1";
            this.txbN1.Size = new System.Drawing.Size(100, 22);
            this.txbN1.TabIndex = 1;
            // 
            // txbT2
            // 
            this.txbT2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbT2.Location = new System.Drawing.Point(109, 70);
            this.txbT2.Name = "txbT2";
            this.txbT2.Size = new System.Drawing.Size(100, 22);
            this.txbT2.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Sueldo 1: S/";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Sueldo 2: S/";
            // 
            // txbN2
            // 
            this.txbN2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbN2.Location = new System.Drawing.Point(112, 70);
            this.txbN2.Name = "txbN2";
            this.txbN2.Size = new System.Drawing.Size(100, 22);
            this.txbN2.TabIndex = 1;
            // 
            // txbT1
            // 
            this.txbT1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbT1.Location = new System.Drawing.Point(109, 33);
            this.txbT1.Name = "txbT1";
            this.txbT1.Size = new System.Drawing.Size(100, 22);
            this.txbT1.TabIndex = 1;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCalcular.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCalcular.Location = new System.Drawing.Point(44, 274);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(157, 36);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular y Ordenar";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnLimpiar.Location = new System.Drawing.Point(207, 274);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(131, 36);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnDatosPrueba
            // 
            this.btnDatosPrueba.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnDatosPrueba.Location = new System.Drawing.Point(344, 274);
            this.btnDatosPrueba.Name = "btnDatosPrueba";
            this.btnDatosPrueba.Size = new System.Drawing.Size(131, 36);
            this.btnDatosPrueba.TabIndex = 5;
            this.btnDatosPrueba.Text = "Datos de Prueba";
            this.btnDatosPrueba.UseVisualStyleBackColor = false;
            this.btnDatosPrueba.Click += new System.EventHandler(this.btnDatosPrueba_Click);
            // 
            // lblTurnoMayor
            // 
            this.lblTurnoMayor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblTurnoMayor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTurnoMayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurnoMayor.Location = new System.Drawing.Point(490, 274);
            this.lblTurnoMayor.Name = "lblTurnoMayor";
            this.lblTurnoMayor.Size = new System.Drawing.Size(287, 36);
            this.lblTurnoMayor.TabIndex = 6;
            this.lblTurnoMayor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lstResultados
            // 
            this.lstResultados.FormattingEnabled = true;
            this.lstResultados.ItemHeight = 16;
            this.lstResultados.Location = new System.Drawing.Point(33, 379);
            this.lstResultados.Name = "lstResultados";
            this.lstResultados.Size = new System.Drawing.Size(744, 164);
            this.lstResultados.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(44, 342);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 16);
            this.label10.TabIndex = 8;
            this.label10.Text = "Resultados";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 575);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lstResultados);
            this.Controls.Add(this.lblTurnoMayor);
            this.Controls.Add(this.btnDatosPrueba);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpNoche);
            this.Controls.Add(this.grpTarde);
            this.Controls.Add(this.grpMañana);
            this.Name = "Form1";
            this.Text = "Ejercicio 1: Planilla por turnos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpMañana.ResumeLayout(false);
            this.grpMañana.PerformLayout();
            this.grpTarde.ResumeLayout(false);
            this.grpTarde.PerformLayout();
            this.grpNoche.ResumeLayout(false);
            this.grpNoche.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMañana;
        private System.Windows.Forms.GroupBox grpTarde;
        private System.Windows.Forms.GroupBox grpNoche;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbM3;
        private System.Windows.Forms.TextBox txbM2;
        private System.Windows.Forms.TextBox txbM1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbT2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbN1;
        private System.Windows.Forms.TextBox txbT1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbN2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnDatosPrueba;
        private System.Windows.Forms.Label lblTurnoMayor;
        private System.Windows.Forms.ListBox lstResultados;
        private System.Windows.Forms.Label label10;
    }
}

