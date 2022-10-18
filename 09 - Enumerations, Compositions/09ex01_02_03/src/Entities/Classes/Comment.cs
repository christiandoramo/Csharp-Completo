
namespace _09ex01_02_03.src.Entities.Classes
{
    class Comment
    {
        private string Text { get; set; }

        public Comment(string text)
        {
            Text = text;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
