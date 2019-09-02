public class Role_Sherif : Role
{
    public Role_Sherif(): base("Shérif", "Eliminez les Hors-la-Loi et les Rénégats !")
    { }

    public override bool conditionsVictoire()
    {
        return true;
    }
}