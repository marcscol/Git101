﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git101
{
  public class NewFile
  {
    public Int32 Division( Int32 a, Int32 b )
    {
      return a / b;
    }

    public Int32 Log( Int32 a, Int32 b )
    {
      return Convert.ToInt32( Math.Log( a, b ) );
    }
  }
}
