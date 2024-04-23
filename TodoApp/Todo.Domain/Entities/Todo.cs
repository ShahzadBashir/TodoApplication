namespace Todo.Domain.Entities;

public class Todo
{
    private Todo()
    {
        
    }

    private Todo(TodoId id, string title, string description, TodoStatus status)
    {
        Id = id;
        Title = title;
        Description = description;
        Status = status;
    }

    public TodoId Id { get; private set; }

    public string Title { get; private set; }

    public string Description { get; private set; }

    public TodoStatus Status { get; private set; }

    public static Todo Create(TodoId id, string title, string description, TodoStatus status)
    {
        return new Todo(id, title, description, status);
    }
}
