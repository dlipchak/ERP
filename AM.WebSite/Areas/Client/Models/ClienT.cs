﻿using System.Web.Mvc;

namespace AM.WebSite.Areas.Client.Models
{
	public class Client : DAL.Client
	{
		public string InfoTitle { get; set; }
		public SelectList ClientTypesSelectList { get; set; }
	}
}