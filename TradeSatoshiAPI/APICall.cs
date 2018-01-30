using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace TradeSatoshiAPI
{
    public class APICall
    {
        #region Public API
        /// <summary>
        /// </summary>
        /// <returns><seealso cref="GetCurrenciesReturn"/></returns>
        public async static Task<GetCurrenciesReturn> GetCurrencies()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    return JsonConvert.DeserializeObject<GetCurrenciesReturn>(await client.GetAsync("https://tradesatoshi.com/api/public/getcurrencies").Result.Content.ReadAsStringAsync());
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="market">market: The market name e.g. 'LTC_BTC' (required)</param>
        /// <returns><seealso cref="GetTickerReturn"/></returns>
        public async static Task<GetTickerReturn> GetTicker(string market)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    return JsonConvert.DeserializeObject<GetTickerReturn>(await client.GetAsync("https://tradesatoshi.com/api/public/getticker?market=" + market).Result.Content.ReadAsStringAsync());
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="market">The market name e.g. 'LTC_BTC' (required)</param>
        /// <param name="count">The max amount of records to return (optional, default: 20)</param>
        /// <returns><seealso cref="GetMarketHistoryReturn"/></returns>
        public async static Task<GetMarketHistoryReturn> GetMarketHistory(string market, int count)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    return JsonConvert.DeserializeObject<GetMarketHistoryReturn>(await client.GetAsync("https://tradesatoshi.com/api/public/getmarkethistory?market=" + market + "&count=" + count.ToString()).Result.Content.ReadAsStringAsync());
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="market">The market name e.g. 'LTC_BTC' (required)</param>
        /// <returns><seealso cref="GetMarketSummaryReturn"/></returns>
        public async static Task<GetMarketSummaryReturn> GetMarketSummary(string market)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    return JsonConvert.DeserializeObject<GetMarketSummaryReturn>(await client.GetAsync("https://tradesatoshi.com/api/public/getmarketsummary?market=" + market).Result.Content.ReadAsStringAsync());
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        /// <summary>
        /// </summary>
        /// <returns><seealso cref="GetMarketSummariesReturn"/></returns>
        public async static Task<GetMarketSummariesReturn> GetMarketSummaries()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    return JsonConvert.DeserializeObject<GetMarketSummariesReturn>(await client.GetAsync("https://tradesatoshi.com/api/public/getmarketsummaries").Result.Content.ReadAsStringAsync());
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="market">The market name e.g. 'LTC_BTC' (required)</param>
        /// <param name="type">The order book type 'buy', 'sell', 'both' (optional, default: 'both')</param>
        /// <param name="depth">Max of records to return (optional, default: 20)</param>
        /// <returns><seealso cref="GetOrderBookReturn"/></returns>
        public async static Task<GetOrderBookReturn> GetOrderBook(string market, string type, int depth)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    return JsonConvert.DeserializeObject<GetOrderBookReturn>(await client.GetAsync("https://tradesatoshi.com/api/public/getorderbook?market=" + market + "&type=" + type + "&depth=" + depth.ToString()).Result.Content.ReadAsStringAsync());
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
        #endregion
    }
}
