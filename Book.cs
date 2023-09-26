using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_WPF_Konyvek
{
    public class Book
    {
		private string _title;

		public string Title
		{
			get { return _title; }
			set { _title = value; }
		}

		private int _pagecount;

		public int Pagecount
		{
			get { return _pagecount; }
			set { _pagecount = value; }
		}

		private string _author;

		public string Author
		{
			get { return _author; }
			set { _author = value; }
		}

		private string _type;

		public string Type
		{
			get { return _type; }
			set { _type = value; }
		}


        public Book(string row)
        {
			string[] datas = row.Split(';');
			Title = datas[0];
			Pagecount = int.Parse(datas[1]);
			Author = datas[2];
			Type = datas[3];
        }
    }
}
