﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace CDR.Register.Domain.Entities
{
    public class DataRecipient
    {
        public Guid DataRecipientId { get; set; }
        public string Status { get; set; }
        public bool IsActive { get; set; }
        public string Industry { get; set; }
        public LegalEntity LegalEntity { get; set; }
        public IList<DataRecipientBrand> DataRecipientBrands { get; set; }
        public DateTime? LastUpdated
        {
            get
            {
                return this.DataRecipientBrands != null && this.DataRecipientBrands.Any()
                    ? this.DataRecipientBrands.OrderByDescending(brand => brand.LastUpdated).First().LastUpdated
                    : null;
            }
        }
    }
}
