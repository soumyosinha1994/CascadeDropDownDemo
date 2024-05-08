using Microsoft.AspNetCore.Mvc.Rendering;

namespace CascadeDropDownDemo.Models
{
    public class ViewModelVM
    {
        public Country Country { get; set; }
        public State State { get; set; }
        public City City { get; set; }
        public IEnumerable<SelectListItem> CountryList { get; set; }
    }
}
