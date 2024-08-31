namespace Ejercicio_Parte3
{
    partial class FromVer
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
            this.lbxLista = new System.Windows.Forms.ListBox();
            this.ctnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxLista
            // 
            this.lbxLista.FormattingEnabled = true;
            this.lbxLista.Location = new System.Drawing.Point(12, 16);
            this.lbxLista.Name = "lbxLista";
            this.lbxLista.Size = new System.Drawing.Size(456, 238);
            this.lbxLista.TabIndex = 0;
            // 
            // ctnCerrar
            // 
            this.ctnCerrar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ctnCerrar.Location = new System.Drawing.Point(127, 276);
            this.ctnCerrar.Name = "ctnCerrar";
            this.ctnCerrar.Size = new System.Drawing.Size(238, 43);
            this.ctnCerrar.TabIndex = 1;
            this.ctnCerrar.Text = "Cerrar";
            this.ctnCerrar.UseVisualStyleBackColor = true;
            this.ctnCerrar.Click += new System.EventHandler(this.ctnCerrar_Click);
            // 
            // FromVer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 330);
            this.Controls.Add(this.ctnCerrar);
            this.Controls.Add(this.lbxLista);
            this.Name = "FromVer";
            this.Text = "FormVer";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox lbxLista;
        private System.Windows.Forms.Button ctnCerrar;
    }
}