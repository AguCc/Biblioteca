
namespace BibliotecaAa
{
    partial class baseDato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(baseDato));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Salida = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-4, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(483, 362);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Salida
            // 
            this.Salida.BackColor = System.Drawing.Color.Transparent;
            this.Salida.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Salida.BackgroundImage")));
            this.Salida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Salida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Salida.Dock = System.Windows.Forms.DockStyle.Right;
            this.Salida.FlatAppearance.BorderSize = 0;
            this.Salida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Salida.Location = new System.Drawing.Point(447, 0);
            this.Salida.Name = "Salida";
            this.Salida.Size = new System.Drawing.Size(102, 362);
            this.Salida.TabIndex = 1;
            this.Salida.UseVisualStyleBackColor = false;
            this.Salida.Click += new System.EventHandler(this.button1_Click);
            // 
            // baseDato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 362);
            this.Controls.Add(this.Salida);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "baseDato";
            this.Text = "baseDato";
            this.Load += new System.EventHandler(this.baseDato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Salida;
    }
}