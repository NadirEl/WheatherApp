using WeatherApp;

namespace WheatherApp
{
    public class Endpoint
    {
        public static string getGeoApify(string city) {
         
            return $"https://api.geoapify.com/v1/geocode/search?text={city}&format=json&apiKey={Config.GeoApifykey}"; 
            
        }
        public static string GetWeatherEndPoint(float lat, float lon)
        {
            var url = $"https://api.open-meteo.com/v1/forecast?latitude={lat}&longitude={lon}&current=temperature_2m,relativehumidity_2m&hourly=temperature_2m&daily=weathercode,temperature_2m_max,temperature_2m_min&timezone=Europe%2FLondon";
            return url;
        }
    }
}
