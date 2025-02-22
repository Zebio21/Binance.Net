﻿using Newtonsoft.Json;

#pragma warning disable IDE0051 
namespace Binance.Net.Objects.Spot.SpotData
{
    /// <summary>
    /// Ids of a canceled order, either OCO or normal
    /// </summary>
    public class BinanceCancelledId
    {
        /// <summary>
        /// Id of the order
        /// </summary>
        [JsonProperty("orderId")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// Client order id
        /// </summary>
        public string ClientOrderId { get; set; } = string.Empty;

        [JsonProperty("listClientOrderId")]
        private string ListClientOrderId
        {
            get => Id;
            set
            {
                ClientOrderId = value;
                OcoOrder = true;
            }
        }
        [JsonProperty("orderListId")]
        private string OrderListId
        {
            get => Id;
            set
            {
                if (value == "-1")
                    return;

                Id = value;
                OcoOrder = true;
            }
        }
        /// <summary>
        /// Whether or not it is an OCO order
        /// </summary>
        public bool OcoOrder { get; set; }
    }
}
#pragma warning restore IDE0051