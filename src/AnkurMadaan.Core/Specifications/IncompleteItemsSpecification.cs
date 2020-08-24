using Ardalis.Specification;
using AnkurMadaan.Core.Entities;

namespace AnkurMadaan.Core.Specifications
{
    public class IncompleteItemsSpecification : Specification<ToDoItem>
    {
        public IncompleteItemsSpecification()
        {
            Query.Where(item => !item.IsDone);
        }
    }
}
