public class History
{
    private readonly Stack<Article.ArticleMemento> _mementos = new Stack<Article.ArticleMemento>();

    public void Push(Article.ArticleMemento memento)
    {
        _mementos.Push(memento);
    }

    public Article.ArticleMemento Pop()
    {
        return _mementos.Pop();
    }
}
