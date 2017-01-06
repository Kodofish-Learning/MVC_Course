using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace _02.EntityFramework.Models.MetaData
{

    [MetadataType(typeof(CategoryMetaData))]
    [CustomValidation(typeof(ModelValidator), "Invalid")]
    public partial class Category
    {

    }

    public class CategoryMetaData
    {

        public int CategoryID { get; set; }
        [CustomValidation(typeof(StringValidator), "Invalid")]
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }

    /// <summary>
    /// Custom Validation Property Sample
    /// </summary>
    public class StringValidator
    {
        public static ValidationResult Invalid(string value, ValidationContext validationContext)
        {
            Regex regex = new Regex(@"[^\w\.-]", RegexOptions.IgnoreCase);
            return (value != null && regex.Match(value).Length > 0) ? 
                new ValidationResult("只許含有英數字元、句號(.)、連字號(-)。") : ValidationResult.Success;
        }
    }

    /// <summary>
    /// Custom Validation Model Sample
    /// </summary>
    public class ModelValidator
    {
        public static ValidationResult Invalid(Category category, ValidationContext validationContext)
        {
            //驗證規則

            return ValidationResult.Success;
        }
    }
}