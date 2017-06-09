using System;
using System.Collections.Generic;
using System.Text;
using KillerAppLibrary.Services;
using KillerAppLibrary.Repocitories;

namespace KillerAppLibrary.Factories
{
    public class ServiceFactory : IServiceFactory
    {
        public SpellService CreateService()
        {
            return new SpellService(new SpellRepocitory());
        }
    }
}
