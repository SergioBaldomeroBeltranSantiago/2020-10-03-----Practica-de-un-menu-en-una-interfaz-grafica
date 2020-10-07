namespace Tarea_02
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Formulario = new System.Windows.Forms.TabControl();
            this.InformacionCliente = new System.Windows.Forms.TabPage();
            this.TextBox_Nombre = new System.Windows.Forms.TextBox();
            this.TextBox_Telefono = new System.Windows.Forms.TextBox();
            this.TextBox_Correo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProcesadorMemoria = new System.Windows.Forms.TabPage();
            this.Ram = new System.Windows.Forms.GroupBox();
            this.Ram01 = new System.Windows.Forms.RadioButton();
            this.Ram04 = new System.Windows.Forms.RadioButton();
            this.Ram02 = new System.Windows.Forms.RadioButton();
            this.Ram03 = new System.Windows.Forms.RadioButton();
            this.Procesadores = new System.Windows.Forms.GroupBox();
            this.Procesador01 = new System.Windows.Forms.RadioButton();
            this.Procesador04 = new System.Windows.Forms.RadioButton();
            this.Procesador03 = new System.Windows.Forms.RadioButton();
            this.Procesador02 = new System.Windows.Forms.RadioButton();
            this.SOAlmacenamiento = new System.Windows.Forms.TabPage();
            this.DiscoDuro = new System.Windows.Forms.GroupBox();
            this.DiscoDuro4 = new System.Windows.Forms.CheckBox();
            this.DiscoDuro3 = new System.Windows.Forms.CheckBox();
            this.DiscoDuro2 = new System.Windows.Forms.CheckBox();
            this.DiscoDuro1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SistemasOperativos = new System.Windows.Forms.ListBox();
            this.Extras = new System.Windows.Forms.TabPage();
            this.LimpiarCampos = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.Comprar = new System.Windows.Forms.Button();
            this.Ajolote = new System.Windows.Forms.PictureBox();
            this.Extra1 = new System.Windows.Forms.CheckBox();
            this.Extra3 = new System.Windows.Forms.CheckBox();
            this.Extra2 = new System.Windows.Forms.CheckBox();
            this.Extra6 = new System.Windows.Forms.CheckBox();
            this.Extra5 = new System.Windows.Forms.CheckBox();
            this.Extra4 = new System.Windows.Forms.CheckBox();
            this.Extra7 = new System.Windows.Forms.CheckBox();
            this.Extra8 = new System.Windows.Forms.CheckBox();
            this.Extra9 = new System.Windows.Forms.CheckBox();
            this.Extra = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Ticket = new System.Windows.Forms.RichTextBox();
            this.Formulario.SuspendLayout();
            this.InformacionCliente.SuspendLayout();
            this.ProcesadorMemoria.SuspendLayout();
            this.Ram.SuspendLayout();
            this.Procesadores.SuspendLayout();
            this.SOAlmacenamiento.SuspendLayout();
            this.DiscoDuro.SuspendLayout();
            this.Extras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ajolote)).BeginInit();
            this.Extra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Formulario
            // 
            this.Formulario.Controls.Add(this.InformacionCliente);
            this.Formulario.Controls.Add(this.ProcesadorMemoria);
            this.Formulario.Controls.Add(this.SOAlmacenamiento);
            this.Formulario.Controls.Add(this.Extras);
            this.Formulario.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Formulario.Location = new System.Drawing.Point(13, 13);
            this.Formulario.Margin = new System.Windows.Forms.Padding(0);
            this.Formulario.Name = "Formulario";
            this.Formulario.SelectedIndex = 0;
            this.Formulario.Size = new System.Drawing.Size(524, 408);
            this.Formulario.TabIndex = 0;
            // 
            // InformacionCliente
            // 
            this.InformacionCliente.BackColor = System.Drawing.Color.Transparent;
            this.InformacionCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("InformacionCliente.BackgroundImage")));
            this.InformacionCliente.Controls.Add(this.TextBox_Nombre);
            this.InformacionCliente.Controls.Add(this.TextBox_Telefono);
            this.InformacionCliente.Controls.Add(this.TextBox_Correo);
            this.InformacionCliente.Controls.Add(this.label3);
            this.InformacionCliente.Controls.Add(this.label2);
            this.InformacionCliente.Controls.Add(this.label1);
            this.InformacionCliente.ForeColor = System.Drawing.Color.Lime;
            this.InformacionCliente.Location = new System.Drawing.Point(4, 29);
            this.InformacionCliente.Name = "InformacionCliente";
            this.InformacionCliente.Padding = new System.Windows.Forms.Padding(3);
            this.InformacionCliente.Size = new System.Drawing.Size(516, 375);
            this.InformacionCliente.TabIndex = 0;
            this.InformacionCliente.Text = "Informacion del cliente";
            // 
            // TextBox_Nombre
            // 
            this.TextBox_Nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBox_Nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_Nombre.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Nombre.ForeColor = System.Drawing.Color.Lime;
            this.TextBox_Nombre.Location = new System.Drawing.Point(244, 105);
            this.TextBox_Nombre.Name = "TextBox_Nombre";
            this.TextBox_Nombre.Size = new System.Drawing.Size(180, 22);
            this.TextBox_Nombre.TabIndex = 5;
            // 
            // TextBox_Telefono
            // 
            this.TextBox_Telefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBox_Telefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_Telefono.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Telefono.ForeColor = System.Drawing.Color.Lime;
            this.TextBox_Telefono.Location = new System.Drawing.Point(244, 210);
            this.TextBox_Telefono.Name = "TextBox_Telefono";
            this.TextBox_Telefono.Size = new System.Drawing.Size(180, 22);
            this.TextBox_Telefono.TabIndex = 4;
            // 
            // TextBox_Correo
            // 
            this.TextBox_Correo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBox_Correo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_Correo.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Correo.ForeColor = System.Drawing.Color.Lime;
            this.TextBox_Correo.Location = new System.Drawing.Point(246, 161);
            this.TextBox_Correo.Name = "TextBox_Correo";
            this.TextBox_Correo.Size = new System.Drawing.Size(180, 22);
            this.TextBox_Correo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(110, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefono o celular: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Correo electronico: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre: ";
            // 
            // ProcesadorMemoria
            // 
            this.ProcesadorMemoria.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ProcesadorMemoria.BackgroundImage")));
            this.ProcesadorMemoria.Controls.Add(this.Ram);
            this.ProcesadorMemoria.Controls.Add(this.Procesadores);
            this.ProcesadorMemoria.Location = new System.Drawing.Point(4, 29);
            this.ProcesadorMemoria.Name = "ProcesadorMemoria";
            this.ProcesadorMemoria.Padding = new System.Windows.Forms.Padding(3);
            this.ProcesadorMemoria.Size = new System.Drawing.Size(516, 375);
            this.ProcesadorMemoria.TabIndex = 1;
            this.ProcesadorMemoria.Text = "Procesador y memoria";
            this.ProcesadorMemoria.UseVisualStyleBackColor = true;
            // 
            // Ram
            // 
            this.Ram.Controls.Add(this.Ram01);
            this.Ram.Controls.Add(this.Ram04);
            this.Ram.Controls.Add(this.Ram02);
            this.Ram.Controls.Add(this.Ram03);
            this.Ram.ForeColor = System.Drawing.Color.Lime;
            this.Ram.Location = new System.Drawing.Point(43, 246);
            this.Ram.Name = "Ram";
            this.Ram.Size = new System.Drawing.Size(427, 101);
            this.Ram.TabIndex = 9;
            this.Ram.TabStop = false;
            this.Ram.Text = "Memoria RAM";
            // 
            // Ram01
            // 
            this.Ram01.AutoSize = true;
            this.Ram01.BackColor = System.Drawing.Color.Transparent;
            this.Ram01.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ram01.ForeColor = System.Drawing.Color.Lime;
            this.Ram01.Location = new System.Drawing.Point(32, 25);
            this.Ram01.Name = "Ram01";
            this.Ram01.Size = new System.Drawing.Size(100, 27);
            this.Ram01.TabIndex = 4;
            this.Ram01.TabStop = true;
            this.Ram01.Text = "8 GB Ram";
            this.Ram01.UseVisualStyleBackColor = false;
            // 
            // Ram04
            // 
            this.Ram04.AutoSize = true;
            this.Ram04.BackColor = System.Drawing.Color.Transparent;
            this.Ram04.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ram04.ForeColor = System.Drawing.Color.Lime;
            this.Ram04.Location = new System.Drawing.Point(283, 58);
            this.Ram04.Name = "Ram04";
            this.Ram04.Size = new System.Drawing.Size(109, 27);
            this.Ram04.TabIndex = 5;
            this.Ram04.TabStop = true;
            this.Ram04.Text = "64 GB Ram";
            this.Ram04.UseVisualStyleBackColor = false;
            // 
            // Ram02
            // 
            this.Ram02.AutoSize = true;
            this.Ram02.BackColor = System.Drawing.Color.Transparent;
            this.Ram02.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ram02.ForeColor = System.Drawing.Color.Lime;
            this.Ram02.Location = new System.Drawing.Point(283, 25);
            this.Ram02.Name = "Ram02";
            this.Ram02.Size = new System.Drawing.Size(109, 27);
            this.Ram02.TabIndex = 7;
            this.Ram02.TabStop = true;
            this.Ram02.Text = "16 GB Ram";
            this.Ram02.UseVisualStyleBackColor = false;
            // 
            // Ram03
            // 
            this.Ram03.AutoSize = true;
            this.Ram03.BackColor = System.Drawing.Color.Transparent;
            this.Ram03.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ram03.ForeColor = System.Drawing.Color.Lime;
            this.Ram03.Location = new System.Drawing.Point(32, 58);
            this.Ram03.Name = "Ram03";
            this.Ram03.Size = new System.Drawing.Size(109, 27);
            this.Ram03.TabIndex = 6;
            this.Ram03.TabStop = true;
            this.Ram03.Text = "32 GB Ram";
            this.Ram03.UseVisualStyleBackColor = false;
            // 
            // Procesadores
            // 
            this.Procesadores.Controls.Add(this.Procesador01);
            this.Procesadores.Controls.Add(this.Procesador04);
            this.Procesadores.Controls.Add(this.Procesador03);
            this.Procesadores.Controls.Add(this.Procesador02);
            this.Procesadores.ForeColor = System.Drawing.Color.Lime;
            this.Procesadores.Location = new System.Drawing.Point(64, 19);
            this.Procesadores.Name = "Procesadores";
            this.Procesadores.Size = new System.Drawing.Size(371, 180);
            this.Procesadores.TabIndex = 8;
            this.Procesadores.TabStop = false;
            this.Procesadores.Text = "Procesadores";
            // 
            // Procesador01
            // 
            this.Procesador01.AutoSize = true;
            this.Procesador01.BackColor = System.Drawing.Color.Transparent;
            this.Procesador01.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Procesador01.ForeColor = System.Drawing.Color.Lime;
            this.Procesador01.Location = new System.Drawing.Point(16, 25);
            this.Procesador01.Name = "Procesador01";
            this.Procesador01.Size = new System.Drawing.Size(251, 27);
            this.Procesador01.TabIndex = 0;
            this.Procesador01.TabStop = true;
            this.Procesador01.Text = "Procesador Intel Celeron G4930";
            this.Procesador01.UseVisualStyleBackColor = false;
            // 
            // Procesador04
            // 
            this.Procesador04.AutoSize = true;
            this.Procesador04.BackColor = System.Drawing.Color.Transparent;
            this.Procesador04.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Procesador04.ForeColor = System.Drawing.Color.Lime;
            this.Procesador04.Location = new System.Drawing.Point(16, 124);
            this.Procesador04.Name = "Procesador04";
            this.Procesador04.Size = new System.Drawing.Size(343, 27);
            this.Procesador04.TabIndex = 1;
            this.Procesador04.TabStop = true;
            this.Procesador04.Text = "Procesador AMD Ryzen Threadripper 3970X ";
            this.Procesador04.UseVisualStyleBackColor = false;
            // 
            // Procesador03
            // 
            this.Procesador03.AutoSize = true;
            this.Procesador03.BackColor = System.Drawing.Color.Transparent;
            this.Procesador03.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Procesador03.ForeColor = System.Drawing.Color.Lime;
            this.Procesador03.Location = new System.Drawing.Point(16, 91);
            this.Procesador03.Name = "Procesador03";
            this.Procesador03.Size = new System.Drawing.Size(255, 27);
            this.Procesador03.TabIndex = 2;
            this.Procesador03.TabStop = true;
            this.Procesador03.Text = "Procesador Intel Core i9-7980XE";
            this.Procesador03.UseVisualStyleBackColor = false;
            // 
            // Procesador02
            // 
            this.Procesador02.AutoSize = true;
            this.Procesador02.BackColor = System.Drawing.Color.Transparent;
            this.Procesador02.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Procesador02.ForeColor = System.Drawing.Color.Lime;
            this.Procesador02.Location = new System.Drawing.Point(16, 58);
            this.Procesador02.Name = "Procesador02";
            this.Procesador02.Size = new System.Drawing.Size(287, 27);
            this.Procesador02.TabIndex = 3;
            this.Procesador02.TabStop = true;
            this.Procesador02.Text = "Procesador AMD A6-Series A6-9500 ";
            this.Procesador02.UseVisualStyleBackColor = false;
            // 
            // SOAlmacenamiento
            // 
            this.SOAlmacenamiento.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SOAlmacenamiento.BackgroundImage")));
            this.SOAlmacenamiento.Controls.Add(this.DiscoDuro);
            this.SOAlmacenamiento.Controls.Add(this.label4);
            this.SOAlmacenamiento.Controls.Add(this.SistemasOperativos);
            this.SOAlmacenamiento.Location = new System.Drawing.Point(4, 29);
            this.SOAlmacenamiento.Name = "SOAlmacenamiento";
            this.SOAlmacenamiento.Size = new System.Drawing.Size(516, 375);
            this.SOAlmacenamiento.TabIndex = 2;
            this.SOAlmacenamiento.Text = "So y almacenamiento";
            this.SOAlmacenamiento.UseVisualStyleBackColor = true;
            // 
            // DiscoDuro
            // 
            this.DiscoDuro.Controls.Add(this.DiscoDuro4);
            this.DiscoDuro.Controls.Add(this.DiscoDuro3);
            this.DiscoDuro.Controls.Add(this.DiscoDuro2);
            this.DiscoDuro.Controls.Add(this.DiscoDuro1);
            this.DiscoDuro.ForeColor = System.Drawing.Color.Lime;
            this.DiscoDuro.Location = new System.Drawing.Point(39, 165);
            this.DiscoDuro.Name = "DiscoDuro";
            this.DiscoDuro.Size = new System.Drawing.Size(436, 164);
            this.DiscoDuro.TabIndex = 2;
            this.DiscoDuro.TabStop = false;
            this.DiscoDuro.Text = "Almacenamiento";
            // 
            // DiscoDuro4
            // 
            this.DiscoDuro4.AutoSize = true;
            this.DiscoDuro4.ForeColor = System.Drawing.Color.Lime;
            this.DiscoDuro4.Location = new System.Drawing.Point(13, 123);
            this.DiscoDuro4.Name = "DiscoDuro4";
            this.DiscoDuro4.Size = new System.Drawing.Size(381, 24);
            this.DiscoDuro4.TabIndex = 3;
            this.DiscoDuro4.Text = "Disco sólido interno Western Digital WDS500G2B0C 500GB";
            this.DiscoDuro4.UseVisualStyleBackColor = true;
            // 
            // DiscoDuro3
            // 
            this.DiscoDuro3.AutoSize = true;
            this.DiscoDuro3.ForeColor = System.Drawing.Color.Lime;
            this.DiscoDuro3.Location = new System.Drawing.Point(13, 93);
            this.DiscoDuro3.Name = "DiscoDuro3";
            this.DiscoDuro3.Size = new System.Drawing.Size(354, 24);
            this.DiscoDuro3.TabIndex = 2;
            this.DiscoDuro3.Text = "Disco sólido interno Kingston SEDC500M/960G 960GB";
            this.DiscoDuro3.UseVisualStyleBackColor = true;
            // 
            // DiscoDuro2
            // 
            this.DiscoDuro2.AutoSize = true;
            this.DiscoDuro2.ForeColor = System.Drawing.Color.Lime;
            this.DiscoDuro2.Location = new System.Drawing.Point(13, 63);
            this.DiscoDuro2.Name = "DiscoDuro2";
            this.DiscoDuro2.Size = new System.Drawing.Size(417, 24);
            this.DiscoDuro2.TabIndex = 1;
            this.DiscoDuro2.Text = "Disco sólido interno Adata XPG Spectrix S40G AS40G-2TT-C 2TB";
            this.DiscoDuro2.UseVisualStyleBackColor = true;
            // 
            // DiscoDuro1
            // 
            this.DiscoDuro1.AutoSize = true;
            this.DiscoDuro1.ForeColor = System.Drawing.Color.Lime;
            this.DiscoDuro1.Location = new System.Drawing.Point(13, 33);
            this.DiscoDuro1.Name = "DiscoDuro1";
            this.DiscoDuro1.Size = new System.Drawing.Size(361, 24);
            this.DiscoDuro1.TabIndex = 0;
            this.DiscoDuro1.Text = "Disco sólido interno Samsung 860 EVO MZ-76E4T0 4TB";
            this.DiscoDuro1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(124, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Sistema Operativo: ";
            // 
            // SistemasOperativos
            // 
            this.SistemasOperativos.FormattingEnabled = true;
            this.SistemasOperativos.ItemHeight = 20;
            this.SistemasOperativos.Items.AddRange(new object[] {
            "Windows 10",
            "Windows 8.1",
            "Windows 7",
            "Windows 95",
            "DOS",
            "Linux",
            "Ubuntu",
            "Custom"});
            this.SistemasOperativos.Location = new System.Drawing.Point(289, 61);
            this.SistemasOperativos.Name = "SistemasOperativos";
            this.SistemasOperativos.Size = new System.Drawing.Size(133, 24);
            this.SistemasOperativos.TabIndex = 0;
            // 
            // Extras
            // 
            this.Extras.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Extras.BackgroundImage")));
            this.Extras.Controls.Add(this.Extra);
            this.Extras.Location = new System.Drawing.Point(4, 29);
            this.Extras.Name = "Extras";
            this.Extras.Padding = new System.Windows.Forms.Padding(3);
            this.Extras.Size = new System.Drawing.Size(516, 375);
            this.Extras.TabIndex = 3;
            this.Extras.Text = "Extras";
            this.Extras.UseVisualStyleBackColor = true;
            // 
            // LimpiarCampos
            // 
            this.LimpiarCampos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LimpiarCampos.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LimpiarCampos.ForeColor = System.Drawing.Color.Lime;
            this.LimpiarCampos.Location = new System.Drawing.Point(184, 485);
            this.LimpiarCampos.Name = "LimpiarCampos";
            this.LimpiarCampos.Size = new System.Drawing.Size(162, 48);
            this.LimpiarCampos.TabIndex = 1;
            this.LimpiarCampos.Text = "Limpiar";
            this.LimpiarCampos.UseVisualStyleBackColor = false;
            this.LimpiarCampos.Click += new System.EventHandler(this.LimpiarCampos_Click_1);
            // 
            // Salir
            // 
            this.Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Salir.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salir.ForeColor = System.Drawing.Color.Lime;
            this.Salir.Location = new System.Drawing.Point(939, 485);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(139, 48);
            this.Salir.TabIndex = 4;
            this.Salir.Text = "Cancelar y salir";
            this.Salir.UseVisualStyleBackColor = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Comprar
            // 
            this.Comprar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Comprar.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comprar.ForeColor = System.Drawing.Color.Lime;
            this.Comprar.Location = new System.Drawing.Point(758, 485);
            this.Comprar.Name = "Comprar";
            this.Comprar.Size = new System.Drawing.Size(162, 48);
            this.Comprar.TabIndex = 5;
            this.Comprar.Text = "Comfirmar compra";
            this.Comprar.UseVisualStyleBackColor = false;
            this.Comprar.Click += new System.EventHandler(this.Comprar_Click);
            // 
            // Ajolote
            // 
            this.Ajolote.BackColor = System.Drawing.Color.Transparent;
            this.Ajolote.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Ajolote.BackgroundImage")));
            this.Ajolote.Location = new System.Drawing.Point(568, 250);
            this.Ajolote.Name = "Ajolote";
            this.Ajolote.Size = new System.Drawing.Size(152, 167);
            this.Ajolote.TabIndex = 6;
            this.Ajolote.TabStop = false;
            // 
            // Extra1
            // 
            this.Extra1.AutoSize = true;
            this.Extra1.ForeColor = System.Drawing.Color.Lime;
            this.Extra1.Location = new System.Drawing.Point(19, 25);
            this.Extra1.Name = "Extra1";
            this.Extra1.Size = new System.Drawing.Size(202, 24);
            this.Extra1.TabIndex = 0;
            this.Extra1.Text = "Teclado Gamer con lucecitas";
            this.Extra1.UseVisualStyleBackColor = true;
            // 
            // Extra3
            // 
            this.Extra3.AutoSize = true;
            this.Extra3.ForeColor = System.Drawing.Color.Lime;
            this.Extra3.Location = new System.Drawing.Point(19, 117);
            this.Extra3.Name = "Extra3";
            this.Extra3.Size = new System.Drawing.Size(87, 24);
            this.Extra3.TabIndex = 1;
            this.Extra3.Text = "Microfono";
            this.Extra3.UseVisualStyleBackColor = true;
            // 
            // Extra2
            // 
            this.Extra2.AutoSize = true;
            this.Extra2.ForeColor = System.Drawing.Color.Lime;
            this.Extra2.Location = new System.Drawing.Point(19, 72);
            this.Extra2.Name = "Extra2";
            this.Extra2.Size = new System.Drawing.Size(120, 24);
            this.Extra2.TabIndex = 2;
            this.Extra2.Text = "Teclado normal";
            this.Extra2.UseVisualStyleBackColor = true;
            // 
            // Extra6
            // 
            this.Extra6.AutoSize = true;
            this.Extra6.ForeColor = System.Drawing.Color.Lime;
            this.Extra6.Location = new System.Drawing.Point(19, 259);
            this.Extra6.Name = "Extra6";
            this.Extra6.Size = new System.Drawing.Size(137, 24);
            this.Extra6.TabIndex = 3;
            this.Extra6.Text = "Monitor 16:9 HDMI";
            this.Extra6.UseVisualStyleBackColor = true;
            // 
            // Extra5
            // 
            this.Extra5.AutoSize = true;
            this.Extra5.ForeColor = System.Drawing.Color.Lime;
            this.Extra5.Location = new System.Drawing.Point(19, 208);
            this.Extra5.Name = "Extra5";
            this.Extra5.Size = new System.Drawing.Size(127, 24);
            this.Extra5.TabIndex = 4;
            this.Extra5.Text = "Bocinas Estereo";
            this.Extra5.UseVisualStyleBackColor = true;
            // 
            // Extra4
            // 
            this.Extra4.AutoSize = true;
            this.Extra4.ForeColor = System.Drawing.Color.Lime;
            this.Extra4.Location = new System.Drawing.Point(19, 160);
            this.Extra4.Name = "Extra4";
            this.Extra4.Size = new System.Drawing.Size(180, 24);
            this.Extra4.TabIndex = 5;
            this.Extra4.Text = "Audifonos estilo diadema";
            this.Extra4.UseVisualStyleBackColor = true;
            // 
            // Extra7
            // 
            this.Extra7.AutoSize = true;
            this.Extra7.ForeColor = System.Drawing.Color.Lime;
            this.Extra7.Location = new System.Drawing.Point(267, 25);
            this.Extra7.Name = "Extra7";
            this.Extra7.Size = new System.Drawing.Size(195, 24);
            this.Extra7.TabIndex = 6;
            this.Extra7.Text = "Mouse Gamer con lucecitas";
            this.Extra7.UseVisualStyleBackColor = true;
            // 
            // Extra8
            // 
            this.Extra8.AutoSize = true;
            this.Extra8.ForeColor = System.Drawing.Color.Lime;
            this.Extra8.Location = new System.Drawing.Point(267, 72);
            this.Extra8.Name = "Extra8";
            this.Extra8.Size = new System.Drawing.Size(113, 24);
            this.Extra8.TabIndex = 7;
            this.Extra8.Text = "Mouse normal";
            this.Extra8.UseVisualStyleBackColor = true;
            // 
            // Extra9
            // 
            this.Extra9.AutoSize = true;
            this.Extra9.ForeColor = System.Drawing.Color.Lime;
            this.Extra9.Location = new System.Drawing.Point(267, 117);
            this.Extra9.Name = "Extra9";
            this.Extra9.Size = new System.Drawing.Size(139, 24);
            this.Extra9.TabIndex = 8;
            this.Extra9.Text = "Garantia extendida";
            this.Extra9.UseVisualStyleBackColor = true;
            // 
            // Extra
            // 
            this.Extra.Controls.Add(this.Extra1);
            this.Extra.Controls.Add(this.Extra9);
            this.Extra.Controls.Add(this.Extra3);
            this.Extra.Controls.Add(this.Extra8);
            this.Extra.Controls.Add(this.Extra2);
            this.Extra.Controls.Add(this.Extra7);
            this.Extra.Controls.Add(this.Extra6);
            this.Extra.Controls.Add(this.Extra4);
            this.Extra.Controls.Add(this.Extra5);
            this.Extra.ForeColor = System.Drawing.Color.Lime;
            this.Extra.Location = new System.Drawing.Point(17, 31);
            this.Extra.Name = "Extra";
            this.Extra.Size = new System.Drawing.Size(482, 305);
            this.Extra.TabIndex = 9;
            this.Extra.TabStop = false;
            this.Extra.Text = "Extras";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(578, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 167);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.Ticket);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(776, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 392);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ticket";
            // 
            // Ticket
            // 
            this.Ticket.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ticket.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Ticket.Location = new System.Drawing.Point(6, 31);
            this.Ticket.Name = "Ticket";
            this.Ticket.ReadOnly = true;
            this.Ticket.Size = new System.Drawing.Size(290, 355);
            this.Ticket.TabIndex = 0;
            this.Ticket.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1090, 569);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Ajolote);
            this.Controls.Add(this.Comprar);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.LimpiarCampos);
            this.Controls.Add(this.Formulario);
            this.Name = "Form1";
            this.Text = "Computadoras \"Kagrenac\"";
            this.Formulario.ResumeLayout(false);
            this.InformacionCliente.ResumeLayout(false);
            this.InformacionCliente.PerformLayout();
            this.ProcesadorMemoria.ResumeLayout(false);
            this.Ram.ResumeLayout(false);
            this.Ram.PerformLayout();
            this.Procesadores.ResumeLayout(false);
            this.Procesadores.PerformLayout();
            this.SOAlmacenamiento.ResumeLayout(false);
            this.SOAlmacenamiento.PerformLayout();
            this.DiscoDuro.ResumeLayout(false);
            this.DiscoDuro.PerformLayout();
            this.Extras.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Ajolote)).EndInit();
            this.Extra.ResumeLayout(false);
            this.Extra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Formulario;
        private System.Windows.Forms.TabPage InformacionCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage ProcesadorMemoria;
        private System.Windows.Forms.TextBox TextBox_Nombre;
        private System.Windows.Forms.TextBox TextBox_Telefono;
        private System.Windows.Forms.TextBox TextBox_Correo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LimpiarCampos;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Button Comprar;
        private System.Windows.Forms.RadioButton Procesador01;
        private System.Windows.Forms.GroupBox Ram;
        private System.Windows.Forms.RadioButton Ram01;
        private System.Windows.Forms.RadioButton Ram04;
        private System.Windows.Forms.RadioButton Ram02;
        private System.Windows.Forms.RadioButton Ram03;
        private System.Windows.Forms.GroupBox Procesadores;
        private System.Windows.Forms.RadioButton Procesador04;
        private System.Windows.Forms.RadioButton Procesador03;
        private System.Windows.Forms.RadioButton Procesador02;
        private System.Windows.Forms.TabPage SOAlmacenamiento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox SistemasOperativos;
        private System.Windows.Forms.PictureBox Ajolote;
        private System.Windows.Forms.GroupBox DiscoDuro;
        private System.Windows.Forms.CheckBox DiscoDuro4;
        private System.Windows.Forms.CheckBox DiscoDuro3;
        private System.Windows.Forms.CheckBox DiscoDuro2;
        private System.Windows.Forms.CheckBox DiscoDuro1;
        private System.Windows.Forms.TabPage Extras;
        private System.Windows.Forms.CheckBox Extra4;
        private System.Windows.Forms.CheckBox Extra5;
        private System.Windows.Forms.CheckBox Extra6;
        private System.Windows.Forms.CheckBox Extra2;
        private System.Windows.Forms.CheckBox Extra3;
        private System.Windows.Forms.CheckBox Extra1;
        private System.Windows.Forms.CheckBox Extra9;
        private System.Windows.Forms.CheckBox Extra8;
        private System.Windows.Forms.CheckBox Extra7;
        private System.Windows.Forms.GroupBox Extra;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox Ticket;
    }
}

