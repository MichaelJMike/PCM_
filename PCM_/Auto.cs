using System.ComponentModel.DataAnnotations;

namespace PCM_
{
    public class Auto
    {
        public int Id { get; set; }
        public int VIN { get; set; }
        public string Fahrzeughersteller { get; set; }
        public int Baujahr { get; set; }
        public int Kilometerstand { get; set; }
        public string Kennzeichen { get; set; }
        public string? Sonstiges { get; set; }

        public int KundenID { get; set;}
    }
}