using System.Collections.Generic;

namespace WebProject.Models.ViewModel
{
    /// <summary>
    /// 紫外線指數Api資料
    /// </summary>
    public class UviApiData
    {
        public string Success { get; set; }
        public Result Result { get; set; }
        public Records Records { get; set; }
    }

    public class Result
    {
        public string Resource_id { get; set; }
        public Field[] Fields { get; set; }
    }

    public class Field
    {
        public string Id { get; set; }
        public string Type { get; set; }
    }

    public class Records
    {
        public Weatherelement WeatherElement { get; set; }
    }

    public class Weatherelement
    {
        public string ElementName { get; set; }
        public Time Time { get; set; }
        public List<Location> Location { get; set; }
    }

    public class Time
    {
        public string DataTime { get; set; }
    }

    public class Location
    {
        public string LocationCode { get; set; }
        public float Value { get; set; }
        public string Style { get; set; }
    }
}
