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
		decimal left = 0;
		/// <summary>
		/// правое число.
		/// </summary>
		decimal right = 0;
		/// <summary>
		/// знак.
		/// </summary>
		char sign = '+';
		/// <summary>
		/// поле с информацией о кнопке.
		/// </summary>
		Button who = null;
		/// <summary>
		/// поле с информацией о том, был ли добавлен знак в выражении.
		/// </summary>
		bool isHaveSign = false;
		/// <summary>
		/// поле, где хранится информация о том, выведен ли ответ в окно.
		/// </summary>
		bool haveAns = false;

		//методы
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
		/// метод для вывода в окно нажимаемых кнопок или других возвращаемых значений.
		/// </summary>
		private void problemBoxInsert()
		{
			switch (who.Text) //текст нажатой кнопки.
			{
				case "0": //если нажата цифра, то
				case "1":
				case "2":
				case "3":
				case "4":
				case "5":
				case "6":
				case "7":
				case "8":
				case "9":
					problemBox.Text += who.Text; //вывод на экран этой цифры.
					break;
				case "!": //если нажат знак факториала
					if (problemBox.Text.Length != 0)
					{ //и если в окне есть хотя бы что-то, то
						left = decimal.Parse(problemBox.Text); //парс чисел с окна в переменную
						decimal fact = Factorial(left);
						if (fact == -1)
						{
							problemBox.Text = "";
						}
						else
						{
							problemBox.Text = $"{fact}"; //пересчёт и вывод этого числа.
						}
						haveAns = true;
					}
					break;
				case "mod":
					right = 1;
					inpAns(left % right);
					break;
				case "^":
					decimal pow = Power(left, right);
					if (pow == -1) problemBox.Text = "";
					else inpAns(pow);
					break;

				default:
					break;
			}
		}
		/// <summary>
		/// метод для вывода ответа в окно.
		/// </summary>
		/// <param name="ans"></param>
		private void inpAns(decimal ans)
		{
			if (!isHaveSign)
			{
				if (problemBox.Text != "")
				{
					left = decimal.Parse(problemBox.Text);
					problemBox.Text = "";
					isHaveSign = true;
				}
			}
			else
			{
				right = decimal.Parse(problemBox.Text);
				haveAns = true;
				problemBox.Text = $"{ans}";
				isHaveSign = false;
			}
		}
		/// <summary>
		/// удаление последнего введённого значения.
		/// </summary>
		private void BackSpace()
		{
			if (problemBox.Text.Length > 0) //в окне сначала что-то должно быть, чтобы можно было это стереть.
			{
				StringBuilder x = new StringBuilder(problemBox.Text); //получение строки из окна типа StringBuilder
				x.Remove(x.Length - 1, 1); //удаление последнего знака
				problemBox.Text = x.ToString(); //возврат строки обратно в окно.
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
		private void BtnsClick(object sender, EventArgs e)
		{
			who = sender as Button; //распаковка отправителя в класс Button.
			if (who.Text == "Clear") problemBox.Text = ""; //если нажатая кнопка Clear, то очищается окно.
			else if (who.Text == "Clear All") //если нажата кнопка Clear All,
			{                                 //то очищаются все поля и окно.
				left = 0;
				right = 0;
				sign = '+';
				who = null; 
				isHaveSign = false;
				haveAns = false;
				problemBox.Text = "";
				return;
			}
			else if (who.Text == "←") BackSpace(); //если нажата кнопка ←, то очищается последнее введённое число. //⌫
			if (haveAns) //если в окне есть ответ, при нажатии любой другой клавиши:
			{ 				
				if (problemBox.Text != "") left = decimal.Parse(problemBox.Text); //ответ запоминается как левое число,
				problemBox.Text = ""; //ответ в окне стирается.
				haveAns = false;
			}
			problemBoxInsert(); //вывод нажимаемых кнопок в окно.
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
//MessageBox.Show
//(
//	caption: "ты што наделол...",
//	text: "я тут пытался выполнить то что ты мне накликал, но я получил тысячу букв в лицо, так что мне придётся тебя наказать.\n"
//	+ "вот они как раз:\n" + ex.ToString()
//);
//for (int i = 0; i < 10; i++) Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ");