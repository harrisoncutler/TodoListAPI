namespace TodoListAPI.Models
{
    public class TodoItem
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public bool Completed { get; set; }
        public bool Required { get; set; }
        public string Description { get; set; }
    }
}
