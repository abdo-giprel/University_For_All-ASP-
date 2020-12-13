﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace University_For_All.Models
{
    public class Faculty
    {
        public int id { get; set; }
        public string fc_name { get; set; }
        public string fc_description { get; set; }
        public DateTime fc_created_at { get; set; }
        public byte fc_levels_num { get; set; }
        public byte fc_spicial_year { get; set; }
        public string fc_logo { get; set; }
    }
}