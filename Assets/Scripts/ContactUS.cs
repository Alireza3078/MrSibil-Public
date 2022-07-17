using UnityEngine;

public class ContactUS : MonoBehaviour
{
    private const string MailAddress = "contact@hivagames.com";
  public void Pressed_InstagramBTN()
    {
        Application.OpenURL("https://instagram.com/mrsibilgame");
    }
    public void Pressed_TelegramBTN()
    {
        Application.OpenURL("https://t.me/hivagames_support");
    }
    public void Pressed_MailBTN()
    {
        SendMail();
    }
    private void SendMail()
    {
        string email = MailAddress;
        string subject =("Support-MrSibil");
        string body = ("");
        Application.OpenURL("mailto:" + email + "?subject=" + subject + "&body=" + body);
    }
}
