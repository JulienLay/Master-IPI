// See https://aka.ms/new-console-template for more information
using CodeFirstNewDatabaseSample;

Console.WriteLine("Hello, World!");

using (var db = new BloggingContext())
{
    // Create and save a new Blog
    Console.Write("Enter a name for a new Blog: ");
    var name = Console.ReadLine();

    var blog = new Blog { Name = name };
    db.Blogs.Add(blog);

    Console.Write("Enter a name for a new Post: ");
    var namep = Console.ReadLine();

    var post = new Post { Title = namep, BlogId = 1 };
    db.Posts.Add(post);
    db.SaveChanges();

    // Display all Blogs from the database
    var query = from b in db.Blogs
                orderby b.Name
                select b;

    Console.WriteLine("All blogs in the database:");
    foreach (var item in query)
    {
        Console.WriteLine(item.Name);
        if (item.Posts != null)
        {
            foreach (var poste in item.Posts)
            {
                Console.WriteLine($"    {poste.Title}");
            }
        }
    }

    Console.WriteLine("Press any key to exit...");
    Console.ReadKey();
}
public class Blog
{
    public int BlogId { get; set; }
    public string Name { get; set; }
    public string Url { get; set; }
    public virtual List<Post> Posts { get; set; }
}

public class Post
{
    public int PostId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }

    public int BlogId { get; set; }
    public virtual Blog Blog { get; set; }
}