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
	public partial class Form2 : Form
	{
		/// <summary>
		/// конструктор второй формы.
		/// </summary>
		public Form2()
		{
			InitializeComponent();
		}

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
		/// обработчик события нажатия на кнопку "к кнопочкам".
		/// </summary>
		/// <remarks>
		/// при нажатии на кнопку, метод возвращает из остальных форм обратно в первую.
		/// </remarks>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Backer(object sender, EventArgs e)
        {
			Form1 f1 = new Form1(); //создание объекта первой формы.
			f1.Show(); //отображение первой формы.
			this.Hide(); //скрытие этой формы.
        }
	}
}