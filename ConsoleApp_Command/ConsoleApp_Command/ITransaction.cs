using System.Collections.Generic;

namespace ConsoleApp_Command
{
    public interface ITransaction
    {
        public void Execute(int amount);

        public void Undo();

        public void Redo();

        public List<ITransaction> GetTransactions();

        public void SetAccount(Account account);
    }
}
