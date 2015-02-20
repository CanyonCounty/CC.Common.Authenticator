namespace CC.Common.Authenticator.Demo
{
  partial class frmMain
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
      this.components = new System.ComponentModel.Container();
      this.txtOTP = new System.Windows.Forms.TextBox();
      this.timerStep = new System.Windows.Forms.Timer(this.components);
      this.progress = new System.Windows.Forms.ProgressBar();
      this.btnCopy = new System.Windows.Forms.Button();
      this.panel1 = new System.Windows.Forms.Panel();
      this.webBrowser1 = new System.Windows.Forms.WebBrowser();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // txtOTP
      // 
      this.txtOTP.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtOTP.ForeColor = System.Drawing.SystemColors.WindowText;
      this.txtOTP.Location = new System.Drawing.Point(19, 21);
      this.txtOTP.Name = "txtOTP";
      this.txtOTP.Size = new System.Drawing.Size(235, 57);
      this.txtOTP.TabIndex = 2;
      this.txtOTP.TabStop = false;
      this.txtOTP.Text = "000000";
      this.txtOTP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // timerStep
      // 
      this.timerStep.Interval = 1000;
      this.timerStep.Tick += new System.EventHandler(this.timerStep_Tick);
      // 
      // progress
      // 
      this.progress.Location = new System.Drawing.Point(19, 84);
      this.progress.Maximum = 30;
      this.progress.Name = "progress";
      this.progress.Size = new System.Drawing.Size(235, 23);
      this.progress.Step = 1;
      this.progress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
      this.progress.TabIndex = 1;
      this.progress.Value = 1;
      // 
      // btnCopy
      // 
      this.btnCopy.Location = new System.Drawing.Point(19, 113);
      this.btnCopy.Name = "btnCopy";
      this.btnCopy.Size = new System.Drawing.Size(235, 23);
      this.btnCopy.TabIndex = 0;
      this.btnCopy.Text = "Copy";
      this.btnCopy.UseVisualStyleBackColor = true;
      this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.webBrowser1);
      this.panel1.Location = new System.Drawing.Point(19, 142);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(252, 228);
      this.panel1.TabIndex = 4;
      // 
      // webBrowser1
      // 
      this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.webBrowser1.Location = new System.Drawing.Point(0, 0);
      this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
      this.webBrowser1.Name = "webBrowser1";
      this.webBrowser1.Size = new System.Drawing.Size(252, 228);
      this.webBrowser1.TabIndex = 0;
      // 
      // frmMain
      // 
      this.AcceptButton = this.btnCopy;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(287, 382);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.btnCopy);
      this.Controls.Add(this.progress);
      this.Controls.Add(this.txtOTP);
      this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmMain";
      this.Text = "KeyGen";
      this.Load += new System.EventHandler(this.frmMain_Load);
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtOTP;
    private System.Windows.Forms.Timer timerStep;
    private System.Windows.Forms.ProgressBar progress;
    private System.Windows.Forms.Button btnCopy;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.WebBrowser webBrowser1;
  }
}

