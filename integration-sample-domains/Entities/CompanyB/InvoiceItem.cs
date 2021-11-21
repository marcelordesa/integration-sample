using System.Text.Json.Serialization;

namespace integration_sample_domains.Entities.CompanyB
{
    public class InvoiceItem
    {
        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("quantity")]
        public string Quantity { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }

        [JsonPropertyName("price")]
        public string Price { get; set; }

        [JsonPropertyName("tax")]
        public string Tax { get; set; }

        [JsonPropertyName("period_from")]
        public string PeriodFrom { get; set; }

        [JsonPropertyName("period_to")]
        public string PeriodTo { get; set; }

        [JsonPropertyName("categoryIdForTransaction")]
        public string CategoryIdForTransaction { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("pos")]
        public string Pos { get; set; }

        [JsonPropertyName("tax_amount")]
        public string TaxAmount { get; set; }

        [JsonPropertyName("transaction_id")]
        public string TransactionId { get; set; }

        [JsonPropertyName("isCorrection")]
        public bool IsCorrection { get; set; }

        [JsonPropertyName("deleteTransaction")]
        public bool DeleteTransaction { get; set; }
    }
}