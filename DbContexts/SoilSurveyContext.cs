using Microsoft.EntityFrameworkCore;
using SoilSurveyAPI.Entities;

namespace SoilSurveyAPI.DbContexts
{
  public class SoilSurveyContext : DbContext
  {
    public SoilSurveyContext(DbContextOptions<SoilSurveyContext> options) 
      : base (options)
      {

      }

      public DbSet<SoilSurvey> SoilSurveys { get; set; }
  }
}