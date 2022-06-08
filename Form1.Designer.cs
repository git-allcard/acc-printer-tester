﻿namespace AllcardPrinter
{
    partial class Form1
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
            this.btnFeed = new System.Windows.Forms.Button();
            this.txtTrack1 = new System.Windows.Forms.TextBox();
            this.txtTrack2 = new System.Windows.Forms.TextBox();
            this.txtTrack3 = new System.Windows.Forms.TextBox();
            this.btnEject = new System.Windows.Forms.Button();
            this.btnReadMag = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblPrinterCounter = new System.Windows.Forms.Label();
            this.lblPrinterSerial = new System.Windows.Forms.Label();
            this.btnInit = new System.Windows.Forms.Button();
            this.grpMagstripe = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpPrint = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrinterName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.grpMagstripe.SuspendLayout();
            this.grpPrint.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFeed
            // 
            this.btnFeed.Enabled = false;
            this.btnFeed.Location = new System.Drawing.Point(129, 46);
            this.btnFeed.Name = "btnFeed";
            this.btnFeed.Size = new System.Drawing.Size(99, 34);
            this.btnFeed.TabIndex = 0;
            this.btnFeed.Text = "Feed Card";
            this.btnFeed.UseVisualStyleBackColor = true;
            this.btnFeed.Click += new System.EventHandler(this.btnFeed_Click);
            // 
            // txtTrack1
            // 
            this.txtTrack1.Location = new System.Drawing.Point(102, 21);
            this.txtTrack1.Name = "txtTrack1";
            this.txtTrack1.Size = new System.Drawing.Size(378, 20);
            this.txtTrack1.TabIndex = 1;
            // 
            // txtTrack2
            // 
            this.txtTrack2.Location = new System.Drawing.Point(102, 49);
            this.txtTrack2.Name = "txtTrack2";
            this.txtTrack2.Size = new System.Drawing.Size(378, 20);
            this.txtTrack2.TabIndex = 2;
            // 
            // txtTrack3
            // 
            this.txtTrack3.Location = new System.Drawing.Point(102, 77);
            this.txtTrack3.Name = "txtTrack3";
            this.txtTrack3.Size = new System.Drawing.Size(378, 20);
            this.txtTrack3.TabIndex = 3;
            // 
            // btnEject
            // 
            this.btnEject.Enabled = false;
            this.btnEject.Location = new System.Drawing.Point(234, 46);
            this.btnEject.Name = "btnEject";
            this.btnEject.Size = new System.Drawing.Size(99, 34);
            this.btnEject.TabIndex = 4;
            this.btnEject.Text = "Eject Card";
            this.btnEject.UseVisualStyleBackColor = true;
            this.btnEject.Click += new System.EventHandler(this.btnEject_Click);
            // 
            // btnReadMag
            // 
            this.btnReadMag.Location = new System.Drawing.Point(27, 109);
            this.btnReadMag.Name = "btnReadMag";
            this.btnReadMag.Size = new System.Drawing.Size(118, 34);
            this.btnReadMag.TabIndex = 5;
            this.btnReadMag.Text = "Read";
            this.btnReadMag.UseVisualStyleBackColor = true;
            this.btnReadMag.Click += new System.EventHandler(this.btnReadMag_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(151, 109);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(118, 34);
            this.btnWrite.TabIndex = 6;
            this.btnWrite.Text = "Write";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPrinterName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.lblPrinterCounter);
            this.groupBox1.Controls.Add(this.lblPrinterSerial);
            this.groupBox1.Controls.Add(this.btnInit);
            this.groupBox1.Controls.Add(this.btnFeed);
            this.groupBox1.Controls.Add(this.btnEject);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 129);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PRINTER";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(275, 109);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 34);
            this.button2.TabIndex = 10;
            this.button2.Text = "Run Command";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(339, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 34);
            this.button1.TabIndex = 12;
            this.button1.Text = "Printer Job";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblPrinterCounter
            // 
            this.lblPrinterCounter.AutoSize = true;
            this.lblPrinterCounter.Location = new System.Drawing.Point(25, 105);
            this.lblPrinterCounter.Name = "lblPrinterCounter";
            this.lblPrinterCounter.Size = new System.Drawing.Size(100, 13);
            this.lblPrinterCounter.TabIndex = 11;
            this.lblPrinterCounter.Text = "Printer Counter:";
            // 
            // lblPrinterSerial
            // 
            this.lblPrinterSerial.AutoSize = true;
            this.lblPrinterSerial.Location = new System.Drawing.Point(24, 87);
            this.lblPrinterSerial.Name = "lblPrinterSerial";
            this.lblPrinterSerial.Size = new System.Drawing.Size(87, 13);
            this.lblPrinterSerial.TabIndex = 10;
            this.lblPrinterSerial.Text = "Printer Serial:";
            // 
            // btnInit
            // 
            this.btnInit.Location = new System.Drawing.Point(24, 46);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(99, 34);
            this.btnInit.TabIndex = 5;
            this.btnInit.Text = "Initialize";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // grpMagstripe
            // 
            this.grpMagstripe.Controls.Add(this.button2);
            this.grpMagstripe.Controls.Add(this.label3);
            this.grpMagstripe.Controls.Add(this.label2);
            this.grpMagstripe.Controls.Add(this.label1);
            this.grpMagstripe.Controls.Add(this.txtTrack1);
            this.grpMagstripe.Controls.Add(this.txtTrack2);
            this.grpMagstripe.Controls.Add(this.btnWrite);
            this.grpMagstripe.Controls.Add(this.txtTrack3);
            this.grpMagstripe.Controls.Add(this.btnReadMag);
            this.grpMagstripe.Enabled = false;
            this.grpMagstripe.Location = new System.Drawing.Point(12, 147);
            this.grpMagstripe.Name = "grpMagstripe";
            this.grpMagstripe.Size = new System.Drawing.Size(511, 159);
            this.grpMagstripe.TabIndex = 8;
            this.grpMagstripe.TabStop = false;
            this.grpMagstripe.Text = "MAGSTRIPE/ COMMANDS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Track 3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Track 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Track 1";
            // 
            // grpPrint
            // 
            this.grpPrint.Controls.Add(this.label6);
            this.grpPrint.Controls.Add(this.txtName);
            this.grpPrint.Controls.Add(this.btnPreview);
            this.grpPrint.Controls.Add(this.btnPrint);
            this.grpPrint.Location = new System.Drawing.Point(12, 312);
            this.grpPrint.Name = "grpPrint";
            this.grpPrint.Size = new System.Drawing.Size(511, 113);
            this.grpPrint.TabIndex = 10;
            this.grpPrint.TabStop = false;
            this.grpPrint.Text = "PRINTING";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(102, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(378, 20);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "JUAN DELA CRUZ";
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(151, 63);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(118, 34);
            this.btnPreview.TabIndex = 6;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(27, 63);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(118, 34);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // rtbLog
            // 
            this.rtbLog.Location = new System.Drawing.Point(12, 431);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ReadOnly = true;
            this.rtbLog.Size = new System.Drawing.Size(511, 69);
            this.rtbLog.TabIndex = 11;
            this.rtbLog.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Printer:";
            // 
            // txtPrinterName
            // 
            this.txtPrinterName.Location = new System.Drawing.Point(102, 20);
            this.txtPrinterName.Name = "txtPrinterName";
            this.txtPrinterName.Size = new System.Drawing.Size(378, 20);
            this.txtPrinterName.TabIndex = 11;
            this.txtPrinterName.Text = "Evolis Zenius";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 518);
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.grpPrint);
            this.Controls.Add(this.grpMagstripe);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ALLCARD EVOLIS PRINTER";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpMagstripe.ResumeLayout(false);
            this.grpMagstripe.PerformLayout();
            this.grpPrint.ResumeLayout(false);
            this.grpPrint.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFeed;
        private System.Windows.Forms.TextBox txtTrack1;
        private System.Windows.Forms.TextBox txtTrack2;
        private System.Windows.Forms.TextBox txtTrack3;
        private System.Windows.Forms.Button btnEject;
        private System.Windows.Forms.Button btnReadMag;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.GroupBox grpMagstripe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpPrint;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.Label lblPrinterCounter;
        private System.Windows.Forms.Label lblPrinterSerial;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtPrinterName;
        private System.Windows.Forms.Label label4;
    }
}

