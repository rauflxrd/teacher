namespace teacher.Models
{
    internal class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Teacher[] Teachers { get; set; } = new Teacher[50];

        public override string ToString()
        {
            return $"{Id} {Name}";
        }
    }
}