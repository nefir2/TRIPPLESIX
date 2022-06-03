using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRIPPLESIX
{
	public partial class Form1 : Form
	{
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
		/// обработчик события нажатия на кнопке Form2.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void changeForm2(object sender, EventArgs e)
		{
			f2.Show(); //открытие указанной формы.
			this.Hide(); //скрытие этой формы.
		}

		/// <summary>
		/// обработчик события нажатия на кнопкe Form3.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void changeForm3(object sender, EventArgs e)
		{
			f3.Show();
			this.Hide();
		}

		/// <summary>
		/// обработчик события нажатия на кнопкe Form4.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void changeForm4(object sender, EventArgs e)
		{
			f4.Show();
			this.Hide();
		}

		/// <summary>
		/// обработчик события нажатия на кнопкe Form5.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void changeForm5(object sender, EventArgs e)
		{
			f5.Show();
			this.Hide();
		}

		/// <summary>
		/// обработчик события нажатия на кнопкe Form6.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void changeForm6(object sender, EventArgs e)
		{
			f6.Show();
			this.Hide();
		}
	}
}