using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TokoBeDia.Factory
{
    public class DetailTransactionFactory
    {
        public static DetailTransaction CreateDetailTransaction(int transactionid, int productid, int quantity)
        {
            DetailTransaction newDetailTransaction = new DetailTransaction()
            {
                TransactionId = transactionid,
                ProductId = productid,
                Quantity = quantity,
            };
            return newDetailTransaction;
        }
    }
}