using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bankofsimba.Models
{
    public class Account
    {
        public static List<BankAccount> bankAccounts { get; set; }

        bankAccounts
        {
            new BankAccount {Name = "Timon", Balance = 200.ToString("0.00") + " Zebra", AnimalType = "meerkat" },
            new BankAccount {Name = "Pumbaa", Balance = 800.ToString("0.00") + " Zebra", AnimalType = "warthog"},
            new BankAccount {Name = "Scar", Balance = 20000.ToString("0.00") + " Zebra", AnimalType = "lion" },
            new BankAccount {Name = "Rafiki", Balance = 100000.ToString("0.00") + " Zebra", AnimalType = "mandrill" },
        };
    }
}
