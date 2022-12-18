using System.Collections.Specialized;

internal class Customer
{
    public void OnItemChanged(object? sender, NotifyCollectionChangedEventArgs collectionEvent)
    {
        switch (collectionEvent.Action)
        {
            case NotifyCollectionChangedAction.Add:
                if (collectionEvent.NewItems?[0] is Item newIten)
                    Console.WriteLine($"Добавлен новый товар: {newIten}");
                break;
            case NotifyCollectionChangedAction.Remove:
                if (collectionEvent.OldItems?[0] is Item oldItem)
                    Console.WriteLine($"Удален товар: {oldItem}");
                break;         
        }
    }
}