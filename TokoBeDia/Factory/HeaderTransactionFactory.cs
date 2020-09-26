using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TokoBeDia.Factory
{
    public class HeaderTransactionFactory
    {
        public static HeaderTransaction CreateHeaderTransaction(int userid, DateTime date)
        {
            HeaderTransaction newHeaderTransaction = new HeaderTransaction()
            {
                UserId = userid,
                Date = date,
            };
            return newHeaderTransaction;
        }
    }
}