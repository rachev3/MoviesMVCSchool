using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Movies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();
                //Cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>(){
                      new Cinema()
                      {
                          Name = "Iskra",
                          Logo = "https://www.google.com/search?q=cinema+iskra+logo&sxsrf=ALiCzsZ28a9OnnPvMl4FTSrovLA-Wl5GPg:1671086020910&source=lnms&tbm=isch&sa=X&ved=2ahUKEwiAhanFgPv7AhWrSPEDHW_NDtkQ_AUoAXoECAEQAw&biw=1536&bih=754&dpr=1.25#imgrc=jTMkLNzGqpXeTM",
                          Description = "The best cinema"

                      },
                      new Cinema()
                      {
                          Name = "Cinema Mall Veliko Tarnovo",
                          Logo = "https://www.google.com/search?q=mall+veliko+tarnovo+cinema+logo&sxsrf=ALiCzsY6yK0j6DWIG0M4JLGSUf-th5Qh3Q:1671086436600&source=lnms&tbm=isch&sa=X&ved=2ahUKEwjJ4sSLgvv7AhVyQ_EDHaQ2CIgQ_AUoAXoECAIQAw&biw=1536&bih=754&dpr=1.25#imgrc=MHk6qeoTfUqciM"
                          Description = "The worst cinema"
                      }
                      ,
                      new Cinema()
                      {
                          Name = "Arena",
                          Logo="https://www.google.com/search?q=arena+cinema+logo&sxsrf=ALiCzsZ2overhhOl6RcHSY3ljMjiseAhdA:1671086530311&source=lnms&tbm=isch&sa=X&ved=2ahUKEwj-spy4gvv7AhUDYPEDHQ8aBnAQ_AUoAXoECAEQAw&biw=1536&bih=754&dpr=1.25#imgrc=jGXFTmv2YjdB6M"
                          Description = "Arena cinema Sofia"
                      }
                    });
                    context.SaveChanges();
                }
                //Actor
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                      new Actor()
                      {
                          FullName = "Jake Gyllenhaal",
                          Bio = "best",
                          ProfilePictureUrl ="https://www.google.com/search?q=jake+gyllenhaal+movies&oq=jake&aqs=chrome.1.69i57j69i59j46i433i512l2j0i512j0i131i433i512j46i512j69i61.4649j0j7&sourceid=chrome&ie=UTF-8#imgrc=pRxAQs4AeAJSXM%253A"
                      },
                      new Actor()
                      {
                          FullName = "Angelina Jolie",
                          Bio = "woman",
                          ProfilePictureUrl = "https://www.google.com/search?q=angelina+jolie&hl=en&sxsrf=ALiCzsYTego_tyvPXuuA-HgJlt5C92NE6w:1671088717241&source=lnms&tbm=isch&sa=X&ved=2ahUKEwjo9IHLivv7AhVKSPEDHaEhAmcQ_AUoAXoECAMQAw&biw=1536&bih=754&dpr=1.25#imgrc=GX8LaBBpBa0G0M"
                      },
                      new Actor()
                      {
                          FullName = "Dwayne Johnson",
                          Bio = "rich",
                          ProfilePictureUrl = "https://www.google.com/search?q=the+rock&sxsrf=ALiCzsYcMENxWgRqhtyIpCr1wQMYlnOlmA:1671088787787&source=lnms&tbm=isch&sa=X&ved=2ahUKEwiB5NXsivv7AhXlSfEDHfsWDycQ_AUoAXoECAEQAw&biw=1536&bih=754&dpr=1.25#imgrc=zLR6B2lwDvvQOM"
                      },
                      new Actor()
                      {
                          FullName ="Kevin Hart",
                          Bio = "funny",
                          ProfilePictureUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fen.wikipedia.org%2Fwiki%2FKevin_Hart&psig=AOvVaw2R7Y_viLHHlAbhxtwQq7hR&ust=1671175392334000&source=images&cd=vfe&ved=0CBAQjRxqFwoTCJiMts-L-_sCFQAAAAAdAAAAABAE"
                      }

                });
                    context.SaveChanges();
                }
                //Movie
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                           Name = "Prisoners",
                           Description ="",
                           ImageUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.imdb.com%2Ftitle%2Ftt1392214%2F&psig=AOvVaw1bNFvspy3z2XrEWZhO_xC_&ust=1671175792158000&source=images&cd=vfe&ved=0CBAQjRxqFwoTCKDBko6N-_sCFQAAAAAdAAAAABAE",
                           Price ="12$",
                           StartDate = DateTime.Now.AddDays(-5),
                           EndDate = DateTime.Now.AddDays(+3),
                           CinemaId = 1,
                           ProducerID = 1,
                           MovieCategory = MovieCategory.Thriller,

                        },
                        new Movie()
                        {
                           Name = "Central Intelligence",
                           Description ="",
                           ImageUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.imdb.com%2Ftitle%2Ftt1489889%2F&psig=AOvVaw1Phc3C8qqwO5BZSTD6adB6&ust=1671175954186000&source=images&cd=vfe&ved=0CBAQjRxqFwoTCJDDtNuN-_sCFQAAAAAdAAAAABAE",
                           Price ="12$",
                           StartDate = DateTime.Now.AddDays(-4),
                           EndDate = DateTime.Now.AddDays(+4),
                           CinemaId = 2,
                           ProducerID = 2,
                           MovieCategory = MovieCategory.Comedy,

                        },
                         new Movie()
                        {
                           Name = "Lara Croft: Tomb Raider",
                           Description ="",
                           ImageUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.imdb.com%2Ftitle%2Ftt0146316%2F&psig=AOvVaw1CNyj267mgNqMY49Dq24I8&ust=1671176066388000&source=images&cd=vfe&ved=0CBAQjRxqFwoTCMDggJGO-_sCFQAAAAAdAAAAABAE"
                           Price ="12$",
                           StartDate = DateTime.Now.AddDays(-2),
                           EndDate = DateTime.Now.AddDays(+6),
                           CinemaId = 3,
                           ProducerID = 3,
                           MovieCategory = MovieCategory.Action,

                        }
                    });
                    context.SaveChanges();
                }
                //Producer
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    { 
                        new Producer()
                        {
                            FullName = "Lawrence Gordon",
                            Bio = "",
                            ProfilePictureUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fes.wikipedia.org%2Fwiki%2FLawrence_Gordon&psig=AOvVaw21Vxup13Z5Cr4Ar6EytmIl&ust=1671176592972000&source=images&cd=vfe&ved=0CBAQjRxqFwoTCNDJ9YuQ-_sCFQAAAAAdAAAAABAE"
                        },
                        new Producer()
                        {
                            FullName = "Broderick Johnson",
                            Bio = "",
                            ProfilePictureUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ea/Broderick_Johnson_by_Gage_Skidmore.jpg/330px-Broderick_Johnson_by_Gage_Skidmore.jpg"
                        },
                        new Producer()
                        {
                           FullName = "Scott Stuber",
                           Bio = "",
                           ProfilePictureUrl = "https://upload.wikimedia.org/wikipedia/commons/c/c9/Scott_Stuber_2016.png"
                        }
                    });
                    context.SaveChanges();
                }
                //MovieActor
                if (!context.MovieActors.Any())
                {
                    context.MovieActors.AddRange(new List<MovieActor>()
                    {
                        new MovieActor()
                        {
                            MovieID = 1,
                            ActorID = 1
                        },
                        new MovieActor()
                        {
                            MovieID = 2,
                            ActorID = 3,
                        },
                        new MovieActor()
                        {
                            MovieID = 2,
                            ActorID = 4,
                        },
                        new MovieActor()
                        {
                            MovieID = 3,
                            ActorID = 2,
                        },
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
