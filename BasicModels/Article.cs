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
        public virtual User CreateBy { get; set; }
        public DateTime PublishDate { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsPublish { get; set; }
        public virtual ICollection<Attachment> Attachments { get; set; }
        public virtual ICollection<Category> Category { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }

    }
}
