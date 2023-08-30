namespace Model {
    public class Genre {

        public int? GenreId {  get; set; }
        public string GenreName { get; set; }

        public Genre() { }

        public Genre(int? genreId, string genreName) {
            GenreId = genreId;
            GenreName = genreName;
        }

        // Example parsing method in Model.Genre
        public static Genre Parse(string genreString) {
            // Parse the string and create a Genre object
            // Example logic:
            Genre genre = new Genre();
            genre.GenreName = genreString;
            return genre;
        }
    }
}
