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
            this.button_remote = new System.Windows.Forms.Button();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.textBoxRepoId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_groupId
            // 
            this.label_groupId.AutoSize = true;
            this.label_groupId.Location = new System.Drawing.Point(45, 65);
            this.label_groupId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_groupId.Name = "label_groupId";
            this.label_groupId.Size = new System.Drawing.Size(78, 15);
            this.label_groupId.TabIndex = 0;
            this.label_groupId.Text = "groupId：";
            // 
            // textBoxGroupId
            // 
            this.textBoxGroupId.Location = new System.Drawing.Point(180, 61);
            this.textBoxGroupId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxGroupId.Name = "textBoxGroupId";
            this.textBoxGroupId.Size = new System.Drawing.Size(192, 25);
            this.textBoxGroupId.TabIndex = 1;
            // 
            // buttonBrowe
            // 
            this.buttonBrowe.Location = new System.Drawing.Point(371, 221);
            this.buttonBrowe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBrowe.Name = "buttonBrowe";
            this.buttonBrowe.Size = new System.Drawing.Size(61, 29);
            this.buttonBrowe.TabIndex = 2;
            this.buttonBrowe.Text = "...";
            this.buttonBrowe.UseVisualStyleBackColor = true;
            this.buttonBrowe.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_artifactId
            // 
            this.label_artifactId.AutoSize = true;
            this.label_artifactId.Location = new System.Drawing.Point(47, 120);
            this.label_artifactId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_artifactId.Name = "label_artifactId";
            this.label_artifactId.Size = new System.Drawing.Size(102, 15);
            this.label_artifactId.TabIndex = 3;
            this.label_artifactId.Text = "artifactId：";
            // 
            // textBoxArtifactId
            // 
            this.textBoxArtifactId.Location = new System.Drawing.Point(181, 116);
            this.textBoxArtifactId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxArtifactId.Name = "textBoxArtifactId";
            this.textBoxArtifactId.Size = new System.Drawing.Size(192, 25);
            this.textBoxArtifactId.TabIndex = 4;
            // 
            // label_version
            // 
            this.label_version.AutoSize = true;
            this.label_version.Location = new System.Drawing.Point(47, 181);
            this.label_version.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_version.Name = "label_version";
            this.label_version.Size = new System.Drawing.Size(78, 15);
            this.label_version.TabIndex = 5;
            this.label_version.Text = "version：";
            // 
            // textBoxVersion
            // 
            this.textBoxVersion.Location = new System.Drawing.Point(181, 178);
            this.textBoxVersion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxVersion.Name = "textBoxVersion";
            this.textBoxVersion.Size = new System.Drawing.Size(192, 25);
            this.textBoxVersion.TabIndex = 6;
            // 
            // label_filePath
            // 
            this.label_filePath.AutoSize = true;
            this.label_filePath.Location = new System.Drawing.Point(47, 236);
            this.label_filePath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_filePath.Name = "label_filePath";
            this.label_filePath.Size = new System.Drawing.Size(86, 15);
            this.label_filePath.TabIndex = 7;
            this.label_filePath.Text = "filePath：";
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.Location = new System.Drawing.Point(181, 224);
            this.textBoxFilePath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.Size = new System.Drawing.Size(192, 25);
            this.textBoxFilePath.TabIndex = 8;
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(180, 266);
            this.button_ok.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(100, 29);
            this.button_ok.TabIndex = 9;
            this.button_ok.Text = "安装到本地库";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // button_remote
            // 
            this.button_remote.Location = new System.Drawing.Point(50, 328);
            this.button_remote.Name = "button_remote";
            this.button_remote.Size = new System.Drawing.Size(110, 26);
            this.button_remote.TabIndex = 10;
            this.button_remote.Text = "安装到远程库";
            this.button_remote.UseVisualStyleBackColor = true;
            this.button_remote.Click += new System.EventHandler(this.button_remote_Click);
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Location = new System.Drawing.Point(242, 328);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(100, 25);
            this.textBoxUrl.TabIndex = 11;
            // 
            // textBoxRepoId
            // 
            this.textBoxRepoId.Location = new System.Drawing.Point(242, 373);
            this.textBoxRepoId.Name = "textBoxRepoId";
            this.textBoxRepoId.Size = new System.Drawing.Size(100, 25);
            this.textBoxRepoId.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "url:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "repositoryId:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 418);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRepoId);
            this.Controls.Add(this.textBoxUrl);
            this.Controls.Add(this.button_remote);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        public System.Windows.Forms.Button button_remote;
        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.TextBox textBoxRepoId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

