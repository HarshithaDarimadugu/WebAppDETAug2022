using APIDemo.Model;

namespace APIDemo.Services
{
    public class TicketsService
    {
        static List<Ticket> Tickets { get; }
        static TicketsService()
        {
            Tickets = new List<Ticket>
            {
                    new Ticket {ID = 10, BookedFor = "PlantinumPlus", Price = 5000, Qty = 200 },
                    new Ticket {ID = 13, BookedFor = "Plantinum", Price = 4000, Qty = 30 },
                    new Ticket {ID = 22, BookedFor = "Gold", Price = 4000, Qty = 300 },
                    new Ticket {ID = 17, BookedFor = "Silver", Price = 4000, Qty = 50 },
                    new Ticket {ID = 19, BookedFor = "General", Price = 4000, Qty = 10 }
                };
        }

        public static List<Ticket> GetAll() => Tickets;

        public static Ticket Get(int id)
        {
            Ticket ticket = Tickets.FirstOrDefault(x => x.ID == id);
            return ticket;
        }

    }
}
