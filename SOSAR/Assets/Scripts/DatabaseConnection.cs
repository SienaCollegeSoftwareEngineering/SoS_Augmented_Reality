using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

using System.Data;
using System.Text;

using System.Security.Cryptography;
using MySql.Data;
using MySql.Data.MySqlClient;

public class DatabaseConnection : MonoBehaviour
{

    public bool pooling = true;

  
    private string connectionString;

    private MySqlConnection connection = null;
	private MySqlCommand cmd = null;
	private MySqlDataReader rdr = null;
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);


        connectionString = $"Server={server};Database={database};Uid={userId};Pwd={password};SslMode={ssl};Pooling=";
        if(pooling)
        {
            connectionString += "true;";
        }
        else
        {
            connectionString += "false;";
        }
        try
        {
            connection = new MySqlConnection(connectionString);
            connection.Open();
            Debug.Log("Connection to database successful!");

            string sql = "SELECT * FROM SOSTable";

            cmd = new MySqlCommand(sql, connection);

            rdr = cmd.ExecuteReader();

            while (rdr.Read()){
			    Debug.Log("???");
				Debug.Log(rdr[0]+" -- "+rdr[1]);
			}
			rdr.Close();

        }
        catch (Exception ex)
        {
            Debug.Log("Could not connect to database.");
            Debug.Log(ex.Message);
        }
    }

   void onApplicationQuit()
	{
		if (connection != null)
		{
			if (connection.State.ToString() != "Closed")
			{
				connection.Close();
				Debug.Log("Mysql connection closed");
			}
			connection.Dispose();
		}
	}
}