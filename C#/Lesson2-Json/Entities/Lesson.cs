namespace Entities
{
    public class Lesson
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Media { get; set; }
        public DateTime TimeStamp { get; set; }

        public Lesson() { }

        public Lesson(int id, string title, string media, DateTime timeStamp)
        {
            Id = id;
            Title = title;
            Media = media;
            TimeStamp = timeStamp;
        }
    }
}