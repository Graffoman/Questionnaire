namespace Domain.Entities.BaseClasses
{
    public class IntRange(int from, int to)
    {
        public int From { get; set; } = from;
        public int To { get; set; } = to;
    }
}
