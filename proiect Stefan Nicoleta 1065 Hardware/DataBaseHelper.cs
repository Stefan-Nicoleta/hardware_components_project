using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using proiect_Stefan_Nicoleta_1065_Hardware;

public static class DatabaseHelper
{
    private static string dbFile = "hardware.db";
    private static string connectionString = $"Data Source={dbFile};Version=3;";

    static DatabaseHelper()
    {
        if (!File.Exists(dbFile))
        {
            SQLiteConnection.CreateFile(dbFile);
            CreateTables();
        }
    }

    private static void CreateTables()
    {
        using (var conn = new SQLiteConnection(connectionString))
        {
            conn.Open();
            string createTableQuery = @"
            CREATE TABLE IF NOT EXISTS Calculatoare (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Nume TEXT NOT NULL,
                Pret INTEGER,
                Model TEXT,
                Componente TEXT
            );";
            var cmd = new SQLiteCommand(createTableQuery, conn);
            cmd.ExecuteNonQuery();
        }
    }

    public static void AdaugaComponenta(int id, string nume, int pret, string model, string componente)
    {
        using (var conn = new SQLiteConnection(connectionString))
        {
            conn.Open();
            string insertQuery = "INSERT INTO Calculatoare (Id,Nume, Pret, Model, Componente) VALUES (@id,@nume, @pret, @model, @componente)";
            var cmd = new SQLiteCommand(insertQuery, conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@nume", nume);
            cmd.Parameters.AddWithValue("@pret", pret);
            cmd.Parameters.AddWithValue("@model", model);
            cmd.Parameters.AddWithValue("@componente", componente);
            cmd.ExecuteNonQuery();
        }
    }

    public static List<(int, string, int, string, string)> GetComponente()
    {
        var list = new List<(int, string, int, string, string)>();
        using (var conn = new SQLiteConnection(connectionString))
        {
            conn.Open();
            var cmd = new SQLiteCommand("SELECT * FROM Componente", conn);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add((
                    Convert.ToInt32(reader["Id"]),
                    reader["Nume"].ToString(),
                    Convert.ToInt32(reader["Pret"]),
                    reader["Model"].ToString(),
                    reader["Componente"].ToString()
                ));
            }
        }
        return list;
    }

    public static List<Calculatoare> GetCalculatoare()
    {
        var lista = new List<Calculatoare>();

        using (var conn = new SQLiteConnection(connectionString))
        {
            conn.Open();
            var cmd = new SQLiteCommand("SELECT * FROM Calculatoare", conn);
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lista.Add(new Calculatoare
                {
                    id = Convert.ToInt32(reader["Id"]),
                    nume = reader["Nume"].ToString(),
                    pret = Convert.ToInt32(reader["Pret"]),
                    model = reader["Model"].ToString(),
                    componente = reader["Componente"].ToString()
                });
            }
        }

        return lista;
    }


    public static void StergeCalculator(int id)
    {
        using (var conn = new SQLiteConnection(connectionString))
        {
            conn.Open();
            var cmd = new SQLiteCommand("DELETE FROM Calculatoare WHERE Id = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
    }

    public static void StergeToateCalculatoarele()
    {
        using (var conn = new SQLiteConnection(connectionString))
        {
            conn.Open();
            var cmd = new SQLiteCommand("DELETE FROM Calculatoare", conn);
            cmd.ExecuteNonQuery();
        }
    }


    public static bool ExistaCalculator(int id)
    {
        using (var conn = new SQLiteConnection(connectionString))
        {
            conn.Open();
            var cmd = new SQLiteCommand("SELECT COUNT(*) FROM Calculatoare WHERE Id = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
        }
    }

    public static void AdaugaCalculator(int id,string nume, int pret, string model, string componente)
    {
        using (var conn = new SQLiteConnection(connectionString))
        {
            conn.Open();

            if (ExistaCalculator(id))
            {
                MessageBox.Show("Eroare: ID-ul există deja în baza de date!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string insertQuery = "INSERT INTO Calculatoare (Id,Nume, Pret, Model, Componente) VALUES (@id,@nume, @pret, @model, @componente)";
            var cmd = new SQLiteCommand(insertQuery, conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@nume", nume);
            cmd.Parameters.AddWithValue("@pret", pret);
            cmd.Parameters.AddWithValue("@model", model);
            cmd.Parameters.AddWithValue("@componente", componente);
            cmd.ExecuteNonQuery();
        }
    }


}
