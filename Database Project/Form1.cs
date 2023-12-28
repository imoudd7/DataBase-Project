using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace Database_Project
{
    public partial class Form1 : Form
    {
        private NpgsqlConnection connection;
        private NpgsqlDataAdapter dataAdapter;
        private DataTable dataTable;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Host=localhost;Username=postgres;Password=2464268;Database=Project";
                connection = new NpgsqlConnection(connectionString);
                connection.Open();
                MessageBox.Show("Database connected successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error connecting to the database: {ex.Message}");
            }
        }

        NpgsqlConnection connectionString = new NpgsqlConnection("Host=localhost;Username=postgres;Password=2464268;Database=Project");

        private void BtnListele_Click(object sender, EventArgs e)
        {
            string Query = "SELECT * FROM personel";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(Query, connectionString);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataCridView1.DataSource = ds.Tables[0];
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection("Host=localhost;Username=postgres;Password=2464268;Database=Project"))
                {
                    connection.Open();

                    NpgsqlCommand Query1 = new NpgsqlCommand("INSERT INTO personel (personel_no, ad, soyad, masa) VALUES (@V1, @V2, @V3, @V4)", connection);
                    Query1.Parameters.AddWithValue("@V1", int.Parse(TxtNo.Text));
                    Query1.Parameters.AddWithValue("@V2", TxtAd.Text);
                    Query1.Parameters.AddWithValue("@V3", TxtSoyad.Text);
                    Query1.Parameters.AddWithValue("@V4", int.Parse(TxtMasa.Text));

                    int rowsAffected = Query1.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Personel Ekleme işlemi yapıldı :)");
                    }
                    else
                    {
                        MessageBox.Show("Personel Ekleme işlemi yapılmadı ):");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"hata: {ex.Message}");
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            connectionString.Open();
            NpgsqlCommand Query2 = new NpgsqlCommand("DELETE FROM personel WHERE personel_no = @V1", connectionString);
            Query2.Parameters.AddWithValue("@V1", int.Parse(TxtNo.Text));
            Query2.ExecuteNonQuery();
            connectionString.Close();
            MessageBox.Show("Personel Silme Islemi Yapildi :)");
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            connectionString.Open();
            NpgsqlCommand Query3 = new NpgsqlCommand("UPDATE personel SET ad=@V2, soyad=@V3, masa=@V4 WHERE personel_no=@V1", connectionString);
            Query3.Parameters.AddWithValue("@V1", int.Parse(TxtNo.Text));
            Query3.Parameters.AddWithValue("@V2", TxtAd.Text);
            Query3.Parameters.AddWithValue("@V3", TxtSoyad.Text);
            Query3.Parameters.AddWithValue("@V4", int.Parse(TxtMasa.Text));
            Query3.ExecuteNonQuery();
            connectionString.Close();
            MessageBox.Show("personel Guncelleme islemi Yapildi :)");
        }

        private void BtnArama_Click(object sender, EventArgs e)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection("Host=localhost;Username=postgres;Password=2464268;Database=Project"))
                {
                    connection.Open();

                    int searchValue = int.Parse(Txt_Search.Text);

                    string query = "SELECT * FROM personel WHERE CAST(personel_no AS TEXT) LIKE @SearchValue";
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connection);
                    da.SelectCommand.Parameters.AddWithValue("@SearchValue", "%" + searchValue + "%");

                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dataCridView1.DataSource = ds.Tables[0];

                    if (ds.Tables[0].Rows.Count == 0)
                    {
                        MessageBox.Show("لم يتم العثور على نتائج.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ في عملية البحث: {ex.Message}");
            }
        }

    }
}
