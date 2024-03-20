namespace WinFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Background = new PictureBox();
            ActionBTN = new Button();
            DramaBTN = new Button();
            pictureMain = new PictureBox();
            ButtonREAD1 = new Button();
            ButtonREAD2 = new Button();
            ButtonREAD3 = new Button();
            ButtonREAD6 = new Button();
            ButtonREAD5 = new Button();
            ButtonREAD4 = new Button();
            buttonblackaction = new Button();
            buttonblackdrama = new Button();
            ((System.ComponentModel.ISupportInitialize)Background).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureMain).BeginInit();
            SuspendLayout();
            // 
            // Background
            // 
            Background.Image = (Image)resources.GetObject("Background.Image");
            Background.Location = new Point(-1, 1);
            Background.Name = "Background";
            Background.Size = new Size(583, 452);
            Background.SizeMode = PictureBoxSizeMode.StretchImage;
            Background.TabIndex = 0;
            Background.TabStop = false;
            // 
            // ActionBTN
            // 
            ActionBTN.Location = new Point(611, 154);
            ActionBTN.Name = "ActionBTN";
            ActionBTN.Size = new Size(123, 34);
            ActionBTN.TabIndex = 1;
            ActionBTN.Text = "ACTION";
            ActionBTN.UseVisualStyleBackColor = true;
            ActionBTN.Click += button1_Click;
            // 
            // DramaBTN
            // 
            DramaBTN.Location = new Point(738, 154);
            DramaBTN.Name = "DramaBTN";
            DramaBTN.Size = new Size(123, 34);
            DramaBTN.TabIndex = 2;
            DramaBTN.Text = "DRAMA";
            DramaBTN.UseVisualStyleBackColor = true;
            DramaBTN.Click += button2_Click;
            // 
            // pictureMain
            // 
            pictureMain.Image = Properties.Resources.mainshow;
            pictureMain.Location = new Point(611, 12);
            pictureMain.Name = "pictureMain";
            pictureMain.Size = new Size(250, 131);
            pictureMain.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureMain.TabIndex = 3;
            pictureMain.TabStop = false;
            // 
            // ButtonREAD1
            // 
            ButtonREAD1.BackColor = SystemColors.MenuText;
            ButtonREAD1.ForeColor = SystemColors.ButtonHighlight;
            ButtonREAD1.Location = new Point(92, 344);
            ButtonREAD1.Name = "ButtonREAD1";
            ButtonREAD1.Size = new Size(109, 33);
            ButtonREAD1.TabIndex = 4;
            ButtonREAD1.Text = "READ";
            ButtonREAD1.UseVisualStyleBackColor = false;
            ButtonREAD1.Click += ButtonREAD1_Click;
            // 
            // ButtonREAD2
            // 
            ButtonREAD2.BackColor = SystemColors.MenuText;
            ButtonREAD2.ForeColor = SystemColors.ButtonHighlight;
            ButtonREAD2.Location = new Point(228, 344);
            ButtonREAD2.Name = "ButtonREAD2";
            ButtonREAD2.Size = new Size(109, 33);
            ButtonREAD2.TabIndex = 5;
            ButtonREAD2.Text = "READ";
            ButtonREAD2.UseVisualStyleBackColor = false;
            ButtonREAD2.Click += ButtonREAD2_Click;
            // 
            // ButtonREAD3
            // 
            ButtonREAD3.BackColor = SystemColors.MenuText;
            ButtonREAD3.ForeColor = SystemColors.ButtonHighlight;
            ButtonREAD3.Location = new Point(377, 344);
            ButtonREAD3.Name = "ButtonREAD3";
            ButtonREAD3.Size = new Size(109, 33);
            ButtonREAD3.TabIndex = 6;
            ButtonREAD3.Text = "READ";
            ButtonREAD3.UseVisualStyleBackColor = false;
            ButtonREAD3.Click += ButtonREAD3_Click;
            // 
            // ButtonREAD6
            // 
            ButtonREAD6.BackColor = SystemColors.MenuText;
            ButtonREAD6.ForeColor = SystemColors.ButtonHighlight;
            ButtonREAD6.Location = new Point(377, 344);
            ButtonREAD6.Name = "ButtonREAD6";
            ButtonREAD6.Size = new Size(109, 33);
            ButtonREAD6.TabIndex = 7;
            ButtonREAD6.Text = "READ";
            ButtonREAD6.UseVisualStyleBackColor = false;
            ButtonREAD6.Click += ButtonREAD6_Click;
            // 
            // ButtonREAD5
            // 
            ButtonREAD5.BackColor = SystemColors.MenuText;
            ButtonREAD5.ForeColor = SystemColors.ButtonHighlight;
            ButtonREAD5.Location = new Point(228, 344);
            ButtonREAD5.Name = "ButtonREAD5";
            ButtonREAD5.Size = new Size(109, 33);
            ButtonREAD5.TabIndex = 8;
            ButtonREAD5.Text = "READ";
            ButtonREAD5.UseVisualStyleBackColor = false;
            ButtonREAD5.Click += ButtonREAD5_Click;
            // 
            // ButtonREAD4
            // 
            ButtonREAD4.BackColor = SystemColors.MenuText;
            ButtonREAD4.ForeColor = SystemColors.ButtonHighlight;
            ButtonREAD4.Location = new Point(92, 344);
            ButtonREAD4.Name = "ButtonREAD4";
            ButtonREAD4.Size = new Size(109, 33);
            ButtonREAD4.TabIndex = 9;
            ButtonREAD4.Text = "READ";
            ButtonREAD4.UseVisualStyleBackColor = false;
            ButtonREAD4.Click += ButtonREAD4_Click;
            // 
            // buttonblackaction
            // 
            buttonblackaction.BackColor = SystemColors.MenuText;
            buttonblackaction.ForeColor = SystemColors.ButtonHighlight;
            buttonblackaction.Location = new Point(434, 406);
            buttonblackaction.Name = "buttonblackaction";
            buttonblackaction.Size = new Size(109, 33);
            buttonblackaction.TabIndex = 10;
            buttonblackaction.Text = "BACK";
            buttonblackaction.UseVisualStyleBackColor = false;
            buttonblackaction.Click += buttonblack_Click;
            // 
            // buttonblackdrama
            // 
            buttonblackdrama.BackColor = SystemColors.MenuText;
            buttonblackdrama.ForeColor = SystemColors.ButtonHighlight;
            buttonblackdrama.Location = new Point(434, 406);
            buttonblackdrama.Name = "buttonblackdrama";
            buttonblackdrama.Size = new Size(109, 33);
            buttonblackdrama.TabIndex = 11;
            buttonblackdrama.Text = "BACK";
            buttonblackdrama.UseVisualStyleBackColor = false;
            buttonblackdrama.Click += buttonblackdrama_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 512);
            Controls.Add(buttonblackdrama);
            Controls.Add(buttonblackaction);
            Controls.Add(ButtonREAD4);
            Controls.Add(ButtonREAD5);
            Controls.Add(ButtonREAD6);
            Controls.Add(ButtonREAD3);
            Controls.Add(ButtonREAD2);
            Controls.Add(ButtonREAD1);
            Controls.Add(pictureMain);
            Controls.Add(DramaBTN);
            Controls.Add(ActionBTN);
            Controls.Add(Background);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Background).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureMain).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox Background;
        private Button ActionBTN;
        private Button DramaBTN;
        private PictureBox pictureMain;
        private Button ButtonREAD1;
        private Button ButtonREAD2;
        private Button ButtonREAD3;
        private Button ButtonREAD6;
        private Button ButtonREAD5;
        private Button ButtonREAD4;
        private Button buttonblackaction;
        private Button buttonblackdrama;
    }
}
