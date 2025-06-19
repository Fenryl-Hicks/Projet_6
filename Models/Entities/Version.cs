namespace Projet6.Models.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Version
    {
        public int VersionId { get; set; }
        public string VersionNumber { get; set; }

        // Navigation property
        public ICollection<ProductVersionOperatingSystem> ProductVersionOperatingSystems { get; set; }
    }

}
