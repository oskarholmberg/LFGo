using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LFGo.Models
{
    public class Group
    {
        public int Id { get; set; }
        public int TeamId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Purpose { get; set; }

    }
}