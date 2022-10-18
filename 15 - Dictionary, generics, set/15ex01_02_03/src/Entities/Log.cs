namespace _15ex01_02_03.src
{
    internal class Log
    {
        public string Name { get; set; }
        private DateTime Date { get; set; }

        public Log(string name, DateTime date)
        {
            Name = name;
            Date = date;
        }

        public override string ToString()
        {
            return $"{Name},{Date}";
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Log))
            {
                return false;
            }
            Log other = obj as Log;
            return GetHashCode().Equals(other.GetHashCode());
        }
    }
}
