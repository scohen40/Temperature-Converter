namespace OOPProgHW1
{
    partial class TemperatureConverterView
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
            this.FahrBackPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.FahrControlsBox = new System.Windows.Forms.GroupBox();
            this.convertFahrButton = new System.Windows.Forms.Button();
            this.convertFahrText = new System.Windows.Forms.TextBox();
            this.CelsBackPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.CelsControlsBox = new System.Windows.Forms.GroupBox();
            this.convertCelsButton = new System.Windows.Forms.Button();
            this.convertCelsText = new System.Windows.Forms.TextBox();
            this.KelvBackPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.KelvControlsBox = new System.Windows.Forms.GroupBox();
            this.convertKelvButton = new System.Windows.Forms.Button();
            this.convertKelvText = new System.Windows.Forms.TextBox();
            this.FahrBackPanel.SuspendLayout();
            this.FahrControlsBox.SuspendLayout();
            this.CelsBackPanel.SuspendLayout();
            this.CelsControlsBox.SuspendLayout();
            this.KelvBackPanel.SuspendLayout();
            this.KelvControlsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // FahrBackPanel
            // 
            this.FahrBackPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.FahrBackPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FahrBackPanel.Controls.Add(this.FahrControlsBox);
            this.FahrBackPanel.Location = new System.Drawing.Point(12, 12);
            this.FahrBackPanel.Name = "FahrBackPanel";
            this.FahrBackPanel.Size = new System.Drawing.Size(185, 131);
            this.FahrBackPanel.TabIndex = 3;
            // 
            // FahrControlsBox
            // 
            this.FahrControlsBox.BackColor = System.Drawing.Color.Silver;
            this.FahrControlsBox.Controls.Add(this.convertFahrButton);
            this.FahrControlsBox.Controls.Add(this.convertFahrText);
            this.FahrControlsBox.Location = new System.Drawing.Point(3, 3);
            this.FahrControlsBox.Name = "FahrControlsBox";
            this.FahrControlsBox.Size = new System.Drawing.Size(175, 119);
            this.FahrControlsBox.TabIndex = 4;
            this.FahrControlsBox.TabStop = false;
            this.FahrControlsBox.Text = "Fahrenheit";
            // 
            // convertFahrButton
            // 
            this.convertFahrButton.Location = new System.Drawing.Point(6, 72);
            this.convertFahrButton.Name = "convertFahrButton";
            this.convertFahrButton.Size = new System.Drawing.Size(75, 23);
            this.convertFahrButton.TabIndex = 1;
            this.convertFahrButton.Text = "convert";
            this.convertFahrButton.UseVisualStyleBackColor = true;
            this.convertFahrButton.Click += new System.EventHandler(this.convertFahrButton_Click);
            // 
            // convertFahrText
            // 
            this.convertFahrText.Location = new System.Drawing.Point(6, 35);
            this.convertFahrText.Name = "convertFahrText";
            this.convertFahrText.Size = new System.Drawing.Size(100, 20);
            this.convertFahrText.TabIndex = 0;
           // this.convertFahrText.TextChanged += new System.EventHandler(this.convertFahrText_TextChanged);
            // 
            // CelsBackPanel
            // 
            this.CelsBackPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.CelsBackPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CelsBackPanel.Controls.Add(this.CelsControlsBox);
            this.CelsBackPanel.Location = new System.Drawing.Point(215, 12);
            this.CelsBackPanel.Name = "CelsBackPanel";
            this.CelsBackPanel.Size = new System.Drawing.Size(185, 131);
            this.CelsBackPanel.TabIndex = 4;
            // 
            // CelsControlsBox
            // 
            this.CelsControlsBox.BackColor = System.Drawing.Color.Silver;
            this.CelsControlsBox.Controls.Add(this.convertCelsButton);
            this.CelsControlsBox.Controls.Add(this.convertCelsText);
            this.CelsControlsBox.Location = new System.Drawing.Point(3, 3);
            this.CelsControlsBox.Name = "CelsControlsBox";
            this.CelsControlsBox.Size = new System.Drawing.Size(175, 119);
            this.CelsControlsBox.TabIndex = 4;
            this.CelsControlsBox.TabStop = false;
            this.CelsControlsBox.Text = "Celcius";
            // 
            // convertCelsButton
            // 
            this.convertCelsButton.Location = new System.Drawing.Point(6, 72);
            this.convertCelsButton.Name = "convertCelsButton";
            this.convertCelsButton.Size = new System.Drawing.Size(75, 23);
            this.convertCelsButton.TabIndex = 1;
            this.convertCelsButton.Text = "convert";
            this.convertCelsButton.UseVisualStyleBackColor = true;
            this.convertCelsButton.Click += new System.EventHandler(this.convertCelsButton_Click);
            // 
            // convertCelsText
            // 
            this.convertCelsText.Location = new System.Drawing.Point(6, 35);
            this.convertCelsText.Name = "convertCelsText";
            this.convertCelsText.Size = new System.Drawing.Size(100, 20);
            this.convertCelsText.TabIndex = 0;
           // this.convertCelsText.TextChanged += new System.EventHandler(this.convertCelsText_TextChanged);
            // 
            // KelvBackPanel
            // 
            this.KelvBackPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.KelvBackPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KelvBackPanel.Controls.Add(this.KelvControlsBox);
            this.KelvBackPanel.Location = new System.Drawing.Point(420, 12);
            this.KelvBackPanel.Name = "KelvBackPanel";
            this.KelvBackPanel.Size = new System.Drawing.Size(185, 131);
            this.KelvBackPanel.TabIndex = 5;
            // 
            // KelvControlsBox
            // 
            this.KelvControlsBox.BackColor = System.Drawing.Color.Silver;
            this.KelvControlsBox.Controls.Add(this.convertKelvButton);
            this.KelvControlsBox.Controls.Add(this.convertKelvText);
            this.KelvControlsBox.Location = new System.Drawing.Point(3, 3);
            this.KelvControlsBox.Name = "KelvControlsBox";
            this.KelvControlsBox.Size = new System.Drawing.Size(175, 119);
            this.KelvControlsBox.TabIndex = 4;
            this.KelvControlsBox.TabStop = false;
            this.KelvControlsBox.Text = "Kelvin";
            // 
            // convertKelvButton
            // 
            this.convertKelvButton.Location = new System.Drawing.Point(6, 72);
            this.convertKelvButton.Name = "convertKelvButton";
            this.convertKelvButton.Size = new System.Drawing.Size(75, 23);
            this.convertKelvButton.TabIndex = 1;
            this.convertKelvButton.Text = "convert";
            this.convertKelvButton.UseVisualStyleBackColor = true;
            this.convertKelvButton.Click += new System.EventHandler(this.convertKelvButton_Click);
            // 
            // convertKelvText
            // 
            this.convertKelvText.Location = new System.Drawing.Point(6, 35);
            this.convertKelvText.Name = "convertKelvText";
            this.convertKelvText.Size = new System.Drawing.Size(100, 20);
            this.convertKelvText.TabIndex = 0;
           // this.convertKelvText.TextChanged += new System.EventHandler(this.convertKelvText_TextChanged);
            // 
            // TemperatureConverterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 158);
            this.Controls.Add(this.KelvBackPanel);
            this.Controls.Add(this.CelsBackPanel);
            this.Controls.Add(this.FahrBackPanel);
            this.Name = "TemperatureConverterView";
            this.Text = "Temperature Converter";
            this.FahrBackPanel.ResumeLayout(false);
            this.FahrControlsBox.ResumeLayout(false);
            this.FahrControlsBox.PerformLayout();
            this.CelsBackPanel.ResumeLayout(false);
            this.CelsControlsBox.ResumeLayout(false);
            this.CelsControlsBox.PerformLayout();
            this.KelvBackPanel.ResumeLayout(false);
            this.KelvControlsBox.ResumeLayout(false);
            this.KelvControlsBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FahrBackPanel;
        private System.Windows.Forms.GroupBox FahrControlsBox;
        private System.Windows.Forms.Button convertFahrButton;
        private System.Windows.Forms.TextBox convertFahrText;
        private System.Windows.Forms.FlowLayoutPanel CelsBackPanel;
        private System.Windows.Forms.GroupBox CelsControlsBox;
        private System.Windows.Forms.Button convertCelsButton;
        private System.Windows.Forms.TextBox convertCelsText;
        private System.Windows.Forms.FlowLayoutPanel KelvBackPanel;
        private System.Windows.Forms.GroupBox KelvControlsBox;
        private System.Windows.Forms.Button convertKelvButton;
        private System.Windows.Forms.TextBox convertKelvText;
    }
}

