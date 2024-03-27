using EvidenceKlicu.Modely;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace EvidenceKlicu.Db;

internal class Db : IDb
{
    string IDb.PripojovaciRetezec { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    bool IDb.ExistujeDatabaze()
    {
        throw new NotImplementedException();
    }

    void IDb.NastavitPripojovaciRetezec(string pripojovaciRetezec)
    {
        throw new NotImplementedException();
    }

    string IDb.VytvoritDatabazi()
    {
        throw new NotImplementedException();
    }

    void IDb.VytvoritTabulky()
    {
        throw new NotImplementedException();
    }

    IEnumerable<Klic> IDb.ZiskatKlice()
    {
        throw new NotImplementedException();
    }

    IEnumerable<Zamestnanec> IDb.ZiskatZamestnance()
    {
        throw new NotImplementedException();
    }

    ZapujceneKliceZamestnancem IDb.ZiskatZapujceneKlice(Zamestnanec zamestnanec)
    {
        throw new NotImplementedException();
    }

    ZapujcenyKlicZamestnancum IDb.ZiskatZapujceneKlice(Klic klic)
    {
        throw new NotImplementedException();
    }


    public void PridatNovehoZamestnance()
    {
        //instance tridy Zamestnanec
        //naplneni instance tridy hodnotami z Okna vytvorit zamestnance
        string textPrikazu = "INSERT INTO Zamestnanci()" +
                             "VALUES()";
        SqlConnection connection = new SqlConnection(PripojovaciRetezec);
        SqlCommand prikaz = new SqlCommand(textPrikazu, connection);
        connection.Open();
        prikaz.Parameters.AddWithValue();
        //vsechny parametry

        prikaz.ExecuteNonQuery();
        connection.Close();
    }

    public void UpravitZamestnance()
    {
        //instance tridy Zamestnanec
        //naplneni instance tridy hodnotami z Okna upravit zamestnance
        string textPrikazu = "UPDATE Zamestnanci" +
                             "SET sloupec = hodnota, sloupec = hodnota" +
                             "WHERE condition";
        SqlConnection connection = new SqlConnection(PripojovaciRetezec);
        SqlCommand prikaz = new SqlCommand(textPrikazu, connection);
        connection.Open();
        prikaz.Parameters.AddWithValue();
        //vsechny parametry

        prikaz.ExecuteNonQuery();
        connection.Close();
    }

    public void OdstranitZamestnance()
    {
        string textPrikazu = "DELETE FROM Zamestnanci WHERE condition";
        SqlConnection connection = new SqlConnection(PripojovaciRetezec);
        SqlCommand prikaz = new SqlCommand(textPrikazu, connection);
        connection.Open();
        prikaz.ExecuteNonQuery();
        connection.Close();
    }


}
