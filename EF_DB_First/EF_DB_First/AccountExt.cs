﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_DB_First
{
    public partial class Account
    {
        public override string ToString()
        {
            return this.Number;
        }
    }
}
