﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluacionP3TomasLopez.ModelsTLopez
{
    [Table("Paises")]
    public class PaisDB
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Region { get; set; }
        public string Maps { get; set; }
        public string TLopez {  get; set; }
    }
}
