using System.Collections.Generic;

namespace ConsoleApp_Command
{
    public interface ITransaction
    {
        public void Execute(int amount);    //işlemi yapar

        public void Undo(); //işlemi geri alır

        public void Redo(); //işlemi tekrarlar

        public List<ITransaction> GetTransactions();

        public void SetAccount(Account account);
    }
}
