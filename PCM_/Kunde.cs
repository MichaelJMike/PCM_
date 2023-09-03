using System.ComponentModel.DataAnnotations;

namespace PCM_
{
    public class Kunde
    {
        [Key]
        public int ID { get; set; }
        public string? Anrede { get; set; }
        public string? Vorname { get; set; }
        public string? Nachname { get; set; }
        public string? Strassenname { get; set; }
        public int Hausnummer { get; set; }
        public int PLZ { get; set; }
        public string? Wohnort { get; set; }
        public int Telefonnr_1 { get; set; }
        public int Telefonnr_2 { get; set; }
        public string? Email { get; set; }

    }
}