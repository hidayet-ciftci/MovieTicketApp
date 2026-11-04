using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Reservation : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int SessionId { get; set; }
        public string ReservationCode { get; set; }
        public string Status { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTimeOffset CreatedTime { get; set; }
    }
}
