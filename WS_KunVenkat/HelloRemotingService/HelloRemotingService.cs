﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloRemotingService
{
  public class HelloRemotingService : MarshalByRefObject,
      IHelloRemotingService.IHelloRemtingService 
    {
      public string PokazPowitanie(string nazwa)
      {
        return "Cześć "+ nazwa;
      }
    }
}
