using Microsoft.AspNetCore.Identity;
using sinemaOtamasyonu.Data.Enums;
using sinemaOtamasyonu.Data.Static;
using sinemaOtamasyonu.Models;

namespace sinemaOtamasyonu.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Sinemalar
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Paribu Cineverse Akasya",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            Description = "Acıbadem Mahallesi Çeçen Sokak No:25 Üsküdar/İstanbul"
                        },
                        new Cinema()
                        {
                            Name = "Paribu Cineverse Zorlu Center",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            Description = "Zorlu Center AVM Beşiktaş/İstanbul"
                        },
                        new Cinema()
                        {
                            Name = "AKM Yeşilçam Sineması",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                            Description = "Atatürk Kültür Merkezi, 34435 Beyoğlu/İstanbul"
                        },
                        new Cinema()
                        {
                            Name = "Kadıköy Sineması",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                            Description = "Osmanağa, Bahariye Cad. Kadıköy Pasajı No:25, 34714 Kadıköy/İstanbul"
                        },
                        new Cinema()
                        {
                            Name = "Paribu Cineverse Kocaeli",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-5.jpeg",
                            Description = "Sanayi Mah. Ömer Türkçakal Bulvarı No: 7, 41040 İzmit/Kocaeli"
                        },
                    });
                    context.SaveChanges();
                }
                //Oyuncular
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Ahmet Mümtaz Taylan",
                            Bio = "Bio",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-1.jpeg"

                        },
                        new Actor()
                        {
                            FullName = "Zeynep Çamcı",
                            Bio = "Bio",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-2.jpeg"
                        },
                        new Actor()
                        {
                            FullName = "Necip Memili",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-3.jpeg"
                        },
                        new Actor()
                        {
                            FullName = "Aras Bulut İynemli",
                            Bio = "Bio",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-4.jpeg"
                        },
                        new Actor()
                        {
                            FullName = "Esra Bilgiç",
                            Bio = "Bio",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-5.jpeg"
                        }
                    });
                    context.SaveChanges();
                }
                //Yönetmenler
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Mehmet Ada Öztekin",
                            Bio = "Bio",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-1.jpeg"

                        },
                        new Producer()
                        {
                            FullName = "Tolga Örnek",
                            Bio = " Bio",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-2.jpeg"
                        },
                        new Producer()
                        {
                            FullName = "Yorgos Lanthimos",
                            Bio = "Bio",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-3.jpeg"
                        },
                        new Producer()
                        {
                            FullName = "İlker Çatak",
                            Bio = "Bio",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-4.jpeg"
                        },
                        new Producer()
                        {
                            FullName = "Erman Bostan",
                            Bio = "Bio",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-5.jpeg"
                        }
                    });
                    context.SaveChanges();
                }
                //Filmler
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "Arap Kadri",
                            Description = "Arap kadri film içeriği",
                            Price = 99.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-3.jpeg",

                            CinemaId = 3,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Komedi
                        },
                        new Movie()
                        {
                            Name = "Atatürk 2",
                            Description = "Atatürk 2 film içeriği",
                            Price = 119.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-1.jpeg",

                            ProducerId = 1,
                            MovieCategory = MovieCategory.Belgesel
                        },
                        new Movie()
                        {
                            Name = "Mucize Aynalar",
                            Description = "Mucize aynalar film içeriği",
                            Price = 139.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-4.jpeg",

                            CinemaId = 4,
                            ProducerId = 4,
                            MovieCategory = MovieCategory.Komedi
                        },
                        new Movie()
                        {
                            Name = "Cadı",
                            Description = "Cadı film içeriği",
                            Price = 119.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-6.jpeg",

                            CinemaId = 1,
                            ProducerId = 2,
                            MovieCategory = MovieCategory.Dram
                        },
                        new Movie()
                        {
                            Name = "Zavallılar",
                            Description = "Zavallılar film içeriği",
                            Price = 89.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-7.jpeg",

                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Bilimkurgu
                        },
                        new Movie()
                        {
                            Name = "Öğretmenler Odası",
                            Description = "Öğretmenler odası film içeriği",
                            Price = 99.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-8.jpeg",

                            CinemaId = 1,
                            ProducerId = 5,
                            MovieCategory = MovieCategory.Dram
                        }
                    });
                    context.SaveChanges();
                }
                //Actors & Movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 1
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 1
                        },

                         new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 2
                        },
                         new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 2
                        },

                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 3
                        },


                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 4
                        },


                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 5
                        },


                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 6
                        },
                    });
                    context.SaveChanges();
                }
            }

        }
        public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {

                //kullanıcı rolleri
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));

                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

                //kullanıcılar
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                string adminUserEmail = "admin@sinema.com";

                var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
                if (adminUser == null)
                {
                    var newAdminUser = new ApplicationUser()
                    {
                        FullName = "Admin",
                        UserName = "admin",
                        Email = adminUserEmail,
                        EmailConfirmed= true
                    };
                    await userManager.CreateAsync(newAdminUser,"Coding@1234?");
                    await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
                }

                string appUserEmail = "user@sinema.com";

                var appUser = await userManager.FindByEmailAsync(appUserEmail);
                if (appUser == null)
                {
                    var newAppUser = new ApplicationUser()
                    {
                        FullName = "App Kullanıcısı",
                        UserName = "app-kullanıcı",
                        Email = appUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAppUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
                }
            }
        }
    }
}

