namespace SimplePaint
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
            lblAppName = new Label();
            groupBox1 = new GroupBox();
            btnCircle = new Button();
            btnRectangle = new Button();
            btnLine = new Button();
            groupBox2 = new GroupBox();
            cmbColor = new ComboBox();
            groupBox3 = new GroupBox();
            trbLineWidth = new TrackBar();
            btnOpenFile = new Button();
            btnSaveFile = new Button();
            pnlCanvas = new Panel();
            picCanvas = new PictureBox();
            btnSizeUp = new Button();
            btnSizeDown = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trbLineWidth).BeginInit();
            pnlCanvas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCanvas).BeginInit();
            SuspendLayout();
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("맑은 고딕", 36F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblAppName.Location = new Point(12, 9);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(314, 65);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "Simple Paint";
            lblAppName.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCircle);
            groupBox1.Controls.Add(btnRectangle);
            groupBox1.Controls.Add(btnLine);
            groupBox1.Location = new Point(19, 80);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(232, 108);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "도형 선택";
            // 
            // btnCircle
            // 
            btnCircle.Image = (Image)resources.GetObject("btnCircle.Image");
            btnCircle.ImageAlign = ContentAlignment.TopCenter;
            btnCircle.Location = new Point(155, 27);
            btnCircle.Name = "btnCircle";
            btnCircle.Size = new Size(68, 67);
            btnCircle.TabIndex = 2;
            btnCircle.Text = "원";
            btnCircle.TextAlign = ContentAlignment.BottomCenter;
            btnCircle.UseVisualStyleBackColor = true;
            // 
            // btnRectangle
            // 
            btnRectangle.Image = (Image)resources.GetObject("btnRectangle.Image");
            btnRectangle.ImageAlign = ContentAlignment.TopCenter;
            btnRectangle.Location = new Point(81, 27);
            btnRectangle.Name = "btnRectangle";
            btnRectangle.Size = new Size(68, 67);
            btnRectangle.TabIndex = 1;
            btnRectangle.Text = "사각형";
            btnRectangle.TextAlign = ContentAlignment.BottomCenter;
            btnRectangle.UseVisualStyleBackColor = true;
            // 
            // btnLine
            // 
            btnLine.Image = (Image)resources.GetObject("btnLine.Image");
            btnLine.ImageAlign = ContentAlignment.TopCenter;
            btnLine.Location = new Point(7, 27);
            btnLine.Name = "btnLine";
            btnLine.Size = new Size(68, 67);
            btnLine.TabIndex = 0;
            btnLine.Text = "직선";
            btnLine.TextAlign = ContentAlignment.BottomCenter;
            btnLine.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cmbColor);
            groupBox2.Location = new Point(266, 80);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(110, 108);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "색 선택";
            // 
            // cmbColor
            // 
            cmbColor.FormattingEnabled = true;
            cmbColor.Items.AddRange(new object[] { "Black 검정", "Red 빨강", "Blue 파랑", "Green 녹색" });
            cmbColor.Location = new Point(6, 50);
            cmbColor.Name = "cmbColor";
            cmbColor.Size = new Size(98, 23);
            cmbColor.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(trbLineWidth);
            groupBox3.Location = new Point(391, 80);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(169, 108);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "선 두께";
            // 
            // trbLineWidth
            // 
            trbLineWidth.Location = new Point(6, 38);
            trbLineWidth.Name = "trbLineWidth";
            trbLineWidth.Size = new Size(157, 45);
            trbLineWidth.TabIndex = 0;
            // 
            // btnOpenFile
            // 
            btnOpenFile.BackColor = Color.MistyRose;
            btnOpenFile.Location = new Point(577, 80);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(59, 67);
            btnOpenFile.TabIndex = 4;
            btnOpenFile.Text = "열기";
            btnOpenFile.UseVisualStyleBackColor = false;
            // 
            // btnSaveFile
            // 
            btnSaveFile.BackColor = Color.PowderBlue;
            btnSaveFile.Location = new Point(643, 80);
            btnSaveFile.Name = "btnSaveFile";
            btnSaveFile.Size = new Size(59, 67);
            btnSaveFile.TabIndex = 5;
            btnSaveFile.Text = "저장";
            btnSaveFile.UseVisualStyleBackColor = false;
            // 
            // pnlCanvas
            // 
            pnlCanvas.AutoScroll = true;
            pnlCanvas.BackColor = Color.LightGray;
            pnlCanvas.BorderStyle = BorderStyle.FixedSingle;
            pnlCanvas.Controls.Add(picCanvas);
            pnlCanvas.Location = new Point(19, 194);
            pnlCanvas.Name = "pnlCanvas";
            pnlCanvas.Size = new Size(682, 351);
            pnlCanvas.TabIndex = 7;
            // 
            // picCanvas
            // 
            picCanvas.BackColor = Color.White;
            picCanvas.Location = new Point(0, 0);
            picCanvas.Name = "picCanvas";
            picCanvas.Size = new Size(682, 351);
            picCanvas.SizeMode = PictureBoxSizeMode.AutoSize;
            picCanvas.TabIndex = 6;
            picCanvas.TabStop = false;
            picCanvas.MouseDown += picCanvas_MouseDown;
            picCanvas.MouseMove += picCanvas_MouseMove;
            picCanvas.MouseUp += picCanvas_MouseUp;
            // 
            // btnSizeUp
            // 
            btnSizeUp.BackColor = Color.Silver;
            btnSizeUp.Location = new Point(577, 153);
            btnSizeUp.Name = "btnSizeUp";
            btnSizeUp.Size = new Size(59, 35);
            btnSizeUp.TabIndex = 8;
            btnSizeUp.Text = "확대";
            btnSizeUp.UseVisualStyleBackColor = false;
            // 
            // btnSizeDown
            // 
            btnSizeDown.BackColor = Color.Silver;
            btnSizeDown.Location = new Point(643, 153);
            btnSizeDown.Name = "btnSizeDown";
            btnSizeDown.Size = new Size(59, 35);
            btnSizeDown.TabIndex = 9;
            btnSizeDown.Text = "축소";
            btnSizeDown.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(717, 557);
            Controls.Add(btnSizeDown);
            Controls.Add(btnSizeUp);
            Controls.Add(pnlCanvas);
            Controls.Add(btnSaveFile);
            Controls.Add(btnOpenFile);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lblAppName);
            Name = "Form1";
            Text = "Simple Paint v1.0";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trbLineWidth).EndInit();
            pnlCanvas.ResumeLayout(false);
            pnlCanvas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picCanvas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppName;
        private GroupBox groupBox1;
        private Button btnCircle;
        private Button btnRectangle;
        private Button btnLine;
        private GroupBox groupBox2;
        private ComboBox cmbColor;
        private GroupBox groupBox3;
        private Button btnOpenFile;
        private Button btnSaveFile;
        private TrackBar trbLineWidth;
        private Panel pnlCanvas;
        private PictureBox picCanvas;
        private Button btnSizeUp;
        private Button btnSizeDown;
    }
}


