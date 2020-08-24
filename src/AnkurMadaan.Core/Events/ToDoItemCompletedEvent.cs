using AnkurMadaan.Core.Entities;
using AnkurMadaan.SharedKernel;

namespace AnkurMadaan.Core.Events
{
    public class ToDoItemCompletedEvent : BaseDomainEvent
    {
        public ToDoItem CompletedItem { get; set; }

        public ToDoItemCompletedEvent(ToDoItem completedItem)
        {
            CompletedItem = completedItem;
        }
    }
}