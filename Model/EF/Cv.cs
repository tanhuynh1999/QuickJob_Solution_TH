//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cv
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cv()
        {
            this.SubmitCvs = new HashSet<SubmitCv>();
            this.SubmitJobs = new HashSet<SubmitJob>();
            this.ViewCvs = new HashSet<ViewCv>();
        }
    
        public int cv_id { get; set; }
        public string cv_img { get; set; }
        public string cv_location { get; set; }
        public string cv_datebirth { get; set; }
        public string cv_sex { get; set; }
        public string cv_website { get; set; }
        public string cv_target { get; set; }
        public string cv_interest { get; set; }
        public string cv_informatin { get; set; }
        public string cv_referenceperson { get; set; }
        public string cv_title { get; set; }
        public string cv_email { get; set; }
        public string cv_phone { get; set; }
        public string cv_fullname { get; set; }
        public Nullable<int> cv_active { get; set; }
        public Nullable<bool> cv_option { get; set; }
        public Nullable<bool> cv_bin { get; set; }
        public Nullable<System.DateTime> cv_datecreate { get; set; }
        public Nullable<System.DateTime> cv_dateupdate { get; set; }
        public string cv_fakeid { get; set; }
        public Nullable<int> cv_fontsize { get; set; }
        public string cv_bg { get; set; }
        public Nullable<int> cv_p { get; set; }
        public Nullable<int> cv_view { get; set; }
        public Nullable<int> cv_point { get; set; }
        public Nullable<System.DateTime> cv_deadline { get; set; }
        public Nullable<int> user_id { get; set; }
        public Nullable<int> theme_id { get; set; }
        public string cv_addpress { get; set; }
        public string cv_f { get; set; }
        public string cv_pass { get; set; }
        public Nullable<int> cv_submitkey { get; set; }
    
        public virtual Theme Theme { get; set; }
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubmitCv> SubmitCvs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubmitJob> SubmitJobs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ViewCv> ViewCvs { get; set; }
    }
}
