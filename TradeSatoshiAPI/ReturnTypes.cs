using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeSatoshiAPI
{
    #region Public API
    public class GetCurrenciesReturn
    {
        public bool success { get; set; }
        public string message { get; set; }
        public CurrencyResult[] result { get; set; }

        public class CurrencyResult
        {
            public string currency { get; set; }
            public string currencyLong { get; set; }
            public int minConfirmation { get; set; }
            public decimal txFee { get; set; }
            public string status { get; set; }
        }
    }
    
    public class GetTickerReturn
    {
        public bool success { get; set; }
        public string message { get; set; }
        public TickerResult result { get; set; }

        public class TickerResult
        {
            public decimal bid { get; set; }
            public decimal ask { get; set; }
            public decimal last { get; set; }
            public string market { get; set; }
        }

    }
    
    public class GetMarketHistoryReturn
    {
        public bool success { get; set; }
        public string message { get; set; }
        public MarketHistoryResult[] result { get; set; }

        public class MarketHistoryResult
        {
            public int id { get; set; }
            public DateTime timeStamp { get; set; }
            public decimal quantity { get; set; }
            public decimal price { get; set; }
            public string orderType { get; set; }
            public decimal total { get; set; }
        }
    }
    
    public class GetMarketSummaryReturn
    {
        public bool success { get; set; }
        public string message { get; set; }
        public MarketSummaryResult result { get; set; }
    }
    
    public class GetMarketSummariesReturn
    {
        public bool success { get; set; }
        public string message { get; set; }
        public MarketSummaryResult[] result { get; set; }
    }
    
    public class GetOrderBookReturn
    {
        public bool success { get; set; }
        public string message { get; set; }
        public OrderBookResult result { get; set; }

        public class OrderBookResult
        {
            public OrderBookItem[] buy { get; set; }
            public OrderBookItem[] sell { get; set; }
        }

        public class OrderBookItem
        {
            public decimal quantity { get; set; }
            public decimal rate { get; set; }
        }
    }
    #endregion

    #region Private API
    public class GetBalanceReturn
    {
        public bool success { get; set; }
        public string message { get; set; }
        public BalanceResult result { get; set; }
    }

    public class GetBalancesReturn
    {
        public bool success { get; set; }
        public string message { get; set; }
        public BalanceResult[] result { get; set; }
    }

    public class GetOrderReturn
    {
        public bool success { get; set; }
        public string message { get; set; }
        public OrderResult result { get; set; }
    }


    public class GetOrdersReturn
    {
        public bool success { get; set; }
        public string message { get; set; }
        public OrderResult[] result { get; set; }
    }

    public class SubmitOrderReturn
    {
        public bool success { get; set; }
        public string message { get; set; }
        public SubmitOrderItem result { get; set; }

        public class SubmitOrderItem
        {
            public int OrderId { get; set; }
            public int[] Filled { get; set; }
        }
    }

    public class CancelOrderReturn
    {
        public bool success { get; set; }
        public string message { get; set; }
        public CancelOrderResult result { get; set; }

        public class CancelOrderResult
        {
            public int[] CanceledOrders { get; set; }
        }
    }

    public class GetTradeHistoryReturn
    {
        public bool success { get; set; }
        public string message { get; set; }
        public int totalRecords { get; set; }
        public GetTradeHistoryResult result { get; set; }

        public class GetTradeHistoryResult
        {
            public int Id { get; set; }
            public string Market { get; set; }
            public string Type { get; set; }
            public decimal Amount { get; set; }
            public decimal Rate { get; set; }
            public decimal Fee { get; set; }
            public decimal Total { get; set; }
            public DateTime Timestamp { get; set; }
            public bool IsApi { get; set; }
        }
    }

    public class GenerateAddressReturn
    {
        public bool success { get; set; }
        public string message { get; set; }
        public GenerateAddressResult result { get; set; }

        public class GenerateAddressResult
        {
            public string Currency { get; set; }
            public string Address { get; set; }
        }
    }

    public class SubmitWithdrawReturn
    {
        public bool success { get; set; }
        public string message { get; set; }
        public SubmitWithdrawResult result { get; set; }

        public class SubmitWithdrawResult
        {
            public int WithdrawalId { get; set; }
        }
    }

    public class GetDepositsReturn
    {
        public bool success { get; set; }
        public string message { get; set; }
        public GetDepositsResult[] result { get; set; }

        public class GetDepositsResult
        {
            public int Id { get; set; }
            public string Currency { get; set; }
            public string CurrencyLong { get; set; }
            public decimal Amount { get; set; }
            public string Status { get; set; }
            public string Txid { get; set; }
            public int Confirmations { get; set; }
            public DateTime Timestamp { get; set; }
        }
    }

    public class GetWithdrawlsReturn
    {
        public bool success { get; set; }
        public string message { get; set; }
        public GetWithdrawalsResult[] result { get; set; }

        public class GetWithdrawalsResult
        {
            public int Id { get; set; }
            public string Currency { get; set; }
            public string CurrencyLong { get; set; }
            public decimal Amount { get; set; }
            public decimal Fee { get; set; }
            public string Address { get; set; }
            public string Status { get; set; }
            public string Txid { get; set; }
            public int Confirmations { get; set; }
            public DateTime Timestamp { get; set; }
            public bool IsApi { get; set; }
        }
    }

    public class SubmitTransferReturn
    {
        public bool success { get; set; }
        public string message { get; set; }
        public SubmitTransferResult result { get; set; }

        public class SubmitTransferResult
        {
            public string data { get; set; }
        }
    }

    #endregion

    #region Shared Result Models
    public class MarketSummaryResult
    {
        public string market { get; set; }
        public decimal high { get; set; }
        public decimal low { get; set; }
        public decimal volume { get; set; }
        public decimal baseVolume { get; set; }
        public decimal last { get; set; }
        public decimal bid { get; set; }
        public decimal ask { get; set; }
        public int openBuyOrders { get; set; }
        public int openSellOrders { get; set; }
    }

    public class BalanceResult
    {
        public string Currency { get; set; }
        public string CurrencyLong { get; set; }
        public decimal Avaliable { get; set; }
        public decimal Total { get; set; }
        public decimal HeldForTrades { get; set; }
        public decimal Unconfirmed { get; set; }
        public decimal PendingWithdraw { get; set; }
        public string address { get; set; }
    }

    public class OrderResult
    {
        public int Id { get; set; }
        public string Market { get; set; }
        public string Type { get; set; }
        public decimal Amount { get; set; }
        public decimal Rate { get; set; }
        public decimal Remaining { get; set; }
        public decimal Total { get; set; }
        public string Status { get; set; }
        public DateTime Timestamp { get; set; }
        public bool IsApi { get; set; }
    }
    #endregion
}
