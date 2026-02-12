using System.ComponentModel.DataAnnotations.Schema;

namespace EEMS.Models
{
    public class Document
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string BlobUrl { get; set; }
        public int UploadedByUser { get; set; }
        public DateTime UploadedDate { get; set; }
    }
}
