using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.Entity
{
    public class Database
    {
        private string hash;
        public string Hash
        {
            get => hash;
            set => hash = value;
        }

        private BindingList<Entry> entries;
        public BindingList<Entry> Entries
        {
            get => entries;
            set => entries = value;
        }

        public Database()
        {
            entries = new BindingList<Entry>();
        }
    }
}
