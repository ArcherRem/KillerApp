using System;
using System.Collections.Generic;
using System.Text;
using KillerAppLibrary.Repocitories;
using KillerAppLibrary.Models;

namespace KillerAppLibrary.Services
{
    public class SpellService
    {
        private readonly ISpellRepocitory spellRepocitory;

        public SpellService(ISpellRepocitory spellRepocitory)
        {
            this.spellRepocitory = spellRepocitory;
        }

        public IReadOnlyCollection<Spell> GetAllSpells()
        {
            return spellRepocitory.GetAllSpells();
        }
    }
}
