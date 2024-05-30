using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstASP_Project.data
{
	public interface IDataHelper <Table>
	{
		List<Table> GetData();

		List<Table> Search(string SearchItem);

		Table GetById(int id);

		void Add(Table table);

		void Edit(int ID,Table table);

		void Delete(int ID);
	}
}
