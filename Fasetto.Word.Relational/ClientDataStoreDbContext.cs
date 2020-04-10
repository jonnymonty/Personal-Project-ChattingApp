﻿using ChattingApp.Core;
using Microsoft.EntityFrameworkCore;

namespace Fasetto.Word.Relational
{
    /// <summary>
    /// The database context for the client data store using Entity Framework and Sqlite
    /// </summary>
    public class ClientDataStoreDbContext : DbContext
    {
        #region DbSets

        /// <summary>
        /// The client login credentials
        /// </summary>
        public DbSet<LoginCredentialsDataModel> LoginCredentials { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// The Default Constructor
        /// </summary>
        public ClientDataStoreDbContext(DbContextOptions<ClientDataStoreDbContext> options) : base(options) { }

        #endregion

        #region Model Creating

        /// <summary>
        /// Configures the database structure and relationships
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Fluent API

            // Configure LoginCredentials
            // --------------------------

            // Set Id as primary key
            modelBuilder.Entity<LoginCredentialsDataModel>().Property(a => a.Id).ValueGeneratedOnAdd();

            // TODO: Set up limits
            //modelBuilder.Entity<LoginCredentialsDataModel>().Property(a => a.FirstName).HasMaxLength(50);
        }

        #endregion
    }
}