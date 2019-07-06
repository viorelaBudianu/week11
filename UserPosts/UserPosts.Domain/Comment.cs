using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserPosts.Domain
{
    public class Comment : BaseEntity
    {
        private int Postid;
        private string Text;


        public int PostId
        {
            get
            {
                return this.Postid;
            }
            set
            {
                this.Postid = value;
            }
        }
        public string CommentText
        {
            get { return this.Text; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Please add a comment");
                }
                else
                    this.Text = value;
            }
        }

    }
}