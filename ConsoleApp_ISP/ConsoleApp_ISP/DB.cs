using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_ISP
{
        //ISP ye uygun değil
        public interface DB
        {
            public void Kaydet();
            public void Sil();
            public void Baglan();

            public void Sirala();

            public void OtomatikSay();
        }


        //ISP ye uygun 
         public interface DB_Gorev1_ISP
        {
            public void Kaydet();
            public void Sil();
            public void Baglan();
        }

        public interface DB_Gorev2_ISP
        {
            public void Sirala();

            public void OtomatikSay();
        }


    }

