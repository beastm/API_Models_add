﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class tbTemplates
    {
        public int id { get; set; }
        public string Template_name { get; set; }
        public string Backup_type { get; set; }
        public string Cronos_config { get; set; }
        public string Save_format { get; set; }
        public int Destination_id { get; set; }
        public DateTime Date_s { get; set; }
        public DateTime Date_e { get; set; }
        public int Object_id { get; set; }
        public int Limit { get; set; }

    }
}