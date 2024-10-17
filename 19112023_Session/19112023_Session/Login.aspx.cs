using _19112023_Session.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _19112023_Session
{
    public partial class Login : System.Web.UI.Page
    {
        /*
          Session(Oturum)
        ---------------------------
        Session ın kelime anlamı oturumdur.Herhangi bir ziyaretçi sitemize ilk girdiği anda o ziyaretçiyle ilgili Session başlatmış olur.Ziyaretçiniz ile ilgili bilginin başka bir sayfada elde edilmesini istiyorsak Sessionları kullanabiliriz
        Session lar yapı itibari ile sunucu tarafından çalışmaktadır.Bu yüzden dolayı sayfada almış oldukları verileri diğer bir sayfada kaybetmezler.O bilgiler oturum devam ettiği sürece hafızada kalı
        Sunucularda çalışan Session ların kendi içerisinde bir oturum sonlanma süreci bulunmaktadır.Bu süreç default olarak 20 dk dır.Ama talebe göre süreyi azaltıp veya arttırabiliriz
        Projeleriniz içerisinde istediğiniz gibi Session oluşturabilir , bu Sessionlara değer atayabilir , güncelleyebilir veya silebilirsiniz

        Session Oluşturma
        ------------------
        1-Session.Add("<sessionAdı",<deger>);
        2-Session["<sessionAdı"]="deger";

        Session Silme
        -----------------
        Session.Remove("<sessionAdi>");

        Session Süresi Tanımlama
        ----------------------
        Session.Timeout=<dk>;

        Tüm Sessionları Silme
        -----------------------
        Session.RemoveAll();
        
        Tüm Sessinoları Sonlandır
        -----------------------
        Session.Abandon();

        Session Okuma
        -----------------
        Session["<sessionAdi>"]
         
         */
         List<Kullanici> kullanicilar=new List<Kullanici> ()
         {
             new Kullanici(){KullaniciAdi="ali", Parola="123456"},
             new Kullanici(){KullaniciAdi="leyla",Parola="0000"}
         };
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Kullanici"] !=null)
            {
                Response.Redirect("Hesap.aspx");//Belirtilen sayfaya yönlendirme işlemi yapar
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            var kullanici=kullanicilar.FirstOrDefault
                (x => 
            x.KullaniciAdi==txtKullaniciAdi.Text &&
            x.Parola ==txtParola.Text );
            if (kullanici==null)
            {
                lblBilgi.Text = "Kullanıcı Adı veya Parola bilgisi Hatalı";
            }
            else
            {
                Session.Add("Kullanici", kullanici);
                Session.Timeout = 1;
                Response.Redirect("Hesap.aspx");
            }
        }
    }
}