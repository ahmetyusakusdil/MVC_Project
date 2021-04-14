using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Concrete
{
   public class Content
    {
        public int ContentId { get; set; }
        public string ContentText { get; set; }
        public DateTime ContentDate { get; set; }


        public int HeadingId { get; set; }
        public virtual Heading Heading { get; set; }

    }
}
