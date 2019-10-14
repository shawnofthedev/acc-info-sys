using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace acc_info_sys.domain
{
    public class Account
    {
        public int Id { get; set; }

        public int AccountNum { get; set; }

        public string AccountName { get; set; }

        public string AccountDescription { get; set; }

        //TODO Maybe load dropdown from database? 
        public List<SelectListItem> AccountType { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "1", Text = "Assets"},
            new SelectListItem { Value = "2", Text = "Liabilities"},
            new SelectListItem { Value = "3", Text = "Equity"},
        };
    }
}
