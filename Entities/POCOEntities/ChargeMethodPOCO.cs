﻿using System;
using System.Collections.Generic;

namespace Entities.POCOEntities
{
    public class ChargeMethodPOCO : EntityPOCO
    {
        public int Id { get; set; }
        public string Description { get; set; }

        //public ICollection<ClientPOCO> Client { get; set; }
        //public ICollection<ProviderPOCO> Provider { get; set; }
        //public ICollection<ClientOrderPOCO> ClientOrder { get; set; }

    }
}
