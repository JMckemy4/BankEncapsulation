using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    internal class BankAccount
    {
        private double _balance = 150;

        public void Deposit(double adding)
        {
                _balance += adding;
        }
        public double GetBalance()
        {
                return _balance;
        }
        public void Withdraw(double taking)
            {
                _balance -= taking;
            }
        }
    }
    
