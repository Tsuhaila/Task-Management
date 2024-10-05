

using MainTask.Interfaces;
using MainTask.Models;

namespace MainTask.Services
{
   
    public class ItemServices:IItem
    {
        List<Item> items= new List<Item>();
        public void CreateItem(Item item)
        {
            item.Id = items.Count + 1;
            items.Add(item);
        }

        public List<Item> GetItems()
        {
            return items;
        }

        public Item GetItemById(int id)
        {
            return items.FirstOrDefault(x => x.Id == id);
        }

        public void UpdateItem(Item item,int id)
        {
            var i=items.FirstOrDefault(x => x.Id == id);
            if(i != null)
            {
                i.Title = item.Title;
                i.Description = item.Description;
                i.Status = item.Status;
            }
        }
        public void DeleteItem(int id)
        {
            var i = GetItemById(id);
            items.Remove(i);
        }
    }
}
