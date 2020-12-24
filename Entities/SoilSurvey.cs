using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable enable


namespace SoilSurveyAPI.Entities
{
  public class SoilSurvey
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid SoilId { get; set; }
    public float? om_r { get; set; }
    public float? awc_r { get; set; }
    public int? wsatiated_r { get; set; }    
    public float? kwfact { get; set; }
    public float? ph1to1h2o_r { get; set; }
    [MaxLength(32)]
    public string? compname { get; set; }
    public int? slope_r { get; set; }
    [MaxLength(16)]
    public string? runoff { get; set; }
    public int? tfact { get; set; }
    public float? elev_r { get; set; }
    [MaxLength(48)]
    public string? geomdesc { get; set; }
    public int? ffd_r { get; set; }
    public int? nirrcapl { get; set; }
    public char? nirrcapscl { get; set; }
    public int? irrcapcl { get; set; }
    public char? irrcapscl { get; set; }
    public int? mukey { get; set; }
    [MaxLength(8)]
    public string? musym { get; set; }
    [MaxLength(96)]
    public string? muname { get; set; }
    [MaxLength(32)]
    public string? drainagecl { get; set; }
    public float? aws025wta { get; set; }
  }
}