//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EF_DB_First
{
    using System;
    using System.Collections.Generic;
    
    public partial class FeatureValues
    {
        public string FeatureID { get; set; }
        public string Code { get; set; }
        public string Value { get; set; }
    
        public virtual Features Features { get; set; }
        public virtual Nomeklatura Nomeklatura { get; set; }
    }
}