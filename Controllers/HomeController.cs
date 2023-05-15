using LearningASP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LearningASP.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            string test = "";
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i + j == 10)
                    {
                        test+='x';
                    }
                    else if (i == j & i > 0)
                    {
                        test += 'x';
                    }
                    else
                    {
                        test += ' ';
                    }
                }
                test += '\n';
            }
            return test;
        }
    }
}
