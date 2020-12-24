using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.ComponentModel.DataAnnotations;

namespace SoilSurveyAPI.Models
{
  public class SoilSurvey
  {
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    public dynamic om_r { get; set; }
    public dynamic awc_r { get; set; }
    public dynamic wsatiated_r { get; set; }    
    public dynamic kwfact { get; set; }
    public dynamic ph1to1h2o_r { get; set; }
    public int cokey { get; set; }
    public string compname { get; set; }
    public dynamic slope_r { get; set; }
    public string runoff { get; set; }
    public dynamic tfact { get; set; }
    public dynamic elev_r { get; set; }
    public string geomdesc { get; set; }
    public dynamic ffd_r { get; set; }
    public dynamic nirrcapcl { get; set; }
    public dynamic nirrcapscl { get; set; }
    public dynamic irrcapcl { get; set; }
    public dynamic irrcapscl { get; set; }
    public int mukey { get; set; }
    public string musym { get; set; }
    public string muname { get; set; }
    public string drainagecl { get; set; }
    public dynamic aws025wta { get; set; }
    public int chkey { get; set; }
  }
}