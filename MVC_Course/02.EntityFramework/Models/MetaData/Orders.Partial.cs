using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _02.EntityFramework.Models
{
    [MetadataType(typeof(OrdersMeta))]
    public partial class Orders : IValidatableObject
    {
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            //實作驗證規則
            if (OrderDate == null)
            {
                yield return new ValidationResult("OrderDate 不得空白", new[] { "OrderDate" });
            }

            if (OrderID == 0)
            {
                yield return new ValidationResult("Orderid 不得為0", new[] { "OrderID" });
            }

            
        }
    }


    public class OrdersMeta 
    {

        public int OrderID { get; set; }
        [MaxLength(20)]
        [MinLength(8)]
        [Required(ErrorMessage ="此欄位必填")]
        [Display(Name = "客戶編號")]
        public string CustomerID { get; set; }
        public Nullable<int> EmployeeID { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public Nullable<System.DateTime> RequiredDate { get; set; }
        public Nullable<System.DateTime> ShippedDate { get; set; }
        public Nullable<int> ShipVia { get; set; }
        public Nullable<decimal> Freight { get; set; }
        public string ShipName { get; set; }
        [ShipAddress]
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipRegion { get; set; }
        public string ShipPostalCode { get; set; }
        public string ShipCountry { get; set; }

        public virtual ICollection<Order_Details> Order_Details { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Shipper Shipper { get; set; }

        
    }


    public class ShipAddress : ValidationAttribute
    {

        public override bool IsValid(object value)
        {
            if (value == null)
            {
                return false;
            }

            if (string.IsNullOrEmpty(value.ToString()))
            {
                return false;
            }

            return true;
        }
    }

}