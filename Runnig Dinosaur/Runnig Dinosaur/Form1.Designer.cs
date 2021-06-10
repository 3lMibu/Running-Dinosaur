
namespace Runnig_Dinosaur
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.puntaje = new System.Windows.Forms.Label();
            this.contadorTiempo = new System.Windows.Forms.Timer(this.components);
            this.tRex = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(-7, 397);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(814, 62);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // puntaje
            // 
            this.puntaje.AutoSize = true;
            this.puntaje.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.puntaje.Location = new System.Drawing.Point(13, 13);
            this.puntaje.Name = "puntaje";
            this.puntaje.Size = new System.Drawing.Size(165, 33);
            this.puntaje.TabIndex = 2;
            this.puntaje.Text = "Puntaje: 0";
            // 
            // contadorTiempo
            // 
            this.contadorTiempo.Interval = 20;
            this.contadorTiempo.Tick += new System.EventHandler(this.contadorJuegoPrincipal);
            // 
            // tRex
            // 
            this.tRex.Image = global::Runnig_Dinosaur.Properties.Resources.running1;
            this.tRex.Location = new System.Drawing.Point(53, 354);
            this.tRex.Name = "tRex";
            this.tRex.Size = new System.Drawing.Size(40, 43);
            this.tRex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.tRex.TabIndex = 3;
            this.tRex.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Runnig_Dinosaur.Properties.Resources.obstacle_1;
            this.pictureBox3.Location = new System.Drawing.Point(311, 351);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(23, 46);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "obstaculo";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Runnig_Dinosaur.Properties.Resources.obstacle_2;
            this.pictureBox4.Location = new System.Drawing.Point(509, 364);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 33);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "obstaculo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.tRex);
            this.Controls.Add(this.puntaje);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Running Dinosaur";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label puntaje;
        private System.Windows.Forms.Timer contadorTiempo;
        private System.Windows.Forms.PictureBox tRex;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

