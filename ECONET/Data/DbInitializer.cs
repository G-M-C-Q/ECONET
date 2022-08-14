using ECONET.Entities;

namespace ECONET.Data
{
    public class DbInitializer
    {


        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {

                var context = serviceScope.ServiceProvider.GetService<MarketContext>();

                context.Database.EnsureCreated();
                //Cinema
                if (!context.Items.Any())
                {
                    context.Items.AddRange(new List<Item>()
                    {
                        new Item()
                        {
                            Id = 1,
                            Name = "T-shirt",
                        },
                    
                    });
                    context.SaveChanges();
                   

                }
            }

        }
    }
}
