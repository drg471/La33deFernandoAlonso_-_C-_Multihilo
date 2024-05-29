namespace Tarea2_Multihilo
{
    partial class MenuPrincipal
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
            btnJugar = new Button();
            btnSalir = new Button();
            alomeme = new PictureBox();
            la33 = new Label();
            alonso = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)alomeme).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnJugar
            // 
            btnJugar.BackColor = Color.Turquoise;
            btnJugar.FlatStyle = FlatStyle.Flat;
            btnJugar.Font = new Font("Consolas", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnJugar.Location = new Point(762, 496);
            btnJugar.Name = "btnJugar";
            btnJugar.Size = new Size(282, 74);
            btnJugar.TabIndex = 0;
            btnJugar.Text = "JUGAR";
            btnJugar.UseVisualStyleBackColor = false;
            btnJugar.Click += btnJugar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(255, 128, 128);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Consolas", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.Location = new Point(762, 640);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(282, 74);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // alomeme
            // 
            alomeme.BackColor = Color.Transparent;
            alomeme.Image = Properties.Resources.alonso_meme_pixelicious;
            alomeme.Location = new Point(-2, 0);
            alomeme.Margin = new Padding(3, 4, 3, 4);
            alomeme.Name = "alomeme";
            alomeme.Size = new Size(640, 845);
            alomeme.SizeMode = PictureBoxSizeMode.StretchImage;
            alomeme.TabIndex = 2;
            alomeme.TabStop = false;
            // 
            // la33
            // 
            la33.AutoSize = true;
            la33.BackColor = Color.Transparent;
            la33.Font = new Font("Consolas", 75F, FontStyle.Bold, GraphicsUnit.Point);
            la33.ForeColor = Color.MediumTurquoise;
            la33.Location = new Point(698, 199);
            la33.Name = "la33";
            la33.Size = new Size(407, 146);
            la33.TabIndex = 3;
            la33.Text = "La 33";
            // 
            // alonso
            // 
            alonso.AutoSize = true;
            alonso.BackColor = Color.Transparent;
            alonso.Font = new Font("Consolas", 30F, FontStyle.Bold, GraphicsUnit.Point);
            alonso.ForeColor = Color.MediumTurquoise;
            alonso.Location = new Point(689, 355);
            alonso.Name = "alonso";
            alonso.Size = new Size(430, 59);
            alonso.TabIndex = 4;
            alonso.Text = "Fernando Alonso";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Consolas", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.MediumTurquoise;
            label1.Location = new Point(878, 316);
            label1.Name = "label1";
            label1.Size = new Size(41, 29);
            label1.TabIndex = 5;
            label1.Text = "de";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.trophy;
            pictureBox1.Location = new Point(810, 32);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(139, 175);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1319, 843);
            Controls.Add(label1);
            Controls.Add(alonso);
            Controls.Add(la33);
            Controls.Add(btnSalir);
            Controls.Add(btnJugar);
            Controls.Add(alomeme);
            Controls.Add(pictureBox1);
            Name = "MenuPrincipal";
            Text = "MenuPrincipal";
            ((System.ComponentModel.ISupportInitialize)alomeme).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnJugar;
        private Button btnSalir;
        private PictureBox alomeme;
        private Label la33;
        private Label alonso;
        private Label label1;
        private PictureBox pictureBox1;
    }
}