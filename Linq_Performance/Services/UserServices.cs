using Linq_Performance.Models;

namespace Linq_Performance.Services
{
    public class UserServices
    {
        private List<User> users()
        {
            List<User> list = new List<User>
            {
                new User{Id = 1,Name = "Name1",LastName = "LastName1"},
                new User{Id = 2,Name = "Name2",LastName = "LastName2"},
                new User{Id = 3,Name = "Name3",LastName = "LastName3"},
                new User{Id = 4,Name = "Name4",LastName = "LastName4"},
                new User{Id = 5,Name = "Name5",LastName = "LastName5"},
                new User{Id = 6,Name = "Name6",LastName = "LastName6"},
                new User{Id = 7,Name = "Name7",LastName = "LastName7"},
                new User{Id = 8,Name = "Name8",LastName = "LastName8"},
                new User{Id = 9,Name = "Name9",LastName = "LastName9"},
                new User{Id = 10,Name = "Name10",LastName = "LastName10"},
                new User{Id = 11,Name = "Name11",LastName = "LastName11"},
                new User{Id = 12,Name = "Name12",LastName = "LastName12"},
                new User{Id = 13,Name = "Name13",LastName = "LastName13"},
                new User{Id = 14,Name = "Name14",LastName = "LastName14"},
                new User{Id = 15,Name = "Name15",LastName = "LastName15"},
                new User{Id = 16,Name = "Name16",LastName = "LastName16"},
                new User{Id = 17,Name = "Name17",LastName = "LastName17"},
                new User{Id = 18,Name = "Name18",LastName = "LastName18"},
                new User{Id = 19,Name = "Name19",LastName = "LastName19"},
                new User{Id = 20,Name = "Name20",LastName = "LastName20"},
                new User{Id = 21,Name = "Name21",LastName = "LastName21"},
                new User{Id = 22,Name = "Name22",LastName = "LastName22"},
                new User{Id = 23,Name = "Name23",LastName = "LastName23"},
                new User{Id = 24,Name = "Name24",LastName = "LastName24"},
                new User{Id = 25,Name = "Name25",LastName = "LastName25"},

            };



            return list;
        }

        //For Larg Data Use Skip and Take
        public List<User> SkipAndTake()
        {
            var user=users();

            // var list=user.Skip(10).ToList();

            var list = user.Take(15).Skip(10).ToList();


            return list;
        } 

        //reduce Trips To DataBase
        // public void add(List<User> users)
        // {
        //     users.AddRange(users);
        //     users.RemoveAll(users);
        //
        // }

        //TryGetNonEnumeratedCount When Work Larg Collection And Use Pagination Need To Count
        public void GetByCount()
        {
            var list = users();
            int count;
             list.TryGetNonEnumeratedCount(out count);
        }



        7

    }
}
