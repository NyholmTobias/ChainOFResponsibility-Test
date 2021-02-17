
namespace ChainOFResponsibility_Test
{
    class TeslaHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if ((request as string) == "El")
            {
                return $"Tesla: bzz.\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
