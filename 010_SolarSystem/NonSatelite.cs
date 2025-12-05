namespace _010_SolarSystem
{
    class NonSatelite : Planet
    {
        public double Distance_from_sun { get; set; }
        public List<Planet> Satellites { get; set; }

        public NonSatelite(string name, double radius, double mass, double volume, double area, double rotation_period, double distance_from_sun, List<Planet> satellites) 
            : base(name, area, mass, volume, area, rotation_period)
        {
            Distance_from_sun = distance_from_sun;
            Satellites = satellites;
        }

        public override string ToString()
        {
            string pl = String.Empty;
            foreach (Planet planet in Satellites)
            {
                pl += planet.ToString();
            }
            return $"{base.ToString()}, distance from sun: {Distance_from_sun}, \nsatellites: {pl}";
        }
    }
}
