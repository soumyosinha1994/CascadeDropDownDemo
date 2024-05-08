using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CascadeDropDownDemo.Models
{
    public class State
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("State Name")]
        public string StateName { get; set; }
        public int CountryId { get; set; }
        [ForeignKey("CountryId")]
        public Country Country { get; set; }
    }
}
