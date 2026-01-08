using DataSources;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");




// --- Affichage des albums ---

// The Three Parts of a LINQ Query:
// 1. Data source.
var allAlbums = ListAlbumsData.ListAlbums;

// 2. Query creation.
// albumQuery is an IEnumerable<int>
var toShowQuery =
    from album in allAlbums
    select $"Album n°{album.AlbumId} : {album.Title} \n";

// 3. Query execution.
foreach (string albumString in toShowQuery)
{
    Console.Write(albumString);
}



// --- Recherche après input entré ---
Console.WriteLine("Quelle est votre recherche ?");
string recherche = Console.ReadLine();

// 2.Query creation.
var FindTitleCorrespondingQuery =
    from album in allAlbums
    where album.Title.Contains(recherche, StringComparison.InvariantCultureIgnoreCase)
    select $"Album n°{album.AlbumId} : {album.Title}";

// 3. Query execution.
foreach (string albumCorresponding in FindTitleCorrespondingQuery)
{
    Console.WriteLine(albumCorresponding);
}


// --- Ordonner ---
// 2.Query creation.

// Syntaxe requête
var FindTitleCorrespondingAndOrderByTitleAscendingAndAlbumIdDescendingQuery =
    from album in allAlbums
    where album.Title.Contains(recherche, StringComparison.InvariantCultureIgnoreCase)
    orderby album.Title ascending, album.AlbumId descending
    select $"Album n°{album.AlbumId} : {album.Title}";

// Syntaxe méthode
var requestMethod = allAlbums.Where(alb => alb.Title.Contains(recherche, StringComparison.InvariantCultureIgnoreCase))
                    .OrderBy(alb => alb.Title)
                    .ThenByDescending(alb => alb.AlbumId)
                    .Select(album => $"Album n°{album.AlbumId} : {album.Title}");

// 3. Query execution.
foreach (string albumCorresponding in FindTitleCorrespondingAndOrderByTitleAscendingAndAlbumIdDescendingQuery)
{
    Console.WriteLine(albumCorresponding);
}