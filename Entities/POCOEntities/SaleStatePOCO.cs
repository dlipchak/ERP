﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Entities.POCOEntities
{
    public class SaleStatePOCO : EntityPOCO
    {
        public int Id { get; set; }

		[Display(Name = "SaleStateDescription", ResourceType = typeof(Resources.Resources))]
		public string Description { get; set; }
    }
}