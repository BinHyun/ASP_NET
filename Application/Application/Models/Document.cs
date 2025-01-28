using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Application.Models
{
    public class Document
    {
        public int Document_Number { get; set; }
        public string Title { get; set; }

        public string Writer { get; set; }
    }

    public class Bear
    {
        public int BearId { get; set; }
        public String BearColor { get; set; }
        public String BearName { get; set; }
    }
}