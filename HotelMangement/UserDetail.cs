//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelMangement
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserDetail
    {
        public int book_ID { get; set; }
        public int room_ID { get; set; }
        public int customerID { get; set; }
    
        public virtual Booking Booking { get; set; }
        public virtual Room Room { get; set; }
        public virtual User User { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
