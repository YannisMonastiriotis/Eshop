//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Eshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class ram
    {
        public int id { get; set; }
        public int productId { get; set; }
        
        [Required]
        [StringLength(20)]
        [RegularExpression(@"^[^,:*?""<>\|]*$")]
        public string memory { get; set; }
        
        [Required]
        [StringLength(20)]
        [RegularExpression(@"^[^,:*?""<>\|]*$")]
        public string type { get; set; }
        
        [Required]
        [StringLength(20)]
        [RegularExpression(@"^[^,:*?""<>\|]*$")]
        public string cash_latency { get; set; }
       
        [Required]
        [StringLength(20)]
        [RegularExpression(@"^[^,:*?""<>\|]*$")]
        public string frequency { get; set; }
    
        public virtual product product { get; set; }
    }
}
