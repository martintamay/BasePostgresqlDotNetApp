namespace ServicesTrackerAPI.Models.DTO {
    public class ClientDTO : BaseDTO {
        public string BusinessName { get; set; }
        public string Ruc { get; set; }
        public int Dv { get; set; }
        public string ContactName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string PreferredPayday { get; set; }

    }
}
