using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expenselt
{
    class ExpenseModel
    {
        public string ExpenseType { get; set; }
        public int ExpenseAmount { get; set; }
        public static int ID { get; set; }
    }
}
