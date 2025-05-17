namespace BTRadioControl
{
    partial class BTRadioControlForm
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
            this.btnOFF = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.btnON = new System.Windows.Forms.Button();
            this.btnListDevices = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnBTPanel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOFF
            // 
            this.btnOFF.Location = new System.Drawing.Point(12, 12);
            this.btnOFF.Name = "btnOFF";
            this.btnOFF.Size = new System.Drawing.Size(75, 23);
            this.btnOFF.TabIndex = 0;
            this.btnOFF.Text = "OF&F";
            this.btnOFF.UseVisualStyleBackColor = true;
            this.btnOFF.Click += new System.EventHandler(this.btnOFF_Click);
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.DetectUrls = false;
            this.txtLog.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLog.Location = new System.Drawing.Point(12, 52);
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(1003, 538);
            this.txtLog.TabIndex = 1;
            this.txtLog.Text = "";
            this.txtLog.WordWrap = false;
            // 
            // btnON
            // 
            this.btnON.Location = new System.Drawing.Point(93, 12);
            this.btnON.Name = "btnON";
            this.btnON.Size = new System.Drawing.Size(75, 23);
            this.btnON.TabIndex = 2;
            this.btnON.Text = "O&N";
            this.btnON.UseVisualStyleBackColor = true;
            this.btnON.Click += new System.EventHandler(this.btnON_Click);
            // 
            // btnListDevices
            // 
            this.btnListDevices.Location = new System.Drawing.Point(174, 12);
            this.btnListDevices.Name = "btnListDevices";
            this.btnListDevices.Size = new System.Drawing.Size(75, 23);
            this.btnListDevices.TabIndex = 3;
            this.btnListDevices.Text = "List De&vices";
            this.btnListDevices.UseVisualStyleBackColor = true;
            this.btnListDevices.Click += new System.EventHandler(this.btnListDevices_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(255, 12);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 4;
            this.btnCopy.Text = "&Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnBTPanel
            // 
            this.btnBTPanel.Location = new System.Drawing.Point(336, 12);
            this.btnBTPanel.Name = "btnBTPanel";
            this.btnBTPanel.Size = new System.Drawing.Size(75, 23);
            this.btnBTPanel.TabIndex = 5;
            this.btnBTPanel.Text = "&BT Panel";
            this.btnBTPanel.UseVisualStyleBackColor = true;
            this.btnBTPanel.Click += new System.EventHandler(this.btnBTPanel_Click);
            // 
            // BTRadioControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 602);
            this.Controls.Add(this.btnBTPanel);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnListDevices);
            this.Controls.Add(this.btnON);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnOFF);
            this.Name = "BTRadioControlForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BTRadioControl";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BTRadioControlForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOFF;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.Button btnON;
        private System.Windows.Forms.Button btnListDevices;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnBTPanel;
    }
}

