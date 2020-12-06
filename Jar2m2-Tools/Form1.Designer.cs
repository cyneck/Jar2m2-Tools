namespace WinFormJar2m2
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label_groupId = new System.Windows.Forms.Label();
            this.textBoxGroupId = new System.Windows.Forms.TextBox();
            this.buttonBrowe = new System.Windows.Forms.Button();
            this.label_artifactId = new System.Windows.Forms.Label();
            this.textBoxArtifactId = new System.Windows.Forms.TextBox();
            this.label_version = new System.Windows.Forms.Label();
            this.textBoxVersion = new System.Windows.Forms.TextBox();
            this.label_filePath = new System.Windows.Forms.Label();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.button_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_groupId
            // 
            this.label_groupId.AutoSize = true;
            this.label_groupId.Location = new System.Drawing.Point(34, 52);
            this.label_groupId.Name = "label_groupId";
            this.label_groupId.Size = new System.Drawing.Size(59, 12);
            this.label_groupId.TabIndex = 0;
            this.label_groupId.Text = "groupId：";
            // 
            // textBoxGroupId
            // 
            this.textBoxGroupId.Location = new System.Drawing.Point(135, 49);
            this.textBoxGroupId.Name = "textBoxGroupId";
            this.textBoxGroupId.Size = new System.Drawing.Size(145, 21);
            this.textBoxGroupId.TabIndex = 1;
            // 
            // buttonBrowe
            // 
            this.buttonBrowe.Location = new System.Drawing.Point(278, 177);
            this.buttonBrowe.Name = "buttonBrowe";
            this.buttonBrowe.Size = new System.Drawing.Size(46, 23);
            this.buttonBrowe.TabIndex = 2;
            this.buttonBrowe.Text = "...";
            this.buttonBrowe.UseVisualStyleBackColor = true;
            this.buttonBrowe.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_artifactId
            // 
            this.label_artifactId.AutoSize = true;
            this.label_artifactId.Location = new System.Drawing.Point(35, 96);
            this.label_artifactId.Name = "label_artifactId";
            this.label_artifactId.Size = new System.Drawing.Size(77, 12);
            this.label_artifactId.TabIndex = 3;
            this.label_artifactId.Text = "artifactId：";
            // 
            // textBoxArtifactId
            // 
            this.textBoxArtifactId.Location = new System.Drawing.Point(136, 93);
            this.textBoxArtifactId.Name = "textBoxArtifactId";
            this.textBoxArtifactId.Size = new System.Drawing.Size(145, 21);
            this.textBoxArtifactId.TabIndex = 4;
            // 
            // label_version
            // 
            this.label_version.AutoSize = true;
            this.label_version.Location = new System.Drawing.Point(35, 145);
            this.label_version.Name = "label_version";
            this.label_version.Size = new System.Drawing.Size(59, 12);
            this.label_version.TabIndex = 5;
            this.label_version.Text = "version：";
            // 
            // textBoxVersion
            // 
            this.textBoxVersion.Location = new System.Drawing.Point(136, 142);
            this.textBoxVersion.Name = "textBoxVersion";
            this.textBoxVersion.Size = new System.Drawing.Size(145, 21);
            this.textBoxVersion.TabIndex = 6;
            // 
            // label_filePath
            // 
            this.label_filePath.AutoSize = true;
            this.label_filePath.Location = new System.Drawing.Point(35, 189);
            this.label_filePath.Name = "label_filePath";
            this.label_filePath.Size = new System.Drawing.Size(65, 12);
            this.label_filePath.TabIndex = 7;
            this.label_filePath.Text = "filePath：";
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.Location = new System.Drawing.Point(136, 179);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.Size = new System.Drawing.Size(145, 21);
            this.textBoxFilePath.TabIndex = 8;
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(136, 232);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 23);
            this.button_ok.TabIndex = 9;
            this.button_ok.Text = "一键生成";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 334);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.textBoxFilePath);
            this.Controls.Add(this.label_filePath);
            this.Controls.Add(this.textBoxVersion);
            this.Controls.Add(this.label_version);
            this.Controls.Add(this.textBoxArtifactId);
            this.Controls.Add(this.label_artifactId);
            this.Controls.Add(this.buttonBrowe);
            this.Controls.Add(this.textBoxGroupId);
            this.Controls.Add(this.label_groupId);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "jar2m2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_groupId;
        private System.Windows.Forms.TextBox textBoxGroupId;
        private System.Windows.Forms.Button buttonBrowe;
        private System.Windows.Forms.Label label_artifactId;
        private System.Windows.Forms.TextBox textBoxArtifactId;
        private System.Windows.Forms.Label label_version;
        private System.Windows.Forms.TextBox textBoxVersion;
        private System.Windows.Forms.Label label_filePath;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.Button button_ok;
    }
}

