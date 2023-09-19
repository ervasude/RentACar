
namespace RentACar.Entity
{
	public class DamageRecord
	{
        public DamageRecord(DateTime accidentTime, string engine, string brake)
        {
            this.accidentTime = accidentTime;
            Engine = engine;
            Brake = brake;
        }

        public DateTime accidentTime { get; set; }

        public string Engine { get; set; }

        public string Brake { get; set; }
    }
}

