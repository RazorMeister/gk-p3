

using System.Windows.Forms;

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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.hundredPercentBlackButton = new System.Windows.Forms.Button();
            this.ucrButton = new System.Windows.Forms.Button();
            this.zeroPercentBlackButton = new System.Windows.Forms.Button();
            this.gcrButton = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.reduceButton = new System.Windows.Forms.Button();
            this.kLabel = new System.Windows.Forms.Label();
            this.kSlider = new System.Windows.Forms.TrackBar();
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
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // curvesWrapper
            // 
            this.curvesWrapper.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.curvesWrapper.Location = new System.Drawing.Point(14, 16);
            this.curvesWrapper.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.curvesWrapper.Name = "curvesWrapper";
            this.curvesWrapper.Size = new System.Drawing.Size(639, 579);
            this.curvesWrapper.TabIndex = 0;
            this.curvesWrapper.TabStop = false;
            this.curvesWrapper.Paint += new System.Windows.Forms.PaintEventHandler(this.curvesWrapper_Paint);
            this.curvesWrapper.MouseDown += new System.Windows.Forms.MouseEventHandler(this.curvesWrapper_MouseDown);
            this.curvesWrapper.MouseMove += new System.Windows.Forms.MouseEventHandler(this.curvesWrapper_MouseMove);
            this.curvesWrapper.MouseUp += new System.Windows.Forms.MouseEventHandler(this.curvesWrapper_MouseUp);
            // 
            // mainImageWrapper
            // 
            this.mainImageWrapper.Location = new System.Drawing.Point(674, 16);
            this.mainImageWrapper.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainImageWrapper.Name = "mainImageWrapper";
            this.mainImageWrapper.Size = new System.Drawing.Size(366, 267);
            this.mainImageWrapper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mainImageWrapper.TabIndex = 1;
            this.mainImageWrapper.TabStop = false;
            // 
            // cyanWrapper
            // 
            this.cyanWrapper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cyanWrapper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cyanWrapper.Location = new System.Drawing.Point(23, 29);
            this.cyanWrapper.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cyanWrapper.Name = "cyanWrapper";
            this.cyanWrapper.Size = new System.Drawing.Size(137, 79);
            this.cyanWrapper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cyanWrapper.TabIndex = 2;
            this.cyanWrapper.TabStop = false;
            this.cyanWrapper.Click += new System.EventHandler(this.cyanWrapper_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.blackRadioButton);
            this.groupBox1.Controls.Add(this.yellowRadioButton);
            this.groupBox1.Controls.Add(this.magentaRadioButton);
            this.groupBox1.Controls.Add(this.cyanRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(14, 603);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(138, 185);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select curve";
            // 
            // blackRadioButton
            // 
            this.blackRadioButton.AutoSize = true;
            this.blackRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.blackRadioButton.Location = new System.Drawing.Point(18, 127);
            this.blackRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.blackRadioButton.Name = "blackRadioButton";
            this.blackRadioButton.Size = new System.Drawing.Size(88, 24);
            this.blackRadioButton.TabIndex = 3;
            this.blackRadioButton.Text = "(K) Black";
            this.blackRadioButton.UseVisualStyleBackColor = true;
            this.blackRadioButton.CheckedChanged += new System.EventHandler(this.blackRadioButton_CheckedChanged);
            // 
            // yellowRadioButton
            // 
            this.yellowRadioButton.AutoSize = true;
            this.yellowRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yellowRadioButton.Location = new System.Drawing.Point(18, 93);
            this.yellowRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.yellowRadioButton.Name = "yellowRadioButton";
            this.yellowRadioButton.Size = new System.Drawing.Size(73, 24);
            this.yellowRadioButton.TabIndex = 2;
            this.yellowRadioButton.Text = "Yellow";
            this.yellowRadioButton.UseVisualStyleBackColor = true;
            this.yellowRadioButton.CheckedChanged += new System.EventHandler(this.yellowRadioButton_CheckedChanged);
            // 
            // magentaRadioButton
            // 
            this.magentaRadioButton.AutoSize = true;
            this.magentaRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.magentaRadioButton.Location = new System.Drawing.Point(18, 60);
            this.magentaRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.magentaRadioButton.Name = "magentaRadioButton";
            this.magentaRadioButton.Size = new System.Drawing.Size(89, 24);
            this.magentaRadioButton.TabIndex = 1;
            this.magentaRadioButton.Text = "Magenta";
            this.magentaRadioButton.UseVisualStyleBackColor = true;
            this.magentaRadioButton.CheckedChanged += new System.EventHandler(this.magentaRadioButton_CheckedChanged);
            // 
            // cyanRadioButton
            // 
            this.cyanRadioButton.AutoSize = true;
            this.cyanRadioButton.Checked = true;
            this.cyanRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cyanRadioButton.Location = new System.Drawing.Point(18, 27);
            this.cyanRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cyanRadioButton.Name = "cyanRadioButton";
            this.cyanRadioButton.Size = new System.Drawing.Size(62, 24);
            this.cyanRadioButton.TabIndex = 0;
            this.cyanRadioButton.TabStop = true;
            this.cyanRadioButton.Text = "Cyan";
            this.cyanRadioButton.UseVisualStyleBackColor = true;
            this.cyanRadioButton.CheckedChanged += new System.EventHandler(this.cyanRadioButton_CheckedChanged);
            // 
            // magentaWrapper
            // 
            this.magentaWrapper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.magentaWrapper.Location = new System.Drawing.Point(199, 29);
            this.magentaWrapper.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.magentaWrapper.Name = "magentaWrapper";
            this.magentaWrapper.Size = new System.Drawing.Size(137, 80);
            this.magentaWrapper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.magentaWrapper.TabIndex = 4;
            this.magentaWrapper.TabStop = false;
            this.magentaWrapper.Click += new System.EventHandler(this.magentaWrapper_Click);
            // 
            // yellowWrapper
            // 
            this.yellowWrapper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yellowWrapper.Location = new System.Drawing.Point(23, 148);
            this.yellowWrapper.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.yellowWrapper.Name = "yellowWrapper";
            this.yellowWrapper.Size = new System.Drawing.Size(137, 80);
            this.yellowWrapper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.yellowWrapper.TabIndex = 5;
            this.yellowWrapper.TabStop = false;
            this.yellowWrapper.Click += new System.EventHandler(this.yellowWrapper_Click);
            // 
            // blackWrapper
            // 
            this.blackWrapper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.blackWrapper.Location = new System.Drawing.Point(199, 148);
            this.blackWrapper.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.blackWrapper.Name = "blackWrapper";
            this.blackWrapper.Size = new System.Drawing.Size(137, 80);
            this.blackWrapper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.blackWrapper.TabIndex = 6;
            this.blackWrapper.TabStop = false;
            this.blackWrapper.Click += new System.EventHandler(this.blackWrapper_Click);
            // 
            // resultImageWrapper
            // 
            this.resultImageWrapper.Location = new System.Drawing.Point(674, 328);
            this.resultImageWrapper.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.resultImageWrapper.Name = "resultImageWrapper";
            this.resultImageWrapper.Size = new System.Drawing.Size(366, 267);
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
            this.groupBox2.Location = new System.Drawing.Point(1087, 16);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(366, 267);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CMYK preview";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(199, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 28);
            this.label7.TabIndex = 10;
            this.label7.Text = "(K) Black";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(23, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 28);
            this.label6.TabIndex = 9;
            this.label6.Text = "Yellow";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(199, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 31);
            this.label5.TabIndex = 8;
            this.label5.Text = "Magenta";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(23, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cyan";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // currentColorImageWrapper
            // 
            this.currentColorImageWrapper.Location = new System.Drawing.Point(1087, 328);
            this.currentColorImageWrapper.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.currentColorImageWrapper.Name = "currentColorImageWrapper";
            this.currentColorImageWrapper.Size = new System.Drawing.Size(366, 267);
            this.currentColorImageWrapper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.currentColorImageWrapper.TabIndex = 9;
            this.currentColorImageWrapper.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(674, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Original image";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(674, 603);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(366, 31);
            this.label2.TabIndex = 11;
            this.label2.Text = "Result image";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(1087, 599);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(366, 31);
            this.label3.TabIndex = 12;
            this.label3.Text = "Current curve image";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.blackWhiteCheckbox);
            this.groupBox3.Controls.Add(this.saveImageButton);
            this.groupBox3.Controls.Add(this.importImageButton);
            this.groupBox3.Location = new System.Drawing.Point(502, 603);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(151, 185);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Image options";
            // 
            // blackWhiteCheckbox
            // 
            this.blackWhiteCheckbox.AutoSize = true;
            this.blackWhiteCheckbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.blackWhiteCheckbox.Location = new System.Drawing.Point(19, 29);
            this.blackWhiteCheckbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.blackWhiteCheckbox.Name = "blackWhiteCheckbox";
            this.blackWhiteCheckbox.Size = new System.Drawing.Size(135, 24);
            this.blackWhiteCheckbox.TabIndex = 2;
            this.blackWhiteCheckbox.Text = "Black and white";
            this.blackWhiteCheckbox.UseVisualStyleBackColor = true;
            this.blackWhiteCheckbox.CheckedChanged += new System.EventHandler(this.blackWhiteCheckbox_CheckedChanged);
            // 
            // saveImageButton
            // 
            this.saveImageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveImageButton.Location = new System.Drawing.Point(7, 121);
            this.saveImageButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveImageButton.Name = "saveImageButton";
            this.saveImageButton.Size = new System.Drawing.Size(137, 35);
            this.saveImageButton.TabIndex = 1;
            this.saveImageButton.Text = "Save image";
            this.saveImageButton.UseVisualStyleBackColor = true;
            this.saveImageButton.Click += new System.EventHandler(this.saveImageButton_Click);
            // 
            // importImageButton
            // 
            this.importImageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.importImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importImageButton.Location = new System.Drawing.Point(7, 79);
            this.importImageButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.importImageButton.Name = "importImageButton";
            this.importImageButton.Size = new System.Drawing.Size(137, 35);
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
            this.groupBox4.Location = new System.Drawing.Point(169, 603);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(151, 185);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Curve options";
            // 
            // importCurvesButton
            // 
            this.importCurvesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.importCurvesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importCurvesButton.Location = new System.Drawing.Point(7, 79);
            this.importCurvesButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.importCurvesButton.Name = "importCurvesButton";
            this.importCurvesButton.Size = new System.Drawing.Size(137, 35);
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
            this.showAllCurvesCheckbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showAllCurvesCheckbox.Location = new System.Drawing.Point(22, 29);
            this.showAllCurvesCheckbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.showAllCurvesCheckbox.Name = "showAllCurvesCheckbox";
            this.showAllCurvesCheckbox.Size = new System.Drawing.Size(132, 24);
            this.showAllCurvesCheckbox.TabIndex = 2;
            this.showAllCurvesCheckbox.Text = "Show all curves";
            this.showAllCurvesCheckbox.UseVisualStyleBackColor = true;
            this.showAllCurvesCheckbox.CheckedChanged += new System.EventHandler(this.showAllCurvesCheckbox_CheckedChanged);
            // 
            // saveCurvesButton
            // 
            this.saveCurvesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveCurvesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveCurvesButton.Location = new System.Drawing.Point(7, 121);
            this.saveCurvesButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveCurvesButton.Name = "saveCurvesButton";
            this.saveCurvesButton.Size = new System.Drawing.Size(137, 35);
            this.saveCurvesButton.TabIndex = 1;
            this.saveCurvesButton.Text = "Save curves";
            this.saveCurvesButton.UseVisualStyleBackColor = true;
            this.saveCurvesButton.Click += new System.EventHandler(this.saveCurvesButton_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.hundredPercentBlackButton);
            this.groupBox5.Controls.Add(this.ucrButton);
            this.groupBox5.Controls.Add(this.zeroPercentBlackButton);
            this.groupBox5.Controls.Add(this.gcrButton);
            this.groupBox5.Location = new System.Drawing.Point(336, 603);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Size = new System.Drawing.Size(151, 185);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Predefined curves";
            // 
            // hundredPercentBlackButton
            // 
            this.hundredPercentBlackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hundredPercentBlackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hundredPercentBlackButton.Location = new System.Drawing.Point(7, 20);
            this.hundredPercentBlackButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hundredPercentBlackButton.Name = "hundredPercentBlackButton";
            this.hundredPercentBlackButton.Size = new System.Drawing.Size(137, 35);
            this.hundredPercentBlackButton.TabIndex = 4;
            this.hundredPercentBlackButton.Text = "100% black";
            this.hundredPercentBlackButton.UseVisualStyleBackColor = true;
            this.hundredPercentBlackButton.Click += new System.EventHandler(this.hundredPercentBlackButton_Click);
            // 
            // ucrButton
            // 
            this.ucrButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucrButton.Enabled = false;
            this.ucrButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ucrButton.Location = new System.Drawing.Point(7, 100);
            this.ucrButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucrButton.Name = "ucrButton";
            this.ucrButton.Size = new System.Drawing.Size(137, 35);
            this.ucrButton.TabIndex = 3;
            this.ucrButton.Text = "UCR";
            this.ucrButton.UseVisualStyleBackColor = true;
            this.ucrButton.Click += new System.EventHandler(this.ucrButton_Click);
            // 
            // zeroPercentBlackButton
            // 
            this.zeroPercentBlackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.zeroPercentBlackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zeroPercentBlackButton.Location = new System.Drawing.Point(7, 60);
            this.zeroPercentBlackButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.zeroPercentBlackButton.Name = "zeroPercentBlackButton";
            this.zeroPercentBlackButton.Size = new System.Drawing.Size(137, 35);
            this.zeroPercentBlackButton.TabIndex = 3;
            this.zeroPercentBlackButton.Text = "0% black";
            this.zeroPercentBlackButton.UseVisualStyleBackColor = true;
            this.zeroPercentBlackButton.Click += new System.EventHandler(this.zeroPercentBlackButton_Click);
            // 
            // gcrButton
            // 
            this.gcrButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gcrButton.Enabled = false;
            this.gcrButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gcrButton.Location = new System.Drawing.Point(7, 143);
            this.gcrButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcrButton.Name = "gcrButton";
            this.gcrButton.Size = new System.Drawing.Size(137, 35);
            this.gcrButton.TabIndex = 1;
            this.gcrButton.Text = "GCR";
            this.gcrButton.UseVisualStyleBackColor = true;
            this.gcrButton.Click += new System.EventHandler(this.gcrButton_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.reduceButton);
            this.groupBox6.Controls.Add(this.kLabel);
            this.groupBox6.Controls.Add(this.kSlider);
            this.groupBox6.Location = new System.Drawing.Point(674, 630);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(157, 158);
            this.groupBox6.TabIndex = 18;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Popularity algorithm settings";
            this.groupBox6.Enter += new System.EventHandler(this.groupBox6_Enter);
            // 
            // reduceButton
            // 
            this.reduceButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reduceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reduceButton.Location = new System.Drawing.Point(6, 115);
            this.reduceButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.reduceButton.Name = "reduceButton";
            this.reduceButton.Size = new System.Drawing.Size(137, 35);
            this.reduceButton.TabIndex = 2;
            this.reduceButton.Text = "Reduce";
            this.reduceButton.UseVisualStyleBackColor = true;
            this.reduceButton.Click += new System.EventHandler(this.reduceButton_Click);
            // 
            // kLabel
            // 
            this.kLabel.Location = new System.Drawing.Point(6, 83);
            this.kLabel.Name = "kLabel";
            this.kLabel.Size = new System.Drawing.Size(137, 25);
            this.kLabel.TabIndex = 1;
            this.kLabel.Text = "K: 16";
            this.kLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kSlider
            // 
            this.kSlider.LargeChange = 8;
            this.kSlider.Location = new System.Drawing.Point(6, 45);
            this.kSlider.Maximum = 80;
            this.kSlider.Minimum = 8;
            this.kSlider.Name = "kSlider";
            this.kSlider.Size = new System.Drawing.Size(137, 56);
            this.kSlider.SmallChange = 8;
            this.kSlider.TabIndex = 1;
            this.kSlider.TickFrequency = 8;
            this.kSlider.Value = 16;
            this.kSlider.Scroll += new System.EventHandler(this.kSlider_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1469, 793);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1487, 840);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1487, 840);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RGB -> CMYK";
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
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kSlider)).EndInit();
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
        private GroupBox groupBox5;
        private Button hundredPercentBlackButton;
        private Button ucrButton;
        private Button zeroPercentBlackButton;
        private Button gcrButton;
        private GroupBox groupBox6;
        private Label kLabel;
        private TrackBar kSlider;
        private Button reduceButton;
    }
}