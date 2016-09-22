﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AM.WebSite.Controls.DataFileList.Models
{
	public class DataFileListModel
	{
		public string ID { get; set; }
		public string Title { get; set; }
		public string Extensions { get; set; }
        public bool ShowTitle { get; set; }
		public List<DataFileListItem> Items { get; set; }
		public bool Required { get; set; }
		
		public string ProgressBarID
		{
			get { return this.ID + "ProgressBar"; }
		}

		public DataFileListModel()
		{
            ShowTitle = true;
			Items = new List<DataFileListItem>();
		}
	}
}