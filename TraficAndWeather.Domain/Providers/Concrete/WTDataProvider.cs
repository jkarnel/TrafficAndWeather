﻿using System;
using System.Collections.Generic;
using TrafficAndWeather.Domain.Data;
using TrafficAndWeather.Domain.Entities.Abstract;
using TrafficAndWeather.Domain.Entities.Concrete;
using TrafficAndWeather.Domain.Providers.Abstract;
using System.Xml.Linq;
using System.Linq;

namespace TrafficAndWeather.Domain.Providers.Concrete
{
    internal sealed class XMLWTDataProvider : IWTDataProvider
    {
        public IWTData GetData(int regionCode, int cacheTime = 0)
        {
            if (AppData.WTData.TryGetValue(regionCode, out string xmlPath))
            {
                XDocument doc = XDocument.Load(xmlPath);
                var root = doc.Root;

                //root data
                var regionNode = root.Element("region");

                var regionIdStr = regionNode.Attribute("id").Value;
                int.TryParse(regionIdStr, out int regionId);

                string regionName = regionNode.Element("title").Value;

                //traffic data
                var traficNode = root.Element("traffic");
                var traficData = GetTrafficData(traficNode);

                var weatherNode = root.Element("weather");
                var weatherData = GetWeatherData(weatherNode);

                return new WTData
                {
                    RegionCode = regionId,
                    RegionName = regionName,
                    TrafficData = traficData,
                    WeatherData = weatherData
                };
            }
            return null;
        }

        private ITrafficData GetTrafficData(XElement traficNode)
        {
            if (traficNode != null && traficNode.HasElements)
            {
                var traficRegionName = traficNode.Element("title").Value;
                var regionNode = traficNode.Element("region");

                var traficStageStr = regionNode.Element("level").Value;
                int.TryParse(traficStageStr, out int traficStage);

                var traficIconColorName = regionNode.Element("icon").Value;
                var timestampStr = regionNode.Element("timestamp").Value;
                int.TryParse(timestampStr, out int timestamp);

                var traficDescription = regionNode.Elements("hint")
                    .Where(x => x.Attribute("lang").Value == "ru")
                    .FirstOrDefault()
                    .Value;

                return new TrafficData
                {
                    DateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddSeconds(timestamp),
                    Stage = traficStage,
                    Description = traficDescription,
                    RegionName = traficRegionName
                };
            }
            return null;
        }

        private IWeatherData GetWeatherData(XElement weatherNode)
        {
            var dayNode = weatherNode.Element("day");

            var partNodes = dayNode.Elements("day_part");
            var currentTempData = partNodes.FirstOrDefault();
            var currentTemperature = currentTempData.Element("temperature").Value;
            var currentDescription = currentTempData.Element("weather_type").Value;
            var imageUrl = currentTempData.Element("image-v3").Value;

            var partList = new List<IWeatherPeriodData>();
            foreach (var part in partNodes.Skip(1))
            {
                partList.Add(GetWeatherPart(part));
            }
            return new WeatherData
            {
                ImageUrl = imageUrl,
                Description = currentDescription,
                Temperature = currentTemperature,
                Periods = partList
            };
        }

        private IWeatherPeriodData GetWeatherPart(XElement partNode)
        {
            var temperatureFrom = partNode.Element("temperature_from").Value;
            var temperatureTo = partNode.Element("temperature_to").Value;
            var imageUrlArray = partNode.Element("image-v3")?.Value.Split('/');
            imageUrlArray[7] = "24";
            var imageUrl = string.Join("/", imageUrlArray);
            var partName = partNode.Attribute("type").Value;
            return new WeatherPeriodData
            {
                ImageUrl = imageUrl,
                PeriodName = partName,
                TemperatureFrom = temperatureFrom,
                TemperatureTo = temperatureTo
            };
        }
    }
}
