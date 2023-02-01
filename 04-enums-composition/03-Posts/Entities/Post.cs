using System.Text;

namespace _03_Posts.Entities
{
    internal class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }

        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post() { }

        public Post(DateTime moment, string title, string content)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = 0;
        }

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }

        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
        }

        public void LikePost()
        {
            Likes++;
        }

        public void RemoveLikeFromPost()
        {
            Likes--;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes + " Likes - ");
            sb.AppendLine(Moment.ToString("dd/mm/yyyy hh:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments: ");
            foreach(Comment comment in Comments)
            {
                sb.AppendLine(comment.Text); 
            }
            return sb.ToString();
        }
    }
}
