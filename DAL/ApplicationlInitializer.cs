using FormRegistrator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FormRegistrator.DAL
{
    public class ApplicationlInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ApplicationContext>
    {
        protected override void Seed(ApplicationContext context)
        {
            var clients = new List<Client>
            {
            new Client{FirstMidName="Carson",LastName="Alexander",RegistrationDate=DateTime.Parse("2005-09-01")},
            new Client{FirstMidName="Meredith",LastName="Alonso",RegistrationDate=DateTime.Parse("2002-09-01")},
            new Client{FirstMidName="Arturo",LastName="Anand",RegistrationDate=DateTime.Parse("2003-09-01")},
            new Client{FirstMidName="Gytis",LastName="Barzdukas",RegistrationDate=DateTime.Parse("2002-09-01")},
            new Client{FirstMidName="Yan",LastName="Li",RegistrationDate=DateTime.Parse("2002-09-01")},
            new Client{FirstMidName="Peggy",LastName="Justice",RegistrationDate=DateTime.Parse("2001-09-01")},
            new Client{FirstMidName="Laura",LastName="Norman",RegistrationDate=DateTime.Parse("2003-09-01")},
            new Client{FirstMidName="Nino",LastName="Olivetto",RegistrationDate=DateTime.Parse("2005-09-01")}
            };

            clients.ForEach(s => context.Clients.Add(s));
            context.SaveChanges();
        }
    }
}