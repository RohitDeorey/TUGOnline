﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public class DeliverStaffEntity
    {
        public int DeliverPersonID { get; set; }
        public string Name { get; set; }
        public string MobileNumber { get; set; }
        public bool IsActive { get; set; }
    }
}
