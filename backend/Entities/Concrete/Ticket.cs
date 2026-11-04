using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Ticket : IEntity
    {
        public int Id { get; set; }
        public int ReservationId { get; set; }
        public int SessionId { get; set; }
        public int SeatId { get; set; }
        public decimal Price { get; set; }
    }
}
