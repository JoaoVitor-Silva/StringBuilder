using System;
using System.Collections.Generic;
using System.Text;

namespace Enum___ExercicioFixação2.Posts
{
    class Post
    {

        public DateTime Moment { get; set; }
        public String Title { get; set; }
        public String Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();  


        public Post()
        {
        }

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComments(Comment comment)
        {
            Comments.Add(comment);
        }

        public void RemoveComments(Comment comment)
        {
            Comments.Remove(comment);
        }

        public override string ToString()
        {
            StringBuilder Text = new StringBuilder();
            Text.AppendLine(Title);
            Text.Append(Likes);
            Text.Append(" Likes - ");
            Text.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            Text.AppendLine(Content);
            Text.AppendLine("Comments");
            foreach(Comment comment in Comments)
            {
                Text.AppendLine(comment.Text);
            }
            return Text.ToString();
        }

    }
}
