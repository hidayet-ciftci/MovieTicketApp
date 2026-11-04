using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Seat : IEntity
    {
        public int Id { get; set; }
        public int HallId { get; set; }
        public string RowLetter { get; set; }
        public int SeatNumber { get; set; }
        public string SeatType { get; set; }
    }
}
