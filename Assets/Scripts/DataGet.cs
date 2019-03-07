// This script gets all the data of choice table from Java_Tower database online
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net;

// Class to get all the data of choice table from database
public class DataGet {
	//Function to get data online
	public string GetChoiceQuestion(string num){
		string urlAddress = "http://javatowergame.000webhostapp.com/choiceData.php?idPost=" + num;  

		using (WebClient client = new WebClient())
		{
			// this string contains the webpage's source
			string pagesource = client.DownloadString(urlAddress);  
			return pagesource;
		}
	}
}
