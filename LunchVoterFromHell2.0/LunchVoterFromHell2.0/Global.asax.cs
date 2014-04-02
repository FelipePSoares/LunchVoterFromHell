using LunchVoterFromHell2.Database;
using LunchVoterFromHell2.Database.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace LunchVoterFromHell2
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            using (var db = new DataContext())
            {
                if (db.Database.CreateIfNotExists())
                {
                    var group = new Group 
                    {
                        Name = "Grupo AD"
                    };

                    var person = new Person 
                    {
                        Name = "felipepires", 
                        Owner = true, 
                        Group = group 
                    };
                    db.Persons.Add(person);

                    db.Restaurants.Add(new Restaurant
                        {
                            Name = "Green garden",
                            Price = 14,
                            Days = new List<Week>{
                                new Week { Day = DayOfWeek.Monday },
                                new Week { Day = DayOfWeek.Tuesday },
                                new Week { Day = DayOfWeek.Wednesday },
                                new Week { Day = DayOfWeek.Thursday },
                                new Week { Day = DayOfWeek.Friday }
                            }
                        });

                    db.Restaurants.Add(new Restaurant
                    {
                        Name = "Delícia Natural",
                        Price = 17,
                        Days = new List<Week>{
                                new Week { Day = DayOfWeek.Monday },
                                new Week { Day = DayOfWeek.Tuesday },
                                new Week { Day = DayOfWeek.Wednesday },
                                new Week { Day = DayOfWeek.Thursday },
                                new Week { Day = DayOfWeek.Friday }
                            }
                    });

                    db.Restaurants.Add(new Restaurant
                    {
                        Name = "Mont Serra",
                        Price = 17.5m,
                        Days = new List<Week>{
                                new Week { Day = DayOfWeek.Monday },
                                new Week { Day = DayOfWeek.Tuesday },
                                new Week { Day = DayOfWeek.Wednesday },
                                new Week { Day = DayOfWeek.Thursday },
                                new Week { Day = DayOfWeek.Friday }
                            }
                    });

                    db.Restaurants.Add(new Restaurant
                    {
                        Name = "Allegro",
                        Price = 14.5m,
                        Days = new List<Week>{
                                new Week { Day = DayOfWeek.Monday },
                                new Week { Day = DayOfWeek.Tuesday },
                                new Week { Day = DayOfWeek.Wednesday },
                                new Week { Day = DayOfWeek.Thursday },
                                new Week { Day = DayOfWeek.Friday }
                            }
                    });

                    db.Restaurants.Add(new Restaurant
                    {
                        Name = "Under Grella",
                        Price = 14,
                        Days = new List<Week>{
                                new Week { Day = DayOfWeek.Monday },
                                new Week { Day = DayOfWeek.Tuesday },
                                new Week { Day = DayOfWeek.Wednesday },
                                new Week { Day = DayOfWeek.Thursday },
                                new Week { Day = DayOfWeek.Friday }
                            }
                    });

                    db.Restaurants.Add(new Restaurant
                    {
                        Name = "Pizzaria",
                        Price = 20,
                        Days = new List<Week>() 
                        { 
                          new Week 
                            { Day = DayOfWeek.Wednesday }, 
                          new Week 
                            { Day = DayOfWeek.Thursday }, 
                          new Week 
                            { Day = DayOfWeek.Friday } 
                        }
                    });

                    db.SaveChanges();
                }
            }

            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}