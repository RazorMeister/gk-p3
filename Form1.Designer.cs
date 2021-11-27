namespace gk_p3
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
            this.curvesWrapper = new System.Windows.Forms.PictureBox();
            this.mainImageWrapper = new System.Windows.Forms.PictureBox();
            this.cyanWrapper = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.blackRadioButton = new System.Windows.Forms.RadioButton();
            this.yellowRadioButton = new System.Windows.Forms.RadioButton();
            this.magentaRadioButton = new System.Windows.Forms.RadioButton();
            this.cyanRadioButton = new System.Windows.Forms.RadioButton();
            this.magentaWrapper = new System.Windows.Forms.PictureBox();
            this.yellowWrapper = new System.Windows.Forms.PictureBox();
            this.blackWrapper = new System.Windows.Forms.PictureBox();
            this.resultImageWrapper = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.currentColorImageWrapper = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.curvesWrapper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainImageWrapper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyanWrapper)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.magentaWrapper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowWrapper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackWrapper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultImageWrapper)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentColorImageWrapper)).BeginInit();
            this.SuspendLayout();
            // 
            // curvesWrapper
            // 
            this.curvesWrapper.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.curvesWrapper.Location = new System.Drawing.Point(12, 12);
            this.curvesWrapper.Name = "curvesWrapper";
            this.curvesWrapper.Size = new System.Drawing.Size(559, 434);
            this.curvesWrapper.TabIndex = 0;
            this.curvesWrapper.TabStop = false;
            this.curvesWrapper.Paint += new System.Windows.Forms.PaintEventHandler(this.curvesWrapper_Paint);
            this.curvesWrapper.MouseDown += new System.Windows.Forms.MouseEventHandler(this.curvesWrapper_MouseDown);
            this.curvesWrapper.MouseMove += new System.Windows.Forms.MouseEventHandler(this.curvesWrapper_MouseMove);
            this.curvesWrapper.MouseUp += new System.Windows.Forms.MouseEventHandler(this.curvesWrapper_MouseUp);
            // 
            // mainImageWrapper
            // 
            this.mainImageWrapper.Location = new System.Drawing.Point(590, 12);
            this.mainImageWrapper.Name = "mainImageWrapper";
            this.mainImageWrapper.Size = new System.Drawing.Size(320, 200);
            this.mainImageWrapper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mainImageWrapper.TabIndex = 1;
            this.mainImageWrapper.TabStop = false;
            // 
            // cyanWrapper
            // 
            this.cyanWrapper.Location = new System.Drawing.Point(6, 22);
            this.cyanWrapper.Name = "cyanWrapper";
            this.cyanWrapper.Size = new System.Drawing.Size(140, 80);
            this.cyanWrapper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cyanWrapper.TabIndex = 2;
            this.cyanWrapper.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.blackRadioButton);
            this.groupBox1.Controls.Add(this.yellowRadioButton);
            this.groupBox1.Controls.Add(this.magentaRadioButton);
            this.groupBox1.Controls.Add(this.cyanRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 452);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(166, 139);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // blackRadioButton
            // 
            this.blackRadioButton.AutoSize = true;
            this.blackRadioButton.Location = new System.Drawing.Point(16, 95);
            this.blackRadioButton.Name = "blackRadioButton";
            this.blackRadioButton.Size = new System.Drawing.Size(53, 19);
            this.blackRadioButton.TabIndex = 3;
            this.blackRadioButton.Text = "Black";
            this.blackRadioButton.UseVisualStyleBackColor = true;
            this.blackRadioButton.CheckedChanged += new System.EventHandler(this.blackRadioButton_CheckedChanged);
            // 
            // yellowRadioButton
            // 
            this.yellowRadioButton.AutoSize = true;
            this.yellowRadioButton.Location = new System.Drawing.Point(16, 70);
            this.yellowRadioButton.Name = "yellowRadioButton";
            this.yellowRadioButton.Size = new System.Drawing.Size(59, 19);
            this.yellowRadioButton.TabIndex = 2;
            this.yellowRadioButton.Text = "Yellow";
            this.yellowRadioButton.UseVisualStyleBackColor = true;
            this.yellowRadioButton.CheckedChanged += new System.EventHandler(this.yellowRadioButton_CheckedChanged);
            // 
            // magentaRadioButton
            // 
            this.magentaRadioButton.AutoSize = true;
            this.magentaRadioButton.Location = new System.Drawing.Point(16, 45);
            this.magentaRadioButton.Name = "magentaRadioButton";
            this.magentaRadioButton.Size = new System.Drawing.Size(72, 19);
            this.magentaRadioButton.TabIndex = 1;
            this.magentaRadioButton.Text = "Magenta";
            this.magentaRadioButton.UseVisualStyleBackColor = true;
            this.magentaRadioButton.CheckedChanged += new System.EventHandler(this.magentaRadioButton_CheckedChanged);
            // 
            // cyanRadioButton
            // 
            this.cyanRadioButton.AutoSize = true;
            this.cyanRadioButton.Checked = true;
            this.cyanRadioButton.Location = new System.Drawing.Point(16, 20);
            this.cyanRadioButton.Name = "cyanRadioButton";
            this.cyanRadioButton.Size = new System.Drawing.Size(52, 19);
            this.cyanRadioButton.TabIndex = 0;
            this.cyanRadioButton.TabStop = true;
            this.cyanRadioButton.Text = "Cyan";
            this.cyanRadioButton.UseVisualStyleBackColor = true;
            this.cyanRadioButton.CheckedChanged += new System.EventHandler(this.cyanRadioButton_CheckedChanged);
            // 
            // magentaWrapper
            // 
            this.magentaWrapper.Location = new System.Drawing.Point(174, 22);
            this.magentaWrapper.Name = "magentaWrapper";
            this.magentaWrapper.Size = new System.Drawing.Size(140, 80);
            this.magentaWrapper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.magentaWrapper.TabIndex = 4;
            this.magentaWrapper.TabStop = false;
            // 
            // yellowWrapper
            // 
            this.yellowWrapper.Location = new System.Drawing.Point(174, 113);
            this.yellowWrapper.Name = "yellowWrapper";
            this.yellowWrapper.Size = new System.Drawing.Size(140, 80);
            this.yellowWrapper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.yellowWrapper.TabIndex = 5;
            this.yellowWrapper.TabStop = false;
            // 
            // blackWrapper
            // 
            this.blackWrapper.Location = new System.Drawing.Point(6, 113);
            this.blackWrapper.Name = "blackWrapper";
            this.blackWrapper.Size = new System.Drawing.Size(140, 80);
            this.blackWrapper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.blackWrapper.TabIndex = 6;
            this.blackWrapper.TabStop = false;
            // 
            // resultImageWrapper
            // 
            this.resultImageWrapper.Location = new System.Drawing.Point(590, 246);
            this.resultImageWrapper.Name = "resultImageWrapper";
            this.resultImageWrapper.Size = new System.Drawing.Size(320, 200);
            this.resultImageWrapper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.resultImageWrapper.TabIndex = 7;
            this.resultImageWrapper.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cyanWrapper);
            this.groupBox2.Controls.Add(this.magentaWrapper);
            this.groupBox2.Controls.Add(this.yellowWrapper);
            this.groupBox2.Controls.Add(this.blackWrapper);
            this.groupBox2.Location = new System.Drawing.Point(951, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 200);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // currentColorImageWrapper
            // 
            this.currentColorImageWrapper.Location = new System.Drawing.Point(951, 246);
            this.currentColorImageWrapper.Name = "currentColorImageWrapper";
            this.currentColorImageWrapper.Size = new System.Drawing.Size(320, 200);
            this.currentColorImageWrapper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.currentColorImageWrapper.TabIndex = 9;
            this.currentColorImageWrapper.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 603);
            this.Controls.Add(this.currentColorImageWrapper);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.resultImageWrapper);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mainImageWrapper);
            this.Controls.Add(this.curvesWrapper);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.curvesWrapper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainImageWrapper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyanWrapper)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.magentaWrapper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowWrapper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackWrapper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultImageWrapper)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.currentColorImageWrapper)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox curvesWrapper;
        private PictureBox mainImageWrapper;
        private PictureBox cyanWrapper;
        private GroupBox groupBox1;
        private RadioButton blackRadioButton;
        private RadioButton yellowRadioButton;
        private RadioButton magentaRadioButton;
        private RadioButton cyanRadioButton;
        private PictureBox magentaWrapper;
        private PictureBox yellowWrapper;
        private PictureBox blackWrapper;
        private PictureBox resultImageWrapper;
        private GroupBox groupBox2;
        private PictureBox currentColorImageWrapper;
    }
}