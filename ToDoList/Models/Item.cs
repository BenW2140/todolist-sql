using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Item
  {
    public Item()
    {
      this.Categories = new HashSet<CategoryItem>();
    }
    public int ItemId { get; set; }
    public string Description { get; set; }
    // public int CategoryId { get; set; }
    public virtual ICollection<CategoryItem> Categories { get; }
  }
}