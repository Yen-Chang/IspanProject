
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
    
public partial class ExpertWork
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public ExpertWork()
    {

        this.ExpertWorkLists = new HashSet<ExpertWorkList>();

    }


    public int WorksID { get; set; }

    public byte[] WorksPhoto { get; set; }

    public Nullable<System.DateTime> DataCreateDate { get; set; }

    public Nullable<System.DateTime> DataModifyDate { get; set; }

    public Nullable<int> DataModifyPerson { get; set; }

    public string Workname { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<ExpertWorkList> ExpertWorkLists { get; set; }

}

}