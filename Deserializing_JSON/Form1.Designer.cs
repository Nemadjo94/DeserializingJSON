namespace Deserializing_JSON
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.jsonInputBox = new System.Windows.Forms.TextBox();
            this.boban = new System.Windows.Forms.Button();
            this.clearDebug = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.jsonOutputBox = new System.Windows.Forms.TextBox();
            this.cmdClearInput = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.jsonInputBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Raw JSON (Serialized String)";
            // 
            // jsonInputBox
            // 
            this.jsonInputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.jsonInputBox.Location = new System.Drawing.Point(0, 19);
            this.jsonInputBox.MaxLength = 32767000;
            this.jsonInputBox.Multiline = true;
            this.jsonInputBox.Name = "jsonInputBox";
            this.jsonInputBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.jsonInputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.jsonInputBox.Size = new System.Drawing.Size(776, 81);
            this.jsonInputBox.TabIndex = 0;
            this.jsonInputBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // boban
            // 
            this.boban.Location = new System.Drawing.Point(12, 118);
            this.boban.Name = "boban";
            this.boban.Size = new System.Drawing.Size(75, 23);
            this.boban.TabIndex = 1;
            this.boban.Text = "Deserialize";
            this.boban.UseVisualStyleBackColor = true;
            this.boban.Click += new System.EventHandler(this.deserialize_Click_1);
            // 
            // clearDebug
            // 
            this.clearDebug.Location = new System.Drawing.Point(174, 118);
            this.clearDebug.Name = "clearDebug";
            this.clearDebug.Size = new System.Drawing.Size(75, 23);
            this.clearDebug.TabIndex = 2;
            this.clearDebug.Text = "Clear Debug";
            this.clearDebug.UseVisualStyleBackColor = true;
            this.clearDebug.Click += new System.EventHandler(this.clearDebug_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.jsonOutputBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 169);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Debug Output";
            // 
            // jsonOutputBox
            // 
            this.jsonOutputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.jsonOutputBox.Location = new System.Drawing.Point(0, 19);
            this.jsonOutputBox.MaxLength = 32000;
            this.jsonOutputBox.Multiline = true;
            this.jsonOutputBox.Name = "jsonOutputBox";
            this.jsonOutputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.jsonOutputBox.Size = new System.Drawing.Size(776, 150);
            this.jsonOutputBox.TabIndex = 1;
            this.jsonOutputBox.TextChanged += new System.EventHandler(this.jsonOutputBox_TextChanged);
            // 
            // cmdClearInput
            // 
            this.cmdClearInput.Location = new System.Drawing.Point(93, 118);
            this.cmdClearInput.Name = "cmdClearInput";
            this.cmdClearInput.Size = new System.Drawing.Size(75, 23);
            this.cmdClearInput.TabIndex = 3;
            this.cmdClearInput.Text = "Clear Input";
            this.cmdClearInput.UseVisualStyleBackColor = true;
            this.cmdClearInput.Click += new System.EventHandler(this.cmdClearInput_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 344);
            this.Controls.Add(this.cmdClearInput);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.clearDebug);
            this.Controls.Add(this.boban);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "JSON Parser";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox jsonInputBox;
        private System.Windows.Forms.Button boban;
        private System.Windows.Forms.Button clearDebug;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox jsonOutputBox;
        private System.Windows.Forms.Button cmdClearInput;
    }
}

