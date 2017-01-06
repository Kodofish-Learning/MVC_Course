using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _02.EntityFramework.Models
{

    [MetadataType(typeof(RegionMeta))]
    public partial class Region
    {
    }

    public class RegionMeta
    {
        public int RegionID { get; set; }
        public string RegionDescription { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Territory> Territories { get; set; }
    }
}