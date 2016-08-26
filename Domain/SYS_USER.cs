//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class SYS_USER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SYS_USER()
        {
            this.SYS_POST_USER = new HashSet<SYS_POST_USER>();
            this.SYS_USER_DEPARTMENT = new HashSet<SYS_USER_DEPARTMENT>();
            this.SYS_USER_PERMISSION = new HashSet<SYS_USER_PERMISSION>();
            this.SYS_USER_ROLE = new HashSet<SYS_USER_ROLE>();
            this.SYS_USERINFO = new HashSet<SYS_USERINFO>();
        }
    
        public int ID { get; set; }
        public string NAME { get; set; }
        public string ACCOUNT { get; set; }
        public string PASSWORD { get; set; }
        public Nullable<int> ISCANLOGIN { get; set; }
        public Nullable<int> SHOWORDER1 { get; set; }
        public Nullable<int> SHOWORDER2 { get; set; }
        public string PINYIN1 { get; set; }
        public string PINYIN2 { get; set; }
        public string FACE_IMG { get; set; }
        public string LEVELS { get; set; }
        public string DPTID { get; set; }
        public string CREATEPER { get; set; }
        public Nullable<System.DateTime> CREATEDATE { get; set; }
        public string UPDATEUSER { get; set; }
        public Nullable<System.DateTime> UPDATEDATE { get; set; }
        public string LastLoginIP { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SYS_POST_USER> SYS_POST_USER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SYS_USER_DEPARTMENT> SYS_USER_DEPARTMENT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SYS_USER_PERMISSION> SYS_USER_PERMISSION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SYS_USER_ROLE> SYS_USER_ROLE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SYS_USERINFO> SYS_USERINFO { get; set; }
    }
}