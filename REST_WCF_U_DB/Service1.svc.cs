using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace REST_WCF_U_DB
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public static List<Game> ListOfGames  = new List<Game> //statisk liste af typen Game. 
        {
            new Game(1,"WoW", 3.4),
            new Game(2,"LoL", 2),
            new Game(3,"Overwatch", 5),
        };
        public void AddGame(Game newGame)
        {
            ListOfGames.Add(newGame);
        }

        public Game DeleteGame(int id)
        {
            var deleteGame = GetOneGame(id.ToString()); //skal bruge en string id som parameter, tostring da id er af typen int. 
            if (deleteGame != null)
            {
                ListOfGames.Remove(deleteGame);
                return deleteGame;
            }

            return null;
        }

        public List<Game> GetGames()
        {
            return ListOfGames;
        }

        public Game GetOneGame(string id)
        {
            int idint = Int32.Parse(id);

            return ListOfGames.Find(c => c.Id == idint);
        }

        public Game UpdateGame(Game myGame)
        {
            var updateGame = GetOneGame(myGame.Id.ToString());
            if (updateGame != null)
            {
                updateGame.Id = myGame.Id;
                updateGame.Titel = myGame.Titel;
                updateGame.Rating = myGame.Rating;
                return updateGame;
            }

            return null;
        }
    }
}
