namespace Ejercicio_Parte3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxNombreCop = new System.Windows.Forms.TextBox();
            this.btnIniciarCooperativa = new System.Windows.Forms.Button();
            this.btnCargaCliente = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxNumServicio = new System.Windows.Forms.TextBox();
            this.lbResultado = new System.Windows.Forms.Label();
            this.tbxConsumo = new System.Windows.Forms.TextBox();
            this.lbConsu = new System.Windows.Forms.Label();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnCargarConsumo = new System.Windows.Forms.Button();
            this.btnVerConsumo = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCargaCliente);
            this.groupBox1.Location = new System.Drawing.Point(12, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 70);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alta de clientes";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbResultado);
            this.groupBox2.Controls.Add(this.btnSeleccionar);
            this.groupBox2.Controls.Add(this.tbxNumServicio);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(12, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(571, 247);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consultas de clientes";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnVerConsumo);
            this.groupBox3.Location = new System.Drawing.Point(29, 162);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(536, 70);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Consumos";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnCargarConsumo);
            this.groupBox4.Controls.Add(this.lbConsu);
            this.groupBox4.Controls.Add(this.tbxConsumo);
            this.groupBox4.Location = new System.Drawing.Point(29, 86);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(536, 70);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Carga de consumos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cooperativa";
            // 
            // tbxNombreCop
            // 
            this.tbxNombreCop.Location = new System.Drawing.Point(204, 23);
            this.tbxNombreCop.Name = "tbxNombreCop";
            this.tbxNombreCop.Size = new System.Drawing.Size(171, 20);
            this.tbxNombreCop.TabIndex = 3;
            // 
            // btnIniciarCooperativa
            // 
            this.btnIniciarCooperativa.Location = new System.Drawing.Point(407, 21);
            this.btnIniciarCooperativa.Name = "btnIniciarCooperativa";
            this.btnIniciarCooperativa.Size = new System.Drawing.Size(146, 30);
            this.btnIniciarCooperativa.TabIndex = 4;
            this.btnIniciarCooperativa.Text = "Iniciar Cooperativa";
            this.btnIniciarCooperativa.UseVisualStyleBackColor = true;
            this.btnIniciarCooperativa.Click += new System.EventHandler(this.btnIniciarCooperativa_Click);
            // 
            // btnCargaCliente
            // 
            this.btnCargaCliente.Location = new System.Drawing.Point(395, 19);
            this.btnCargaCliente.Name = "btnCargaCliente";
            this.btnCargaCliente.Size = new System.Drawing.Size(146, 30);
            this.btnCargaCliente.TabIndex = 5;
            this.btnCargaCliente.Text = "Carga de clientes";
            this.btnCargaCliente.UseVisualStyleBackColor = true;
            this.btnCargaCliente.Click += new System.EventHandler(this.btnCargaCliente_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numero de servicio";
            // 
            // tbxNumServicio
            // 
            this.tbxNumServicio.Location = new System.Drawing.Point(176, 40);
            this.tbxNumServicio.Name = "tbxNumServicio";
            this.tbxNumServicio.Size = new System.Drawing.Size(106, 20);
            this.tbxNumServicio.TabIndex = 4;
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Location = new System.Drawing.Point(208, 70);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(37, 13);
            this.lbResultado.TabIndex = 7;
            this.lbResultado.Text = "----------";
            // 
            // tbxConsumo
            // 
            this.tbxConsumo.Location = new System.Drawing.Point(147, 19);
            this.tbxConsumo.Name = "tbxConsumo";
            this.tbxConsumo.Size = new System.Drawing.Size(106, 20);
            this.tbxConsumo.TabIndex = 5;
            // 
            // lbConsu
            // 
            this.lbConsu.AutoSize = true;
            this.lbConsu.Location = new System.Drawing.Point(179, 42);
            this.lbConsu.Name = "lbConsu";
            this.lbConsu.Size = new System.Drawing.Size(37, 13);
            this.lbConsu.TabIndex = 8;
            this.lbConsu.Text = "----------";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(395, 26);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(146, 30);
            this.btnSeleccionar.TabIndex = 6;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnCargarConsumo
            // 
            this.btnCargarConsumo.Location = new System.Drawing.Point(366, 13);
            this.btnCargarConsumo.Name = "btnCargarConsumo";
            this.btnCargarConsumo.Size = new System.Drawing.Size(146, 30);
            this.btnCargarConsumo.TabIndex = 9;
            this.btnCargarConsumo.Text = "Cargar Consumo";
            this.btnCargarConsumo.UseVisualStyleBackColor = true;
            this.btnCargarConsumo.Click += new System.EventHandler(this.btnCargarConsumo_Click);
            // 
            // btnVerConsumo
            // 
            this.btnVerConsumo.Location = new System.Drawing.Point(366, 19);
            this.btnVerConsumo.Name = "btnVerConsumo";
            this.btnVerConsumo.Size = new System.Drawing.Size(146, 30);
            this.btnVerConsumo.TabIndex = 10;
            this.btnVerConsumo.Text = "Ver Consumo";
            this.btnVerConsumo.UseVisualStyleBackColor = true;
            this.btnVerConsumo.Click += new System.EventHandler(this.btnVerConsumo_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(214, 389);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(146, 30);
            this.btnCerrar.TabIndex = 11;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(619, 431);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnIniciarCooperativa);
            this.Controls.Add(this.tbxNombreCop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxNombreCop;
        private System.Windows.Forms.Button btnIniciarCooperativa;
        private System.Windows.Forms.Button btnCargaCliente;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.TextBox tbxNumServicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCargarConsumo;
        private System.Windows.Forms.Label lbConsu;
        private System.Windows.Forms.TextBox tbxConsumo;
        private System.Windows.Forms.Button btnVerConsumo;
        private System.Windows.Forms.Button btnCerrar;
    }
}

