public class Role_HorsLaLoi : Role
{
    public Role_HorsLaLoi(): base("Hors-la-Loi", "Tuez le Shérif ! Ou d'autres, histoire d'avoir leurs récompenses...")
    { }

    public override bool conditionsVictoire()
    {
        return true;
    }
}