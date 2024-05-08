using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CascadeDropDownDemo.Models
{
    public class City
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("City Name")]
        public string CityName { get; set; }
        public int StateId { get; set; }
        [ForeignKey("StateId")]
        public State State { get; set; }
    }
}
