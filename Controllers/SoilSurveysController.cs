using SoilSurveyAPI.Models;
using SoilSurveyAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using MongoDB.Driver;
using MongoDB.Bson.Serialization;

namespace SoilSurveyAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class SoilSurveysController : ControllerBase
  {
    private readonly SoilSurveyService _soilSurveyService;

    public SoilSurveysController(SoilSurveyService soilSurveyService)
    {
        _soilSurveyService = soilSurveyService;
    }

    // [HttpGet]
    // public ActionResult<List<SoilSurvey>> Get() => _soilSurveyService.Get();

    [HttpGet]
    public ActionResult<List<SoilSurvey>> Get(string musym)
    {
      var surveys = _soilSurveyService.Get(musym);
      if (surveys == null)
      {
        return NotFound();
      }

      return surveys;
    }
  }
}