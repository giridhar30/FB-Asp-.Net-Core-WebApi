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
                var users = new User[]
                {
                    new User{
                        Name="Wes Anderson",
                        ProfileImg="https://cdn.allfamous.org/people/avatars/wes-anderson-m4f2-allfamous.org.jpg",
                        Active=true,
                        Mutual=4
                    },
                    new User{
                        Name="Quentin Tarantino",
                        ProfileImg="https://www.themoviedb.org/t/p/w235_and_h235_face/1gjcpAa99FAOWGnrUvHEXXsRs7o.jpg",
                        Active=true,
                        Mutual=4
                    },
                    new User{
                        Name="Yorgos Lanthimos",
                        ProfileImg="https://upload.wikimedia.org/wikipedia/commons/thumb/9/91/Yorgos_Lanthimos%2C_THE_LOBSTER%2C_Fantastic_Fest_2015_-9674_%2827161878820%29.jpg/330px-Yorgos_Lanthimos%2C_THE_LOBSTER%2C_Fantastic_Fest_2015_-9674_%2827161878820%29.jpg",
                        Active=true,
                        Mutual=4
                    },
                    new User{
                        Name="Alejandro Inarritu",
                        ProfileImg="https://upload.wikimedia.org/wikipedia/commons/thumb/4/48/Alejandro_Gonz%C3%A1lez_I%C3%B1%C3%A1rritu_2014.jpg/654px-Alejandro_Gonz%C3%A1lez_I%C3%B1%C3%A1rritu_2014.jpg",
                        Active=true,
                        Mutual=4
                    },
                    new User{
                        Name="Bong Joon Ho",
                        ProfileImg="https://s3.amazonaws.com/criterion-production/explore_images/1028-a00db9fe603bb7d63d1851d110b824a2/DUG7s5aiNsjhrNGxBO0Ex60XJvGjfd_original.jpg",
                        Active=true,
                        Mutual=4
                    }
                };

                foreach (User u in users)
                {
                    context.User.Add(u);
                }

                context.SaveChanges();
            }

            if (!context.ProfileFriend.Any())
            {
                var profileFriends = new ProfileFriend[]
                {
                    new ProfileFriend
                    {
                        Name = "Burn Abasse",
                        Img = "https://randomuser.me/api/portraits/men/23.jpg",
                    },
                    new ProfileFriend
                    {
                        Name = "Neab Mey",
                        Img = "https://randomuser.me/api/portraits/men/27.jpg",
                    },
                    new ProfileFriend
                    {
                        Name = "Ogbulata Rolly B Roland",
                        Img = "https://randomuser.me/api/portraits/men/22.jpg",
                    },
                    new ProfileFriend
                    {
                        Name = "Machaba Marceloovoid",
                        Img = "https://randomuser.me/api/portraits/men/52.jpg",
                    },
                    new ProfileFriend
                    {
                        Name = "Rubengod de Luque",
                        Img = "https://randomuser.me/api/portraits/men/67.jpg",
                    },
                    new ProfileFriend
                    {
                        Name = "Sangkut Susanti",
                        Img = "https://randomuser.me/api/portraits/men/39.jpg",
                    },
                    new ProfileFriend
                    {
                        Name = "Kazol Kazol",
                        Img = "https://randomuser.me/api/portraits/men/81.jpg",
                    },
                    new ProfileFriend
                    {
                        Name = "LƯU NGUYÊN",
                        Img = "https://randomuser.me/api/portraits/men/80.jpg",
                    },
                    new ProfileFriend
                    {
                        Name = "Yeen Prc",
                        Img = "https://randomuser.me/api/portraits/men/61.jpg",
                    }
                };

                foreach (ProfileFriend pf in profileFriends)
                {
                    context.ProfileFriend.Add(pf);
                }

                context.SaveChanges();
            }

            if (!context.ProfilePhoto.Any())
            {
                var profilePhotos = new ProfilePhoto[]
                {
                    new ProfilePhoto
                    {
                        Url = "https://randomuser.me/api/portraits/men/4.jpg"
                    },
                    new ProfilePhoto
                    {
                        Url = "https://randomuser.me/api/portraits/men/88.jpg"
                    },
                    new ProfilePhoto
                    {
                        Url = "https://randomuser.me/api/portraits/men/66.jpg"
                    },
                    new ProfilePhoto
                    {
                        Url = "https://randomuser.me/api/portraits/men/62.jpg"
                    },
                    new ProfilePhoto
                    {
                        Url = "https://randomuser.me/api/portraits/men/90.jpg"
                    },
                    new ProfilePhoto
                    {
                        Url = "https://randomuser.me/api/portraits/men/49.jpg"
                    },
                    new ProfilePhoto
                    {
                        Url = "https://randomuser.me/api/portraits/men/24.jpg"
                    },
                    new ProfilePhoto
                    {
                        Url = "https://randomuser.me/api/portraits/men/55.jpg"
                    },
                    new ProfilePhoto
                    {
                        Url = "https://randomuser.me/api/portraits/men/82.jpg"
                    }
                };

                foreach (ProfilePhoto pp in profilePhotos)
                {
                    context.ProfilePhoto.Add(pp);
                }

                context.SaveChanges();
            }
        }
    }
}