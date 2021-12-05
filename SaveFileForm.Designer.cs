using System.Windows.Forms;

namespace gk_p3
{
    partial class SaveFileForm
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
            this.cyanWrapper = new System.Windows.Forms.PictureBox();
            this.magentaWrapper = new System.Windows.Forms.PictureBox();
            this.yellowWrapper = new System.Windows.Forms.PictureBox();
            this.blackWrapper = new System.Windows.Forms.PictureBox();
            this.resultImageWrapper = new System.Windows.Forms.PictureBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.yellowLabel = new System.Windows.Forms.Label();
            this.blackLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cyanWrapper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magentaWrapper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowWrapper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackWrapper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultImageWrapper)).BeginInit();
            this.SuspendLayout();
            // 
            // cyanWrapper
            // 
            this.cyanWrapper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cyanWrapper.Location = new System.Drawing.Point(16, 51);
            this.cyanWrapper.Name = "cyanWrapper";
            this.cyanWrapper.Size = new System.Drawing.Size(250, 130);
            this.cyanWrapper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cyanWrapper.TabIndex = 2;
            this.cyanWrapper.TabStop = false;
            this.cyanWrapper.Click += new System.EventHandler(this.cyanWrapper_Click);
            // 
            // magentaWrapper
            // 
            this.magentaWrapper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.magentaWrapper.Location = new System.Drawing.Point(282, 51);
            this.magentaWrapper.Name = "magentaWrapper";
            this.magentaWrapper.Size = new System.Drawing.Size(250, 130);
            this.magentaWrapper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.magentaWrapper.TabIndex = 3;
            this.magentaWrapper.TabStop = false;
            this.magentaWrapper.Click += new System.EventHandler(this.magentaWrapper_Click);
            // 
            // yellowWrapper
            // 
            this.yellowWrapper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yellowWrapper.Location = new System.Drawing.Point(16, 214);
            this.yellowWrapper.Name = "yellowWrapper";
            this.yellowWrapper.Size = new System.Drawing.Size(250, 130);
            this.yellowWrapper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.yellowWrapper.TabIndex = 4;
            this.yellowWrapper.TabStop = false;
            this.yellowWrapper.Click += new System.EventHandler(this.yellowWrapper_Click);
            // 
            // blackWrapper
            // 
            this.blackWrapper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.blackWrapper.Location = new System.Drawing.Point(282, 214);
            this.blackWrapper.Name = "blackWrapper";
            this.blackWrapper.Size = new System.Drawing.Size(250, 130);
            this.blackWrapper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.blackWrapper.TabIndex = 5;
            this.blackWrapper.TabStop = false;
            this.blackWrapper.Click += new System.EventHandler(this.blackWrapper_Click);
            // 
            // resultImageWrapper
            // 
            this.resultImageWrapper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.resultImageWrapper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resultImageWrapper.Location = new System.Drawing.Point(149, 383);
            this.resultImageWrapper.Name = "resultImageWrapper";
            this.resultImageWrapper.Size = new System.Drawing.Size(250, 130);
            this.resultImageWrapper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.resultImageWrapper.TabIndex = 6;
            this.resultImageWrapper.TabStop = false;
            this.resultImageWrapper.Click += new System.EventHandler(this.resultImageWrapper_Click);
            // 
            // saveButton
            // 
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.Location = new System.Drawing.Point(324, 558);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(135, 41);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cyan";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(282, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Magenta";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // yellowLabel
            // 
            this.yellowLabel.Location = new System.Drawing.Point(16, 347);
            this.yellowLabel.Name = "yellowLabel";
            this.yellowLabel.Size = new System.Drawing.Size(250, 23);
            this.yellowLabel.TabIndex = 13;
            this.yellowLabel.Text = "Yellow";
            this.yellowLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // blackLabel
            // 
            this.blackLabel.Location = new System.Drawing.Point(282, 347);
            this.blackLabel.Name = "blackLabel";
            this.blackLabel.Size = new System.Drawing.Size(250, 23);
            this.blackLabel.TabIndex = 14;
            this.blackLabel.Text = "(K) Black";
            this.blackLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(149, 516);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "Result image";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cancelButton
            // 
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.Location = new System.Drawing.Point(79, 558);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(135, 41);
            this.cancelButton.TabIndex = 16;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(16, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(516, 36);
            this.label3.TabIndex = 17;
            this.label3.Text = "Click image and click `Save` button";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SaveFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 611);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.blackLabel);
            this.Controls.Add(this.yellowLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.resultImageWrapper);
            this.Controls.Add(this.blackWrapper);
            this.Controls.Add(this.yellowWrapper);
            this.Controls.Add(this.magentaWrapper);
            this.Controls.Add(this.cyanWrapper);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(560, 650);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(560, 650);
            this.Name = "SaveFileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Save image";
            ((System.ComponentModel.ISupportInitialize)(this.cyanWrapper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magentaWrapper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowWrapper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackWrapper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultImageWrapper)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox cyanWrapper;
        private PictureBox magentaWrapper;
        private PictureBox yellowWrapper;
        private PictureBox blackWrapper;
        private PictureBox resultImageWrapper;
        private Button saveButton;
        private Label label1;
        private Label label2;
        private Label yellowLabel;
        private Label blackLabel;
        private Label label5;
        private Button cancelButton;
        private Label label3;
    }
}