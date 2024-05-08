using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CascadeDropDownDemo.Models
{
    public class Country
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Country Name")]
        public string CountryName { get; set; }
    }
}
