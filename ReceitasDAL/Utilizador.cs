﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceitasDAL
{
    public class Utilizador
    {
        public Utilizador(string nome, string email, string password)
        {
            Nome = nome;
            Email = email;
            Password = password;
        }

        public Utilizador(string id, string nome, string email, string password)
        {
            UserId = id;
            Nome = nome;
            Email = email;
            Password = password;
        }

        public Utilizador() { }

        public string UserId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
