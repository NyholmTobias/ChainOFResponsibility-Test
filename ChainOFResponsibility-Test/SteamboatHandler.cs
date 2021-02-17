namespace ChainOFResponsibility_Test
{
    class SteamboatHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if (request.ToString() == "Kol")
            {
                return $"Ångbåt: tuut tuut.\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
