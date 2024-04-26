using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FileLogic
{
	public class csvCrud
	{
		private static string userName = Environment.UserName;
		private static string productsPath = $@"C:/Users/{userName}/Products.csv";
		private static string separator = ",";

		public void CreateCSV()
		{
			try
			{
				if (!File.Exists(productsPath))
				{
					using (File.Create(productsPath)) { }

					List<string> products = new List<string>
					{
						"SERIAL,NAME,CATEGORY,BUY,SELL,DESCRIPTION",
						"1001,Smartphone X,Electronics,500,700,High-end smartphone with advanced features",
						"1002,Laptop Y,Electronics,800,1000,Powerful laptop for gaming and productivity tasks",
						"1003,Headphones Z,Electronics,50,80,Noise-cancelling headphones with crisp sound quality",
						"1004,Smartwatch A,Electronics,200,250,Smartwatch with fitness tracking and notification features",
						"1005,Portable Speaker B,Electronics,80,100,Compact speaker with Bluetooth connectivity",
						"1006,Wireless Mouse C,Electronics,20,30,Ergonomic wireless mouse for comfortable use",
						"1007,External Hard Drive D,Electronics,100,120,Portable hard drive with large storage capacity",
						"1008,Desk Lamp E,Home & Garden,30,40,Adjustable desk lamp for studying or working",
						"1009,Plant F,Home & Garden,15,20,Low-maintenance indoor plant for home decor",
						"1010,Coffee Maker G,Home & Garden,50,70,Programmable coffee maker for brewing fresh coffee",
						"1011,Travel Backpack H,Fashion,40,60,Durable backpack with multiple compartments for travel",
						"1012,Running Shoes I,Fashion,60,80,Comfortable running shoes with cushioned soles",
						"1013,Sunglasses J,Fashion,25,35,Stylish sunglasses with UV protection",
						"1014,Leather Wallet K,Fashion,30,45,Classic leather wallet with multiple card slots",
						"1015,Denim Jeans L,Fashion,40,50,Stylish denim jeans for casual wear",
						"1016,Notebook M,Office Supplies,5,8,Simple notebook for jotting down notes or sketches",
						"1017,Ballpoint Pen N,Office Supplies,1,2,Smooth-writing ballpoint pen for everyday use",
						"1018,Whiteboard Marker O,Office Supplies,2,3,Eraser-friendly marker for whiteboard presentations",
						"1019,Stapler P,Office Supplies,3,5,Durable stapler for securing papers together",
						"1020,Desk Organizer Q,Office Supplies,10,15,Compact desk organizer for storing stationery items"
					};

					File.WriteAllLines(productsPath, products, Encoding.UTF8);
				}
			}
			catch (Exception ex)
			{
				throw new Exception($"Error in 'CreateCSV' method. Error: {ex.Message}");
			}
		}

		public List<string> LoadCategories()
		{
			List<string> categories = new List<string>();

			try
			{	
				string[] lines = File.ReadAllLines(productsPath);

				if (lines.Length > 0)
				{
					for (int i = 1; i < lines.Length; i++)
					{
						string[] item = lines[i].Split(char.Parse(separator));

						if (!categories.Contains(item[2]))
						{
							categories.Add(item[2]);
						}
					}
				}
				else
				{
					throw new Exception("No data in CSV file");
				}

				return categories;
			}
			catch (Exception ex)
			{
				throw new Exception($"Error in 'LoadCategory' method. Error: {ex.Message}");
			}
		}

		public List<string> ReturnProduct(int actualLine)
		{
			try
			{
				List<string> products = new List<string>();

				string[] lines = File.ReadAllLines(productsPath);

				if (lines.Length > 0 && actualLine > 0)
				{
					string[] item = lines[actualLine].Split(char.Parse(separator));

					for (int i = 0; i < item.Length; i++)
					{
						products.Add(item[i]);
					}
				}
				else
				{
					throw new Exception("No data in CSV file.");
				}

				return products;
			}
			catch (Exception ex)
			{
				throw new Exception($"Error in 'ReturnProducts' method. Error: {ex.Message}");
			}
		}

		public int LastProductArray()
		{
			try
			{
				string[] lines = File.ReadAllLines(productsPath);

				if (lines.Length > 0)
				{
					return lines.Length - 1; // Last item in array
				}
				else
				{
					throw new Exception("No data in CSV file.");
				}

			}
			catch (Exception ex)
			{
				throw new Exception($"Error in 'LastProduct' method. Error: {ex.Message}");
			}
		}

		public void NewProductCSV(string serial, string name, string category, string buy, string sell, string description)
		{
			try
			{
				VerifyData(name, category, buy, sell, serial);
				ChangeSeparator();

				buy = buy.Replace("$", "").Replace("R", "").Replace(" ", "").Replace(",", ".");
				sell = sell.Replace("$", "").Replace("R", "").Replace(" ", "").Replace(",", ".");

				var line = $"{serial},{name},{category},{buy},{sell},{description}";

				using (StreamWriter writer = new StreamWriter(productsPath, true))
				{
					writer.WriteLine(line);

					writer.Close();
				}

				string[] allLines = File.ReadAllLines(productsPath);
				allLines[0] = "SERIAL,NAME,CATEGORY,BUY,SELL,DESCRIPTION";
				File.WriteAllLines(productsPath, allLines, Encoding.UTF8);
			}
			catch (Exception ex)
			{
				throw new Exception($"Error in 'NewProductCSV' method. Error: {ex.Message}");
			}
		}

		public void UpdateProductCSV(int line, string serial, string name, string category, string buy, string sell, string description)
		{
			try
			{
				VerifyData(name, category, buy, sell);
				ChangeSeparator();

				buy = buy.Replace("$", "").Replace("R", "").Replace(" ", "").Replace(",", ".");
				sell = sell.Replace("$", "").Replace("R", "").Replace(" ", "").Replace(",", ".");

				string[] allLines = File.ReadAllLines(productsPath);
				allLines[line] = $"{serial},{name},{category},{buy},{sell},{description}";
				File.WriteAllLines(productsPath, allLines, Encoding.UTF8);
			}
			catch (Exception ex)
			{
				throw new Exception($"Error in 'UpdateProductCSV' method. Error: {ex.Message}");
			}
		}

		public void ChangeSeparator()
		{
			try
			{
				using (StreamReader reader = new StreamReader(productsPath))
				{
					string fileContent = reader.ReadToEnd();

					string replaceSeparator = fileContent.Replace(";", separator);

					reader.ReadLine();

					reader.Close();

					using (StreamWriter writer = new StreamWriter(productsPath))
					{
						writer.Write(replaceSeparator);

						writer.Close();
					}
				}
			}
			catch (Exception ex)
			{
				throw new Exception($"Error in 'ChangeSeparator' method. Error : {ex.Message}"); 
			}
		}

		private void VerifyData(string name, string category, string buy, string sell, string serial = "none")
		{
			if (serial != "none")
			{
				if (serial == "")
				{
					throw new Exception("The field 'Serial' cannot be empty!");
				}

				if (!int.TryParse(serial, out _))
				{
					throw new Exception("Insert a valid Serial number!");
				}
			}

			if (name == "")
			{
				throw new Exception("The field 'Name' cannnot be empty!");
			}

			if (buy == "")
			{
				throw new Exception("The field 'Buy' cannnot be empty!");
			}

			if (!decimal.TryParse(buy.Replace("$", "").Replace("R", "").Replace(" ", ""), out _))
			{
				throw new Exception("Insert a valid Buy price!");
			}

			if (sell == "")
			{
				throw new Exception("The field 'Sell' cannnot be empty!");
			}

			if (!decimal.TryParse(sell.Replace("$", "").Replace("R", "").Replace(" ", ""), out _))
			{
				throw new Exception("Insert a valid Sell price!");
			}

			if (category == "")
			{
				throw new Exception("Select a Category!");
			}
		}
	}
}
