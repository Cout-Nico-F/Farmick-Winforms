﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winforms_Farmick
{
  public interface State
  {
    void Poke(FarmButton context_FarmButton);
  }
}
