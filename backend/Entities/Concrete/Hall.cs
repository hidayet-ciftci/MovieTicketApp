using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Hall : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RowCount { get; set; }
        public int SeatsPerRow { get; set; }
        public bool IsActive { get; set; }
        public DateTimeOffset CreatedTime { get; set; }
    }
}
