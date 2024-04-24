using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileLogic
{
	public class csvCrud
	{
		public void CreateCSV()
		{
			string userName = Environment.UserName;
			string productsPath = $@"C:/Users/{userName}/Produtos.csv";

			try
			{
				if (!File.Exists(productsPath))
				{
					File.Create(productsPath);
				}
			}
			catch (Exception ex)
			{
				throw new Exception($"Error in 'CreateCSV' method. Error: {ex}");
			}
		}
	}
}
