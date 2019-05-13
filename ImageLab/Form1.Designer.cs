namespace ImageLab
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
      this.openBtn = new System.Windows.Forms.Button();
      this.Btn = new System.Windows.Forms.Button();
      this.saveBtn = new System.Windows.Forms.Button();
      this.pictureBox = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
      this.SuspendLayout();
      // 
      // openBtn
      // 
      this.openBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.openBtn.Location = new System.Drawing.Point(12, 333);
      this.openBtn.Name = "openBtn";
      this.openBtn.Size = new System.Drawing.Size(75, 23);
      this.openBtn.TabIndex = 0;
      this.openBtn.Text = "Открыть";
      this.openBtn.UseVisualStyleBackColor = true;
      this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
      // 
      // Btn
      // 
      this.Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.Btn.Location = new System.Drawing.Point(93, 333);
      this.Btn.Name = "Btn";
      this.Btn.Size = new System.Drawing.Size(119, 23);
      this.Btn.TabIndex = 1;
      this.Btn.Text = "Подменить цвет";
      this.Btn.UseVisualStyleBackColor = true;
      this.Btn.Click += new System.EventHandler(this.shiftColorBtn_Click);
      // 
      // saveBtn
      // 
      this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.saveBtn.Location = new System.Drawing.Point(454, 333);
      this.saveBtn.Name = "saveBtn";
      this.saveBtn.Size = new System.Drawing.Size(99, 23);
      this.saveBtn.TabIndex = 2;
      this.saveBtn.Text = "Сохранить";
      this.saveBtn.UseVisualStyleBackColor = true;
      this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
      // 
      // pictureBox
      // 
      this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.pictureBox.Location = new System.Drawing.Point(13, 13);
      this.pictureBox.Name = "pictureBox";
      this.pictureBox.Size = new System.Drawing.Size(540, 314);
      this.pictureBox.TabIndex = 3;
      this.pictureBox.TabStop = false;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(565, 368);
      this.Controls.Add(this.pictureBox);
      this.Controls.Add(this.saveBtn);
      this.Controls.Add(this.Btn);
      this.Controls.Add(this.openBtn);
      this.Name = "Form1";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button openBtn;
    private System.Windows.Forms.Button Btn;
    private System.Windows.Forms.Button saveBtn;
    private System.Windows.Forms.PictureBox pictureBox;
  }
}

