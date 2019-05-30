using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Abstract
{
    public abstract class Auditable : IAuditable
    {
        public DateTime? CreatedDate { set; get; }
        [MaxLength(256)]
        public string CreatedBy { set; get; }
        public DateTime? UpdateDate { set; get; }
        public string MetaKeyWord { set; get; }
        public string MetaDescription { set; get; }
        public string UpdateBy { set; get; }
        public bool Status { set; get; }
    }
}
