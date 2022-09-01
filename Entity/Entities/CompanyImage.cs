using System;
namespace Entity.Entities
{
    public class CompanyImage
    {
        public int Id { get; set; }
        public Company? Company { get; set; }
        public Image? Image { get; set; }
        public int CompanyId { get; set; }
        public int ImageId { get; set; }
    }
}

