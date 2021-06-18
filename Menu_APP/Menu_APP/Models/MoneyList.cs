using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Menu_APP.Models
{
    [Table("MoneyList")]
    public class MoneyList
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }

        public string AllMoney { get; set; }
        public string SplitMoney { get; set; }
        public string HowMoney { get; set; }
    }
}
