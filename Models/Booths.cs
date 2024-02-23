using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;

namespace PhotoBooth.Models
{
  public class Booth
  {
    public int BoothId { get; set; }
    [Required]
    public string Location { get; set; }
    [Required]
    public string Address { get; set; }
    [Required]
    public string Neighborhood { get; set; }
    public string Type { get; set; }
    public string Color { get; set; }

    public static List<Booth> GetBooths()
    {
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Booth> boothList = JsonConvert.DeserializeObject<List<Booth>>(jsonResponse.ToString());

      return boothList;
    }

    
  }
}