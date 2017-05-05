using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class ValidationLibrary
{

    //**********************************************************************************************
    // Library of validation functions we can use in future projects
    //**********************************************************************************************

    // Receives a string and we can let user know if it is filled in
    public static bool IsItFilledIn(string temp)
    {
        bool result = false;

        if (temp.Length > 0)
        {
            result = true;
        }

        return result;
    }


    // Receives a string and we can let user know if it is filled in
    public static bool IsItFilledIn(string temp, int minlen)
    {
        bool result = false;

        if (temp.Length >= minlen)
        {
            result = true;
        }

        return result;
    }


    // Receives a string and we can let user know if it has a semi-valid email format
    public static bool IsValidEmail(string strEmail)
    {
        // assume true, but look for bad stuff to make it false
        bool result = true;

        // Look for position of "@"
        int atLocation = strEmail.IndexOf("@");
        int NextatLocation = strEmail.IndexOf("@", atLocation + 1);

        // Look for position of last period "."
        int periodLocation = strEmail.LastIndexOf(".");

        // check for minimum length
        if (strEmail.Length < 8)
        {
            result = false;
        }
        else if (atLocation < 2)    // if it is -1, not found and needs at least 2 chars in front
        {
            result = false;
        }
        else if (periodLocation + 2 > (strEmail.Length))
        {
            result = false;
        }

        return result;
    }


    // Receives a string and lets user know if State abbreviation is proper length (2).
    public static bool IsValidLength(string strTemp, int intLength)
    {
        bool result = false;

        // Check for correct length of characters
        if (strTemp.Length != intLength)
        {
            result = false;
        }
        else
        {
            result = true;
        }

        return result;
    }


    // Receives a string and we can let user know if length of Country name is a valid length.
    public static bool IsWithinRange(string strTemp, int intMinLen, int intMaxLen)
    {
        bool result = false;

        if (strTemp.Length >= intMinLen && strTemp.Length <= intMaxLen)
        {
            result = true;
        }

        return result;
    }
}