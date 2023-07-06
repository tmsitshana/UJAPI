using Microsoft.EntityFrameworkCore;

namespace MVCWebAppTestAPI.DBModels
{
    public interface ICandidateContext
    {
        DbSet<User> Users { get; set; }
    }
}
