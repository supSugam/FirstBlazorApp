namespace FirstBlazorApp.Data;

public class WeatherForecast
{
    public DateOnly Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    public string? Summary { get; set; }
}

// Student.cs inside Data
// public string FullName { get; set; }
// public string PhoneNumber { get; set; }
// public int Semester { get; set; }
// public Guid Guid { get; set; }

/**
 * Write a description of class san17 here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */
// public class san17
// {
//     /* use logical operator || and && to denote that if busy say go work, if free 
//     //go for hiking, if summer and busy go to see other travel and if (!summer || 
//     !spring) & free what to do even on free time else enjoy life */
//     public static void main (String[] args){
//         String weather = "summer";
//         String availability = "free";
//         if (weather == "summer" && availability == "free"){
//             System.out.println("go for hiking");
//         }
//         if (weather == "rain")
//             if(availability == "busy"){
//                 System.out.println("work at home");
//             }
//         if (weather == "spring" && availability =="free"){
//             System.out.println("go for vacation");
//         }
//         if (weather == "summer" && availability =="busy"){
//             System.out.println("get to work");
//         }    
//         if (weather == "rain" && availability =="free"){
//             System.out.println("stay at home and watch netflix");
//         }
//         if (weather == "spring" && availability =="busy"){
//             System.out.println("see others traveling and get jealous");
//         }
//         else{
//             System.out.println("enjoy life playing games");
//         }
//     }
// }