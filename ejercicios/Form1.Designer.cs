
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
            this.LblConversor = new System.Windows.Forms.Label();
            this.Btn_ConvertirConversores = new System.Windows.Forms.Button();
            this.CboDeConversor = new System.Windows.Forms.ComboBox();
            this.CboAConversores = new System.Windows.Forms.ComboBox();
            this.LblA = new System.Windows.Forms.Label();
            this.LblRespuestaConversores = new System.Windows.Forms.Label();
            this.TxtCantidadConversores = new System.Windows.Forms.TextBox();
            this.LblCantidadConversores = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblConversor
            // 
            this.LblConversor.AutoSize = true;
            this.LblConversor.Location = new System.Drawing.Point(90, 67);
            this.LblConversor.Name = "LblConversor";
            this.LblConversor.Size = new System.Drawing.Size(39, 22);
            this.LblConversor.TabIndex = 0;
            this.LblConversor.Text = "De:";
            // 
            // Btn_ConvertirConversores
            // 
            this.Btn_ConvertirConversores.Location = new System.Drawing.Point(268, 301);
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
            this.CboDeConversor.Items.AddRange(new object[] {
            "Dolar",
            "Euro",
            "Quetzales",
            "Lempiras",
            "Colón Salvadoreño",
            "Cordoba",
            "Pesos Costarricenses",
            "Yen Japones",
            "Libras esterlina",
            "Rupia India"});
            this.CboDeConversor.Location = new System.Drawing.Point(155, 64);
            this.CboDeConversor.Name = "CboDeConversor";
            this.CboDeConversor.Size = new System.Drawing.Size(206, 30);
            this.CboDeConversor.TabIndex = 2;
            // 
            // CboAConversores
            // 
            this.CboAConversores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboAConversores.FormattingEnabled = true;
            this.CboAConversores.Items.AddRange(new object[] {
            "Dolar",
            "Euro",
            "Quetzales",
            "Lempiras",
            "Colón Salvadoreño",
            "Cordoba",
            "Pesos Costarricenses",
            "Yen Japones",
            "Libras esterlina",
            "Rupia India"});
            this.CboAConversores.Location = new System.Drawing.Point(155, 141);
            this.CboAConversores.Name = "CboAConversores";
            this.CboAConversores.Size = new System.Drawing.Size(206, 30);
            this.CboAConversores.TabIndex = 4;
            // 
            // LblA
            // 
            this.LblA.AutoSize = true;
            this.LblA.Location = new System.Drawing.Point(90, 149);
            this.LblA.Name = "LblA";
            this.LblA.Size = new System.Drawing.Size(30, 22);
            this.LblA.TabIndex = 3;
            this.LblA.Text = "A:";
            // 
            // LblRespuestaConversores
            // 
            this.LblRespuestaConversores.AutoSize = true;
            this.LblRespuestaConversores.Location = new System.Drawing.Point(90, 280);
            this.LblRespuestaConversores.Name = "LblRespuestaConversores";
            this.LblRespuestaConversores.Size = new System.Drawing.Size(110, 22);
            this.LblRespuestaConversores.TabIndex = 5;
            this.LblRespuestaConversores.Text = "Respuesta: ?";
            // 
            // TxtCantidadConversores
            // 
            this.TxtCantidadConversores.Location = new System.Drawing.Point(194, 217);
            this.TxtCantidadConversores.Name = "TxtCantidadConversores";
            this.TxtCantidadConversores.Size = new System.Drawing.Size(206, 30);
            this.TxtCantidadConversores.TabIndex = 6;
            // 
            // LblCantidadConversores
            // 
            this.LblCantidadConversores.AutoSize = true;
            this.LblCantidadConversores.Location = new System.Drawing.Point(90, 225);
            this.LblCantidadConversores.Name = "LblCantidadConversores";
            this.LblCantidadConversores.Size = new System.Drawing.Size(81, 22);
            this.LblCantidadConversores.TabIndex = 7;
            this.LblCantidadConversores.Text = "Cantidad";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 393);
            this.Controls.Add(this.LblCantidadConversores);
            this.Controls.Add(this.TxtCantidadConversores);
            this.Controls.Add(this.LblRespuestaConversores);
            this.Controls.Add(this.CboAConversores);
            this.Controls.Add(this.LblA);
            this.Controls.Add(this.CboDeConversor);
            this.Controls.Add(this.Btn_ConvertirConversores);
            this.Controls.Add(this.LblConversor);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblConversor;
        private System.Windows.Forms.Button Btn_ConvertirConversores;
        private System.Windows.Forms.ComboBox CboDeConversor;
        private System.Windows.Forms.ComboBox CboAConversores;
        private System.Windows.Forms.Label LblA;
        private System.Windows.Forms.Label LblRespuestaConversores;
        private System.Windows.Forms.TextBox TxtCantidadConversores;
        private System.Windows.Forms.Label LblCantidadConversores;
    }
}

