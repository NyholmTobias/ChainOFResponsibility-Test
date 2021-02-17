using System;

namespace ChainOFResponsibility_Test
{
    public interface IHandler
    {
        IHandler SetNext(IHandler Handler);

        Object Handle(Object Request);
    }
}
