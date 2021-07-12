using System;

class MainClass {

  
  public static void Main (string[] args) {

    Console.WriteLine(CalculateCharge(18));
  
}
  
 public static double CalculateCharge(double hours)
  { 
  //time is less or equal to 3hrs = $2
  //time is greater than or equal to 4hrs and less than 19hrs is $2 + $0.50hr
  //tme is greater than or equal to 19hrs and less than or equal to 24hrs = $10
  double result;
  
    if (hours <= 3)
    {
      result = 2;
    }
     if (hours >=4 && hours <=19)
    { 
      result = hours*0.50 + 0.50;
    }

    else
    { 
      result = 10;
    }
    
    return result;
  }
  }
    
