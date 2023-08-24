namespace OpgaveTilmeldning.Personer
{
    internal sealed class Elev : Person
    {

        public Elev(string? fornavn, string? efternavn, DateTime fødselsdag) : base(fornavn, efternavn, fødselsdag, "Elev")
        {
            string defaultInfo = ShowAllInfo2();
        }

        public Elev(string? fornavn, string? efternavn, DateTime fødselsdag, string? type) : base(fornavn, efternavn, fødselsdag, type)
        {
        }

        protected override string ShowAllInfo()
        {
            return $"{PersonInfo.Fornavn} {PersonInfo.Efternavn}";
        }

        public override string ShowMyIdentity()
        {
            return "Jeg er en elev";
        }
    }
}