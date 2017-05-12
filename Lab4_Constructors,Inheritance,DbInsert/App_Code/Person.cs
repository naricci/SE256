using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;                  // Library to bring in a dataset
using System.Data.SqlClient;        // Library to connect to SQL Server

public class Person
{
    // Set private variables within Person class
    private string firstname;
    private string middlename;
    private string lastname;
    private string street1;
    private string street2;
    private string city;
    private string state;
    private string zipcode;
    private DateTime birthday;
    private DateTime anniversary;
    private string homephone;
    private string workphone;
    private string cellphone;
    private string email;
    private string cardworthy;
    private string relationship;
    private string notes;
    private string feedback = "";
    public Int32 Person_ID = 0;
    // public const string connstring = @"Server=SQL.NEIT.EDU,4500;Database=SE255_NRicci;User Id=SE255_NRicci;Password = 001405200;";


    // Create public variables to use as the front-end for their private counterparts above
    public string FirstName
    {
        get { return firstname; }   // Accessor
        set    // Mutator
        {
            if (ValidationLibrary.IsItFilledIn(value, 1) == false)
            {
                feedback += "ERROR: First Name cannot be left blank.\n";
            }
            else
            {
                firstname = value;
            }
        }
    }

    public string MiddleName
    {
        get { return middlename; }
        set
        {
            middlename = value;
        }
    }

    public string LastName
    {
        get { return lastname; }
        set
        {
            if (ValidationLibrary.IsItFilledIn(value, 1) == false)
            {
                feedback += "ERROR: Last Name cannot be left blank.\n";
            }
            else
            {
                lastname = value;
            }
        }
    }

    public string Street1
    {
        get { return street1; }
        set { street1 = value; }
    }

    public string Street2
    {
        get { return street2; }
        set { street2 = value; }
    }

    public string City
    {
        get { return city; }
        set { city = value; }
    }

    public string State
    {
        get { return state; }
        set
        {
            if (ValidationLibrary.IsItFilledIn(value, 2) == false)
            {
                feedback += "ERROR: State must be filled using abbreviation.\n";
            }
            else if (ValidationLibrary.IsValidLength(value, 2) == false)
            {
                feedback += "ERROR: State must use 2-letter abbreviation.\n";
            }
            else
            {
                state = value;
            }
        }
    }

    public string ZipCode
    {
        get { return zipcode; }
        set
        {
            if (ValidationLibrary.IsItFilledIn(value, 5) == false)
            {
                feedback += "ERROR: Please fill in a 5-digit Zip Code.\n";
            }
            else if (ValidationLibrary.IsValidLength(value, 5) == false)
            {
                feedback += "ERROR: Zip Code must be exactly 5 digits.\n";
            }
            else
            {
                zipcode = value;
            }
        }
    }

    public DateTime Birthday
    {
        get { return birthday; }
        set
        {
            birthday = value;
        }
    }

    public DateTime Anniversary
    {
        get { return anniversary; }
        set { anniversary = value; }
    }

    public string HomePhone
    {
        get { return homephone; }
        set { homephone = value; }
    }

    public string WorkPhone
    {
        get { return workphone; }
        set { workphone = value; }
    }

    public string CellPhone
    {
        get { return cellphone; }
        set { cellphone = value; }
    }

    public string Email
    {
        get { return email; }
        set
        {
            if (ValidationLibrary.IsItFilledIn(value, 1) == false)
            {
                feedback += "ERROR: Please fill in an Email address.\n";
            }
            else if (ValidationLibrary.IsValidEmail(value) == false)
            {
                feedback += "ERROR: Email not valid.  Try again.";
            }
            else
            {
                email = value;
            }
        }
    }

    public string CardWorthy
    {
        get { return cardworthy; }
        set { cardworthy = value; }
    }

    public string Relationship
    {
        get { return relationship; }
        set { relationship = value; }
    }

    public string Notes
    {
        get { return notes; }
        set { notes = value; }
    }

    public string Feedback
    {
        get { return feedback; }
    }


    // Default Constructor
    public Person()
    {
        // Start by giving the feedback an empty string
        feedback = "";
    }

