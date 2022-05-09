using FbBackend.Models;
using System;
using System.Linq;

namespace FbBackend.Data
{
    public static class DbInitializer
    {
        public static void Initialize(FbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (!context.Posts.Any())
            {
                var posts = new Post[]
                {
                    new Post{
                          Become_friend_1="Vijay",
                          Become_friend_2="Ajith",
                          Comment="Hi",
                          Comment_user_dp="https://i.pinimg.com/originals/67/f8/06/67f8069527ae689ee3ae05a52bed2ce7.jpg",
                          Comment_user_name="Saairaam",
                          Imgsrc="https://p1.pxfuel.com/preview/631/595/702/sea-rocks-sunset-evening-water.jpg",
                          Last_seen="active",
                          Mutual_friend_1="1",
                          Mutual_friend_2="2",
                          No_of_comments="0",
                          No_of_likes="0",
                          Text="Good evening presidio!",
                          Userdp="https://yourwikis.com/wp-content/uploads/2020/01/mark-zuck-img.jpg",
                          Username="Mark Zuckerberg"
                    },
                    new Post{
                          Become_friend_1="Ram",
                          Become_friend_2="Shyam",
                          Comment="Enakku nane",
                          Comment_user_dp="https://yourwikis.com/wp-content/uploads/2020/01/mark-zuck-img.jpg",
                          Comment_user_name="Mark Zuckerberg",
                          Imgsrc="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQZgc8ENvGvZFQgCkrub9lta-1MCFV5UD9LUA&usqp=CAU",
                          Last_seen="active",
                          Mutual_friend_1="1",
                          Mutual_friend_2="2",
                          No_of_comments="1",
                          No_of_likes="0",
                          Text="Good morning presidio!",
                          Userdp="https://yourwikis.com/wp-content/uploads/2020/01/mark-zuck-img.jpg",
                          Username="Mark Zuckerberg"
                    },
                    new Post{
                          Become_friend_1="Kabir",
                          Become_friend_2="Raheem",
                          Comment="Thalaivare!",
                          Comment_user_dp="https://images.mubicdn.net/images/cast_member/2184/cache-2992-1547409411/image-w856.jpg?size=800x",
                          Comment_user_name="Vanangamudi",
                          Imgsrc="https://st.depositphotos.com/1006706/2671/i/600/depositphotos_26715369-stock-photo-which-way-to-choose-3d.jpg",
                          Last_seen="active",
                          Mutual_friend_1="1",
                          Mutual_friend_2="2",
                          No_of_comments="0",
                          No_of_likes="0",
                          Text="Good evening presidio!",
                          Userdp="https://yourwikis.com/wp-content/uploads/2020/01/mark-zuck-img.jpg",
                          Username="Mark Zuckerberg"
                    },
                };

                foreach (Post p in posts)
                {
                    context.Posts.Add(p);
                }

                context.SaveChanges();
            }

            if (!context.User.Any())
            {
                
            }
        }
    }
}