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
    
    public partial class Desktop
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Desktop()
        {
            this.carts = new HashSet<cart>();
            this.OrderItems = new HashSet<OrderItem>();
            this.Users = new HashSet<User>();
        }
    
        public int ID { get; set; }
        public Nullable<int> CPU { get; set; }
        public Nullable<int> MOTHERBOARD { get; set; }
        public Nullable<int> GPU { get; set; }
        public Nullable<int> HARDDISC { get; set; }
        public Nullable<int> RAM { get; set; }
        public Nullable<int> PSU { get; set; }
        public Nullable<int> ProductID { get; set; }
        public string Name { get; set; }
        public Nullable<int> Box { get; set; }
        public Nullable<decimal> price { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cart> carts { get; set; }
        public virtual product product { get; set; }
        public virtual product product1 { get; set; }
        public virtual product product2 { get; set; }
        public virtual product product3 { get; set; }
        public virtual product product4 { get; set; }
        public virtual product product5 { get; set; }
        public virtual product product6 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderItem> OrderItems { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> Users { get; set; }
        
        
               
        public void UpdateMyPrice()
        {
            price = 0;
            price = product.price + product1.price + product2.price + product3.price + product4.price + product5.price +product6.price;

        }
    }
}