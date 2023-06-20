﻿namespace FinalProject.DataAccessLayer.Entities
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string CreatedBy { get; set; }
        public string Date { get; set; }
        public int CommentCount { get; set; }
        public string LinkUrl { get; set; }
    }
}
