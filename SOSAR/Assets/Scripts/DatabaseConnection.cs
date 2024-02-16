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
    private string ssl = "VerifyFull";

    // private string server = System.Environment.GetEnvironmentVariable("DB_SERVER");
    // private string database = System.Environment.GetEnvironmentVariable("DB_NAME");
    // private string userId = System.Environment.GetEnvironmentVariable("DB_USER");
    // private string password = System.Environment.GetEnvironmentVariable("DB_PASSWORD");

    private string server = "aws.connect.psdb.cloud";
    private string database = "sosar";
    private string userId = "zy54coc77i33kmnrk7ts";

    // private string p1 = "pscale_pw_p5A40vBe4v5NdlK7nSS5TPyYb4uarnKD0Vvt1pjQvEW";
    
    private string p1 = "pscale_pw_p5A40vBe4v5NdlK7nSS5";
    private string p2 ="TPyYb4uarnKD0Vvt1pjQvEW";
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);

        p1 = p1 + p2;   
        connectionString = $"Server={server};Database={database};Uid={userId};Pwd={p1};SslMode={ssl};Pooling=";
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