// Reference: https://www.youtube.com/watch?v=dqheDZH_mNc
using System;

class Program {         
     static void Main(string[] args)
    {
    
            var myNumbers = new List<int> {0,1,1,4,4,5,5,7,9,12};

            // var numbersOver5 = new List<int>();
            // foreach(var n in myNumbers)
            // {
            //     if(n > 5)  numbersOver5.Add(number);
            // }

            //this is the equivalent of the foreach loop above. Adding each number that are greater than 5 to the list.
            var numbersOver5 = myNumbers.Where(n=> n > 5);           
            numbersOver5.ToList();  //we want to loop print this in console, so we need to convert it to a list.
            //BONUS: Similarly, the comment below displays the same result as the above code. But it additionally converts its type from List<int> to List<string> using ConvertAll()
            //List<string> numbersOver5 = myNumbers.Where(n => n > 5).ToList().ConvertAll<string>(x=>x.ToString());  
            foreach(var numbers in numbersOver5){Console.Write(numbers+" ");} //returns 7 9 12
              
            //returns true if all items in myNumbers are greater than 5. Else it prints false.
            var allIsOver5 = myNumbers.All(n=> n > 5);  
            Console.WriteLine("\n"+allIsOver5);  //returns false

            //returns the first value or null in the myNumbers list that are greater than 5.
            var selectFirst = myNumbers.FirstOrDefault(n => n > 5); 
            Console.WriteLine(selectFirst); //returns 7
              
            //Example # 2  Supposed there is a list of game and its rating, we want to display only games that are higher than 3 rating after converting the max rating to 5.
            var gameList = new List<Game>{
                new Game{Name ="LOL", rating=10},
                new Game{Name ="DOTA", rating=8},
                new Game{Name ="SMITE", rating=6},
            };

            // var starRatings = new List<StarRating>();
            // foreach(var s in gameList){
            //     if(s.rating *0.5>3) {starRatings.Add(new StarRating{Name = s.Name,Stars = s.rating * 0.5});}
            // }

            //this is the equivalent of the foreach loop above.
            List<StarRating> starRatings = gameList.Select(g=> new StarRating{
                Name= g.Name,                       
                Stars= g.rating * 0.5               //creates 3 new objects with the same game name and star ratings up to 5
            }).Where(s => s.Stars > 3).ToList();    //then using Where(), filter only to include games that have higher that 3 stars


            foreach(var games in starRatings){Console.WriteLine("Game: "+games.Name+"  Stars: "+games.Stars);} //displays Game: LOL  Stars: 5 , Game: DOTA  Stars: 4
    }
}