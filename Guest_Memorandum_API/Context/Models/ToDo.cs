﻿namespace Guest_Memorandum_API.Context.Models
{
    public class ToDo : BaseEntity
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public int Status { get; set; }
    }
}