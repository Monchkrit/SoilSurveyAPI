namespace SoilSurveyAPI.Models
{
  public interface ISoilSurveyDatabaseSettings
  {
    // string SoilSurveyCollectionName { get; set; }
    string ConnectionString { get; set; }
    string DatabaseName { get; set; }
  }

  public class SoilSurveyDatabaseSettings : ISoilSurveyDatabaseSettings
  {
    // public string SoilSurveyCollectionName { get; set; }
    public string ConnectionString { get; set; }
    public string DatabaseName { get; set; }
  }

}