﻿using Microsoft.EntityFrameworkCore;
using System;

namespace CardBot.Models
{
    public class CardContext : DbContext
    {
        public DbSet<CardGivings> CardGivings { get; set; }
        public DbSet<Cards> Cards { get; set; }
        public DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite(@"Data Source=Database.db");
            }
        }
    }

    public class Cards
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ulong ServerId { get; set; }
        public string Emoji { get; set; }
        public int Value { get; set; }
        public bool Poll { get; set; }
        public Guid FailedId { get; set; }
    }

    public class Users
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }

    public class CardGivings
    {
        public Guid Id { get; set; }
        public string CardReason { get; set; }
        public DateTime TimeStamp { get; set; }
        public ulong ServerId { get; set; }

        public Guid GiverId { get; set; }
        public Users Giver { get; set; }

        public Guid DegenerateId { get; set; }
        public Users Degenerate { get; set; }

        public Guid CardId { get; set; }
        public Cards Card { get; set; }

    }
}
