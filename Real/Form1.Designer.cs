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
      this.RecieveButton = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // UITextBox
      // 
      this.UITextBox.Location = new System.Drawing.Point(29, 28);
      this.UITextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.UITextBox.Multiline = true;
      this.UITextBox.Name = "UITextBox";
      this.UITextBox.Size = new System.Drawing.Size(822, 409);
      this.UITextBox.TabIndex = 0;
      // 
      // UISaveButton
      // 
      this.UISaveButton.Location = new System.Drawing.Point(701, 460);
      this.UISaveButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.UISaveButton.Name = "UISaveButton";
      this.UISaveButton.Size = new System.Drawing.Size(151, 51);
      this.UISaveButton.TabIndex = 1;
      this.UISaveButton.Text = "button1";
      this.UISaveButton.UseVisualStyleBackColor = true;
      this.UISaveButton.Click += new System.EventHandler(this.UISaveButton_Click);
      // 
      // RecieveButton
      // 
      this.RecieveButton.Location = new System.Drawing.Point(486, 460);
      this.RecieveButton.Name = "RecieveButton";
      this.RecieveButton.Size = new System.Drawing.Size(143, 51);
      this.RecieveButton.TabIndex = 2;
      this.RecieveButton.Text = "Receive";
      this.RecieveButton.UseVisualStyleBackColor = true;
      this.RecieveButton.Click += new System.EventHandler(this.RecieveButton_Click);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(267, 527);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(75, 23);
      this.button2.TabIndex = 3;
      this.button2.Text = "button2";
      this.button2.UseVisualStyleBackColor = true;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(880, 525);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.RecieveButton);
      this.Controls.Add(this.UISaveButton);
      this.Controls.Add(this.UITextBox);
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

    #endregion

    private System.Windows.Forms.TextBox UITextBox;
    private System.Windows.Forms.Button UISaveButton;
        private System.Windows.Forms.Button RecieveButton;
        private System.Windows.Forms.Button button2;
    }
}

