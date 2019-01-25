namespace SocketClient
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
            this.TextoChat = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextoIP = new System.Windows.Forms.TextBox();
            this.TextoPuerto = new System.Windows.Forms.TextBox();
            this.TextoAEnviar = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BotonConectar = new System.Windows.Forms.Button();
            this.BotonEnviar = new System.Windows.Forms.Button();
            this.DevIP = new System.Windows.Forms.Button();
            this.Desconectar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextoChat
            // 
            this.TextoChat.Enabled = false;
            this.TextoChat.Location = new System.Drawing.Point(43, 52);
            this.TextoChat.Name = "TextoChat";
            this.TextoChat.Size = new System.Drawing.Size(351, 270);
            this.TextoChat.TabIndex = 0;
            this.TextoChat.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Puerto : ";
            // 
            // TextoIP
            // 
            this.TextoIP.Location = new System.Drawing.Point(78, 28);
            this.TextoIP.Name = "TextoIP";
            this.TextoIP.Size = new System.Drawing.Size(100, 20);
            this.TextoIP.TabIndex = 3;
            // 
            // TextoPuerto
            // 
            this.TextoPuerto.Location = new System.Drawing.Point(237, 28);
            this.TextoPuerto.Name = "TextoPuerto";
            this.TextoPuerto.Size = new System.Drawing.Size(63, 20);
            this.TextoPuerto.TabIndex = 4;
            // 
            // TextoAEnviar
            // 
            this.TextoAEnviar.Enabled = false;
            this.TextoAEnviar.Location = new System.Drawing.Point(433, 52);
            this.TextoAEnviar.Name = "TextoAEnviar";
            this.TextoAEnviar.Size = new System.Drawing.Size(261, 270);
            this.TextoAEnviar.TabIndex = 5;
            this.TextoAEnviar.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(512, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mensaje a enviar ";
            // 
            // BotonConectar
            // 
            this.BotonConectar.Location = new System.Drawing.Point(309, 26);
            this.BotonConectar.Name = "BotonConectar";
            this.BotonConectar.Size = new System.Drawing.Size(85, 23);
            this.BotonConectar.TabIndex = 7;
            this.BotonConectar.Text = "Conectar";
            this.BotonConectar.UseVisualStyleBackColor = true;
            this.BotonConectar.Click += new System.EventHandler(this.BotonConectar_Click);
            // 
            // BotonEnviar
            // 
            this.BotonEnviar.Enabled = false;
            this.BotonEnviar.Location = new System.Drawing.Point(515, 328);
            this.BotonEnviar.Name = "BotonEnviar";
            this.BotonEnviar.Size = new System.Drawing.Size(75, 23);
            this.BotonEnviar.TabIndex = 9;
            this.BotonEnviar.Text = "Enviar";
            this.BotonEnviar.UseVisualStyleBackColor = true;
            this.BotonEnviar.Click += new System.EventHandler(this.BotonEnviar_Click);
            // 
            // DevIP
            // 
            this.DevIP.Location = new System.Drawing.Point(400, 26);
            this.DevIP.Name = "DevIP";
            this.DevIP.Size = new System.Drawing.Size(75, 23);
            this.DevIP.TabIndex = 10;
            this.DevIP.Text = "DevIP";
            this.DevIP.UseVisualStyleBackColor = true;
            this.DevIP.Click += new System.EventHandler(this.DevIP_Click);
            // 
            // Desconectar
            // 
            this.Desconectar.Location = new System.Drawing.Point(309, 26);
            this.Desconectar.Name = "Desconectar";
            this.Desconectar.Size = new System.Drawing.Size(85, 23);
            this.Desconectar.TabIndex = 11;
            this.Desconectar.Text = "Desconectar";
            this.Desconectar.UseVisualStyleBackColor = true;
            this.Desconectar.Visible = false;
            this.Desconectar.Click += new System.EventHandler(this.Desconectar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 369);
            this.Controls.Add(this.Desconectar);
            this.Controls.Add(this.DevIP);
            this.Controls.Add(this.BotonEnviar);
            this.Controls.Add(this.BotonConectar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextoAEnviar);
            this.Controls.Add(this.TextoPuerto);
            this.Controls.Add(this.TextoIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextoChat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RichTextBox TextoChat;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox TextoIP;
        public System.Windows.Forms.TextBox TextoPuerto;
        public System.Windows.Forms.RichTextBox TextoAEnviar;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button BotonConectar;
        public System.Windows.Forms.Button BotonEnviar;
        private System.Windows.Forms.Button DevIP;
        private System.Windows.Forms.Button Desconectar;
    }
}

