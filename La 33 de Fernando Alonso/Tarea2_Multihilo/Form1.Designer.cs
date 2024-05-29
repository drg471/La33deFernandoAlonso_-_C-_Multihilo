namespace Tarea2_Multihilo
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
            btnIniciar = new Button();
            btnReiniciar = new Button();
            caballo1 = new PictureBox();
            caballo2 = new PictureBox();
            caballo3 = new PictureBox();
            caballo4 = new PictureBox();
            btnAtras = new Button();
            pbPodium = new PictureBox();
            pbPodio2 = new PictureBox();
            pbPodio1 = new PictureBox();
            pbPodio3 = new PictureBox();
            rbNivelFacil = new RadioButton();
            rbNivelDificil = new RadioButton();
            rbNivelExperto = new RadioButton();
            btnAcelerar = new Button();
            txtAceleracion = new TextBox();
            lblJ1 = new Label();
            lblCOM1 = new Label();
            lblCOM2 = new Label();
            lblCOM3 = new Label();
            pbAceleracion = new ProgressBar();
            mando = new PictureBox();
            pbConfeti = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)caballo1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)caballo2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)caballo3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)caballo4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPodium).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPodio2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPodio1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPodio3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mando).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbConfeti).BeginInit();
            SuspendLayout();
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.LawnGreen;
            btnIniciar.FlatAppearance.BorderColor = Color.ForestGreen;
            btnIniciar.FlatStyle = FlatStyle.Flat;
            btnIniciar.Font = new Font("Consolas", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnIniciar.Location = new Point(230, 688);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(70, 29);
            btnIniciar.TabIndex = 0;
            btnIniciar.Text = "INICIAR";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnReiniciar
            // 
            btnReiniciar.BackColor = Color.Orange;
            btnReiniciar.FlatAppearance.BorderColor = Color.DarkGoldenrod;
            btnReiniciar.FlatStyle = FlatStyle.Flat;
            btnReiniciar.Font = new Font("Consolas", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnReiniciar.Location = new Point(363, 724);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(66, 31);
            btnReiniciar.TabIndex = 1;
            btnReiniciar.Text = "RESET";
            btnReiniciar.UseVisualStyleBackColor = false;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // caballo1
            // 
            caballo1.BackColor = Color.Transparent;
            caballo1.BackgroundImageLayout = ImageLayout.Stretch;
            caballo1.Image = Properties.Resources.aston;
            caballo1.Location = new Point(54, 417);
            caballo1.Name = "caballo1";
            caballo1.Size = new Size(159, 111);
            caballo1.SizeMode = PictureBoxSizeMode.StretchImage;
            caballo1.TabIndex = 2;
            caballo1.TabStop = false;
            // 
            // caballo2
            // 
            caballo2.BackColor = Color.Transparent;
            caballo2.BackgroundImageLayout = ImageLayout.Stretch;
            caballo2.Image = Properties.Resources.mclaren;
            caballo2.Location = new Point(53, 321);
            caballo2.Name = "caballo2";
            caballo2.Size = new Size(159, 111);
            caballo2.SizeMode = PictureBoxSizeMode.StretchImage;
            caballo2.TabIndex = 3;
            caballo2.TabStop = false;
            // 
            // caballo3
            // 
            caballo3.BackColor = Color.Transparent;
            caballo3.BackgroundImageLayout = ImageLayout.Stretch;
            caballo3.Image = Properties.Resources.rb;
            caballo3.Location = new Point(53, 231);
            caballo3.Name = "caballo3";
            caballo3.Size = new Size(159, 111);
            caballo3.SizeMode = PictureBoxSizeMode.StretchImage;
            caballo3.TabIndex = 4;
            caballo3.TabStop = false;
            // 
            // caballo4
            // 
            caballo4.BackColor = Color.Transparent;
            caballo4.BackgroundImageLayout = ImageLayout.Zoom;
            caballo4.Image = Properties.Resources.ferrari;
            caballo4.Location = new Point(53, 137);
            caballo4.Name = "caballo4";
            caballo4.Size = new Size(159, 111);
            caballo4.SizeMode = PictureBoxSizeMode.StretchImage;
            caballo4.TabIndex = 5;
            caballo4.TabStop = false;
            // 
            // btnAtras
            // 
            btnAtras.BackColor = Color.OrangeRed;
            btnAtras.FlatAppearance.BorderColor = Color.Crimson;
            btnAtras.FlatStyle = FlatStyle.Flat;
            btnAtras.Font = new Font("Consolas", 8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAtras.Location = new Point(230, 724);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(70, 31);
            btnAtras.TabIndex = 6;
            btnAtras.Text = "SALIR";
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // pbPodium
            // 
            pbPodium.BackColor = Color.Transparent;
            pbPodium.BackgroundImage = Properties.Resources.podium_pixelicious;
            pbPodium.BackgroundImageLayout = ImageLayout.Stretch;
            pbPodium.Location = new Point(841, 688);
            pbPodium.Name = "pbPodium";
            pbPodium.Size = new Size(429, 163);
            pbPodium.TabIndex = 7;
            pbPodium.TabStop = false;
            // 
            // pbPodio2
            // 
            pbPodio2.BackColor = Color.Transparent;
            pbPodio2.BackgroundImage = Properties.Resources.aloPodium;
            pbPodio2.BackgroundImageLayout = ImageLayout.Stretch;
            pbPodio2.Location = new Point(887, 595);
            pbPodio2.Name = "pbPodio2";
            pbPodio2.Size = new Size(79, 144);
            pbPodio2.TabIndex = 8;
            pbPodio2.TabStop = false;
            // 
            // pbPodio1
            // 
            pbPodio1.BackColor = Color.Transparent;
            pbPodio1.BackgroundImage = Properties.Resources.verPodium;
            pbPodio1.BackgroundImageLayout = ImageLayout.Stretch;
            pbPodio1.Location = new Point(1023, 571);
            pbPodio1.Name = "pbPodio1";
            pbPodio1.Size = new Size(85, 147);
            pbPodio1.TabIndex = 9;
            pbPodio1.TabStop = false;
            // 
            // pbPodio3
            // 
            pbPodio3.BackColor = Color.Transparent;
            pbPodio3.BackgroundImage = Properties.Resources.saiPodium;
            pbPodio3.BackgroundImageLayout = ImageLayout.Stretch;
            pbPodio3.Location = new Point(1147, 611);
            pbPodio3.Name = "pbPodio3";
            pbPodio3.Size = new Size(82, 144);
            pbPodio3.TabIndex = 10;
            pbPodio3.TabStop = false;
            // 
            // rbNivelFacil
            // 
            rbNivelFacil.AutoSize = true;
            rbNivelFacil.BackColor = SystemColors.ControlDarkDark;
            rbNivelFacil.BackgroundImageLayout = ImageLayout.None;
            rbNivelFacil.Font = new Font("Consolas", 8F, FontStyle.Regular, GraphicsUnit.Point);
            rbNivelFacil.ForeColor = Color.Lime;
            rbNivelFacil.Location = new Point(247, 571);
            rbNivelFacil.Name = "rbNivelFacil";
            rbNivelFacil.Size = new Size(117, 21);
            rbNivelFacil.TabIndex = 11;
            rbNivelFacil.TabStop = true;
            rbNivelFacil.Text = "Nivel Facil";
            rbNivelFacil.UseVisualStyleBackColor = false;
            // 
            // rbNivelDificil
            // 
            rbNivelDificil.AutoSize = true;
            rbNivelDificil.BackColor = SystemColors.ControlDarkDark;
            rbNivelDificil.Font = new Font("Consolas", 8F, FontStyle.Regular, GraphicsUnit.Point);
            rbNivelDificil.ForeColor = Color.Lime;
            rbNivelDificil.Location = new Point(247, 595);
            rbNivelDificil.Name = "rbNivelDificil";
            rbNivelDificil.Size = new Size(133, 21);
            rbNivelDificil.TabIndex = 12;
            rbNivelDificil.TabStop = true;
            rbNivelDificil.Text = "Nivel Dificil";
            rbNivelDificil.UseVisualStyleBackColor = false;
            // 
            // rbNivelExperto
            // 
            rbNivelExperto.AutoSize = true;
            rbNivelExperto.BackColor = SystemColors.ControlDarkDark;
            rbNivelExperto.Font = new Font("Consolas", 8F, FontStyle.Regular, GraphicsUnit.Point);
            rbNivelExperto.ForeColor = Color.Lime;
            rbNivelExperto.Location = new Point(247, 617);
            rbNivelExperto.Name = "rbNivelExperto";
            rbNivelExperto.Size = new Size(133, 21);
            rbNivelExperto.TabIndex = 13;
            rbNivelExperto.TabStop = true;
            rbNivelExperto.Text = "Nivel Experto";
            rbNivelExperto.UseVisualStyleBackColor = false;
            // 
            // btnAcelerar
            // 
            btnAcelerar.BackColor = Color.Cyan;
            btnAcelerar.FlatAppearance.BorderColor = Color.DarkTurquoise;
            btnAcelerar.FlatStyle = FlatStyle.Flat;
            btnAcelerar.Font = new Font("Consolas", 8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAcelerar.Location = new Point(363, 688);
            btnAcelerar.Name = "btnAcelerar";
            btnAcelerar.Size = new Size(66, 29);
            btnAcelerar.TabIndex = 15;
            btnAcelerar.Text = "TURBO";
            btnAcelerar.UseVisualStyleBackColor = false;
            btnAcelerar.Click += btnAcelerar_Click;
            // 
            // txtAceleracion
            // 
            txtAceleracion.Location = new Point(246, 644);
            txtAceleracion.Name = "txtAceleracion";
            txtAceleracion.ReadOnly = true;
            txtAceleracion.Size = new Size(41, 27);
            txtAceleracion.TabIndex = 16;
            // 
            // lblJ1
            // 
            lblJ1.AutoSize = true;
            lblJ1.BackColor = SystemColors.ActiveCaptionText;
            lblJ1.Font = new Font("Consolas", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblJ1.ForeColor = SystemColors.ButtonHighlight;
            lblJ1.Location = new Point(6, 473);
            lblJ1.Name = "lblJ1";
            lblJ1.Size = new Size(36, 20);
            lblJ1.TabIndex = 17;
            lblJ1.Text = "ALO";
            // 
            // lblCOM1
            // 
            lblCOM1.AutoSize = true;
            lblCOM1.BackColor = SystemColors.ActiveCaptionText;
            lblCOM1.Font = new Font("Consolas", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblCOM1.ForeColor = SystemColors.ButtonHighlight;
            lblCOM1.Location = new Point(6, 384);
            lblCOM1.Name = "lblCOM1";
            lblCOM1.Size = new Size(36, 20);
            lblCOM1.TabIndex = 18;
            lblCOM1.Text = "NOR";
            // 
            // lblCOM2
            // 
            lblCOM2.AutoSize = true;
            lblCOM2.BackColor = SystemColors.ActiveCaptionText;
            lblCOM2.Font = new Font("Consolas", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblCOM2.ForeColor = SystemColors.ButtonHighlight;
            lblCOM2.Location = new Point(6, 291);
            lblCOM2.Name = "lblCOM2";
            lblCOM2.Size = new Size(36, 20);
            lblCOM2.TabIndex = 19;
            lblCOM2.Text = "VER";
            // 
            // lblCOM3
            // 
            lblCOM3.AutoSize = true;
            lblCOM3.BackColor = SystemColors.ActiveCaptionText;
            lblCOM3.Font = new Font("Consolas", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblCOM3.ForeColor = SystemColors.ButtonHighlight;
            lblCOM3.Location = new Point(6, 195);
            lblCOM3.Name = "lblCOM3";
            lblCOM3.Size = new Size(36, 20);
            lblCOM3.TabIndex = 20;
            lblCOM3.Text = "SAI";
            // 
            // pbAceleracion
            // 
            pbAceleracion.Location = new Point(293, 643);
            pbAceleracion.Name = "pbAceleracion";
            pbAceleracion.Size = new Size(125, 29);
            pbAceleracion.TabIndex = 21;
            // 
            // mando
            // 
            mando.BackColor = Color.Transparent;
            mando.BackgroundImageLayout = ImageLayout.Stretch;
            mando.Image = Properties.Resources.wheel_f1_pixelicious;
            mando.Location = new Point(6, 515);
            mando.Name = "mando";
            mando.Size = new Size(655, 420);
            mando.SizeMode = PictureBoxSizeMode.StretchImage;
            mando.TabIndex = 22;
            mando.TabStop = false;
            // 
            // pbConfeti
            // 
            pbConfeti.BackColor = Color.Transparent;
            pbConfeti.Image = Properties.Resources.confetti_40;
            pbConfeti.Location = new Point(661, 195);
            pbConfeti.Margin = new Padding(3, 4, 3, 4);
            pbConfeti.Name = "pbConfeti";
            pbConfeti.Size = new Size(661, 560);
            pbConfeti.TabIndex = 23;
            pbConfeti.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bggame;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1319, 843);
            Controls.Add(pbAceleracion);
            Controls.Add(lblCOM3);
            Controls.Add(lblCOM2);
            Controls.Add(lblCOM1);
            Controls.Add(lblJ1);
            Controls.Add(txtAceleracion);
            Controls.Add(btnAcelerar);
            Controls.Add(rbNivelExperto);
            Controls.Add(rbNivelDificil);
            Controls.Add(rbNivelFacil);
            Controls.Add(pbPodio3);
            Controls.Add(pbPodio1);
            Controls.Add(pbPodio2);
            Controls.Add(pbPodium);
            Controls.Add(btnAtras);
            Controls.Add(caballo4);
            Controls.Add(caballo3);
            Controls.Add(caballo2);
            Controls.Add(caballo1);
            Controls.Add(btnReiniciar);
            Controls.Add(btnIniciar);
            Controls.Add(mando);
            Controls.Add(pbConfeti);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "JUGAR";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)caballo1).EndInit();
            ((System.ComponentModel.ISupportInitialize)caballo2).EndInit();
            ((System.ComponentModel.ISupportInitialize)caballo3).EndInit();
            ((System.ComponentModel.ISupportInitialize)caballo4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPodium).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPodio2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPodio1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPodio3).EndInit();
            ((System.ComponentModel.ISupportInitialize)mando).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbConfeti).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIniciar;
        private Button btnReiniciar;
        private PictureBox caballo1;
        private PictureBox caballo2;
        private PictureBox caballo3;
        private PictureBox caballo4;
        private Button btnAtras;
        private PictureBox pbPodium;
        private PictureBox pbPodio2;
        private PictureBox pbPodio1;
        private PictureBox pbPodio3;
        private RadioButton rbNivelFacil;
        private RadioButton rbNivelDificil;
        private RadioButton rbNivelExperto;
        private Button btnAcelerar;
        private TextBox txtAceleracion;
        private Label lblJ1;
        private Label lblCOM1;
        private Label lblCOM2;
        private Label lblCOM3;
        private ProgressBar pbAceleracion;
        private PictureBox mando;
        private PictureBox pbConfeti;
    }
}