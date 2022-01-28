namespace RPG.src.Entities
{
    public class Wizard : Hero
    {

        public Wizard(string Name, int Level, string HeroType) :base(Name, Level, HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        
            public string Attack(){
        return this.Name + "Lançou Magia ";
        
    }

        public override string Attack(int Bonus)
        {
        if (Bonus > 6)
        {
            return this.Name + "Lançou uma Magia Super efetiva com bonus de " + Bonus;
        }
        else
        {
            return this.Name + "Lançou uma Magia com força fraca";
        }

    }

    }
}

