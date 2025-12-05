namespace _010_SolarSystem
{
    class Planet
    {
        public string Name { get; set; }
        public double Radius{ get; set; }
        public double Mass{ get; set; }
        public double Volume{ get; set; }
        public double Area{ get; set; }
        public double Rotation_period{ get; set; }

        public Planet(string name, double radius, double mass, double volume, double area, double rotation_period)
        {
            Name = name;
            Radius = radius;
            Mass = mass;
            Volume = volume;
            Area = area;
            Rotation_period = rotation_period;
        }

        public override string ToString()
        {
            return $"name: {Name}, radius: {Radius}, mass: {Mass}, volume: {Volume}";
        }
    }
}
