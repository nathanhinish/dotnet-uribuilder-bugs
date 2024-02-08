UriBuilder uriBuilder = new UriBuilder("", "", 0, "");

Console.WriteLine(uriBuilder.ToString());

Uri uri = uriBuilder.Uri;

Console.WriteLine(uriBuilder.ToString());