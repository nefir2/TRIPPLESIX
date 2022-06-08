using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace TRIPPLESIX
{
	public partial class DontTouch : Form
	{
		/// <summary>
		/// конструктор пятой формы.
		/// </summary>
		public DontTouch()
		{
			InitializeComponent();
			Runaway(this, new EventArgs());
		}

		//поля
		/// <summary>
		/// поле с объектом рандома.
		/// </summary>
		Random rnd = new Random();

		/// <summary>
		/// поле с оставшимся временем для таймера.
		/// </summary>
		int secs;

		//методы
		private void NewLoca()
		{
			button1.Location = new Point
			{
				X = rnd.Next(0, 1100),
				Y = rnd.Next(0, 600)
			};
		}
		//события
		/// <summary>
		/// если пользователь наводится на кнопку, то кнопка убегает.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Runaway(object sender, EventArgs e)
		{
			secs = 2;
			time.Start();
		}

		private void Timedout(object sender, EventArgs e)
		{
			if (secs > 0) secs--;
			else
			{
				time.Stop();
				NewLoca();
			}
		}

		private void Resizing(object sender, EventArgs e)
		{
			this.Hide();
			Closer(this, new FormClosingEventArgs(CloseReason.UserClosing, false));
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
			if (e.CloseReason == CloseReason.UserClosing || e.CloseReason == CloseReason.TaskManagerClosing)
			{ //запрещает выход из программы нажатием на крестик и с помощью диспетчера задач.
				DontTouch tb = new DontTouch();
				tb.Show();
			}
		}
	}
}