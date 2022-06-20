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
		ushort key;

		//методы.
		/// <summary>
		/// метод возвращает текст помноженный на ключ.
		/// </summary>
		/// <returns></returns>
		private string SetSecret()
		{
			string mes = ""; //переменная для возврата полученного значения.
			if (inpBox.Text != "") //если поле ввода не пустое
			{	//проход по длине значения в поле ввода.
				for (int i = 0; i < inpBox.Text.Length; i++)
				{ //добавление очередного символа возвращаемую строку.
					mes += Convert.ToChar(inpBox.Text[i] ^ key); //сложение символов через "исключающее или".
				}
			}
			return mes; //возврат полученной строки.
		}
		//		обработчики событий.
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
			labelException.Text = ""; //очистка места вывода ошибок.
			TextBox who = sender as TextBox; //определение, кто отправил событие.

			//если отправитель - главное поле ввода, и ключ пустой, то ключ возвращается к изначальному значению.
			if (who.Name == "inpBox" && keyBox.Text == "") keyBox.Text = "13425"; //значение по умолчанию подобрано то, какое понравилось.
			try //попытка преобразовать текст из места с ключом в поле ключа.
			{
				key = ushort.Parse(keyBox.Text); //сохранение значение ключа в собственное поле.
				outpBox.Text = SetSecret(); //вывод зашифрованного текста, при помощи ключа.
			}
			catch (FormatException) //если есть буквы в поле ввода ключа, или там ничего нет, то 
			{
				labelException.Text = "буквы.\n\nне.\n\nвводить."; //выводится ошибка в своё место.
			}
			catch (OverflowException) //если в ключ внесли слишком большое число, то 
			{
				labelException.Text = "слишком.\n\nмного.\n\nчисел."; //вывод ошибки в своё место.
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
		private void Closer(object sender, FormClosingEventArgs e) => Application.Exit();

		private void selecter(object sender, MouseEventArgs e)
		{
			if (outpBox.SelectedText != "") outpBox.Select(0, 0);
			else outpBox.SelectAll();
		}
    }
}