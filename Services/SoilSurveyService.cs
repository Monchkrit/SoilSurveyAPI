using SoilSurveyAPI.Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Dynamic;
using MongoDB.Bson;

namespace SoilSurveyAPI.Services
{
  public class SoilSurveyService
  {
    private readonly IMongoCollection<SoilSurvey> _soilSurveys;

    public SoilSurveyService(ISoilSurveyDatabaseSettings settings)
    {
      var client = new MongoClient(settings.ConnectionString);
      var database = client.GetDatabase(settings.DatabaseName);

      _soilSurveys = database.GetCollection<SoilSurvey>("soil_survey");
    }

    // public List<SoilSurvey> Get() => _soilSurveys.Find(soil_surveys => true).ToList();

    // public List<SoilSurvey> Get()
    // {
    //   var survey_list = _soilSurveys.Find<SoilSurvey>(soilSurvey => true).ToList();
    //   return survey_list;
    // }

    public List<SoilSurvey> Get(string musym)
    {
      if (musym != null)
      {
        var survey_list = _soilSurveys.Find<SoilSurvey>(soilSurvey => soilSurvey.musym == musym).ToList();
        return survey_list;
      }
      return null;
    }
  }
}