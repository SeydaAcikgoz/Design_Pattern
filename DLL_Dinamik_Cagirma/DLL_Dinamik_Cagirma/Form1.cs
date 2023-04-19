using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLL_Dinamik_Cagirma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var değişken türü dönüş tipinden emin olunmadığı durumlarda kullanılan değişken türüdür. İçerisine atanan değerin tipini alır.
            var dll = Assembly.LoadFile(@"C:\Users\90505\source\repos\ileri_programlama\dll\Dll_ornek_projesi\Dll_ornek_projesi\bin\Debug\Dll_ornek_projesi.dll");//dll dosyasının bulunduğu dosya yolu
            var dllClass = dll.GetType("Dll_ornek_projesi.Hesaplama");//NameSpace - Class
            var istek = Activator.CreateInstance(dllClass);//çağıracağımız method için class ımızın bir örneğini oluşturuyor
            var metod = dllClass.GetMethod("islem_hesapla");//çağıracağımız method
            SonucTxt.Text = ((double)metod.Invoke(istek, new object[] { Convert.ToInt32(Sayi1Txt.Text), Convert.ToInt32(Sayi2Txt.Text) })).ToString();
        }
    }
}
