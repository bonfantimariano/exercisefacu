using System;
using System.Collections.Generic;

namespace ExerciseAPI.Models
{
    public class Search
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string TextSearched { get; set; }
        public int ResultNumber { get; set; }
        public DateTime CreationDate { get; set; }

        public Search()
        {
            Id = Guid.NewGuid().ToString();
            CreationDate = DateTime.UtcNow;
        }
    }
}