﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileAppHowest.Models
{
    public class UserInfo
    {
        public String FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<String> Roles { get; set; } = new List<string>();
        public String KernelTeamCCode { get; set; }
        public List<String> EducationCodes { get; set; } = new List<string>();
        //public string Name { get; set; }
        //public string ImageUri { get; set; }
        //public string Email { get; set; }
        public override string ToString()
        {
            return FirstName;
        }
    }
}
