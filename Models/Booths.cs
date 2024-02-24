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

    public static Booth GetDetails(int id)
    {
      var apiCallTask = ApiHelper.Get(id);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      Booth booth = JsonConvert.DeserializeObject<Booth>(jsonResponse.ToString());

      return booth;
    }

    public static void Post(Booth booth)
    {
      string jsonBooth = JsonConvert.SerializeObject(booth);
      ApiHelper.Post(jsonBooth);
    }

    public static void Put(Booth booth)
    {
      string jsonBooth = JsonConvert.SerializeObject(booth);
      ApiHelper.Put(booth.BoothId, jsonBooth);
    }

    public static void Delete(int id)
    {
      ApiHelper.Delete(id);
    }
  }
}