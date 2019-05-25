namespace MVC5hw.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(Vw_客戶相關數量MetaData))]
    public partial class Vw_客戶相關數量
    {
    }
    
    public partial class Vw_客戶相關數量MetaData
    {
        
        [StringLength(50, ErrorMessage="欄位長度不得大於 50 個字元")]
        [Required]
        public string 客戶名稱 { get; set; }
        public Nullable<int> 聯絡人數量 { get; set; }
        public Nullable<int> 客戶銀行數量 { get; set; }
    }
}
