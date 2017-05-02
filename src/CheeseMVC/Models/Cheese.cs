using System.Collections.Generic;

namespace CheeseMVC.Models
{
    public class Cheese
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int CategoryID { get; set; }
        //Category is a navigation property. Goes with CategoryID
        public CheeseCategory Category { get; set; }
        
        //Give Cheese class access to CheeseMenus/relationship of cheese & menu
        public List<CheeseMenu> CheeseMenus { get; set; }           //**would an IList be better here?
    }
}
