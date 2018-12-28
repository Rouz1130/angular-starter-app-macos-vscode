using Microsoft.EntityFrameworkCore;

namespace my_starter_app.Model
{
    public class VideoTrackerContext : DbContext
    {
        public VideoTrackerContext (DbContextOptions <VideoTrackerContext> options)
            : base (options)
            {

            } 
            public DbSet<Video> Videos {get; set; }
        
    }
}