//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Licenta.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserAccount
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Parola { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public int IdRol { get; set; }
    
        public virtual Rol Rol { get; set; }
    }
}
