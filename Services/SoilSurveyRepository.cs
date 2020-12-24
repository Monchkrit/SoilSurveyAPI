using System;
using System.Collections.Generic;
using System.Linq;
using SoilSurveyAPI.DbContexts;
using SoilSurveyAPI.Entities;

namespace SoilSurveyAPI.Services
{
  public class SoilSurveyRepository : ISoilSurveyRepository
  {
    private readonly SoilSurveyContext _context;

    public SoilSurveyRepository(SoilSurveyContext context) => _context = context ?? throw new ArgumentNullException(nameof(context));

    public SoilSurvey GetSoilSurvey(Guid soilId)
    {
      if (soilId == Guid.Empty)
        throw new ArgumentNullException(nameof(soilId));

      return _context.SoilSurveys.Where(x => x.SoilId == soilId).FirstOrDefault();
    }

    public IEnumerable<SoilSurvey> GetSoilSurveys(string musym)
    {
      if (musym == null)
        throw new ArgumentNullException(nameof(musym));

      return _context.SoilSurveys.Where(x => x.musym == musym).ToList();
    }

    public bool Save()
    {
      throw new NotImplementedException();
    }

    public bool SoilSurveyExists(Guid soilId)
    {
      throw new NotImplementedException();
    }
  }
}