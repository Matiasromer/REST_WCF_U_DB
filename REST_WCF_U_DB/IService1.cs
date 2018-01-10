using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace REST_WCF_U_DB
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        //Get all
        [OperationContract] //Operation Contract. Web service metode
        [WebInvoke(
                Method = "GET", //http kald get
                RequestFormat = WebMessageFormat.Json,
                ResponseFormat = WebMessageFormat.Json,
                UriTemplate = "games")
        ]
        List<Game> GetGames(); //liste som jeg kalder GetGames af typen Game


        //Get by id
        [WebInvoke(
                Method = "GET",
                RequestFormat = WebMessageFormat.Json,
                ResponseFormat = WebMessageFormat.Json,
                UriTemplate = "games/{id}")
        ]
        Game GetOneGame(string id);

        //Post/create
        [WebInvoke(
                Method = "POST",
                RequestFormat = WebMessageFormat.Json,
                ResponseFormat = WebMessageFormat.Json,
                UriTemplate = "games")
        ]
        void AddGame(Game newGame);

        //Delete ( husk at erstatte hele {id} med et tal )
        [WebInvoke(
                Method = "DELETE",
                RequestFormat = WebMessageFormat.Json,
                ResponseFormat = WebMessageFormat.Json,
                UriTemplate = "games?id={id}")
        ]
        Game DeleteGame(int id);

        //Update/Put
        [WebInvoke(
                Method = "PUT",
                RequestFormat = WebMessageFormat.Json,
                ResponseFormat = WebMessageFormat.Json,
                UriTemplate = "games")
        ]
        Game UpdateGame(Game myGame);


    }


    
}
