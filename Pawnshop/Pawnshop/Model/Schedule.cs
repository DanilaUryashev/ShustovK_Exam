//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pawnshop.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Schedule
    {
        public int ID { get; set; }
        public Nullable<int> ID_Product { get; set; }
        public Nullable<int> Sum { get; set; }
        public Nullable<int> Date_pay { get; set; }
        public Nullable<System.DateTime> Actyal_Date_Pay { get; set; }
        public Nullable<int> Employer { get; set; }
        public Nullable<int> Pay_Statys { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual Product Product { get; set; }
    }
}
