// C# program to illustrate the use of 
// Concat(String, String, String, String) Method 
using System; 

class GFG { 
	
	// Main Method 
	static public void Main() 
	{ 
		string strA = "Welcome "; 
		string strB = "to "; 
		string strC = "GFG "; 
		string strD = "Portal."; 
		string str; 

		// print all strings 
		Console.WriteLine("String A is: {0}", strA); 
		Console.WriteLine("String B is: {0}", strB); 
		Console.WriteLine("String C is: {0}", strC); 
		Console.WriteLine("String D is: {0}", strD); 

		// Concatenate four different strings 
		// into a single String using the 
		// Concat(String, String, String, String) Method 
		str = String.Concat(strA, strB, strC, strD); 

		Console.WriteLine("Concatenated string is: {0}", str); 
	} 
} 
