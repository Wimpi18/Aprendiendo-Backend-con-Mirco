public class Article
{
    public string Title { get; set; }
    public string Content { get; set; }

    public class ArticleMemento
    {
        internal string Title { get; }
        internal string Content { get; }

        public ArticleMemento(string title, string content)
        {
            Title = title;
            Content = content;
        }
    }

    public Article(string title, string content)
    {
        this.Title = title;
        this.Content = content;
    }

    public void Show()
    {
        Console.WriteLine($"--- Article current state --- \nTitle: {Title}\nContent: {Content}\n");
    }

    public ArticleMemento CreateMemento() => new ArticleMemento(Title, Content);

    public void Restore(ArticleMemento memento)
    {
        if (memento == null)
            return;
        Title = memento.Title;
        Content = memento.Content;
    }
}
