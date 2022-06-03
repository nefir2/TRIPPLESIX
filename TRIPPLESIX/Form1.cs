using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRIPPLESIX
{
	public partial class Form1 : Form
	{
		/// <summary>
		/// конструктор первой формы.
		/// </summary>
		public Form1()
		{
			InitializeComponent();
		}

		//поля
		/// <summary>
		/// вторая форма.
		/// </summary>
		Form2 f2 = new Form2();
		/// <summary>
		/// третья форма.
		/// </summary>
		Form3 f3 = new Form3();
		/// <summary>
		/// четвёртая форма.
		/// </summary>
		Form4 f4 = new Form4();
		/// <summary>
		/// пятая форма.
		/// </summary>
		Form5 f5 = new Form5();
		/// <summary>
		/// шестая форма.
		/// </summary>
		Form6 f6 = new Form6();

		//методы

		//		обработчики событий.
		/// <summary>
		/// обработчик события нажатия на кнопке Form2.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void changeForm2(object sender, EventArgs e)
		{
			f2.Show(); //открытие нажатой формы.
			this.Hide(); //скрытие этой формы.
		}

		/// <summary>
		/// обработчик события нажатия на кнопкe Form3.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void changeForm3(object sender, EventArgs e)
		{
			f3.Show(); //открытие нажатой формы.
			this.Hide(); //скрытие этой формы.
		}

		/// <summary>
		/// обработчик события нажатия на кнопкe Form4.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void changeForm4(object sender, EventArgs e)
		{
			f4.Show(); //открытие нажатой формы.
			this.Hide(); //скрытие этой формы.
		}

		/// <summary>
		/// обработчик события нажатия на кнопкe Form5.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void changeForm5(object sender, EventArgs e)
		{
			f5.Show(); //открытие нажатой формы.
			this.Hide(); //скрытие этой формы.
		}

		/// <summary>
		/// обработчик события нажатия на кнопкe Form6.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void changeForm6(object sender, EventArgs e)
		{
			f6.Show(); //открытие нажатой формы.
			this.Hide(); //скрытие этой формы.
		}


		//					закрытие всех форм на крестик.
		/// <summary>
		/// обработчик события закрытия формы на крестик.
		/// </summary>
		/// <remarks>
		/// при нажатии на крестик на одной из форм, закроется вся программа.
		/// </remarks>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Closer(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		/// <summary>
		/// обрабтчик события при нажатии на кнопку не связанную с формами.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void OpenSource(object sender, EventArgs e)
        {
			Process.Start("https://github.com/nefir2/TRIPPLESIX");
        }
    }
}