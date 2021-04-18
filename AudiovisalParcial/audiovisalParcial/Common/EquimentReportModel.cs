namespace audiovisalParcial.Common
{
    public class EquimentReportModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Serial { get; set; }
        public string ServiceTag { get; set; }
        public string EquimentType { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string TechnologiesConnection { get; set; }
        public string State { get; set; }
        public bool Enabled { get; set; }
    }
}
