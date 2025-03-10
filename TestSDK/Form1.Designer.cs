namespace TestSDK
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
            groupBox5 = new GroupBox();
            button1 = new Button();
            lstControladora = new ListBox();
            groupBox3 = new GroupBox();
            chk8 = new CheckBox();
            chk7 = new CheckBox();
            chk5 = new CheckBox();
            chk6 = new CheckBox();
            chk4 = new CheckBox();
            chk3 = new CheckBox();
            chk2 = new CheckBox();
            chk1 = new CheckBox();
            groupBox4 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            txtIpControlador = new TextBox();
            btnConectar = new Button();
            txtPuertoControlador = new TextBox();
            chkEstado = new CheckBox();
            groupBox2 = new GroupBox();
            groupBox7 = new GroupBox();
            lstPlaca = new ListBox();
            groupBox8 = new GroupBox();
            pictureBox1 = new PictureBox();
            groupBox6 = new GroupBox();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            textBox2 = new TextBox();
            checkBox1 = new CheckBox();
            groupBox1.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox5);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(630, 492);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Controlador";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(button1);
            groupBox5.Controls.Add(lstControladora);
            groupBox5.Controls.Add(groupBox3);
            groupBox5.Location = new Point(20, 146);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(569, 316);
            groupBox5.TabIndex = 10;
            groupBox5.TabStop = false;
            groupBox5.Text = "Estados DI - DO";
            // 
            // button1
            // 
            button1.Location = new Point(72, 250);
            button1.Name = "button1";
            button1.Size = new Size(172, 38);
            button1.TabIndex = 9;
            button1.Text = "Consulta Conexión";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lstControladora
            // 
            lstControladora.FormattingEnabled = true;
            lstControladora.Location = new Point(22, 26);
            lstControladora.Name = "lstControladora";
            lstControladora.Size = new Size(275, 204);
            lstControladora.TabIndex = 2;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(chk8);
            groupBox3.Controls.Add(chk7);
            groupBox3.Controls.Add(chk5);
            groupBox3.Controls.Add(chk6);
            groupBox3.Controls.Add(chk4);
            groupBox3.Controls.Add(chk3);
            groupBox3.Controls.Add(chk2);
            groupBox3.Controls.Add(chk1);
            groupBox3.Location = new Point(322, 26);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(222, 207);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "OutPuts";
            // 
            // chk8
            // 
            chk8.AutoSize = true;
            chk8.Location = new Point(157, 156);
            chk8.Name = "chk8";
            chk8.Size = new Size(39, 24);
            chk8.TabIndex = 9;
            chk8.Text = "8";
            chk8.UseVisualStyleBackColor = true;
            chk8.CheckedChanged += chk8_CheckedChanged;
            // 
            // chk7
            // 
            chk7.AutoSize = true;
            chk7.Location = new Point(157, 118);
            chk7.Name = "chk7";
            chk7.Size = new Size(39, 24);
            chk7.TabIndex = 8;
            chk7.Text = "7";
            chk7.UseVisualStyleBackColor = true;
            chk7.CheckedChanged += chk7_CheckedChanged;
            // 
            // chk5
            // 
            chk5.AutoSize = true;
            chk5.Location = new Point(157, 36);
            chk5.Name = "chk5";
            chk5.Size = new Size(39, 24);
            chk5.TabIndex = 7;
            chk5.Text = "5";
            chk5.UseVisualStyleBackColor = true;
            chk5.CheckedChanged += chk5_CheckedChanged;
            // 
            // chk6
            // 
            chk6.AutoSize = true;
            chk6.Location = new Point(157, 77);
            chk6.Name = "chk6";
            chk6.Size = new Size(39, 24);
            chk6.TabIndex = 6;
            chk6.Text = "6";
            chk6.UseVisualStyleBackColor = true;
            chk6.CheckedChanged += chk6_CheckedChanged;
            // 
            // chk4
            // 
            chk4.AutoSize = true;
            chk4.Location = new Point(29, 156);
            chk4.Name = "chk4";
            chk4.Size = new Size(39, 24);
            chk4.TabIndex = 5;
            chk4.Text = "4";
            chk4.UseVisualStyleBackColor = true;
            chk4.CheckedChanged += chk4_CheckedChanged;
            // 
            // chk3
            // 
            chk3.AutoSize = true;
            chk3.Location = new Point(29, 118);
            chk3.Name = "chk3";
            chk3.Size = new Size(39, 24);
            chk3.TabIndex = 4;
            chk3.Text = "3";
            chk3.UseVisualStyleBackColor = true;
            chk3.CheckedChanged += chk3_CheckedChanged;
            // 
            // chk2
            // 
            chk2.AutoSize = true;
            chk2.Location = new Point(29, 77);
            chk2.Name = "chk2";
            chk2.Size = new Size(39, 24);
            chk2.TabIndex = 3;
            chk2.Text = "2";
            chk2.UseVisualStyleBackColor = true;
            chk2.CheckedChanged += chk2_CheckedChanged;
            // 
            // chk1
            // 
            chk1.AutoSize = true;
            chk1.Location = new Point(29, 36);
            chk1.Name = "chk1";
            chk1.Size = new Size(39, 24);
            chk1.TabIndex = 2;
            chk1.Text = "1";
            chk1.UseVisualStyleBackColor = true;
            chk1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label1);
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(txtIpControlador);
            groupBox4.Controls.Add(btnConectar);
            groupBox4.Controls.Add(txtPuertoControlador);
            groupBox4.Controls.Add(chkEstado);
            groupBox4.Location = new Point(20, 35);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(569, 97);
            groupBox4.TabIndex = 9;
            groupBox4.TabStop = false;
            groupBox4.Text = "Parametros de conexión";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 34);
            label1.Name = "label1";
            label1.Size = new Size(21, 20);
            label1.TabIndex = 6;
            label1.Text = "IP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(186, 31);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 7;
            label2.Text = "Puerto";
            // 
            // txtIpControlador
            // 
            txtIpControlador.Location = new Point(37, 57);
            txtIpControlador.Name = "txtIpControlador";
            txtIpControlador.PlaceholderText = "Ingrese IP";
            txtIpControlador.Size = new Size(125, 27);
            txtIpControlador.TabIndex = 4;
            txtIpControlador.Text = "192.168.18.100";
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(263, 51);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(106, 38);
            btnConectar.TabIndex = 0;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // txtPuertoControlador
            // 
            txtPuertoControlador.Location = new Point(179, 57);
            txtPuertoControlador.Name = "txtPuertoControlador";
            txtPuertoControlador.PlaceholderText = "Puerto";
            txtPuertoControlador.Size = new Size(65, 27);
            txtPuertoControlador.TabIndex = 5;
            txtPuertoControlador.Text = "5000";
            // 
            // chkEstado
            // 
            chkEstado.AutoSize = true;
            chkEstado.Enabled = false;
            chkEstado.Location = new Point(396, 59);
            chkEstado.Name = "chkEstado";
            chkEstado.Size = new Size(103, 24);
            chkEstado.TabIndex = 1;
            chkEstado.Text = "Conectado";
            chkEstado.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox7);
            groupBox2.Controls.Add(groupBox6);
            groupBox2.Location = new Point(648, 23);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(581, 481);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Camara LPR";
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(lstPlaca);
            groupBox7.Controls.Add(groupBox8);
            groupBox7.Location = new Point(6, 149);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(569, 316);
            groupBox7.TabIndex = 11;
            groupBox7.TabStop = false;
            groupBox7.Text = "Eventos LPR";
            // 
            // lstPlaca
            // 
            lstPlaca.FormattingEnabled = true;
            lstPlaca.Location = new Point(22, 26);
            lstPlaca.Name = "lstPlaca";
            lstPlaca.Size = new Size(275, 204);
            lstPlaca.TabIndex = 2;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(pictureBox1);
            groupBox8.Location = new Point(322, 26);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(222, 207);
            groupBox8.TabIndex = 3;
            groupBox8.TabStop = false;
            groupBox8.Text = "Foto de Placa";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(39, 63);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(label3);
            groupBox6.Controls.Add(label4);
            groupBox6.Controls.Add(textBox1);
            groupBox6.Controls.Add(button2);
            groupBox6.Controls.Add(textBox2);
            groupBox6.Controls.Add(checkBox1);
            groupBox6.Location = new Point(33, 37);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(495, 97);
            groupBox6.TabIndex = 10;
            groupBox6.TabStop = false;
            groupBox6.Text = "Parametros de conexión";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(86, 34);
            label3.Name = "label3";
            label3.Size = new Size(21, 20);
            label3.TabIndex = 6;
            label3.Text = "IP";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(186, 31);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 7;
            label4.Text = "Puerto";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(37, 57);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Ingrese IP";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 4;
            textBox1.Text = "192.168.18.100";
            // 
            // button2
            // 
            button2.Location = new Point(263, 51);
            button2.Name = "button2";
            button2.Size = new Size(106, 38);
            button2.TabIndex = 0;
            button2.Text = "Iniciar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(179, 57);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Puerto";
            textBox2.Size = new Size(65, 27);
            textBox2.TabIndex = 5;
            textBox2.Text = "5000";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Enabled = false;
            checkBox1.Location = new Point(386, 59);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(84, 24);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Iniciado";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1268, 526);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox lstControladora;
        private CheckBox chkEstado;
        private Button btnConectar;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private CheckBox chk8;
        private CheckBox chk7;
        private CheckBox chk5;
        private CheckBox chk6;
        private CheckBox chk4;
        private CheckBox chk3;
        private CheckBox chk2;
        private CheckBox chk1;
        private Label label2;
        private Label label1;
        private TextBox txtPuertoControlador;
        private TextBox txtIpControlador;
        private GroupBox groupBox5;
        private GroupBox groupBox4;
        private Button button1;
        private GroupBox groupBox6;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private Button button2;
        private TextBox textBox2;
        private CheckBox checkBox1;
        private GroupBox groupBox7;
        private ListBox lstPlaca;
        private GroupBox groupBox8;
        private PictureBox pictureBox1;
    }
}
