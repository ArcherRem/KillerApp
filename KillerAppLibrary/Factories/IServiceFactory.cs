using System;
using System.Collections.Generic;
using System.Text;
using KillerAppLibrary.Services;

namespace KillerAppLibrary.Factories
{
    interface IServiceFactory
    {
        SpellService CreateService();
    }
}
