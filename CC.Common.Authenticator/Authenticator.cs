using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CC.Common.Authenticator
{
  public class Authenticator
  {
    internal TOTP _totp;
    internal string _base32Secret;

    public Authenticator(string secret)
    {
      byte[] bytes = Bytes.GetBytes(secret);
      Base32Encoder encoder = new Base32Encoder();
      _base32Secret = encoder.Encode(bytes);

      //byte[] bytes = Base32Encoding.ToBytes(secret);
      //string base32 = new Base32Encoder().Encode(bytes);

      _totp = new TOTP(_base32Secret);
    }

    public string GetTOTPForNow()
    {
      return _totp.now().ToString("D6");
    }

    public string GetQRCodeUrl(string identity)
    {
      // https://code.google.com/p/google-authenticator/wiki/KeyUriFormat
      //var base32Secret = Base32.Encode(Secret);
      identity = identity.Replace(" ", "%2520");
      return String.Format("https://www.google.com/chart?chs=200x200&chld=M|0&cht=qr&chl=otpauth://totp/{0}%3Fsecret%3D{1}", identity, _base32Secret);
    }

    public static int CalculateProgress()
    {
      int seconds = DateTime.Now.Second;
      if (seconds >= 30) seconds = (seconds - 30);
      return seconds;
    }

    public static string GetTOTPForSecret(string secret)
    {
      byte[] bytes = Bytes.GetBytes(secret);
      Base32Encoder encoder = new Base32Encoder();
      string base32 = encoder.Encode(bytes);

      //byte[] bytes = Base32Encoding.ToBytes(secret);
      //string base32 = new Base32Encoder().Encode(bytes);

      TOTP totp = new TOTP(base32);
      //MessageBox.Show(totp.provisitioning_uri("Something"));
      return totp.now().ToString("D6");
    }
  }
}
