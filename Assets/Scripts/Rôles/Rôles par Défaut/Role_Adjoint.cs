public class Role_Adjoint : Role
{
    public Role_Adjoint(): base("Adjoint", "Aidez et protégez le Shérif !")
    { }

    public override bool conditionsVictoire()
    {
        return true;
    }
}