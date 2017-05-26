using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;                  // Library to bring in a dataset
using System.Data.SqlClient;        // Library to connect to SQL Server

public class PizzaOrders
{
    private string pizzasize;
    private string toppings;
    private string firstname;
    private string lastname;
    private string street1;
    private string street2;
    private string city;
    private string state;
    private string zipcode;
    private string phone;
    private string email;
    private double totalcost;
    private string feedback = "";
    public Int32 Order_ID = 0;
    public const string connstring = @"Server=SQL.NEIT.EDU,4500;Database=SE255_NRicci;User Id=SE255_NRicci;Password = 001405200;";

    public string PizzaSize
    {
        get { return pizzasize; }
        set { pizzasize = value; }
    }

    public string Toppings
    {
        get { return toppings; }
        set { toppings = value; }
    }

    public string FirstName
    {
        get { return firstname; }
        set
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
            state = value;
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

    public string Phone
    {
        get { return phone; }
        set { phone = value; }
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

    public double TotalCost
    {
        get { return totalcost; }
        set { totalcost = value; }
    }

    public string Feedback
    {
        get { return feedback; }
        set { feedback = value; }
    }

    public PizzaOrders()
    {
        feedback = "";
        totalcost = 0;
    }


    public string AddOrder()
    {
        string strFeedback = "";    // User feedback

        string strConn = "Server=SQL.NEIT.EDU,4500;Database=SE255_NRicci;User Id=SE255_NRicci;Password = 001405200;";   // Connection String

        SqlConnection conn = new SqlConnection();   // Create a Connection Object
        conn.ConnectionString = strConn;    // Point the Connection Object to our Connection String

        SqlCommand comm = new SqlCommand(); // Create a Command Object
        // Needs to know the connection and sql string
        comm.Connection = conn;
        comm.CommandText = "INSERT INTO PizzaOrders (PizzaSize, Toppings, FirstName, LastName, Street1, Street2, City, State, ZipCode, Phone, Email, TotalCost) VALUES (@PizzaSize, @Toppings, @FirstName, @LastName, @Street1, @Street2, @City, @State, @ZipCode, @Phone, @Email, @TotalCost)";

        comm.Parameters.AddWithValue("@PizzaSize", PizzaSize);
        comm.Parameters.AddWithValue("@Toppings", Toppings);
        comm.Parameters.AddWithValue("@FirstName", FirstName);
        comm.Parameters.AddWithValue("@LastName", LastName);
        comm.Parameters.AddWithValue("@Street1", Street1);
        comm.Parameters.AddWithValue("@Street2", Street2);
        comm.Parameters.AddWithValue("@City", City);
        comm.Parameters.AddWithValue("@State", State);
        comm.Parameters.AddWithValue("@ZipCode", ZipCode);
        comm.Parameters.AddWithValue("@Phone", Phone);
        comm.Parameters.AddWithValue("@Email", Email);
        comm.Parameters.AddWithValue("@TotalCost", TotalCost);

        try
        {
            conn.Open();

            // Perform our add
            strFeedback = comm.ExecuteNonQuery().ToString() + " Order(s) Added";

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


    public DataSet SearchOrders(String FirstName, String LastName)
    {
        //Create a dataset to return filled
        DataSet ds = new DataSet();


        //Create a command for our SQL statement
        SqlCommand comm = new SqlCommand();


        //Write a Select Statement to perform Search
        String strSQL = "SELECT Order_ID, FirstName, LastName FROM PizzaOrders WHERE 0=0";

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
        da.Fill(ds, "PizzaOrders");     //Fill the dataset with results from database and call it "Persons"
        conn.Close();               //Close the connection (hangs up phone)

        //Return the data
        return ds;
    }

    //Method that returns a Data Reader filled with all the data
    // of one person.  This one person is specified by the ID passed
    // to this function
    public SqlDataReader FindOneOrder(int intOrder_ID)
    {
        //Create and Initialize the DB Tools we need
        SqlConnection conn = new SqlConnection();
        SqlCommand comm = new SqlCommand();

        //My Connection String
        string strConn = @connstring;

        //My SQL command string to pull up one person's data
        string sqlString =
       "SELECT Order_ID, PizzaSize, Toppings, FirstName, LastName, Street1, Street2, City, State, ZipCode, Phone, Email, TotalCost FROM PizzaOrders WHERE Order_ID = @Order_ID;";

        //Tell the connection object the who, what, where, how
        conn.ConnectionString = strConn;

        //Give the command object info it needs
        comm.Connection = conn;
        comm.CommandText = sqlString;
        comm.Parameters.AddWithValue("@Order_ID", intOrder_ID);

        //Open the DataBase Connection and Yell our SQL Command
        conn.Open();

        //Return some form of feedback
        return comm.ExecuteReader();   //Return the dataset to be used by others (the calling form)

    }


    //Method that will delete one person record specified by the ID
    //It will return an Integer meant for feedback on how many 
    // records were deleted
    public Int32 DeleteOneOrder(int intOrder_ID)
    {
        Int32 intRecords = 0;

        //Create and Initialize the DB Tools we need
        SqlConnection conn = new SqlConnection();
        SqlCommand comm = new SqlCommand();

        //My Connection String
        string strConn = @connstring;

        //My SQL command string to pull up one person's data
        string sqlString =
       "DELETE FROM PizzaOrders WHERE Order_ID = @Order_ID;";

        //Tell the connection object the who, what, where, how
        conn.ConnectionString = strConn;

        //Give the command object info it needs
        comm.Connection = conn;
        comm.CommandText = sqlString;
        comm.Parameters.AddWithValue("@Order_ID", intOrder_ID);

        //Open the DataBase Connection and Yell our SQL Command
        conn.Open();

        //Run the deletion and store the number of records effected
        intRecords = comm.ExecuteNonQuery();

        //close the connection
        conn.Close();

        return intRecords;   //Return # of records deleted

    }

    //Method that will update one person record specified by the ID
    public Int32 UpdateAnOrder()
    {
        Int32 intRecords = 0;

        //Create SQL command string
        string strSQL = "UPDATE PizzaOrders SET PizzaSize = @PizzaSize, Toppings = @Toppings, FirstName = @FirstName, LastName = @LastName, Street1 = @Street1, Street2 = @Street2, City = @City, State = @State, ZipCode = @ZipCode, Phone = @Phone, Email = @Email, TotalCost = @TotalCost WHERE Order_ID = @Order_ID;";

        // Create a connection to DB
        SqlConnection conn = new SqlConnection();
        //Create the who, what where of the DB
        string strConn = @connstring;
        conn.ConnectionString = strConn;

        // Bark out our command
        SqlCommand comm = new SqlCommand();
        comm.CommandText = strSQL;  //Commander knows what to say
        comm.Connection = conn;     //Where's the phone?  Here it is

        //Fill in the parameters (Has to be created in same sequence as they are used in SQL Statement)
        comm.Parameters.AddWithValue("@PizzaSize", PizzaSize);
        comm.Parameters.AddWithValue("@Toppings", Toppings);
        comm.Parameters.AddWithValue("@FirstName", FirstName);
        comm.Parameters.AddWithValue("@LastName", LastName);
        comm.Parameters.AddWithValue("@Street1", Street1);
        comm.Parameters.AddWithValue("@Street2", Street2);
        comm.Parameters.AddWithValue("@City", City);
        comm.Parameters.AddWithValue("@State", State);
        comm.Parameters.AddWithValue("@ZipCode", ZipCode);
        comm.Parameters.AddWithValue("@Phone", Phone);
        comm.Parameters.AddWithValue("@Email", Email);
        comm.Parameters.AddWithValue("@TotalCost", TotalCost);
        comm.Parameters.AddWithValue("@Order_ID", Order_ID);

        try
        {
            //Open the connection
            conn.Open();

            //Run the Update and store the number of records effected
            intRecords = comm.ExecuteNonQuery();
        }
        catch (Exception err)
        {
        }
        finally
        {
            //close the connection
            conn.Close();
        }

        return intRecords;

    }
};