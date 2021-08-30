using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.Entity
{
    public class Configuration
    {
        private string lastUsedFile;
        public string LastUsedFile
        {
            get => lastUsedFile;
            set => lastUsedFile = value;
        }
    }
}
