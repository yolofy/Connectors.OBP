namespace Connectors.OBP
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;

    using Newtonsoft.Json;

    using RestSharp;
    using RestSharp.Deserializers;
    using RestSharp.Serializers;

    using StringFormat;

    public class LoginResponse
    {
        [JsonProperty("token")]
        public string Token { get; set; }
    }

    public class ObpRestClient
    {
        private readonly string baseUrl;

        private string token;

        public ObpRestClient(string baseUrl)
        {
            this.baseUrl = baseUrl;
        }

        public const string URL_LOGINS_DIRECT = "/my/logins/direct";
        public const string HEADER_AUTHORIZATION = @"DirectLogin username=""{Username}"",   password=""{Password}"",  consumer_key=""{ConsumerKey}""";

        public void Login(string username, string password, string consumerKey)
        {
            var authorizationValue = TokenStringFormat.Format(
                HEADER_AUTHORIZATION,
                new { Username = username, Password = password, ConsumerKey = consumerKey });

            var headers = new Dictionary<string, string> { { "Authorization", authorizationValue } };

            var response = this.DoPost<LoginResponse>(URL_LOGINS_DIRECT, headers: headers);

            this.token = response.Token;
        }

        public const string URL_GET_ACCOUNT_BY_ID_CORE = "obp/v2.1.0/my/banks/{BankId}/accounts/{AccountId}/account";
        public GetAccountByIdCoreResponse GetAccountByIdCore(string bankId, string accountId)
        {
            var url = TokenStringFormat.Format(
                URL_GET_ACCOUNT_BY_ID_CORE,
                new { BankId = bankId, AccountId = accountId });
            return this.DoGet<GetAccountByIdCoreResponse>(url);
        }

        public const string URL_GET_ACCOUNT_BY_ID_FULL = "obp/v2.1.0/banks/{BankId}/accounts/{AccountId}/{ViewId}/account";
        public GetAccountByIdFullResponse GetAccountByIdFull(string bankId, string accountId, string viewId)
        {
            var url = TokenStringFormat.Format(
                URL_GET_ACCOUNT_BY_ID_FULL,
                new { BankId = bankId, AccountId = accountId, ViewId = viewId });
            return this.DoGet<GetAccountByIdFullResponse>(url);
        }

        public const string URL_GET_ACCOUNTS_AT_BANK = "obp/v2.1.0/my/banks/{BankId}/accounts";

        public IEnumerable<AccountInfo> GetAccountsAtBank(string bankId)
        {
            var url = TokenStringFormat.Format(
               URL_GET_ACCOUNTS_AT_BANK,
               new { BankId = bankId });

            var accounts = this.DoGet<List<AccountInfo>>(url);

            return accounts;
        }

        public const string URL_GET_ACCOUNTS = "obp/v2.1.0/my/accounts";

        public IEnumerable<AccountInfo> GetAccounts()
        {
            var accounts = this.DoGet<List<AccountInfo>>(URL_GET_ACCOUNTS);
            return accounts;
        }

        public const string URL_GET_TRANSACTION_BY_ID = "obp/v2.1.0/banks/{BankId}/accounts/{AccountId}/{ViewId}/transactions/{TransactionId}/transaction";

        public Transaction GetTransactionById(string bankId, string accountId, string viewId, string transactionId)
        {
            var url = TokenStringFormat.Format(
                URL_GET_TRANSACTION_BY_ID,
                new
                {
                    BankId = bankId,
                    AccountId = accountId,
                    ViewId = viewId,
                    TransactionId = transactionId
                });
            return this.DoGet<Transaction>(url);
        }

        public const string URL_GET_TRANSACTIONS_FOR_ACCOUNT_CORE = "obp/v2.1.0/my/banks/{BankId}/accounts/{AccountId}/transactions";

        public GetTransactionsForAccountCoreResponse GetTransactionsForAccountCore(string bankId, string accountId)
        {
            var url = TokenStringFormat.Format(
              URL_GET_TRANSACTIONS_FOR_ACCOUNT_CORE,
              new
              {
                  BankId = bankId,
                  AccountId = accountId
              });
            return this.DoGet<GetTransactionsForAccountCoreResponse>(url);
        }

        public const string URL_GET_TRANSACTIONS_FOR_ACCOUNT_FULL = "obp/v2.1.0/banks/{BankId}/accounts/{AccountId}/{ViewId}/transactions";

        public GetTransactionsForAccountFullResponse GetTransactionsForAccountFull(string bankId, string accountId, string viewId)
        {
            var url = TokenStringFormat.Format(
            URL_GET_TRANSACTIONS_FOR_ACCOUNT_FULL,
            new
            {
                BankId = bankId,
                AccountId = accountId,
                ViewId = viewId
            });
            return this.DoGet<GetTransactionsForAccountFullResponse>(url);
        }

        public const string URL_GET_ACCOUNTS_AT_ALL_BANKS = "obp/v2.1.0/accounts";

        public GetAccountsAtAllBanksPublicResponse GetAccountsAtAllBanksPublic()
        {
            return this.DoGet<GetAccountsAtAllBanksPublicResponse>(URL_GET_ACCOUNTS_AT_ALL_BANKS);
        }

        public const string URL_GET_TRANSACTION_TYPES_OFFERED_BY_BANK = "obp/v2.1.0/banks/{BankId}/transaction-types";

        public GetTransactionTypesOfferedByBankResponse GetTransactionTypesOfferedByBankResponse(string bankId)
        {
            var url = TokenStringFormat.Format(
           URL_GET_TRANSACTION_TYPES_OFFERED_BY_BANK,
           new
           {
               BankId = bankId
           });
            return this.DoGet<GetTransactionTypesOfferedByBankResponse>(url);
        }

        public const string URL_GET_TRANSACTION_REQUEST_TYPES_FOR_ACCOUNT = "obp/v2.1.0/banks/{BankId}/accounts/{AccountId}/{ViewId}/transaction-request-types";
        public IEnumerable<TransactionRequestType> GetTransactionRequestTypesForAccount(string bankId, string accountId, string viewId)
        {
            var url = TokenStringFormat.Format(
           URL_GET_TRANSACTION_REQUEST_TYPES_FOR_ACCOUNT,
           new
           {
               BankId = bankId,
               AccountId = accountId,
               ViewId = viewId

           });
            return this.DoGet<List<TransactionRequestType>>(url);
        }

        public const string URL_GET_TRANSACTION_REQUESTS = "obp/v2.1.0/banks/{BankId}/accounts/{AccountId}/{ViewId}/transaction-requests";

        public GetTransactionRequestsResponse GetTransactionRequests(string bankId, string accountId, string viewId)
        {
            var url = TokenStringFormat.Format(
         URL_GET_TRANSACTION_REQUESTS,
         new
         {
             BankId = bankId,
             AccountId = accountId,
             ViewId = viewId

         });
            return this.DoGet<GetTransactionRequestsResponse>(url);
        }

        public const string URL_GET_ROLES = "obp/v2.1.0/roles";

        public GetRolesResponse GetRoles()
        {
            return this.DoGet<GetRolesResponse>(URL_GET_ROLES);
        }

        public const string URL_CREATE_TRANSACTION_REQUEST = "obp/v2.1.0/banks/{BankId}/accounts/{AccountId}/{ViewId}/transaction-request-types/{TransactionRequestType}/transaction-requests";

        public TransactionRequest CreateTransactionRequest(
            string bankId,
            string accountId,
            string viewId,
            string transactionRequestType,
            CreateTransactionRequestRequest request)
        {
            var url = TokenStringFormat.Format(
                URL_CREATE_TRANSACTION_REQUEST,
                new
                {
                    BankId = bankId,
                    AccountId = accountId,
                    ViewId = viewId,
                    TransactionRequestType = transactionRequestType
                });
            return this.DoPost<TransactionRequest>(url, content: request);
        }

        public const string URL_ANSWER_TRANSACTION_REQUEST_CHALLENGE = "obp/v2.1.0/banks/{BankId}/accounts/{AccountId}/{ViewId}/transaction-request-types/{TransactionRequestType}/transaction-requests/{TransactionRequestId}/challenge";

        public void AnswerTransactionRequestChallenge(string bankId, string accountId, string viewId, string transactionRequestType, string transactionRequestId, AnswerTransactionRequestChallenge request)
        {
            var url = TokenStringFormat.Format(
                URL_CREATE_TRANSACTION_REQUEST,
                new
                {
                    BankId = bankId,
                    AccountId = accountId,
                    ViewId = viewId,
                    TransactionRequestType = transactionRequestType
                });
        //    return this.DoPost<TransactionRequest>(url, content: request);
        }


        public TResponse DoGet<TResponse>(string url, Dictionary<string, string> headers = null, string baseUrlOverride = null) where TResponse : new()
        {
            var restClient = this.CreateClient(this.baseUrl ?? baseUrlOverride);
            var request = new RestRequest(url, Method.GET) { JsonSerializer = JsonSerializer.Default };

            this.AddHeadersToRequest(request, headers);
            var response = restClient.Get<TResponse>(request);
            this.CheckResponse(response);
            return response.Data;
        }

        public TResponse DoPost<TResponse>(string url, object content = null, Dictionary<string, string> headers = null, string baseUrlOverride = null) where TResponse : new()
        {
            var restClient = this.CreateClient(this.baseUrl ?? baseUrlOverride);
            var request = new RestRequest(url, Method.POST)
                              {
                                  JsonSerializer = JsonSerializer.Default,
                                    RequestFormat = DataFormat.Json
                              };

            this.AddHeadersToRequest(request, headers);
            if (content != null)
            {
                request.AddBody(content);
            }

            var response = restClient.Post<TResponse>(request);
            this.CheckResponse(response);
            return response.Data;
        }

        private RestClient CreateClient(string baseUrl)
        {
            var client = new RestClient(baseUrl);

            // Override with Newtonsoft JSON Handler
            client.AddHandler("application/json", JsonSerializer.Default);
            client.AddHandler("text/json", JsonSerializer.Default);
            client.AddHandler("text/x-json", JsonSerializer.Default);
            client.AddHandler("text/javascript", JsonSerializer.Default);
            client.AddHandler("*+json", JsonSerializer.Default);

            return client;
        }

        private void CheckResponse(IRestResponse response)
        {
            if (response.StatusCode != HttpStatusCode.OK 
                && response.StatusCode != HttpStatusCode.Created)
            {
                throw new Exception(response.StatusCode + response.StatusDescription, response.ErrorException);
            }
        }

        public void AddHeadersToRequest(IRestRequest request, Dictionary<string, string> headers)
        {
            if (headers != null)
            {
                foreach (var header in headers)
                {
                    request.AddHeader(header.Key, header.Value);
                }
            }

            if (this.token != null && (headers == null || !headers.ContainsKey("Authorization")))
            {
                request.AddHeader("Authorization", $@"DirectLogin token = ""{this.token}""");
            }

            if (this.token != null && (headers == null || !headers.ContainsKey("Content-Type")))
            {
                request.AddHeader("Content-Type", "application/json");
            }
        }
    }

    public class JsonSerializer : ISerializer, IDeserializer
    {
        public static JsonSerializer Default => new JsonSerializer();

        public string Serialize(object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

        public T Deserialize<T>(IRestResponse response)
        {
            return JsonConvert.DeserializeObject<T>(response.Content);
        }

        public string RootElement { get; set; }

        public string Namespace { get; set; }

        public string DateFormat { get; set; }

        public string ContentType { get; set; } = "application/json";
    }
}
