namespace CodigosQR
{
    partial class CodigosQR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodigosQR));
            this.LdatosAlumnos = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.pbgenerar = new System.Windows.Forms.PictureBox();
            this.btGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbgenerar)).BeginInit();
            this.SuspendLayout();
            // 
            // LdatosAlumnos
            // 
            this.LdatosAlumnos.AutoSize = true;
            this.LdatosAlumnos.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LdatosAlumnos.Location = new System.Drawing.Point(28, 20);
            this.LdatosAlumnos.Name = "LdatosAlumnos";
            this.LdatosAlumnos.Size = new System.Drawing.Size(209, 28);
            this.LdatosAlumnos.TabIndex = 0;
            this.LdatosAlumnos.Text = "DATOS ALUMNOS";
            this.LdatosAlumnos.Click += new System.EventHandler(this.LdatosAlumnos_Click);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(32, 65);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(431, 22);
            this.txtnombre.TabIndex = 1;
            this.txtnombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pbgenerar
            // 
            this.pbgenerar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbgenerar.Location = new System.Drawing.Point(32, 112);
            this.pbgenerar.Name = "pbgenerar";
            this.pbgenerar.Size = new System.Drawing.Size(205, 189);
            this.pbgenerar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbgenerar.TabIndex = 2;
            this.pbgenerar.TabStop = false;
            // 
            // btGuardar
            // 
            this.btGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btGuardar.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btGuardar.Location = new System.Drawing.Point(290, 124);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(173, 55);
            this.btGuardar.TabIndex = 3;
            this.btGuardar.Text = "GUARDAR";
            this.btGuardar.UseVisualStyleBackColor = false;
            // 
            // CodigosQR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(797, 406);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.pbgenerar);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.LdatosAlumnos);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CodigosQR";
            this.Text = "GENERACION DE CODIGOS QR";
            this.AutoSizeChanged += new System.EventHandler(this.Form1_AutoSizeChanged);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbgenerar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LdatosAlumnos;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.PictureBox pbgenerar;
        private System.Windows.Forms.Button btGuardar;
    }
}

