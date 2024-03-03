using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class BaseEntity<TId>
    {
        //<TId> yazma imkanını genericslerden alırız ıd her zaman int yapıda olmak zorunda değil o yüzden TId olarak aldık
        public TId Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
    
    }
}
