//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ReadlyCursed
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderMark
    {
        public Nullable<System.DateTime> StartTime { get; set; }
        public Nullable<System.DateTime> EndTime { get; set; }
        public Nullable<decimal> Balance { get; set; }
        public Nullable<int> ServiceId { get; set; }
        public int Id { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> Number { get; set; }
    
        public virtual ServiceMark ServiceMark { get; set; }
        public virtual UserMark UserMark { get; set; }
    }
}