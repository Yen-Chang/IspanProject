
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
    
public partial class Product
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Product()
    {

        this.ProductPhotoes = new HashSet<ProductPhoto>();

        this.OrderDetails = new HashSet<OrderDetail>();

    }


    public int ProductID { get; set; }

    public Nullable<int> CategoryID { get; set; }

    public string ProductName { get; set; }

    public Nullable<int> UnitPrice { get; set; }

    public byte[] CoverPhoto { get; set; }

    public string ProductDesc { get; set; }

    public string Status { get; set; }

    public Nullable<System.DateTime> PostStartDate { get; set; }

    public Nullable<System.DateTime> PostEndDate { get; set; }

    public Nullable<int> UnitsInStock { get; set; }

    public Nullable<int> TopDate { get; set; }

    public string TopType { get; set; }

    public Nullable<int> UnitPoint { get; set; }

    public Nullable<int> GetPoint { get; set; }



    public virtual Category Category { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<ProductPhoto> ProductPhotoes { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<OrderDetail> OrderDetails { get; set; }

}

}
