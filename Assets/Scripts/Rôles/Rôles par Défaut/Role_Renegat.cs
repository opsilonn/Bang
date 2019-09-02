public class Role_Renegat : Role
{
    public Role_Renegat(): base("Rénégat", "Soyez le dernier en vie !")
    { }

    public override bool conditionsVictoire()
    {
        return true;
    }
}