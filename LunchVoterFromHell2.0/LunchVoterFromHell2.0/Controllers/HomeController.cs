using DomainService;
using LunchVoterFromHell2.App_Start;
using LunchVoterFromHell2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LunchVoterFromHell2.Controllers
{
    public class HomeController : Controller
    {
        GroupBO bo;

        public HomeController(GroupBO bo)
        {
            this.bo = bo;
        }

        public ActionResult Index()
        {
            var index = new Index();
            var rank = new List<Ranking>();

            // var bo = SimpleInjectorInitializer.Container.GetInstance<GroupBO>();

            /* TODO: Chamar Repositório aqui e passar essa regra de negócio para o local correto
            using (var db = new DataContext())
            {
                var name = User.Identity.Name.Split('\\')[1];
                var user = db.Persons.Where(p => p.Name == name).ToList().FirstOrDefault();

                if (user == null)
                    return this.Redirect("Error/UserNotExits");

                var group = db.Groups.Find(user.Group);

                var votes = db.Votes
                    .Where(x => new { x.Date.Day, x.Date.Month, x.Date.Year } == new { DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year })
                    .GroupBy(x => x.Restaurant.Id);

                var result = new
                {
                    Votes = votes.ToArray(),
                    Ranking = votes.Select(vote => new
                    {
                        Id = vote.Key,
                        VotesCount = vote.Count()
                    })
                    .ToArray()
                };

                foreach (var item in result.Ranking)
                {
                    rank.Add(new Ranking() { Restaurant = db.Restaurants.Find(item.Id), VotesCount = item.VotesCount });
                }

                index.Restaurants = db.Restaurants.ToList();
            }

            rank = rank.OrderByDescending(r => r.VotesCount).ToList();
            index.Ranking = rank;
            */
            return this.View(index);
        }
    }
}
