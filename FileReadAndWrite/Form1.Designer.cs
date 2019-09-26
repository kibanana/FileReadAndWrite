namespace FileReadAndWrite
{
    partial class FormFile
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDlg = new System.Windows.Forms.SaveFileDialog();
            this.tab = new System.Windows.Forms.TabControl();
            this.tpRead = new System.Windows.Forms.TabPage();
            this.tpWrite = new System.Windows.Forms.TabPage();
            this.txtReadText = new System.Windows.Forms.TextBox();
            this.btnReadText = new System.Windows.Forms.Button();
            this.btnReadFileSelect = new System.Windows.Forms.Button();
            this.txtReadFile = new System.Windows.Forms.TextBox();
            this.txtWriteFile = new System.Windows.Forms.TextBox();
            this.btnWritefileSelect = new System.Windows.Forms.Button();
            this.btnWriteText = new System.Windows.Forms.Button();
            this.txtWriteText = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            this.tab.SuspendLayout();
            this.tpRead.SuspendLayout();
            this.tpWrite.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 227);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(567, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(168, 17);
            this.toolStripStatusLabel1.Text = "3504 김예원 - 파일 읽고 쓰기";
            // 
            // openFileDlg
            // 
            this.openFileDlg.FileName = "텍스트 파일(*.txt)|*.txt|모든파일 (*.*)|*.*";
            // 
            // saveFileDlg
            // 
            this.saveFileDlg.Filter = "텍스트 파일(*.txt)|*.txt";
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tpRead);
            this.tab.Controls.Add(this.tpWrite);
            this.tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab.Location = new System.Drawing.Point(0, 0);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(567, 227);
            this.tab.TabIndex = 2;
            // 
            // tpRead
            // 
            this.tpRead.BackColor = System.Drawing.Color.White;
            this.tpRead.Controls.Add(this.txtReadText);
            this.tpRead.Controls.Add(this.btnReadText);
            this.tpRead.Controls.Add(this.btnReadFileSelect);
            this.tpRead.Controls.Add(this.txtReadFile);
            this.tpRead.Location = new System.Drawing.Point(4, 22);
            this.tpRead.Name = "tpRead";
            this.tpRead.Padding = new System.Windows.Forms.Padding(3);
            this.tpRead.Size = new System.Drawing.Size(559, 201);
            this.tpRead.TabIndex = 0;
            this.tpRead.Text = "파일 읽기";
            // 
            // tpWrite
            // 
            this.tpWrite.Controls.Add(this.txtWriteText);
            this.tpWrite.Controls.Add(this.btnWriteText);
            this.tpWrite.Controls.Add(this.btnWritefileSelect);
            this.tpWrite.Controls.Add(this.txtWriteFile);
            this.tpWrite.Location = new System.Drawing.Point(4, 22);
            this.tpWrite.Name = "tpWrite";
            this.tpWrite.Padding = new System.Windows.Forms.Padding(3);
            this.tpWrite.Size = new System.Drawing.Size(559, 201);
            this.tpWrite.TabIndex = 1;
            this.tpWrite.Text = "파일 쓰기";
            this.tpWrite.UseVisualStyleBackColor = true;
            // 
            // txtReadText
            // 
            this.txtReadText.Location = new System.Drawing.Point(14, 34);
            this.txtReadText.Multiline = true;
            this.txtReadText.Name = "txtReadText";
            this.txtReadText.ReadOnly = true;
            this.txtReadText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtReadText.Size = new System.Drawing.Size(530, 161);
            this.txtReadText.TabIndex = 7;
            // 
            // btnReadText
            // 
            this.btnReadText.Location = new System.Drawing.Point(469, 7);
            this.btnReadText.Name = "btnReadText";
            this.btnReadText.Size = new System.Drawing.Size(75, 20);
            this.btnReadText.TabIndex = 6;
            this.btnReadText.Text = "불러오기";
            this.btnReadText.UseVisualStyleBackColor = true;
            // 
            // btnReadFileSelect
            // 
            this.btnReadFileSelect.Location = new System.Drawing.Point(388, 6);
            this.btnReadFileSelect.Name = "btnReadFileSelect";
            this.btnReadFileSelect.Size = new System.Drawing.Size(75, 21);
            this.btnReadFileSelect.TabIndex = 5;
            this.btnReadFileSelect.Text = "파일 선택";
            this.btnReadFileSelect.UseVisualStyleBackColor = true;
            // 
            // txtReadFile
            // 
            this.txtReadFile.Location = new System.Drawing.Point(14, 6);
            this.txtReadFile.Name = "txtReadFile";
            this.txtReadFile.ReadOnly = true;
            this.txtReadFile.Size = new System.Drawing.Size(368, 21);
            this.txtReadFile.TabIndex = 4;
            // 
            // txtWriteFile
            // 
            this.txtWriteFile.Location = new System.Drawing.Point(18, 6);
            this.txtWriteFile.Name = "txtWriteFile";
            this.txtWriteFile.ReadOnly = true;
            this.txtWriteFile.Size = new System.Drawing.Size(361, 21);
            this.txtWriteFile.TabIndex = 0;
            // 
            // btnWritefileSelect
            // 
            this.btnWritefileSelect.Location = new System.Drawing.Point(385, 7);
            this.btnWritefileSelect.Name = "btnWritefileSelect";
            this.btnWritefileSelect.Size = new System.Drawing.Size(75, 21);
            this.btnWritefileSelect.TabIndex = 1;
            this.btnWritefileSelect.Text = "파일 선택";
            this.btnWritefileSelect.UseVisualStyleBackColor = true;
            // 
            // btnWriteText
            // 
            this.btnWriteText.Location = new System.Drawing.Point(466, 6);
            this.btnWriteText.Name = "btnWriteText";
            this.btnWriteText.Size = new System.Drawing.Size(75, 21);
            this.btnWriteText.TabIndex = 2;
            this.btnWriteText.Text = "저장하기";
            this.btnWriteText.UseVisualStyleBackColor = true;
            // 
            // txtWriteText
            // 
            this.txtWriteText.Location = new System.Drawing.Point(18, 34);
            this.txtWriteText.Multiline = true;
            this.txtWriteText.Name = "txtWriteText";
            this.txtWriteText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtWriteText.Size = new System.Drawing.Size(523, 161);
            this.txtWriteText.TabIndex = 3;
            // 
            // FormFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 249);
            this.Controls.Add(this.tab);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormFile";
            this.Text = "3504 김예원";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tab.ResumeLayout(false);
            this.tpRead.ResumeLayout(false);
            this.tpRead.PerformLayout();
            this.tpWrite.ResumeLayout(false);
            this.tpWrite.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.OpenFileDialog openFileDlg;
        private System.Windows.Forms.SaveFileDialog saveFileDlg;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tpRead;
        private System.Windows.Forms.TabPage tpWrite;
        private System.Windows.Forms.TextBox txtReadText;
        private System.Windows.Forms.Button btnReadText;
        private System.Windows.Forms.Button btnReadFileSelect;
        private System.Windows.Forms.TextBox txtReadFile;
        private System.Windows.Forms.Button btnWriteText;
        private System.Windows.Forms.Button btnWritefileSelect;
        private System.Windows.Forms.TextBox txtWriteFile;
        private System.Windows.Forms.TextBox txtWriteText;
    }
}

