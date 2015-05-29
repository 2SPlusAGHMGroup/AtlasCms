using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicModels
{
    public class Attachment
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public virtual ICollection<Article> Articles { get; set; }
    }
}
