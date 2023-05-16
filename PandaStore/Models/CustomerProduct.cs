﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PandaStore.Models
{
    public class CustomerProduct
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerProductID { get; set; }

        [Required]
        [ForeignKey("Users")]
        public int FK_UserID { get; set; }
        public virtual User Users { get; set; }


        [Required]
        [ForeignKey("Products")]
        public int FK_ProductID { get; set; }
        public virtual Product Products { get; set; }


        [Required]
        [ForeignKey("Receipts")]
        public int FK_ReceiptID { get; set; }
        public virtual Receipt Receipts { get; set; }


        [Required]
        public int Quantity { get; set; }


        [Required]
        public double Price { get; set; }


        [Required]
        public int ReceiptNumber { get; set; }


    }
}