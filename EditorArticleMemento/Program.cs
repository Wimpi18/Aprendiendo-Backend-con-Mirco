var article = new Article("Initial Title", "Initial Content");
var history = new History();

// 1. Guardar el estado inicial
history.Push(article.CreateMemento());

// 2. Hacer un cambio
article.Title = "New Title";
article.Show();

// 3. ¿Cómo usarías el método 'Pop' de history y el 'Restore' de article para volver atrás?
article.Restore(history.Pop());

article.Show();
