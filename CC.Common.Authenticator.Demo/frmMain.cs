using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CC.Common.Authenticator;

namespace CC.Common.Authenticator.Demo
{
  public partial class frmMain : Form
  {
    private Authenticator _authenticator;

    public frmMain()
    {
      InitializeComponent();
    }

    private void frmMain_Load(object sender, EventArgs e)
    {
      string secret = "CanyonCounty";
      _authenticator = new Authenticator(secret);
      txtOTP.Text = _authenticator.GetTOTPForNow();

      CalculateProgress();

      timerStep.Enabled = true;
      // totp debugger = "https://www.google.com/chart?chs=200x200&chld=M|0&cht=qr&chl=otpauth://totp/Canyon%2520County%3Fsecret%3Dimagcadoab4qa3yanyaegadpab2qa3qaoqahsaa"
      string url = _authenticator.GetQRCodeUrl("Canyon County");
      webBrowser1.Navigate(url);
    }

    private void CalculateProgress()
    {
      progress.Value = Authenticator.CalculateProgress();

      if (progress.Value >= 27)
        txtOTP.ForeColor = Color.Red;
      else
        txtOTP.ForeColor = SystemColors.WindowText;
    }

    private void timerStep_Tick(object sender, EventArgs e)
    {
      CalculateProgress();
      txtOTP.Text = _authenticator.GetTOTPForNow();
    }

    private void btnCopy_Click(object sender, EventArgs e)
    {
      Clipboard.SetText(txtOTP.Text);
    }

  }
}
