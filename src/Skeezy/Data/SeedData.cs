using Skeezy.Models;

namespace Skeezy.Data
{
    public static class SeedData 
    {
        public static void Create(ApplicationDbContext context) 
        {
            User stito = new User 
            { 
                Name = "Stito Jones"
            };
            User wumbo = new User
            {
                Name = "Wumbno Dingus"
            };
        
            context.Users.Add(stito);
            context.Users.Add(wumbo);

            context.Messages.Add(new Message
            {
                Text = "I could ski today, chill?",
                UserId = stito.Id
            });

            context.Messages.Add(new Message
            {
                Text = "Ankles. Broken.",
                UserId = wumbo.Id
            });

            context.SaveChanges();
        }
    }


}