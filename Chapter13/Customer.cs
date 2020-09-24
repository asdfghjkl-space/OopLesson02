using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter13
{
    class Customer : Person
    {
        //顧客ID
        public string Id { get; set; }
        //顧客ランク１～５ ５が最上位ランク
        public int Rank { get; set; }
        //クレジットカード番号
        public string CreditCardNumber { get; set; }

        public override void Print()
        {
            Console.WriteLine($"{Id}:{FullName}:({CreditCardNumber})評価:{Rank}");
        }

        public override string ToString()
        {
            return $"{Id}:{FullName}:({CreditCardNumber})評価:{Rank}";
        }
    }
}
