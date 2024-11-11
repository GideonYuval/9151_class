using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9151
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        public static int BuyEggs(Node<Supermarket> l, int amount)
        {
            while (l != null) 
            {
                if (l.GetValue().Amount >= amount) //יש מספיק ביצים בסופר הנוכחי
                {
                    l.GetValue().Amount -= amount;
                    return 0;
                }
                amount -= l.GetValue().Amount;
                l.GetValue().Amount = 0;
                l = l.GetNext();
            }
            return amount;
        }
    }

    public class Supermarket
    {
        private string name;
        private int amount;

        public Supermarket(string name, int amount)
        {
            this.name = name;
            this.amount = amount;
        }

        public string Name { get => name; set => name = value; }
        public int Amount { get => amount; set => amount = value; }
    }
}
