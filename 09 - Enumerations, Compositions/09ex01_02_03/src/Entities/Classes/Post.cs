using System;
using System.Collections.Generic;
using System.Text;

namespace _09ex01_02_03.src.Entities.Classes
{
    class Post
    {
        private DateTime Moment { get; set; }
        private string Title { get; set; }
        private string Content { get; set; }
        private int Likes { get; set; }
        // Praticamente sempre que se trabalha com composições haverá a necessidade de usar listas//arrays
        // logo a necessidade de criar metodos de adição e de remoção de itens
        private List<Comment> Lista = new List<Comment>();

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComment(Comment comment)
        {
            Lista.Add(comment);
        }

        public void RemoveComment(Comment comment)
        {
            Lista.Remove(comment);
        }

        public override string ToString()
        {
            // StringBuilder usa System.Text
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.AppendLine($"{Likes} Likes - {Moment}");
            sb.AppendLine($"{Content}");
            sb.AppendLine("Comments: ");
            foreach (Comment comment in Lista)
            {
                sb.AppendLine($"{comment}");
            }
            return sb.ToString();
        }
    }
}
