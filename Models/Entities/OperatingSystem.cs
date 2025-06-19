namespace Projet6.Models.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class OperatingSystem
    {
        public int OperatingSystemId { get; set; }
        public string Name { get; set; }

        // Navigation property
        public ICollection<ProductVersionOperatingSystem> ProductVersionOperatingSystems { get; set; }
    }

}
