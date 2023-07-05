
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
    
public partial class ForumPost
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public ForumPost()
    {

        this.ForumPost1 = new HashSet<ForumPost>();

        this.ForumPostCategories = new HashSet<ForumPostCategory>();

        this.ForumPostComments = new HashSet<ForumPostComment>();

    }


    public int PostID { get; set; }

    public int AccountID { get; set; }

    public Nullable<int> ParentID { get; set; }

    public string Title { get; set; }

    public string PostContent { get; set; }

    public System.DateTime Created { get; set; }

    public Nullable<System.DateTime> Updated { get; set; }

    public byte Status { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<ForumPost> ForumPost1 { get; set; }

    public virtual ForumPost ForumPost2 { get; set; }

    public virtual ForumStatu ForumStatu { get; set; }

    public virtual MemberAccount MemberAccount { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<ForumPostCategory> ForumPostCategories { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<ForumPostComment> ForumPostComments { get; set; }

}

}
