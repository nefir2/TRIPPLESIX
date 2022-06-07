using System;
using System.Text;
using System.Windows.Forms;

namespace TRIPPLESIX
{
	public partial class cyph : Form
	{
		/// <summary>
		/// конструктор четвёртой формы.
		/// </summary>
		public cyph()
		{
			InitializeComponent();
			outpBox.Text = ""; //очистка значения окна вывода при запуске формы.
			labelException.Text = ""; //очистка окна сообщения с ошибками.
		}

		//поля
		/// <summary>
		/// поле хранящее значение ключа с keyBox.
		/// </summary>
		int key;
		//методы.

		private string SetSecret()
        {
			StringBuilder mes = new StringBuilder();
			if (inpBox.Text != "")
			{
				for (int i = 0; i < inpBox.Text.Length; i++)
				{
					mes.Append(Convert.ToChar(inpBox.Text[i] ^ key));
				}
			}
			return mes.ToString();
		}

		/// <summary>
		/// обработчик события поднятия клавиши, находясь в фокусе на inpBox.
		/// </summary>
		/// <remarks>
		/// метод ожидает событие поднятие клавиши и выводит засекреченное сообщение в outpBox.
		/// </remarks>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SecretTheMess(object sender, KeyEventArgs e)
		{
			TextBox who = sender as TextBox;
			if (who.Name == "inpBox" && keyBox.Text == "") keyBox.Text = "15"; //если ключ будет пустым.
			try
			{
				key = int.Parse(keyBox.Text); //сохранение значение ключа в собственное поле.
				outpBox.Text = SetSecret();
			}
            catch (FormatException)
            {
				labelException.Text = "буквы.\n\nне.\n\nвводить.";
            }
			catch (OverflowException)
            {
				labelException.Text = "слишком.\n\nмного.\n\nчисел.";
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