namespace Swift.Umbraco.Models.DTO
{
    public class CrmResponse
    {
        public bool Success { get; set; }

        public string ConsumerId { get; set; }

        public string ApiStatus { get; set; }

        public string ApiMessage { get; set; }
    }
}
