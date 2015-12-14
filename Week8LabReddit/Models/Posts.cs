﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Week8LabReddit.Models
{
    public class Posts
    {
        public int PostId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime PostTime { get; set; }
        public int UpVote { get; set; }
        public int DownVote { get; set; }
    }
}