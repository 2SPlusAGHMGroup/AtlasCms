using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicModels
{
    public class Article
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreateDate { get; set; }
        public User CreateBy { get; set; }
        public DateTime PublishDate { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsPublish { get; set; }
        public List<Attachment> Attachments { get; set; }
        public Category Category { get; set; }
        public List<Tag> Tags { get; set; }

    }
}
