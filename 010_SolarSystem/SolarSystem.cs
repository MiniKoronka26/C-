namespace _010_SolarSystem
{
    class SolarSystem
    {
        List<NonSatelite> planets;

        public SolarSystem(List<NonSatelite> planets)
        {
            this.planets = planets;
        }

        public Planet Search(string value)
        {
            for (int i = 0; i < planets.Count(); i++) {
                if (planets[i].Name == value)
                    return planets[i];
            }
            for(int i = 0; i < planets.Count(); i++)
            {
                for(int j = 0; j < planets[i].Satellites.Count(); j++)
                {
                    if (planets[i].Satellites[j].Name == value)
                        return planets[i].Satellites[j];
                }
            }
            return null;
        }

        public Planet Max_element()
        {
            double max = planets[0].Mass;
            Planet p = null;


            for(int i = 0; i < planets.Count(); i++) {
                if (planets[i].Mass > max)
                {
                    max = planets[i].Mass;
                    p = planets[i];
                }
            }
            for (int i = 0; i < planets.Count(); i++)
            {
                for (int j = 0; j < planets[i].Satellites.Count(); j++)
                {
                    if (planets[i].Satellites[j].Mass > max)
                    {
                        max = planets[i].Satellites[j].Mass;
                        p = planets[i];
                    }
                }
            }
            return p;
        }

        public override string ToString()
        {
            string pl = String.Empty;
            foreach (Planet planet in planets)
            {
                pl += planet.ToString();
            }
            return $"planets: {pl}";
        }

    }
}
