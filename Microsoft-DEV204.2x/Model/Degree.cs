namespace Model
{
    public class Degree
    {
        public Course Course { get; set; }
        public readonly string Title;

        public Degree(string title)
        {
            Title = title;
        }
    }
}
