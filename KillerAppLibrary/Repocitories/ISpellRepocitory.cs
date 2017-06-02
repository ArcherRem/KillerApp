using System;
using System.Collections.Generic;
using System.Text;
using KillerAppLibrary.Models;

namespace KillerAppLibrary.Repocitories
{
    public interface ISpellRepocitory
    {
        List<Spell> GetAllSpells();

        List<Spell> GetSearchedSpell(string query);
    }
}
