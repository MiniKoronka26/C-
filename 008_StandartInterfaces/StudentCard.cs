namespace _008_StandartInterfaces
{
    class StudentCard : ICloneable
    {
        public int Number { get; set; }
        public string Series { get; set; }

        public object Clone()
        {
            /*return new StudentCard
            {
                Number = this.Number,
                Series = this.Series
            };*/
            return this.MemberwiseClone(); // не глибоке клонування
        }

        public override string ToString()
        {
            return $"Student card: {Series} {Number} ";
        }
    }
}