    // Overloaded Constructor
    public Person(string firstname, string middlename, string lastname, string street1, string street2, string city, string state, string zipcode, DateTime birthday, DateTime anniversary, string homephone, string workphone, string cellphone, string email, string cardworthy, string relationship, string notes)
    {
        this.FirstName = firstname;
        this.MiddleName = middlename;
        this.LastName = lastname;
        this.Street1 = street1;
        this.Street2 = street2;
        this.City = city;
        this.State = state;
        this.ZipCode = zipcode;
        this.Birthday = birthday;
        this.Anniversary = anniversary;
        this.HomePhone = homephone;
        this.WorkPhone = workphone;
        this.CellPhone = cellphone;
        this.Email = email;
        this.CardWorthy = cardworthy;
        this.Relationship = relationship;
        this.Notes = notes;

        // Start by giving the feedback an empty string
        feedback = "";
    }

    
    public string AddPerson()
    {
        string strFeedback = "";    // User feedback

        string strConn = "Server=SQL.NEIT.EDU,4500;Database=SE255_NRicci;User Id=SE255_NRicci;Password = 001405200;";   // Connection String

        SqlConnection conn = new SqlConnection();   // Create a Connection Object
        conn.ConnectionString = strConn;    // Point the Connection Object to our Connection String

        SqlCommand comm = new SqlCommand(); // Create a Command Object
        // Needs to know the connection and sql string
        comm.Connection = conn;
        comm.CommandText = "INSERT INTO WebPeople (FirstName, MiddleName, LastName, Street1, Street2, City, State, ZipCode, Birthday, Anniversary, HomePhone, WorkPhone, CellPhone, Email, CardWorthy, Relationship, Notes) VALUES (@FirstName, @MiddleName, @LastName, @Street1, @Street2, @City, @State, @ZipCode, @Birthday, @Anniversary, @HomePhone, @WorkPhone, @CellPhone, @Email, @CardWorthy, @Relationship, @Notes)";

        comm.Parameters.AddWithValue("@FirstName", FirstName);
        comm.Parameters.AddWithValue("@MiddleName", MiddleName);
        comm.Parameters.AddWithValue("@LastName", LastName);
        comm.Parameters.AddWithValue("@Street1", Street1);
        comm.Parameters.AddWithValue("@Street2", Street2);
        comm.Parameters.AddWithValue("@City", City);
        comm.Parameters.AddWithValue("@State", State);
        comm.Parameters.AddWithValue("@ZipCode", ZipCode);
        comm.Parameters.AddWithValue("@Birthday", Birthday);
        comm.Parameters.AddWithValue("@Anniversary", Anniversary);
        comm.Parameters.AddWithValue("@HomePhone", HomePhone);
        comm.Parameters.AddWithValue("@WorkPhone", WorkPhone);
        comm.Parameters.AddWithValue("@CellPhone", CellPhone);
        comm.Parameters.AddWithValue("@Email", Email);
        comm.Parameters.AddWithValue("@CardWorthy", CardWorthy);
        comm.Parameters.AddWithValue("@Relationship", Relationship);
        comm.Parameters.AddWithValue("@Notes", Notes);

        try { 
            conn.Open();

            // Perform our add
            strFeedback = comm.ExecuteNonQuery().ToString() + " Record(s) Added";

            conn.Close();

            // got here...we must be fine
            // strFeedback = "All good here";   // Main job is to add now, not just connect...
        }
        catch (Exception err)
        {
            strFeedback = "ERROR: " + err.Message;
        }

        return strFeedback;     // Return User feedback
    }

    /*
    public DataSet SearchContacts(String FirstName, String LastName)
    {
        //Create a dataset to return filled
        DataSet ds = new DataSet();


        //Create a command for our SQL statement
        SqlCommand comm = new SqlCommand();


        //Write a Select Statement to perform Search
        String strSQL = "SELECT Person_ID, FirstName, MiddleName, LastName FROM Web-Persons WHERE 0=0";

        //If the First/Last Name is filled in include it as search criteria
        if (FirstName.Length > 0)
        {
            strSQL += " AND FirstName LIKE @FirstName";
            comm.Parameters.AddWithValue("@FirstName", "%" + FirstName + "%");
        }
        if (LastName.Length > 0)
        {
            strSQL += " AND LastName LIKE @LastName";
            comm.Parameters.AddWithValue("@LastName", "%" + LastName + "%");
        }


        //Create DB tools and Configure
        //*********************************************************************************************
        SqlConnection conn = new SqlConnection();
        //Create the who, what where of the DB
        string strConn = @connstring;
        conn.ConnectionString = strConn;

        //Fill in basic info to command object
        comm.Connection = conn;     //tell the commander what connection to use
        comm.CommandText = strSQL;  //tell the command what to say

        //Create Data Adapter
        SqlDataAdapter da = new SqlDataAdapter();
        da.SelectCommand = comm;    //commander needs a translator(dataAdapter) to speak with datasets

        //*********************************************************************************************

        //Get Data
        conn.Open();                //Open the connection (pick up the phone)
        da.Fill(ds, "Persons");     //Fill the dataset with results from database and call it "Persons"
        conn.Close();               //Close the connection (hangs up phone)

        //Return the data
        return ds;
    } */
};