﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Portfolio
    {
        [Key]
        public int PortfolioID { get; set; }
        public string Name { get; set; }
        public string ImageURL { get; set; }
        public string DataBD { get; set; }  
        public string Link { get; set; }

    }
}