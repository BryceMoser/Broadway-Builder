﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer
{
    [Table("ProductionsDatesTimes")]
   public class ProductionDateTime
    {
        [Key]
        public int ProductionDateTimeId { get; set; }
        [Column(TypeName = "date")]
        public DateTime Date { get; set; }
        //[Column(TypeName = "time")]
        public TimeSpan Time { get; set; }

        public int ProductionID { get; set; }
        public Production production { get; set; }

        //Overloaded Constructor
        public ProductionDateTime(int productionID, DateTime date, TimeSpan time)
        {
            ProductionID = productionID;
            Date = date;
            Time = time;

        }

    }
}