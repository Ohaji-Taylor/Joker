﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Joke
    {

        public int Id { get; set; }

        public string JokeQuestion { get; set; }
        public string JokeAnswer { get; set; }

        public Joke()
        {

        }

    }
}