using System;
using System.Collections.Generic;
using System.Text;
using KillerAppLibrary.Models;
using System.Data.SqlClient;
using System.IO;

namespace KillerAppLibrary.Repocitories
{/// <summary>
/// Get spells from database 
/// </summary>
    class SpellRepocitory : ISpellRepocitory
    {
        SqlConnection sqlcon = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=DnDCMS;Integrated Security=SSPI");
        public List<Spell> GetAllSpells()
        {
            try
            {
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Spells", sqlcon);
                SqlDataReader reader = cmd.ExecuteReader();
                List<Spell> spellBook = new List<Spell>();
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["id"]);
                    string name = reader["name"].ToString();
                    string level = reader["spelllevel"].ToString();
                    string type = reader["spelltype"].ToString();
                    bool ritual = Convert.ToBoolean(reader["ritual"]);
                    string effect = reader["effect"].ToString();
                    string castingtime = reader["casting time"].ToString();
                    string range = reader["range"].ToString();
                    string components = reader["components"].ToString();
                    string duration = reader["duration"].ToString();
                    Spell allspells = new Spell(id, name, level, type, ritual, effect, castingtime, range, components, duration);
                    spellBook.Add(allspells);
                }
                return spellBook;

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlcon != null)
                {
                    sqlcon.Close();
                }

            }

        }
        public List<Spell> GetSearchedSpell(string query)
        {

            try
            {
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Spells " + query, sqlcon);
                SqlDataReader reader = cmd.ExecuteReader();
                List<Spell> spellBook = new List<Spell>();
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["id"]);
                    string name = reader["name"].ToString();
                    string level = reader["spelllevel"].ToString();
                    string type = reader["spelltype"].ToString();
                    bool ritual = Convert.ToBoolean(reader["ritual"]);
                    string effect = reader["effect"].ToString();
                    string castingtime = reader["casting time"].ToString();
                    string range = reader["range"].ToString();
                    string components = reader["components"].ToString();
                    string duration = reader["duration"].ToString();
                    Spell allspells = new Spell(id, name, level, type, ritual, effect, castingtime, range, components, duration);
                    spellBook.Add(allspells);
                }
                return spellBook;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlcon != null)
                {
                    sqlcon.Close();
                }

            }
        }

    }
}
