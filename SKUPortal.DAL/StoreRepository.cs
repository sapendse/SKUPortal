using Microsoft.VisualBasic.FileIO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SKUPortal.BusinessLayer.DALInterfaces;
using SKUPortal.Model;
using System.Text.Json;

namespace SKUPortal.DAL
{
	public class StoreRepository : IStoreRepository
	{
		private List<SKUDrink> ParseSKUDrinksList()
		{
			List<SKUDrink> inventoryDrinkList = new List<SKUDrink>();
			string fullPath = "../SampleData/sku.csv";
			using (TextFieldParser csvParser = new TextFieldParser(fullPath))
			{
				csvParser.TextFieldType = FieldType.Delimited;
				csvParser.SetDelimiters(",");

				string[] csvFields = csvParser.ReadFields(); // Read the headers but don't process them
				while (!csvParser.EndOfData)
				{
					try
					{
						float tempFloat;
						int tempInt;
						csvFields = csvParser.ReadFields();
						SKUDrink tempDrink = new SKUDrink();
						tempDrink.JanCode = csvFields[0];
						tempDrink.DrinkName = csvFields[1];
						float.TryParse(csvFields[2], out tempFloat);
						tempDrink.ProductSize.Width = tempFloat;
						float.TryParse(csvFields[3], out tempFloat);
						tempDrink.ProductSize.Depth = tempFloat;
						float.TryParse(csvFields[4], out tempFloat);
						tempDrink.ProductSize.Height = tempFloat;
						tempDrink.ProductImageUrl = csvFields[5];
						int.TryParse(csvFields[6], out tempInt);
						tempDrink.DrinkSizeInMl = tempInt;
						tempDrink.ProductRegistrationTimeStamp = csvFields[7];
						tempDrink.ProductShapeType = csvFields[8];
						inventoryDrinkList.Add(tempDrink);
					}
					catch (Exception ex)
					{
						// TODO: Log error
						return null;
					}
				}
			}
			return inventoryDrinkList;
		}

		public SKUStore ReadAndParseSampleData()
		{
			SKUStore store = new SKUStore();
			using (StreamReader storeFileReader = File.OpenText("../SampleData/shelf.json"))
			{
				using (JsonTextReader jtReader = new JsonTextReader(storeFileReader))
				{
					store = ((JObject)JToken.ReadFrom(jtReader)).ToObject<SKUStore>();
				}
			}
			store.DrinkInventory = ParseSKUDrinksList();
			return store;
		}
	}
}
