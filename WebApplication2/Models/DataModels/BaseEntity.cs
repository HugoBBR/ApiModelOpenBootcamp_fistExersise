﻿using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models.DataModels
{
    public class BaseEntity
    {
        [Required]
        [Key] 
        public int Id { get; set; }
        public string CreatedBy { get; set; } = string.Empty;
        public string UpdatedBy { get; set; } = string.Empty;
        public string DeletedBy { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }=DateTime.Now;
        public DateTime? UpdatedAt { get; set;} 

        public DateTime? DeletedAt { get; set; }   

    }
}