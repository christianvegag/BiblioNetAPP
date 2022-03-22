﻿using BiblioNetAPP.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace BiblioNetAPP.Services
{
    public interface IRepositorieBook
    {
        void Create(Book book)
    }
    public class RepositorieBook : IRepositorieBook
    {
        private readonly string connectionString;
        public RepositorieBook(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }
        public void Create(Book book)
        {
            using var connection = new SqlConnection(connectionString);
            var id = connection.QuerySingle<int>($@"INSERT INTO Libros 
                                                (IdEditorial,Titulo, FechaPub, Paginas) 
                                                VALUES (@IdEditorial,@Titulo, @FechaPub, @Paginas); SELECT SCOPE_IDENTITY();", book);
            book.Id = id;
        }
    }
}
