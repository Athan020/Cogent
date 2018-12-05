using Abp.Domain.Entities;
using Cogent.Authorization.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Cogent.Calls
{
    [Table("Call")]
    public class Call : Entity<int>
    {

        public const int MaxDescriptionLength = 16 * 1024;

        [Required]
        [MinLength(10)]
        public  string Callnumber { get; set; }

        [StringLength(MaxDescriptionLength)]
        public  string Description { get; set; }

        [ForeignKey(nameof(UserId))]
        public User User { get; set; }
        public long UserId { get; set; }

        public Call()
        {

        }
        public Call(string callnumber, long userId, string description = null)
        {
            Callnumber = callnumber;
            Description = description;
            UserId = userId;
        }

    }
}
