﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TCC.Original.MVC.Controllers
{
    public class TratamentoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}