using System;
using Entity.Base;

namespace Entity.Entities
{
    public class Company : BaseEntity,IEntity
    {
        public string Name { get; set; }
        public string Mail { get; set; }
        public string TelNumber { get; set; }
    }
}

