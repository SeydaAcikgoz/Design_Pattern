using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_LSP
{
    public interface DB
    {
        public void Kaydet();
        public void Sil();
        public void Baglan();

        public void Sirala();

        public void OtomatikSay();
    }

    public interface DB1_LSP
    {
        public void Kaydet();
        public void Sil();
        public void Baglan();

    }
    public interface DB2_LSP
    {
        public void Sirala();

        public void OtomatikSay();
    }


}