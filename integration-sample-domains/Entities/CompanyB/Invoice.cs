using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace integration_sample_domains.Entities.CompanyB
{
    public class Invoice
    {
        [JsonPropertyName("customer_id")]
        public string CustomerId { get; set; }

        [JsonPropertyName("date_created")]
        public string DateCreated { get; set; }

        [JsonPropertyName("date_updated")]
        public string DateUpdated { get; set; }

        [JsonPropertyName("date_till")]
        public string DateTill { get; set; }

        [JsonPropertyName("date_payment")]
        public string DatePayment { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("number")]
        public string Number { get; set; }

        [JsonPropertyName("payment_id")]
        public string PaymentId { get; set; }

        [JsonPropertyName("payd_from_deposit")]
        public string PaydFromDeposit { get; set; }

        [JsonPropertyName("items")]
        public List<InvoiceItem> Items { get; set; } = new List<InvoiceItem>();

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("real_create_datetime")]
        public string RealCreateDatetime { get; set; }

        [JsonPropertyName("use_transactions")]
        public string UseTransactions { get; set; }

        [JsonPropertyName("note")]
        public string Note { get; set; }

        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        [JsonPropertyName("total")]
        public int Total { get; set; }

        [JsonPropertyName("is_sent")]
        public string IsSent { get; set; }

        [JsonPropertyName("disable_cache")]
        public string DisableCache { get; set; }

        [JsonPropertyName("added_by")]
        public string AddedBy { get; set; }

        [JsonPropertyName("added_by_id")]
        public string AddedById { get; set; }
    }
}