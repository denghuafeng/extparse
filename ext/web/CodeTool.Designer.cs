namespace web
{
    partial class CodeTool
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
            this.TB_FilePath = new System.Windows.Forms.TextBox();
            this.TB_FileExts = new System.Windows.Forms.TextBox();
            this.BT_TrimCode = new System.Windows.Forms.Button();
            this.BT_FilePath = new System.Windows.Forms.Button();
            this.LB_FileInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TB_FilePath
            // 
            this.TB_FilePath.Location = new System.Drawing.Point(12, 12);
            this.TB_FilePath.Name = "TB_FilePath";
            this.TB_FilePath.ReadOnly = true;
            this.TB_FilePath.Size = new System.Drawing.Size(240, 21);
            this.TB_FilePath.TabIndex = 0;
            // 
            // TB_FileExts
            // 
            this.TB_FileExts.Location = new System.Drawing.Point(12, 39);
            this.TB_FileExts.Multiline = true;
            this.TB_FileExts.Name = "TB_FileExts";
            this.TB_FileExts.Size = new System.Drawing.Size(268, 96);
            this.TB_FileExts.TabIndex = 2;
            this.TB_FileExts.Text = ".aspx\r\n.ascx";
            // 
            // BT_TrimCode
            // 
            this.BT_TrimCode.Location = new System.Drawing.Point(205, 141);
            this.BT_TrimCode.Name = "BT_TrimCode";
            this.BT_TrimCode.Size = new System.Drawing.Size(75, 23);
            this.BT_TrimCode.TabIndex = 3;
            this.BT_TrimCode.Text = "Ñ¹Ëõ(&T)";
            this.BT_TrimCode.UseVisualStyleBackColor = true;
            this.BT_TrimCode.Click += new System.EventHandler(this.BT_TrimCode_Click);
            // 
            // BT_FilePath
            // 
            this.BT_FilePath.BackColor = System.Drawing.Color.Transparent;
            this.BT_FilePath.FlatAppearance.BorderSize = 0;
            this.BT_FilePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_FilePath.Image = global::web.Properties.Resources.Edit;
            this.BT_FilePath.Location = new System.Drawing.Point(258, 12);
            this.BT_FilePath.Name = "BT_FilePath";
            this.BT_FilePath.Size = new System.Drawing.Size(21, 21);
            this.BT_FilePath.TabIndex = 1;
            this.BT_FilePath.UseVisualStyleBackColor = false;
            this.BT_FilePath.Click += new System.EventHandler(this.BT_FilePath_Click);
            // 
            // LB_FileInfo
            // 
            this.LB_FileInfo.AutoSize = true;
            this.LB_FileInfo.Location = new System.Drawing.Point(12, 150);
            this.LB_FileInfo.Name = "LB_FileInfo";
            this.LB_FileInfo.Size = new System.Drawing.Size(0, 12);
            this.LB_FileInfo.TabIndex = 4;
            // 
            // CodeTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 178);
            this.Controls.Add(this.LB_FileInfo);
            this.Controls.Add(this.BT_TrimCode);
            this.Controls.Add(this.TB_FileExts);
            this.Controls.Add(this.BT_FilePath);
            this.Controls.Add(this.TB_FilePath);
            this.Name = "CodeTool";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_FilePath;
        private System.Windows.Forms.Button BT_FilePath;
        private System.Windows.Forms.TextBox TB_FileExts;
        private System.Windows.Forms.Button BT_TrimCode;
        private System.Windows.Forms.Label LB_FileInfo;
    }
}

