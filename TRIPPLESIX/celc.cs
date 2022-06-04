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
	public partial class celc : Form
	{
		/// <summary>
		/// конструктор второй формы.
		/// </summary>
		public celc()
		{
			InitializeComponent();
		}

		//поля
		/// <summary>
		/// левое число.
		/// </summary>
		int left;
		/// <summary>
		/// правое число.
		/// </summary>
		int right;
		/// <summary>
		/// знак.
		/// </summary>
		char sign;

		//методы
		private decimal Calc()
		{
			switch (sign)
			{
				case '+':
					return left + right;
				case '-':
					return left - right;
				case '*':
					return left * right;
				case '/':
					return left / right;
				case '%':
					return left % right;
				case '^':
					return (int)Math.Pow(left, right);
				default:
					return Calcleft();
			}
		}
		private decimal Calcleft()
        {
            switch (sign)
            {
				case '!':

                default:
					return 0;
            }
        }

		//обработчики событий.
		/// <summary>
		/// обработчик событий нажатий на любую из кнопок.
		/// </summary>
		/// <remarks>
		/// при нажатии на кнопку вызывается этот метод, <br/>
		/// с помощью <paramref name="sender"/> определяется на какую именно кнопку нажали. <br/>
		/// </remarks>
		/// <param name="sender">отправитель события.</param>
		/// <param name="e"></param>
		private void BtnsClick(object sender, EventArgs e)
		{
			Button who = sender as Button; //распаковка отправителя в класс Button.
			problemBox.Text += who.Text; //установка названия кнопки в окно вывода.
			try
			{
				int.Parse("f");
			}
			catch (Exception ex)
			{
				MessageBox.Show
				(
					caption: "ты што наделол...",
					text: "я тут пытался пропарсить то что ты мне накликал, но я получил тысячу букв в лицо, так что мне придётся тебя наказать.\n" 
					+ "вот они как раз:\n" +  ex.ToString()
				);
				for (int i = 0; i < 10; i++) Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
			}
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
			Application.Exit();
		}
	}
}