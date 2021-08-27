using ByteBank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.AgencySystem {
  class Program {
    static void Main(string[] args) {
      CheckingAccount account = new CheckingAccount(256, 256487);

      account.Withdraw(50);
      Console.WriteLine(account.Balance);

      Console.WriteLine("The application finished! Key enter to exit!");
      Console.ReadLine();
    }
  }
}
