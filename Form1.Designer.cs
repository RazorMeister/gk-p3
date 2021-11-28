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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.currentColorImageWrapper = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.blackWhiteCheckbox = new System.Windows.Forms.CheckBox();
            this.saveImageButton = new System.Windows.Forms.Button();
            this.importImageButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.importCurvesButton = new System.Windows.Forms.Button();
            this.showAllCurvesCheckbox = new System.Windows.Forms.CheckBox();
            this.saveCurvesButton = new System.Windows.Forms.Button();
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
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            this.cyanWrapper.Location = new System.Drawing.Point(20, 22);
            this.cyanWrapper.Name = "cyanWrapper";
            this.cyanWrapper.Size = new System.Drawing.Size(120, 60);
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
            this.groupBox1.Size = new System.Drawing.Size(121, 139);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select curve";
            // 
            // blackRadioButton
            // 
            this.blackRadioButton.AutoSize = true;
            this.blackRadioButton.Location = new System.Drawing.Point(16, 95);
            this.blackRadioButton.Name = "blackRadioButton";
            this.blackRadioButton.Size = new System.Drawing.Size(71, 19);
            this.blackRadioButton.TabIndex = 3;
            this.blackRadioButton.Text = "(K) Black";
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
            this.magentaWrapper.Size = new System.Drawing.Size(120, 60);
            this.magentaWrapper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.magentaWrapper.TabIndex = 4;
            this.magentaWrapper.TabStop = false;
            // 
            // yellowWrapper
            // 
            this.yellowWrapper.Location = new System.Drawing.Point(20, 111);
            this.yellowWrapper.Name = "yellowWrapper";
            this.yellowWrapper.Size = new System.Drawing.Size(120, 60);
            this.yellowWrapper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.yellowWrapper.TabIndex = 5;
            this.yellowWrapper.TabStop = false;
            // 
            // blackWrapper
            // 
            this.blackWrapper.Location = new System.Drawing.Point(174, 111);
            this.blackWrapper.Name = "blackWrapper";
            this.blackWrapper.Size = new System.Drawing.Size(120, 60);
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
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cyanWrapper);
            this.groupBox2.Controls.Add(this.magentaWrapper);
            this.groupBox2.Controls.Add(this.yellowWrapper);
            this.groupBox2.Controls.Add(this.blackWrapper);
            this.groupBox2.Location = new System.Drawing.Point(951, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 200);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CMYK preview";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(174, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 21);
            this.label7.TabIndex = 10;
            this.label7.Text = "(K) Black";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(20, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "Yellow";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(174, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Magenta";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(20, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cyan";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(590, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Original image";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(590, 452);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Result image";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(951, 449);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(320, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Current curve image";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.blackWhiteCheckbox);
            this.groupBox3.Controls.Add(this.saveImageButton);
            this.groupBox3.Controls.Add(this.importImageButton);
            this.groupBox3.Location = new System.Drawing.Point(304, 452);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(132, 139);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Image options";
            // 
            // blackWhiteCheckbox
            // 
            this.blackWhiteCheckbox.AutoSize = true;
            this.blackWhiteCheckbox.Location = new System.Drawing.Point(17, 22);
            this.blackWhiteCheckbox.Name = "blackWhiteCheckbox";
            this.blackWhiteCheckbox.Size = new System.Drawing.Size(109, 19);
            this.blackWhiteCheckbox.TabIndex = 2;
            this.blackWhiteCheckbox.Text = "Black and white";
            this.blackWhiteCheckbox.UseVisualStyleBackColor = true;
            this.blackWhiteCheckbox.CheckedChanged += new System.EventHandler(this.blackWhiteCheckbox_CheckedChanged);
            // 
            // saveImageButton
            // 
            this.saveImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveImageButton.Location = new System.Drawing.Point(6, 91);
            this.saveImageButton.Name = "saveImageButton";
            this.saveImageButton.Size = new System.Drawing.Size(120, 26);
            this.saveImageButton.TabIndex = 1;
            this.saveImageButton.Text = "Save image";
            this.saveImageButton.UseVisualStyleBackColor = true;
            // 
            // importImageButton
            // 
            this.importImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importImageButton.Location = new System.Drawing.Point(6, 59);
            this.importImageButton.Name = "importImageButton";
            this.importImageButton.Size = new System.Drawing.Size(120, 26);
            this.importImageButton.TabIndex = 0;
            this.importImageButton.Text = "Import image";
            this.importImageButton.UseVisualStyleBackColor = true;
            this.importImageButton.Click += new System.EventHandler(this.importImageButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.importCurvesButton);
            this.groupBox4.Controls.Add(this.showAllCurvesCheckbox);
            this.groupBox4.Controls.Add(this.saveCurvesButton);
            this.groupBox4.Location = new System.Drawing.Point(152, 452);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(132, 139);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Curve options";
            // 
            // importCurvesButton
            // 
            this.importCurvesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importCurvesButton.Location = new System.Drawing.Point(6, 59);
            this.importCurvesButton.Name = "importCurvesButton";
            this.importCurvesButton.Size = new System.Drawing.Size(120, 26);
            this.importCurvesButton.TabIndex = 3;
            this.importCurvesButton.Text = "Import curves";
            this.importCurvesButton.UseVisualStyleBackColor = true;
            this.importCurvesButton.Click += new System.EventHandler(this.importCurvesButton_Click);
            // 
            // showAllCurvesCheckbox
            // 
            this.showAllCurvesCheckbox.AutoSize = true;
            this.showAllCurvesCheckbox.Checked = true;
            this.showAllCurvesCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showAllCurvesCheckbox.Location = new System.Drawing.Point(19, 22);
            this.showAllCurvesCheckbox.Name = "showAllCurvesCheckbox";
            this.showAllCurvesCheckbox.Size = new System.Drawing.Size(107, 19);
            this.showAllCurvesCheckbox.TabIndex = 2;
            this.showAllCurvesCheckbox.Text = "Show all curves";
            this.showAllCurvesCheckbox.UseVisualStyleBackColor = true;
            this.showAllCurvesCheckbox.CheckedChanged += new System.EventHandler(this.showAllCurvesCheckbox_CheckedChanged);
            // 
            // saveCurvesButton
            // 
            this.saveCurvesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveCurvesButton.Location = new System.Drawing.Point(6, 91);
            this.saveCurvesButton.Name = "saveCurvesButton";
            this.saveCurvesButton.Size = new System.Drawing.Size(120, 26);
            this.saveCurvesButton.TabIndex = 1;
            this.saveCurvesButton.Text = "Save curves";
            this.saveCurvesButton.UseVisualStyleBackColor = true;
            this.saveCurvesButton.Click += new System.EventHandler(this.saveCurvesButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 603);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
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
        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox3;
        private Button saveImageButton;
        private Button importImageButton;
        private GroupBox groupBox4;
        private Button importCurvesButton;
        private CheckBox showAllCurvesCheckbox;
        private Button saveCurvesButton;
        private CheckBox blackWhiteCheckbox;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
    }
}