using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;
using System.Xml;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        private const string PrizesFile = "PrizeModels.csv";


        // TODO - Wire up the CreatePrize for text files
        public PrizeModel CreatePrize(PrizeModel model)
        {
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();
            int currentId = 1;

            if (prizes.Count > 0) 
            {
                currentId = PrizesFile.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;

            prizes.Add(model);
            //Load the text file 
            //Convert the text to List<PrizeModel>
            //Find the max ID
            //Add a new record with the new ID
            //Convert the prizes to list<strings>
            //Save the list<strings> to the text file
            prizes.SaveToPrizeFile(PrizesFile);

            return model;

        }
    }
}
