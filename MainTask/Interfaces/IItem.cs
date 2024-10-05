using MainTask.Models;

namespace MainTask.Interfaces
{
    public interface IItem
    {
        void CreateItem(Item item);
        List<Item> GetItems();
        Item GetItemById(int id);
        void UpdateItem(Item item,int id);
        void DeleteItem(int id);
    }
}
