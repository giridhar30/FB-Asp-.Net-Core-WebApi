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

            if (!context.Watch.Any())
            {
                var watchs = new Watch[]
                {
                    new Watch
                    {
                          no_of_comments = "25M",
                          no_of_like = "32M",
                          no_of_views = "112M",
                          posted_date = "march 27 at 12:45",
                          user_dp = "https://static.toiimg.com/photo/msid-90466724/90466724.jpg?39050",
                          username = "Ram charan",
                          video = "https://www.youtube.com/embed/G62HrubdD6o"
                    },
                    new Watch
                    {
                        no_of_comments = "25M",
                        no_of_like = "32M",
                        no_of_views = "112M",
                        posted_date = "march 27 at 12:45",
                        user_dp = "https://static.toiimg.com/photo/msid-90466724/90466724.jpg?39050",
                        username = "Ram charan",
                        video = "https://www.youtube.com/embed/G62HrubdD6o"
                    },
                    new Watch
                    {
                        no_of_comments = "25M",
                        no_of_like = "32M",
                        no_of_views = "112M",
                        posted_date = "march 27 at 12:45",
                        user_dp = "https://static.toiimg.com/photo/msid-90466724/90466724.jpg?39050",
                        username = "Ram charan",
                        video = "https://www.youtube.com/embed/G62HrubdD6o"
                    },
                };

                foreach (Watch w in watchs)
                {
                    context.Watch.Add(w);
                }

                context.SaveChanges();
            }

            if (!context.FriendSuggestion.Any())
            {
                var friend = new FriendSuggestion[]
                {
                    new FriendSuggestion
                    {
                        Accept = "neutral",
                        Education = "Studied at harvard University",
                        Image_url = "https://th.bing.com/th/id/OIP.wXqI4TPDiNuoxRjIb3vGHQHaGL?pid=ImgDet&rs=1",
                        Mutual_friends = "2",
                        Name = "Chris Hughes",
                        Friends_url ="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTLEHswHVyxjQ-muQA6Te6teY_DxAw-cOm-gA&usqp=CAU",
                        Friends_name = "Pranesh",
                        Work = "Co-Chair at Economic Security Project and Co-founder at Facebook App"
                    },
                    new FriendSuggestion
                    {
                        Accept = "neutral",
                        Education = "NYU Stern School of Business",
                        Image_url = "https://www.bing.com/th?id=AMMS_6401f02989627919a8d6c6b4f20e1d9b&w=120&h=160&c=12&rs=1&qlt=80&o=6&cdv=1&dpr=1.5&rf=Placeholder-Person_60x60.png&pid=16.2",
                        Mutual_friends = "2",
                        Name = "Kevin Systrom",
                        Friends_url ="https://www.photopills.com/sites/default/files/tutorials/2020/sunrise-cover.jpg",
                        Friends_name = "Keerthivasan",
                        Work = "Programmer & Entrepreneur and founder of Instagram"
                    },
                    new FriendSuggestion
                    {
                        Accept = "neutral",
                        Education = "Studied Economics at Harvard University",
                        Image_url = "https://cdn01.vulcanpost.com/wp-uploads/2020/08/eduardo-saverin.png",
                        Mutual_friends = "3",
                        Name = "Eduardo Saverin",
                        Friends_url ="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQw45u8HGeQQVqTYm5HXl7khHg0Y2SmyywcJw&usqp=CAU",
                        Friends_name = "Vigneswar",
                        Work = "Co-founder at Facebook App"
                    },
                    new FriendSuggestion
                    {
                        Accept = "neutral",
                        Education = "NYU Stern School of Business",
                        Image_url = "https://media-exp1.licdn.com/dms/image/C4D03AQEjoEO4vmHDIA/profile-displayphoto-shrink_400_400/0/1568044697083?e=2147483647&v=beta&t=08U3qplXHnzgBZ6nWIE-j7SfrEOdqmktyaJKaEGxc78",
                        Mutual_friends = "2",
                        Name = "Bob Cagnazzi",
                        Friends_url ="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQw45u8HGeQQVqTYm5HXl7khHg0Y2SmyywcJw&usqp=CAU",
                        Friends_name = "Giridhar",
                        Work = "CEO at Presidio"
                    },
                    new FriendSuggestion{
                        Accept = "neutral",
                        Education = "Studied at Universitas Paramadina",
                        Image_url = "https://th.bing.com/th/id/OIP.cMFRr8KMyYC2j6GueJ7YMgHaEo?pid=ImgDet&rs=1",
                        Mutual_friends = "2",
                        Name = "HairilPauzi",
                        Friends_url ="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQw45u8HGeQQVqTYm5HXl7khHg0Y2SmyywcJw&usqp=CAU",
                        Friends_name = "Divya",
                        Work = "Manager at Self Employed (Business)"
                    },
                    new FriendSuggestion{
                        Accept = "neutral",
                        Education = "Studied at Al-aqsa primary and secondary school",
                        Image_url = "https://th.bing.com/th/id/OIP.QBCoV6d7oWbyJjl4R8wvKgHaHY?pid=ImgDet&rs=1",
                        Mutual_friends = "2",
                        Name = "Mohamed Khadar Haji",
                        Friends_url ="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQw45u8HGeQQVqTYm5HXl7khHg0Y2SmyywcJw&usqp=CAU",
                        Friends_name = "Yazhini",
                        Work = "Works at Facebook App"
                    },
                    new FriendSuggestion{
                        Accept = "neutral",
                        Education = "Studied Economics at Harvard University",
                        Image_url = "https://th.bing.com/th/id/OIP.8de3LN92R_UDLn5t8W3dkQAAAA?w=233&h=180&c=7&r=0&o=5&dpr=1.5&pid=1.7",
                        Mutual_friends = "2",
                        Name = "Pete Kocks",
                        Friends_url ="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQw45u8HGeQQVqTYm5HXl7khHg0Y2SmyywcJw&usqp=CAU",
                        Friends_name = "Hari",
                        Work = "Works at Salesforce"
                    },
                    new FriendSuggestion{
                        Accept = "neutral",
                        Education = "Studied at Harvard University",
                        Image_url = "https://www.bing.com/th?id=AMMS_f7740bdadb46896a29fc14fb61f57189&w=120&h=160&c=12&rs=1&qlt=80&o=6&cdv=1&dpr=1.5&rf=Placeholder-Person_60x60.png&pid=16.2",
                        Mutual_friends = "5",
                        Name = "Shreyl SandBerg",
                        Friends_url ="https://www.photopills.com/sites/default/files/tutorials/2020/sunrise-cover.jpg",
                        Friends_name = "Jerry",
                        Work = "Chief operating officer at Meta"
                    }
                };

                foreach (FriendSuggestion f in friend)
                {
                    context.FriendSuggestion.Add(f);
                }

                context.SaveChanges();
            }

            if (!context.FriendList.Any())
            {
                var friend = new FriendList[]
                {
                    new FriendList
                    {
                        Accept = "neutral",
                        Education = "Studied at harvard University",
                        Image_url = "https://scontent.fixm4-1.fna.fbcdn.net/v/t39.30808-1/274956007_8430212720338310_8265895301701885934_n.jpg?stp=dst-jpg_p240x240&_nc_cat=105&ccb=1-6&_nc_sid=7206a8&_nc_ohc=euEMd7VXK1sAX_KdYLS&_nc_oc=AQnhtdVPDiMjQXDKgZKyApjaBPjOpIwS9rqFb_KWnT7EnqIy5KfmT0OQqWVCwsKUYBulUEmoBasgaPWfmEhXoo7N&tn=zGKqiCGg0sq9Xfek&_nc_ht=scontent.fixm4-1.fna&oh=00_AT_MbYXRSjXN7YRkNhnJ-BmARpQsS16QxVD60zedS-Hklg&oe=627E92F7",
                        Mutual_friends = "2",
                        Name = "Deepika Sanna",
                        Friends_url ="https://www.photopills.com/sites/default/files/tutorials/2020/sunrise-cover.jpg",
                        Friends_name = "Yazhini",
                        Work = "Programmer at Meta"
                    },
                    new FriendList{
                        Accept = "neutral",
                        Education = "Studied at UCSF",
                        Image_url = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a8/Priscilla_Chan%2C_2018_%28cropped%29.jpg/330px-Priscilla_Chan%2C_2018_%28cropped%29.jpg",
                        Mutual_friends = "1",
                        Name = "Priscilla Chan",
                        Friends_url ="https://www.photopills.com/sites/default/files/tutorials/2020/sunrise-cover.jpg",
                        Friends_name = "Yazhini",
                        Work ="Founder at Chan Zuckerberg Initiative"
                    }
                };

                foreach (FriendList f in friend)
                {
                    context.FriendList.Add(f);
                }

                context.SaveChanges();
            }

            if (!context.MarketData.Any())
            {
                var marketData = new MarketData[]
                {
                    new MarketData
                    {
                        Src = "https://firebasestorage.googleapis.com/v0/b/facebook-ui-clone-2d854.appspot.com/o/himalaya.jpg?alt=media&token=a6c4836f-6a1e-4551-bcb8-bac1b24db657",
                        Dec = "Himalayan",
                        Price = 2500,
                        Location = "chennai"
                    },
                    new MarketData
                    {
                        Src = "https://firebasestorage.googleapis.com/v0/b/facebook-ui-clone-2d854.appspot.com/o/motorbike.jpg?alt=media&token=e50cab0e-feaa-428c-b490-e8d1bc226dec",
                        Dec = "Bike",
                        Price = 1000,
                        Location = "Hosur"
                    },
                    new MarketData
                    {
                        Src = "https://firebasestorage.googleapis.com/v0/b/facebook-ui-clone-2d854.appspot.com/o/ktm.jpg?alt=media&token=d249233e-655d-43ee-8345-04655da09915",
                        Dec = "KTM",
                        Price = 78000,
                        Location = "Banglore"
                    }

                };

                foreach (MarketData md in marketData)
                {
                    context.MarketData.Add(md);
                }

                context.SaveChanges();
            }

            if (!context.Gpost.Any())
            {
                //Console.WriteLine("Gposts created");
                var gPosts = new Gpost[] {
                    new Gpost { Name = "Tenz", ProfileImg = "https://www.bestpvpers.com/wp-content/uploads/2021/09/tenz-1.jpg", VideoUrl="https://www.youtube.com/embed/uIt298IgFhk" },
                    new Gpost { Name="Unreal Dreamer", ProfileImg="https://yt3.ggpht.com/qH3O0F_fbvANyzk904IHQaxDUootPy38WwTQxInclcM0b2s4ttnkdHxeURQ0y3YJD87AOqAjdg=s176-c-k-c0x00ffffff-no-rj-mo", VideoUrl="https://www.youtube.com/embed/-dCIPjxH3wU"},
                    new Gpost {Name="Mark", ProfileImg = "https://yourwikis.com/wp-content/uploads/2020/01/mark-zuck-img.jpg", VideoUrl="https://www.youtube.com/embed/p4QG59y6FGE"}
                };

                foreach (Gpost p in gPosts)
                {
                    context.Gpost.Add(p);
                }

                context.SaveChanges();
            }
        }
    }
}