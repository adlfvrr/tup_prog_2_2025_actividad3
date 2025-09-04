namespace ej1
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
            groupBox1 = new GroupBox();
            btnListarIncidente = new Button();
            btnCrearComisaria = new Button();
            groupBox3 = new GroupBox();
            btnAsignarAgente = new Button();
            tbDNIAgente = new TextBox();
            label11 = new Label();
            tbNombreAgente = new TextBox();
            label10 = new Label();
            groupBox4 = new GroupBox();
            cbTipoIncidente = new ComboBox();
            btnRegistrarIncidente = new Button();
            tbMotivo = new TextBox();
            label9 = new Label();
            tbDNI = new TextBox();
            label8 = new Label();
            tbPersona = new TextBox();
            label7 = new Label();
            nudMinutoIncidente = new NumericUpDown();
            label6 = new Label();
            nudHoraIncidente = new NumericUpDown();
            label5 = new Label();
            groupBox2 = new GroupBox();
            btnAsignacionGuardia = new Button();
            nudDuracionM = new NumericUpDown();
            nudMinuto = new NumericUpDown();
            nudHora = new NumericUpDown();
            nudGuardia = new NumericUpDown();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            cbPlaca = new ComboBox();
            label1 = new Label();
            btnCerrar = new Button();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMinutoIncidente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudHoraIncidente).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDuracionM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMinuto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudHora).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudGuardia).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnListarIncidente);
            groupBox1.Controls.Add(btnCrearComisaria);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1139, 139);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Administración comisaría";
            // 
            // btnListarIncidente
            // 
            btnListarIncidente.Location = new Point(899, 33);
            btnListarIncidente.Name = "btnListarIncidente";
            btnListarIncidente.Size = new Size(165, 81);
            btnListarIncidente.TabIndex = 1;
            btnListarIncidente.Text = "Listar incidentes";
            btnListarIncidente.UseVisualStyleBackColor = true;
            btnListarIncidente.Click += btnListarIncidente_Click;
            // 
            // btnCrearComisaria
            // 
            btnCrearComisaria.Location = new Point(704, 33);
            btnCrearComisaria.Name = "btnCrearComisaria";
            btnCrearComisaria.Size = new Size(165, 81);
            btnCrearComisaria.TabIndex = 0;
            btnCrearComisaria.Text = "Creacion comisaría";
            btnCrearComisaria.UseVisualStyleBackColor = true;
            btnCrearComisaria.Click += btnCrearComisaria_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnAsignarAgente);
            groupBox3.Controls.Add(tbDNIAgente);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(tbNombreAgente);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(groupBox4);
            groupBox3.Controls.Add(groupBox2);
            groupBox3.Controls.Add(cbPlaca);
            groupBox3.Controls.Add(label1);
            groupBox3.Location = new Point(12, 157);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1139, 668);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Operaciones sobre el agente";
            // 
            // btnAsignarAgente
            // 
            btnAsignarAgente.Location = new Point(982, 41);
            btnAsignarAgente.Name = "btnAsignarAgente";
            btnAsignarAgente.Size = new Size(136, 74);
            btnAsignarAgente.TabIndex = 2;
            btnAsignarAgente.Text = "Asignar Agente";
            btnAsignarAgente.UseVisualStyleBackColor = true;
            btnAsignarAgente.Click += btnAsignarAgente_Click;
            // 
            // tbDNIAgente
            // 
            tbDNIAgente.Location = new Point(766, 64);
            tbDNIAgente.Name = "tbDNIAgente";
            tbDNIAgente.Size = new Size(193, 34);
            tbDNIAgente.TabIndex = 18;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(704, 67);
            label11.Name = "label11";
            label11.Size = new Size(46, 28);
            label11.TabIndex = 18;
            label11.Text = "DNI";
            // 
            // tbNombreAgente
            // 
            tbNombreAgente.Location = new Point(457, 64);
            tbNombreAgente.Name = "tbNombreAgente";
            tbNombreAgente.Size = new Size(193, 34);
            tbNombreAgente.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(351, 67);
            label10.Name = "label10";
            label10.Size = new Size(85, 28);
            label10.TabIndex = 4;
            label10.Text = "Nombre";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(cbTipoIncidente);
            groupBox4.Controls.Add(btnRegistrarIncidente);
            groupBox4.Controls.Add(tbMotivo);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(tbDNI);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(tbPersona);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(nudMinutoIncidente);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(nudHoraIncidente);
            groupBox4.Controls.Add(label5);
            groupBox4.Location = new Point(17, 335);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1116, 327);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Administración de incidentes";
            // 
            // cbTipoIncidente
            // 
            cbTipoIncidente.FormattingEnabled = true;
            cbTipoIncidente.Items.AddRange(new object[] { "Denuncia", "Arresto" });
            cbTipoIncidente.Location = new Point(197, 46);
            cbTipoIncidente.Name = "cbTipoIncidente";
            cbTipoIncidente.Size = new Size(168, 36);
            cbTipoIncidente.TabIndex = 4;
            // 
            // btnRegistrarIncidente
            // 
            btnRegistrarIncidente.Location = new Point(797, 152);
            btnRegistrarIncidente.Name = "btnRegistrarIncidente";
            btnRegistrarIncidente.Size = new Size(165, 81);
            btnRegistrarIncidente.TabIndex = 10;
            btnRegistrarIncidente.Text = "Registrar incidente";
            btnRegistrarIncidente.UseVisualStyleBackColor = true;
            btnRegistrarIncidente.Click += btnRegistrarIncidente_Click;
            // 
            // tbMotivo
            // 
            tbMotivo.Location = new Point(197, 202);
            tbMotivo.Multiline = true;
            tbMotivo.Name = "tbMotivo";
            tbMotivo.Size = new Size(524, 86);
            tbMotivo.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(22, 205);
            label9.Name = "label9";
            label9.Size = new Size(80, 28);
            label9.TabIndex = 16;
            label9.Text = "Motivo:";
            // 
            // tbDNI
            // 
            tbDNI.Location = new Point(528, 139);
            tbDNI.Name = "tbDNI";
            tbDNI.Size = new Size(193, 34);
            tbDNI.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(440, 142);
            label8.Name = "label8";
            label8.Size = new Size(46, 28);
            label8.TabIndex = 14;
            label8.Text = "DNI";
            // 
            // tbPersona
            // 
            tbPersona.Location = new Point(197, 139);
            tbPersona.Name = "tbPersona";
            tbPersona.Size = new Size(193, 34);
            tbPersona.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 142);
            label7.Name = "label7";
            label7.Size = new Size(80, 28);
            label7.TabIndex = 12;
            label7.Text = "Persona";
            // 
            // nudMinutoIncidente
            // 
            nudMinutoIncidente.Location = new Point(291, 92);
            nudMinutoIncidente.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            nudMinutoIncidente.Name = "nudMinutoIncidente";
            nudMinutoIncidente.Size = new Size(74, 34);
            nudMinutoIncidente.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 94);
            label6.Name = "label6";
            label6.Size = new Size(55, 28);
            label6.TabIndex = 10;
            label6.Text = "Hora";
            // 
            // nudHoraIncidente
            // 
            nudHoraIncidente.Location = new Point(197, 92);
            nudHoraIncidente.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
            nudHoraIncidente.Name = "nudHoraIncidente";
            nudHoraIncidente.Size = new Size(74, 34);
            nudHoraIncidente.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 49);
            label5.Name = "label5";
            label5.Size = new Size(136, 28);
            label5.TabIndex = 10;
            label5.Text = "Tipo incidente";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnAsignacionGuardia);
            groupBox2.Controls.Add(nudDuracionM);
            groupBox2.Controls.Add(nudMinuto);
            groupBox2.Controls.Add(nudHora);
            groupBox2.Controls.Add(nudGuardia);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(17, 121);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1116, 208);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Administración de guardias";
            // 
            // btnAsignacionGuardia
            // 
            btnAsignacionGuardia.Location = new Point(882, 73);
            btnAsignacionGuardia.Name = "btnAsignacionGuardia";
            btnAsignacionGuardia.Size = new Size(165, 81);
            btnAsignacionGuardia.TabIndex = 2;
            btnAsignacionGuardia.Text = "Asignación de las guardias";
            btnAsignacionGuardia.UseVisualStyleBackColor = true;
            btnAsignacionGuardia.Click += btnAsignacionGuardia_Click;
            // 
            // nudDuracionM
            // 
            nudDuracionM.Location = new Point(197, 145);
            nudDuracionM.Name = "nudDuracionM";
            nudDuracionM.Size = new Size(168, 34);
            nudDuracionM.TabIndex = 9;
            // 
            // nudMinuto
            // 
            nudMinuto.Location = new Point(291, 97);
            nudMinuto.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            nudMinuto.Name = "nudMinuto";
            nudMinuto.Size = new Size(74, 34);
            nudMinuto.TabIndex = 8;
            // 
            // nudHora
            // 
            nudHora.Location = new Point(197, 97);
            nudHora.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
            nudHora.Name = "nudHora";
            nudHora.Size = new Size(74, 34);
            nudHora.TabIndex = 7;
            // 
            // nudGuardia
            // 
            nudGuardia.Location = new Point(197, 52);
            nudGuardia.Name = "nudGuardia";
            nudGuardia.Size = new Size(168, 34);
            nudGuardia.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 147);
            label4.Name = "label4";
            label4.Size = new Size(140, 28);
            label4.TabIndex = 5;
            label4.Text = "Duración en M";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 99);
            label3.Name = "label3";
            label3.Size = new Size(66, 28);
            label3.TabIndex = 4;
            label3.Text = "Desde";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 54);
            label2.Name = "label2";
            label2.Size = new Size(120, 28);
            label2.TabIndex = 3;
            label2.Text = "Nro Guardia";
            // 
            // cbPlaca
            // 
            cbPlaca.FormattingEnabled = true;
            cbPlaca.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15" });
            cbPlaca.Location = new Point(188, 64);
            cbPlaca.Name = "cbPlaca";
            cbPlaca.Size = new Size(121, 36);
            cbPlaca.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 67);
            label1.Name = "label1";
            label1.Size = new Size(152, 28);
            label1.TabIndex = 0;
            label1.Text = "Placa de Agente";
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(455, 831);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(165, 81);
            btnCerrar.TabIndex = 18;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1163, 923);
            Controls.Add(btnCerrar);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 15F);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudMinutoIncidente).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudHoraIncidente).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudDuracionM).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMinuto).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudHora).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudGuardia).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnListarIncidente;
        private Button btnCrearComisaria;
        private GroupBox groupBox3;
        private ComboBox cbPlaca;
        private Label label1;
        private GroupBox groupBox2;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox groupBox4;
        private Label label7;
        private NumericUpDown nudMinutoIncidente;
        private Label label6;
        private NumericUpDown nudHoraIncidente;
        private Label label5;
        private Button btnAsignacionGuardia;
        private NumericUpDown nudDuracionM;
        private NumericUpDown nudMinuto;
        private NumericUpDown nudHora;
        private NumericUpDown nudGuardia;
        private ComboBox cbTipoIncidente;
        private Button btnRegistrarIncidente;
        private TextBox tbMotivo;
        private Label label9;
        private TextBox tbDNI;
        private Label label8;
        private TextBox tbPersona;
        private Button btnCerrar;
        private Button btnAsignarAgente;
        private TextBox tbDNIAgente;
        private Label label11;
        private TextBox tbNombreAgente;
        private Label label10;
    }
}
