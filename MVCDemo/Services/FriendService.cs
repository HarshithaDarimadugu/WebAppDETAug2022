using MVCDemo.Data;
using System.Xml.Linq;

namespace MVCDemo.Services
{
    public class FriendService
    {
        static List<Friends> Friends { get; }
        static int nextId = 4;
        static FriendService()
        {
            Friends = new List<Friends>
                {
                    new Friends { FriendId = 1, FriendName = "Rakshith", Place="Hassan" },
                    new Friends { FriendId = 2, FriendName = "Jeevan Gowda", Place="KGF" },
                    new Friends {FriendId = 3, FriendName = "Nachi", Place="Tumkur" }
                };
        }

        public static List<Friends> GetAll() => Friends;

        public static Friends? Get(int id) => Friends.FirstOrDefault(f => f.FriendId == id);

        public static void Add(Friends friend)
        {
            friend.FriendId = nextId++;
            Friends.Add(friend);
        }

        public static void Delete(int id)
        {
            var friend = Get(id);
            if (friend is null)
                return;

            Friends.Remove(friend);
        }

        public static void Update(Friends friend)
        {
            var index = Friends.FindIndex(f => f.FriendId == friend.FriendId);
            if (index == -1)
                return;

            Friends[index] = friend;
        }

    }
}

    

