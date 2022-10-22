namespace Real
{
    partial class Form1
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
      this.UITextBox = new System.Windows.Forms.TextBox();
      this.UISaveButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // UITextBox
      // 
      this.UITextBox.Location = new System.Drawing.Point(26, 24);
      this.UITextBox.Multiline = true;
      this.UITextBox.Name = "UITextBox";
      this.UITextBox.Size = new System.Drawing.Size(748, 351);
      this.UITextBox.TabIndex = 0;
      // 
      // UISaveButton
      // 
      this.UISaveButton.Location = new System.Drawing.Point(637, 394);
      this.UISaveButton.Name = "UISaveButton";
      this.UISaveButton.Size = new System.Drawing.Size(137, 44);
      this.UISaveButton.TabIndex = 1;
      this.UISaveButton.Text = "button1";
      this.UISaveButton.UseVisualStyleBackColor = true;
      this.UISaveButton.Click += new System.EventHandler(this.UISaveButton_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.UISaveButton);
      this.Controls.Add(this.UITextBox);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

        }

    #endregion

    private System.Windows.Forms.TextBox UITextBox;
    private System.Windows.Forms.Button UISaveButton;
  }
}

