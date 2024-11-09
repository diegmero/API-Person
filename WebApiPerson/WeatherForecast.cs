namespace WebApiPerson
{
    public class WeatherForecast
    {
        public DateOnly Dia {get; set; }

        public int TemperaturaC { get; set; }

        public int TemperaturaF => 32 + (int)(TemperaturaC / 0.5556);

        public string? Resumen { get; set; }
    }
}
