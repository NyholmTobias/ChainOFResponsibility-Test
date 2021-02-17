namespace ChainOFResponsibility_Test
{
    class RocketHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if (request.ToString() == "Raketbränsle")
            {
                return $"Raket: Mot oändligheten och vidare!.\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
