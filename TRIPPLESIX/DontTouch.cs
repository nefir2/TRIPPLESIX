using System;
using System.Drawing;
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
			NewLoca();
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
		/// <summary>
		/// установка нового положения кнопки.
		/// </summary>
		private void NewLoca()
		{
			button1.Location = new Point
			{
				X = rnd.Next(0, 1100),
				Y = rnd.Next(0, 600)
			};
		}
		//		обработчики события
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
		/// <summary>
		/// таймер, для облегчения успеваемости нажатия кнопки.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Timedout(object sender, EventArgs e)
		{
			if (secs > 0) secs--;
			else
			{
				time.Stop();
				NewLoca();
			}
		}
		/// <summary>
		/// обработчик события изменения окна.
		/// </summary>
		/// <remarks>
		/// не позволяет изменить размер окна.
		/// </remarks>
		/// <param name="sender"></param>
		/// <param name="e"></param>
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
			{ //запрещает выход из программы нажатием на крестик или с помощью диспетчера задач.
				DontTouch tb = new DontTouch();
				tb.Show();
			}
		}
	}
}