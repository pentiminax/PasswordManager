using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.Entity
{
    public class Entry
    {
        private string uuid;

        [Browsable(false)]
        public string UUID
        {
            get => uuid;
            set => uuid = value;
        }

        private string title;

        [DisplayName("Titre")]
        public string Title
        {
            get => title;
            set => title = value;
        }

        private string username;

        [DisplayName("Nom d'utilisateur")]
        public string Username
        {
            get => username;
            set => username = value;
        }

        private string password;

        [DisplayName("Mot de passe")]
        public string Password
        {
            get => password;
            set => password = value;
        }

        private string link;

        [DisplayName("Adresse (URL)")]
        public string Link
        {
            get => link;
            set => link = value;
        }

        private DateTime createdAt;

        [DisplayName("Date de création")]
        public DateTime CreatedAt
        {
            get => createdAt;
            set => createdAt = value;
        }
    }
}
