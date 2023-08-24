namespace Model {
    public class BookImage {

        public int? ImageId { get; set; }
        public int? BookId { get; set; }
        public string ImageName { get; set; }
        public string ImagePath { get; set; }

        public BookImage() { }

        public BookImage(int ImageId, int BookId, string ImageName, string ImagePath) {
            this.ImageId = ImageId;
            this.BookId = BookId;
            this.ImageName = ImageName; 
            this.ImagePath = ImagePath; 
        }
    }
}
