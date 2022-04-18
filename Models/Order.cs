using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Authtest.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        [HiddenInput]
        public string UserId { get; set; }
        public int ProductId { get; set; }
        public int Count { get; set; }

        [HiddenInput]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime OrderDate { get; set; }

        [ForeignKey(nameof(UserId))]
        public virtual IdentityUser User { get; set; }
        [ForeignKey(nameof(ProductId))]
        public virtual Product Product{ get; set; }
    }
}
