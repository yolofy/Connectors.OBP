namespace KSP.AnalyzeTransactionsJob
{
    using System;

    using Connectors.OBP;

    using Newtonsoft.Json;

    class Program
    {
        static string bankId = "psd201-bank-x--uk";
        static string accountId = "90909090";
        static string viewId = "owner";
        static string transactionRequestType = "SANDBOX_TAN";
        static string description = "TX1";
        static string currency = "EUR";

        static void Main(string[] args)
        {
            Console.BufferHeight = short.MaxValue -1;

            var url = "https://psd2-api.openbankproject.com/";
            var client = new ObpRestClient(url);

            client.Login("robert.xuk.x@example.com", "<password>", "<consumerKey>");

          
            if (TxExists(description, client, new DateTime(2017, 01, 19)))
            {
                Console.WriteLine("TRIGGER: Tx exists");
            }

            Test(client, bankId, accountId, viewId, transactionRequestType, description, currency);

            Console.ReadLine();        
        }

        private static bool TxExists(string description, ObpRestClient client, DateTime laatsteKeerBinnengekomen)
        {
            var transactions = client.GetTransactionsForAccountFull(bankId, accountId, viewId);
            foreach (var transaction in transactions.Transactions)
            {
                if (transaction.Details.Value.Amount > 0 
                    && transaction.Details.Description.Contains(description)
                    && transaction.Details.Completed > laatsteKeerBinnengekomen)
                {
                    Console.WriteLine(JsonConvert.SerializeObject(transaction, Formatting.Indented));
                    return true;
                }

               
            }
            return false;
        }

        private static void Test(
            ObpRestClient client,
            string bankId,
            string accountId,
            string viewId,
            string transactionRequestType,
            string description,
            string currency)
        {
            Test("GetAccountByIdCore", () => client.GetAccountByIdCore(bankId, accountId));
            Test("GetAccountsAtBank", () => client.GetAccountsAtBank(bankId));
            Test("GetAccountByIdFull", () => client.GetAccountByIdFull(bankId, accountId, viewId));
            Test("GetAccounts", client.GetAccounts);
            Test(
                "GetTransactionById",
                () => client.GetTransactionById(bankId, accountId, viewId, "f64ae303-5be6-45e1-9bba-9a7dbbf11ccf"));
            Test("GetTransactionsForAccountCore", () => client.GetTransactionsForAccountCore(bankId, accountId));
            Test("GetTransactionsForAccountFull", () => client.GetTransactionsForAccountFull(bankId, accountId, viewId));
            Test("GetAccountsAtAllBanksPublic", client.GetAccountsAtAllBanksPublic);
            Test("GetTransactionTypesOfferedByBankResponse", () => client.GetTransactionTypesOfferedByBankResponse(bankId));
            Test(
                "GetTransactionRequestTypesForAccount",
                () => client.GetTransactionRequestTypesForAccount(bankId, accountId, viewId));
            Test("GetTransactionRequests", () => client.GetTransactionRequests(bankId, accountId, viewId));
            Test("GetRoles", client.GetRoles);
            Test(
                "CreateTransactionRequest",
                () =>
                client.CreateTransactionRequest(
                    bankId,
                    accountId,
                    viewId,
                    transactionRequestType,
                    new CreateTransactionRequestRequest
                        {
                            To =
                                new TransactionRequestAccount
                                    {
                                        AccountId = accountId,
                                        BankId = bankId
                                    },
                            Description = description,
                            Value =
                                new AmountOfMoney
                                    {
                                        Amount = 1000m,
                                        Currency = currency
                                    }
                        }));
        }

        public static void Test(string name, Func<object> method)
        {
            Console.WriteLine(name);
            Console.ReadLine();
            var result = method();
            Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            Console.WriteLine();
        }
    }
}
