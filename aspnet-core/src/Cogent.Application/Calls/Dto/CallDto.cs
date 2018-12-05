using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Cogent.Authorization.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Cogent.Calls.Dto
{
    [AutoMap(typeof(Call))]
    public class CallDto : EntityDto<int>
    {

        [Required]
        public string CallNumber { get; set; }
        [StringLength(Call.MaxDescriptionLength)]
        public string Description { get; set; }

        public long? UserId { get; set; }
    }
}
