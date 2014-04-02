using LunchVoterFromHell2.Database;
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
        public ActionResult Index()
        {
            var index = new Index();
            var rank = new List<Ranking>();

            using (var db = new DataContext())
            {
                var name = User.Identity.Name.Split('\\')[1];
                var user = db.Persons.Where(p => p.Name == name).ToList().FirstOrDefault();

                if (user == null)
                    return Redirect("Error/UserNotExits");

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
                    rank.Add(new Ranking() { restaurant = db.Restaurants.Find(item.Id), votesCount = item.VotesCount });
                }

                index.restaurants = db.Restaurants.ToList();
            }
            rank = rank.OrderByDescending(r => r.votesCount).ToList();
            index.Ranking = rank;

            return View(index);
        }
    }
}
