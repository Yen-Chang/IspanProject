
//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------


namespace prjWantWantWinForm
{

using System;
    using System.Collections.Generic;
    
public partial class Rating
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Rating()
    {

        this.ExpertApplications = new HashSet<ExpertApplication>();

        this.ExpertApplications1 = new HashSet<ExpertApplication>();

        this.ApplicationLists = new HashSet<ApplicationList>();

    }


    public int RatingID { get; set; }

    public string RatingStar { get; set; }

    public string RatingContent { get; set; }

    public Nullable<System.DateTime> RatingDate { get; set; }

    public Nullable<int> SourceRoleID { get; set; }

    public Nullable<int> SourceAccountID { get; set; }

    public Nullable<int> TargetRoleID { get; set; }

    public Nullable<int> TargetAccountID { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<ExpertApplication> ExpertApplications { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<ExpertApplication> ExpertApplications1 { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<ApplicationList> ApplicationLists { get; set; }

}

}