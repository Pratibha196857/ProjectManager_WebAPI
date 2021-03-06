//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectManager_WebAPI.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    public partial class User
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Nullable<int> ProjectID { get; set; }
        public Nullable<int> TaskID { get; set; }
        public Nullable<int> IsDeleted { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        public virtual Project Project { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        public virtual Task Task { get; set; }
    }
}
