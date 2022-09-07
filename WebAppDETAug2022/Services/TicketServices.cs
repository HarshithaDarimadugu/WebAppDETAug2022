using System.Xml.Linq;
using WebAppDETAug2022.Models;

namespace WebAppDETAug2022.Services
{
    public class TicketServices
    {
     
          static List<Tickets> Tickets { get; set; }
            static int nextId = 3;
        private static Tickets ticket;

        static TicketServices()
            {
                Tickets = new List<Tickets>
                {
                    new Tickets { Category = "PlantinumPlus", Price = 5000, MaxLimit = 200000 },
                    new Tickets { Category = "Plantinum", Price = 4000, MaxLimit = 300000 }
                };
            }

        public static List<Pizza> GetAll(List<Pizza> tickets) => tickets;
        public static Tickets? Get(int id) => Tickets.FirstOrDefault(p => p.Id == id);


        public static void Add(Tickets ticket)
            {
            //ticket.Id = nextId++;
            Models.Tickets.Add(ticket);
            }

            public static void Delete()
            {
               // var Ticket = Get(id);
                if (Tickets is null)
                    return;

                Tickets.Remove(ticket);
            }

        //public static void Update(Tickets ticket)
        //{
        //    var tickets = Models.Tickets
        //    if (Tickets == -1)
        //        return;

        //    Tickets[] = ticket;
        //}
    }
}

