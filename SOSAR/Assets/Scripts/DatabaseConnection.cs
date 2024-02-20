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

    public static string global_TextForNewScene;
    public static string global_ProfNameForNewScene;

    public static string global_ProfDepartmentForNewScene;
  
    private string connectionString;

    private MySqlConnection connection = null;
	private MySqlCommand cmd = null;
	private MySqlDataReader rdr = null;
    //SSL verification mode
    private string ssl = "VerifyFull";
    //Server
    private string server = "aws.connect.psdb.cloud";
    //database name
    private string database = "sosar";
    //user id
    private string userId = "u4dpxa9ii6kwh518h5e5";

    
    
    private string p1 = "pscale_pw_cKzR6oY0jB9s9k";

    private string p2 = "15leTeKrzt8nZNwhsYK4xionulXVB";
    //Awake is called when the script instance is being loaded, so as soon as script is loaded this runs once to update all information in the scene
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);

        p1 = p1 + p2;
        //String to connect to database
        connectionString = $"Server={server};Database={database};Uid={userId};Pwd={p1};SslMode={ssl};Pooling=";
        if(pooling)
        {
            connectionString += "true;";
        }
        else
        {
            connectionString += "false;";
        }
        //try connecting to database
        try
        {
            connection = new MySqlConnection(connectionString);
            connection.Open();
            Debug.Log("Connection to database successful!");


            //SQL query to get the information for the room
            string sql = string.Format("SELECT * FROM SOSTable WHERE roomnum = \"{0}\"", ModifyInfoButton.global_RoomNum);
            
            Debug.Log(sql);

            //Make command with the database
            cmd = new MySqlCommand(sql, connection);

            //Read from the command
            rdr = cmd.ExecuteReader();

            //While reading, update the global variables to be used in the more info scene
            while (rdr.Read()){
			    //Debug.Log("???");
				//Debug.Log(rdr[0]+" -- "+rdr[1]);

                //Get all the information from the database and put them into global variables to be used by the MoreInfo script to update more info scene
                global_TextForNewScene = rdr[6].ToString();
                global_ProfNameForNewScene = rdr[1].ToString() + ". " + rdr[3].ToString();
                global_ProfDepartmentForNewScene = rdr[5].ToString();
			}
			rdr.Close();

        }
        //If we cant connect to the database, print error message and set global variables to empty strings
        catch (Exception ex)
        {
            Debug.Log("Could not connect to database.");
            Debug.Log(ex.Message);
            global_TextForNewScene = "Failed to load, please retry.";
            global_ProfNameForNewScene = "";
            global_ProfDepartmentForNewScene = "";
        }
    }

    //When the application is closed, close the connection to the database
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