using System.Text.Json.Serialization;

namespace integration_sample_domains.Entities.CompanyB
{
    public class TokenResponse
    {
        [JsonPropertyName("access_token")]
        public string access_token { get; set; }

        [JsonPropertyName("access_token_expiration")]
        public int access_token_expiration { get; set; }

        [JsonPropertyName("refresh_token")]
        public string refresh_token { get; set; }

        [JsonPropertyName("refresh_token_expiration")]
        public int refresh_token_expiration { get; set; }

        [JsonPropertyName("permissions")]
        public Permissions permissions { get; set; }
    }

    public class Permissions
    {
        public AdminTariffsChangetariff admintariffsChangeTariff { get; set; }
        public AdminTariffsTariffsforchange admintariffsTariffsForChange { get; set; }
        public AdminFupCounter adminfupCounter { get; set; }
        public AdminFupUsage adminfupUsage { get; set; }
        public AdminCustomersCustomer admincustomersCustomer { get; set; }
        public AdminCustomersCustomerinfo admincustomersCustomerInfo { get; set; }
        public AdminCustomersCustomerbilling admincustomersCustomerBilling { get; set; }
        public AdminCustomersCustomerpaymentaccounts admincustomersCustomerPaymentAccounts { get; set; }
        public AdminCustomersCustomerbundleservices admincustomersCustomerBundleServices { get; set; }
        public AdminCustomersCustomerinternetservices admincustomersCustomerInternetServices { get; set; }
        public AdminCustomersCustomervoiceservices admincustomersCustomerVoiceServices { get; set; }
        public AdminCustomersCustomerrecurringservices admincustomersCustomerRecurringServices { get; set; }
        public AdminCustomersCustomerstatistics admincustomersCustomerStatistics { get; set; }
        public AdminCustomersPrepaidcardsstatistics admincustomersPrepaidCardsStatistics { get; set; }
        public AdminCustomersBillinginfo admincustomersBillingInfo { get; set; }
        public AdminCustomersCustomerbonustrafficcounter admincustomersCustomerBonusTrafficCounter { get; set; }
        public AdminFinanceTransactions adminfinanceTransactions { get; set; }
        public AdminFinanceInvoices adminfinanceInvoices { get; set; }
        public AdminFinanceRequests adminfinanceRequests { get; set; }
        public AdminFinancePayments adminfinancePayments { get; set; }
        public AdminFinancePaymentmethods adminfinancePaymentMethods { get; set; }
        public AdminFinanceRefillcards adminfinanceRefillCards { get; set; }
        public AdminSupportTickets adminsupportTickets { get; set; }
        public AdminSupportTicketmessages adminsupportTicketMessages { get; set; }
        public AdminSupportTicketattachments adminsupportTicketAttachments { get; set; }
        public AdminSupportTicketsstatuses adminsupportTicketsStatuses { get; set; }
        public AdminConfigConfig adminconfigConfig { get; set; }
        public AdminConfigCompanyinfo adminconfigCompanyInfo { get; set; }
        public AdminConfigEntrypoints adminconfigEntryPoints { get; set; }
        public PortalDashboardDashboard portaldashboardDashboard { get; set; }
    }

    public class AdminTariffsChangetariff
    {
        public string view { get; set; }
        public string update { get; set; }
    }

    public class AdminTariffsTariffsforchange
    {
        public string view { get; set; }
    }

    public class AdminFupCounter
    {
        public string index { get; set; }
        public string view { get; set; }
    }

    public class AdminFupUsage
    {
        public string view { get; set; }
    }

    public class AdminCustomersCustomer
    {
        public string index { get; set; }
        public string view { get; set; }
        public string update { get; set; }
    }

    public class AdminCustomersCustomerinfo
    {
        public string index { get; set; }
        public string view { get; set; }
        public string update { get; set; }
    }

    public class AdminCustomersCustomerbilling
    {
        public string view { get; set; }
    }

    public class AdminCustomersCustomerpaymentaccounts
    {
        public string index { get; set; }
        public string view { get; set; }
        public string update { get; set; }
    }

    public class AdminCustomersCustomerbundleservices
    {
        public string index { get; set; }
        public string view { get; set; }
        public string update { get; set; }
    }

    public class AdminCustomersCustomerinternetservices
    {
        public string index { get; set; }
        public string view { get; set; }
        public string update { get; set; }
    }

    public class AdminCustomersCustomervoiceservices
    {
        public string index { get; set; }
        public string view { get; set; }
        public string update { get; set; }
    }

    public class AdminCustomersCustomerrecurringservices
    {
        public string index { get; set; }
        public string view { get; set; }
        public string update { get; set; }
    }

    public class AdminCustomersCustomerstatistics
    {
        public string index { get; set; }
        public string view { get; set; }
    }

    public class AdminCustomersPrepaidcardsstatistics
    {
        public string index { get; set; }
        public string view { get; set; }
    }

    public class AdminCustomersBillinginfo
    {
        public string view { get; set; }
    }

    public class AdminCustomersCustomerbonustrafficcounter
    {
        public string index { get; set; }
        public string view { get; set; }
    }

    public class AdminFinanceTransactions
    {
        public string index { get; set; }
        public string view { get; set; }
    }

    public class AdminFinanceInvoices
    {
        public string index { get; set; }
        public string view { get; set; }
    }

    public class AdminFinanceRequests
    {
        public string index { get; set; }
        public string view { get; set; }
    }

    public class AdminFinancePayments
    {
        public string index { get; set; }
        public string view { get; set; }
    }

    public class AdminFinancePaymentmethods
    {
        public string index { get; set; }
        public string view { get; set; }
    }

    public class AdminFinanceRefillcards
    {
        public string update { get; set; }
    }

    public class AdminSupportTickets
    {
        public string index { get; set; }
        public string view { get; set; }
        public string add { get; set; }
        public string update { get; set; }
    }

    public class AdminSupportTicketmessages
    {
        public string index { get; set; }
        public string view { get; set; }
        public string add { get; set; }
        public string update { get; set; }
        public string delete { get; set; }
    }

    public class AdminSupportTicketattachments
    {
        public string index { get; set; }
        public string view { get; set; }
        public string add { get; set; }
        public string delete { get; set; }
    }

    public class AdminSupportTicketsstatuses
    {
        public string index { get; set; }
        public string view { get; set; }
    }

    public class AdminConfigConfig
    {
        public string index { get; set; }
    }

    public class AdminConfigCompanyinfo
    {
        public string view { get; set; }
        public string index { get; set; }
    }

    public class AdminConfigEntrypoints
    {
        public string index { get; set; }
        public string view { get; set; }
    }

    public class PortalDashboardDashboard
    {
        public string index { get; set; }
        public string view { get; set; }
    }

}