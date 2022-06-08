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
			UseDefault();
		}

		//поля
		/// <summary>
		/// поле, где хранится вводимое число.
		/// </summary>
		decimal num;



		//методы
		/// <summary>
		/// метод для восстановления к значениям полей по умолчанию.
		/// </summary>
		private void UseDefault()
        {
			num = 0;
		}
		/// <summary>
		/// метод возвращающий факториал числа.
		/// </summary>
		/// <param name="n">число, которому выдаётся факториал.</param>
		/// <returns>факториал числа <paramref name="n"/>.</returns>
		private decimal Factorial(decimal n)
		{
			decimal ans = 1; //ответ, если цикл даже не запустится.
			try //попытка выполнить команду.
			{
				for (int i = 2; i <= n; i++) ans *= i; //получение факториала.
			}
			catch (OverflowException ex) //если значение слишком большое
			{
				MessageBox.Show("ты мне тут слишком бальшые цыферки не набирай, я тут взорву тебе ща комп понял!!\n" + ex, "слыыш");
				return -1; //вывод сообщения об этом, и возврат числа -1.
			}
			return ans; //возврат ответа если всё прошло успешно.
		}
		/// <summary>
		/// получение числа <paramref name="a"/> в степени <paramref name="b"/>.
		/// </summary>
		/// <param name="a">число возводимое в степень.</param>
		/// <param name="b">степень в которую нужно возвести <paramref name="a"/>.</param>
		/// <returns>число <paramref name="a"/> в степени <paramref name="b"/> типа <see cref="decimal"/> для больших чисел.</returns>
		private decimal Power(decimal a, decimal b)
		{
			decimal ans = 1; //ответ, если цикл не запустится.
			try //попытка возвести число в степень.
			{
				for (int i = 0; i < b; i++) ans *= a; //цикл для получения числа a в степени b
			}
			catch (OverflowException ex) //если в цикле произошло переполнение
			{
				MessageBox.Show("ты мне тут слишком бальшые цыферки не набирай, я тут взорву тебе ща комп понял!!\n" + ex, "слыыш");
				return -1; //вывод сообщения об этом и возврат числа -1.
			}
			return ans; //возврат числа если всё прошло успешно.
		}
		/// <summary>
		/// удаление последнего введённого значения.
		/// </summary>
		private void BackSpace()
		{
			StringBuilder x = new StringBuilder("");
			try
			{
				if (problemBox.Text.Length > 0) //в окне сначала что-то должно быть, чтобы можно было это стереть.
				{
					x = new StringBuilder(problemBox.Text); //получение строки из окна типа StringBuilder
					x.Remove(x.Length - 1, 1); //удаление последнего знака
					problemBox.Text = x.ToString(); //возврат строки обратно в окно.
					num = decimal.Parse(x.ToString()); //сохранение в поле полученного значения.
				}
			}
            catch (FormatException)
            {
				if (x.Length != 0) throw;
				num = 0;
            }
			catch (Exception x) //??????
            {
				MessageBox.Show
					(
					caption: "ну и ну",
					text: "ты каким образом смог получить здесь эксепшн?\n" + x
					);
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
		/// <param name="sender">отправитель события (кто именно нажал на кнопку).</param>
		/// <param name="e"></param>
		private void Deleter(object sender, EventArgs e)
		{
			Button sended = sender as Button;
			if (sended.Text == "Clear")
			{
				problemBox.Text = ""; //если нажатая кнопка Clear, то очищается окно.
				num = 0; //очистка поля от чисел.
			}
			else if (sended.Text == "Clear All") //если нажата кнопка Clear All,
			{                                   //то очищаются все поля и окно.
				UseDefault();
				return;
			}
			else if (sended.Text == "←") BackSpace(); //если нажата кнопка ←, то очищается последнее введённое число. //⌫
		}
		private void ActionBtns(object sender, EventArgs e)
		{

		}

		private void EqualBtn(object sender, EventArgs e)
		{

		}

		/// <summary>
		/// обработчик события нажатия на кнопку с цифрой или запятой.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void NumsBtns(object sender, EventArgs e)
		{
			Button sended = sender as Button; //получение нажатой кнопки
			problemBox.Text += sended.Text; //вывод текста, имеющегося на нажатой кнопке.
			try { num = decimal.Parse(problemBox.Text); } //для проверки выведенного текста, проводится попытка перевести выведенный в окно текст в тип децимал.
            catch { BackSpace(); } //если не получается это сделать, то удаляется последний выведенный знак.
		}

		/// <summary>
		/// метод для кнопки (+/-).
		/// </summary>
		/// <remarks>
		/// при нажатии на кнопку, <br/>
		/// метод превращает выведенный текст на экране в тип децимал, <br/>
		/// и выводит его обратно на экран с минусом.
		/// </remarks>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Negate(object sender, EventArgs e)
		{
			if (problemBox.Text == "") return; //если поле ввода пустое, то выходим из метода.
            try //попытка перевести выведенный текст в децимал.
            {
				num = decimal.Parse(problemBox.Text); //вывод числа в поле.
				problemBox.Text = $"{-num}"; //получение числа из поля, и вывод на экран с '-'.
            }
            catch { MessageBox.Show("ты каким образом смог здесь ошибку вызвать...", "успех!"); }
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
	}
}
//MessageBox.Show
//(
//	caption: "ты што наделол...",
//	text: "я тут пытался выполнить то что ты мне накликал, но я получил тысячу букв в лицо, так что мне придётся тебя наказать.\n"
//	+ "вот они как раз:\n" + ex.ToString()
//);
//for (int i = 0; i < 10; i++) Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ");