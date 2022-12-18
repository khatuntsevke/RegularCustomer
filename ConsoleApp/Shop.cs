using System.Collections.ObjectModel;

internal class Shop : ObservableCollection<Item>
{ 
    public void Add(string itemName, string? id = default)
    {        
        base.Add(new Item(id: id ?? Count.ToString(), name: itemName));
    }

    internal void Remove(string? itemID)
    {
        for (int i = 0; i < Count; i++)
        {
            if(base[i].Id == itemID)
            {
               RemoveAt(i);
            }
        }
    }
}