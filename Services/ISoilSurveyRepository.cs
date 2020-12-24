using SoilSurveyAPI.Entities;
using System;
using System.Collections.Generic;

namespace SoilSurveyAPI.Services
{
  public interface ISoilSurveyRepository
  {
    IEnumerable<SoilSurvey> GetSoilSurveys(string musym);
    SoilSurvey GetSoilSurvey(Guid soilId);

    bool SoilSurveyExists(Guid soilId);
    bool Save();
  }
}