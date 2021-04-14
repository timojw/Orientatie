namespace Test2TimoEind
{
    internal class PScore
    {
        public PScore()
        {
        }

        public string PlayerName { get; set; }
        public int Punten { get; set; }
        public override string ToString()
        {
            return "Speler: " + PlayerName + " Punten: " + Punten;
        }
        public void Addpoints()
        {
            Punten++;
        }

    }
}