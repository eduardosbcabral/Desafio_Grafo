﻿using Grafo.Api.Controllers;
using Grafo.Domain._Grafo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Grafo.Api.App_Start
{
    public class AutofacBootstrapper
    {
        public static void Run()
        {
            AutofacWebapiConfig.Initialize(GlobalConfiguration.Configuration);
        }
    }
}