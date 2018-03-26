using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using TrafficAndWeather.Domain.Entities.Abstract;

namespace TrafficAndWeather.Domain.Services.Abstract
{
    public interface IWTDataReader
    {
        IWTData ReadData(Stream stream);
    }
}
