namespace KISSlicerPlugin
{
    partial class SetupPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbExe = new System.Windows.Forms.TextBox();
            this.tbGcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.btSelectKiss = new System.Windows.Forms.Button();
            this.btSelectGcode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path to KISSlicer:";
            // 
            // tbExe
            // 
            this.tbExe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbExe.Location = new System.Drawing.Point(136, 1);
            this.tbExe.Name = "tbExe";
            this.tbExe.Size = new System.Drawing.Size(303, 20);
            this.tbExe.TabIndex = 1;
            // 
            // tbGcode
            // 
            this.tbGcode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbGcode.Location = new System.Drawing.Point(136, 39);
            this.tbGcode.Name = "tbGcode";
            this.tbGcode.Size = new System.Drawing.Size(303, 20);
            this.tbGcode.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Output gcode file";
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.Location = new System.Drawing.Point(445, 124);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // btSelectKiss
            // 
            this.btSelectKiss.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSelectKiss.Location = new System.Drawing.Point(445, 0);
            this.btSelectKiss.Name = "btSelectKiss";
            this.btSelectKiss.Size = new System.Drawing.Size(75, 23);
            this.btSelectKiss.TabIndex = 5;
            this.btSelectKiss.Text = "Select";
            this.btSelectKiss.UseVisualStyleBackColor = true;
            this.btSelectKiss.Click += new System.EventHandler(this.btSelectKiss_Click);
            // 
            // btSelectGcode
            // 
            this.btSelectGcode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSelectGcode.Location = new System.Drawing.Point(445, 37);
            this.btSelectGcode.Name = "btSelectGcode";
            this.btSelectGcode.Size = new System.Drawing.Size(75, 23);
            this.btSelectGcode.TabIndex = 6;
            this.btSelectGcode.Text = "Select";
            this.btSelectGcode.UseVisualStyleBackColor = true;
            this.btSelectGcode.Click += new System.EventHandler(this.btSelectGcode_Click);
            // 
            // SetupPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.btSelectGcode);
            this.Controls.Add(this.btSelectKiss);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.tbGcode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbExe);
            this.Controls.Add(this.label1);
            this.Name = "SetupPanel";
            this.Size = new System.Drawing.Size(530, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbExe;
        private System.Windows.Forms.TextBox tbGcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button btSelectKiss;
        private System.Windows.Forms.Button btSelectGcode;
    }
}
