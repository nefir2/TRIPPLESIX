using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRIPPLESIX
{
	public partial class TransBin : Form
	{
		/// <summary>
		/// конструктор пятой формы.
		/// </summary>
		public TransBin()
		{
			InitializeComponent();
		}


		


		//важные методы для всех форм.
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
			Buttoner f1 = new Buttoner(); //создание объекта первой формы.
			f1.Show(); //отображение первой формы.
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
			//Application.Exit();
			if (e.CloseReason == CloseReason.UserClosing || e.CloseReason == CloseReason.TaskManagerClosing) //запрещает выход из программы нажатием на крестик и с помощью диспетчера задач.
            {
				TransBin tb = new TransBin();
				tb.Show();
			}
		}

		/// <summary>
		/// если пользователь наводится на кнопку, то кнопка убегает.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void Runaway(object sender, EventArgs e)
        {
			Random rnd = new Random();
			Point x = new Point();
			x.X = rnd.Next(0, 1100);
			x.Y = rnd.Next(0, 600);
			button1.Location = x;
        }
    }
}