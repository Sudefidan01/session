using _19112023_Session.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _19112023_Session
{
    public partial class Hesap : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Kullanici"] ==null)
            {
                Response.Redirect("Login.aspx");
            }
            var kul = (Kullanici)Session["Kullanici"];
            if (kul!=null)
            {
                lblKullanici.Text = string.Format("<b> {0} <b> kullanıcısı hoşgeldiniz",kul.KullaniciAdi);
            }
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Session.Remove("Kullanici");
            Response.Redirect("Login.aspx");
        }
    }
}