
namespace ejercicios
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
            this.LblDeConversor = new System.Windows.Forms.Label();
            this.Btn_ConvertirConversores = new System.Windows.Forms.Button();
            this.CboDeConversor = new System.Windows.Forms.ComboBox();
            this.CboAConversores = new System.Windows.Forms.ComboBox();
            this.LblAConversor = new System.Windows.Forms.Label();
            this.LblRespuestaConversores = new System.Windows.Forms.Label();
            this.TxtCantidadConversores = new System.Windows.Forms.TextBox();
            this.LblCantidadConversores = new System.Windows.Forms.Label();
            this.CboTipoConversor = new System.Windows.Forms.ComboBox();
            this.lblTipoConversor = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblDeConversor
            // 
            this.LblDeConversor.AutoSize = true;
            this.LblDeConversor.Location = new System.Drawing.Point(99, 146);
            this.LblDeConversor.Name = "LblDeConversor";
            this.LblDeConversor.Size = new System.Drawing.Size(39, 22);
            this.LblDeConversor.TabIndex = 0;
            this.LblDeConversor.Text = "De:";
            // 
            // Btn_ConvertirConversores
            // 
            this.Btn_ConvertirConversores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_ConvertirConversores.Location = new System.Drawing.Point(221, 420);
            this.Btn_ConvertirConversores.Name = "Btn_ConvertirConversores";
            this.Btn_ConvertirConversores.Size = new System.Drawing.Size(132, 45);
            this.Btn_ConvertirConversores.TabIndex = 1;
            this.Btn_ConvertirConversores.Text = "Convertir";
            this.Btn_ConvertirConversores.UseVisualStyleBackColor = true;
            this.Btn_ConvertirConversores.Click += new System.EventHandler(this.Btn_ConvertirConversores_Click);
            // 
            // CboDeConversor
            // 
            this.CboDeConversor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboDeConversor.FormattingEnabled = true;
            this.CboDeConversor.Location = new System.Drawing.Point(164, 143);
            this.CboDeConversor.Name = "CboDeConversor";
            this.CboDeConversor.Size = new System.Drawing.Size(206, 30);
            this.CboDeConversor.TabIndex = 2;
            // 
            // CboAConversores
            // 
            this.CboAConversores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboAConversores.FormattingEnabled = true;
            this.CboAConversores.Location = new System.Drawing.Point(164, 220);
            this.CboAConversores.Name = "CboAConversores";
            this.CboAConversores.Size = new System.Drawing.Size(206, 30);
            this.CboAConversores.TabIndex = 4;
            // 
            // LblAConversor
            // 
            this.LblAConversor.AutoSize = true;
            this.LblAConversor.Location = new System.Drawing.Point(99, 228);
            this.LblAConversor.Name = "LblAConversor";
            this.LblAConversor.Size = new System.Drawing.Size(30, 22);
            this.LblAConversor.TabIndex = 3;
            this.LblAConversor.Text = "A:";
            // 
            // LblRespuestaConversores
            // 
            this.LblRespuestaConversores.AutoSize = true;
            this.LblRespuestaConversores.Location = new System.Drawing.Point(99, 359);
            this.LblRespuestaConversores.Name = "LblRespuestaConversores";
            this.LblRespuestaConversores.Size = new System.Drawing.Size(110, 22);
            this.LblRespuestaConversores.TabIndex = 5;
            this.LblRespuestaConversores.Text = "Respuesta: ?";
            // 
            // TxtCantidadConversores
            // 
            this.TxtCantidadConversores.Location = new System.Drawing.Point(203, 296);
            this.TxtCantidadConversores.Name = "TxtCantidadConversores";
            this.TxtCantidadConversores.Size = new System.Drawing.Size(206, 30);
            this.TxtCantidadConversores.TabIndex = 6;
            // 
            // LblCantidadConversores
            // 
            this.LblCantidadConversores.AutoSize = true;
            this.LblCantidadConversores.Location = new System.Drawing.Point(99, 304);
            this.LblCantidadConversores.Name = "LblCantidadConversores";
            this.LblCantidadConversores.Size = new System.Drawing.Size(81, 22);
            this.LblCantidadConversores.TabIndex = 7;
            this.LblCantidadConversores.Text = "Cantidad";
            // 
            // CboTipoConversor
            // 
            this.CboTipoConversor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboTipoConversor.FormattingEnabled = true;
            this.CboTipoConversor.Items.AddRange(new object[] {
            "Moneda",
            "Masa",
            "Volumen",
            "Longitud",
            "Almacenamiento",
            "Tiempo"});
            this.CboTipoConversor.Location = new System.Drawing.Point(164, 84);
            this.CboTipoConversor.Name = "CboTipoConversor";
            this.CboTipoConversor.Size = new System.Drawing.Size(206, 30);
            this.CboTipoConversor.TabIndex = 8;
            this.CboTipoConversor.TextChanged += new System.EventHandler(this.CboTipoConversor_TextChanged);
            // 
            // lblTipoConversor
            // 
            this.lblTipoConversor.AutoSize = true;
            this.lblTipoConversor.Location = new System.Drawing.Point(99, 87);
            this.lblTipoConversor.Name = "lblTipoConversor";
            this.lblTipoConversor.Size = new System.Drawing.Size(53, 22);
            this.lblTipoConversor.TabIndex = 9;
            this.lblTipoConversor.Text = "Tipo:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(491, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 33);
            this.button1.TabIndex = 10;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(578, 614);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTipoConversor);
            this.Controls.Add(this.CboTipoConversor);
            this.Controls.Add(this.LblCantidadConversores);
            this.Controls.Add(this.TxtCantidadConversores);
            this.Controls.Add(this.LblRespuestaConversores);
            this.Controls.Add(this.CboAConversores);
            this.Controls.Add(this.LblAConversor);
            this.Controls.Add(this.CboDeConversor);
            this.Controls.Add(this.Btn_ConvertirConversores);
            this.Controls.Add(this.LblDeConversor);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblDeConversor;
        private System.Windows.Forms.Button Btn_ConvertirConversores;
        private System.Windows.Forms.ComboBox CboDeConversor;
        private System.Windows.Forms.ComboBox CboAConversores;
        private System.Windows.Forms.Label LblAConversor;
        private System.Windows.Forms.Label LblRespuestaConversores;
        private System.Windows.Forms.TextBox TxtCantidadConversores;
        private System.Windows.Forms.Label LblCantidadConversores;
        private System.Windows.Forms.ComboBox CboTipoConversor;
        private System.Windows.Forms.Label lblTipoConversor;
        private System.Windows.Forms.Button button1;
    }
}

