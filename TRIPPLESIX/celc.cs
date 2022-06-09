using System;
using System.Text;
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
			InitializeComponent(); //метод инициализирующий окно.
			UseDefault(); //метод устанавливающий стандартные значения полей.
		}

		//поля
		/// <summary>
		/// поле второго числа.
		/// </summary>
		decimal? right;
		/// <summary>
		/// поле первого числа.
		/// </summary>
		decimal? left;
		/// <summary>
		/// вводимое число.
		/// </summary>
		decimal num;
		/// <summary>
		/// предыдущий знак действия.
		/// </summary>
		char prevsn;
		/// <summary>
		/// знак действия.
		/// </summary>
		char action;
		//		объекты с формы.
		/// <summary>
		/// текст с кнопки удаления последнего символа.
		/// </summary>
		string backspace;
		/// <summary>
		/// текст с кнопки для очистки всего.
		/// </summary>
		string clrall;
		/// <summary>
		/// текст с кнопки факториала.
		/// </summary>
		string fact;
		/// <summary>
		/// текст с кнопки очистки окна вывода.
		/// </summary>
		string cl;

		//методы
		/// <summary>
		/// метод для восстановления к значениям полей по умолчанию.
		/// </summary>
		private void UseDefault()
		{
			//поля со значениями.
			prevsn = '+';
			action = '+';
			right = null;
			left = null;
			num = 0;
			//конпки
			fact = btnfactorial.Text;
			backspace = btnbsp.Text;
			clrall = btndel.Text;
			cl = btnclr.Text;
			//экраны.
			labelLastValue.Text = "";
			problemBox.Text = "";
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
			if (problemBox.Text.Length > 0) //в окне сначала что-то должно быть, чтобы можно было это стереть.
			{
				StringBuilder x = new StringBuilder(problemBox.Text); //получение строки из окна типа StringBuilder
				x.Remove(x.Length - 1, 1); //удаление последнего знака
				problemBox.Text = x.ToString(); //возврат строки обратно в окно.
				try 
				{ //попытка перевести полученный текст в поле значения.
					num = decimal.Parse(x.ToString()); //сохранение в поле полученного значения.
				}
				catch (FormatException)
				{ //если не получилось из-за того что текст пустой, то выставление значения 0 для поля.
					if (x.Length != 0) throw; //но если не из-за этого, то -->
					num = 0;
				}
				catch (Exception ex) // --> вывод этой ошибки.
				{
					MessageBox.Show
					(
						caption: "ну и ну",
						text: "ты каким образом смог получить здесь эксепшн?\n\n" + ex.Message
					);
				}
			}
		}
		/// <summary>
		/// метод для получения ответа от указанного действия.
		/// </summary>
		/// <remarks>
		/// если указан унарный знак, то возвращается ответ от первого числа, а не от обоих.
		/// </remarks>
		/// <param name="sign">знак действия.</param>
		/// <returns>ответ из двух полей, в зависимости от указанного знака действия.</returns>
		private decimal GetAns(char action)
		{
			decimal left = this.left ?? 0;
			decimal right = this.right ?? 0;
			try
			{
				switch (action)
				{
					case '^':
						return Power(left, right);
					case '!':
						return GetFact();
					case '%':
						return left % right;
					case '/':
					case '÷':
						return left / right;
					case '*':
					case '×':
						return left * right;
					case '-':
						return left - right;
					case '+':
						return left + right;
					default:
						return 0;
				}
			}
			catch (OverflowException ex) //если откуда-то ещё вылезло переполнение.
			{
				MessageBox.Show("ты мне тут слишком бальшые цыферки не набирай, я тут взорву тебе ща комп понял!!\n\n" + ex.Message, "слыыш");
				UseDefault();
				return 0;
			}
			catch (DivideByZeroException ex) //если произошло деление на 0.
            {
				MessageBox.Show("молодец! поздравляю! ты решил калькулятор!\n\n" + ex.Message, "успех!");
				UseDefault();
				return 0;
            }
		}
		/// <summary>
		/// метод возвращающий факториал какого либо числа.
		/// </summary>
		/// <returns> факториал какого либо числа. типа <see cref="decimal"/>. </returns>
		private decimal GetFact()
		{
			decimal left = this.left ?? 0;
			decimal right = this.right ?? 0;
			if (this.right != null) return Factorial(right);
			else if (this.left != null) return Factorial(left);
			else return 0;
		}
		/// <summary>
		/// установка значений с экрана в поля.
		/// </summary>
		/// <remarks>
		/// устанавливает в поля <see cref="right"/> или <see cref="left"/> значения с экрана.
		/// </remarks>
		//		обработчики событий.
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
			if (sended.Text == cl)
			{
				problemBox.Text = ""; //если нажатая кнопка Clear, то очищается окно.
				num = 0; //очистка поля от чисел.
			}
			else if (sended.Text == clrall) //если нажата кнопка Clear All,
			{                                   //то очищаются все поля и окно.
				UseDefault();
				return;
			}
			else if (sended.Text == backspace) BackSpace(); //если нажата кнопка ←, то очищается последнее введённое число. //⌫
		}
		/// <summary>
		/// обработчик события нажатия на один из знаков действия.
		/// </summary>
		/// <param name="sender">объект кнопки.</param>
		/// <param name="e"></param>
		private void ActionBtns(object sender, EventArgs e)
		{
			//получение нажатой кнопки.
			Button btn = sender as Button; //объект нажатой кнопки.
			try { action = Convert.ToChar(btn.Text); } //попытка перевести текст с кнопки в тип char.
			catch { action = '%'; } //если не получилось - это был 'mod'.

			//сохранение последнего значения в специальное окно.
			labelLastValue.Text = $"{problemBox.Text}";

			//расчёт факториала.
			if (btn.Text == fact)
			{
				if (left != null && problemBox.Text != "")
				{
					right = num;
					right = GetAns(prevsn);
                }
                else if (left == null && problemBox.Text != "")
				{
					right = num;
					right = GetAns(action);
                }

				problemBox.Text = $"{GetFact()}";
				return;
			}

			if (problemBox.Text != "") //если окно вывода не пустое
			{

				//получение числа с окна или ответа.
				if (left != null && right != null) //если оба числа не null
				{
					left = GetAns(prevsn); //получение их ответа,
					right = null; //установка для правого числа - null.
				}
				else if (left != null && right == null)
				{
					right = num; //иначе правое это число с окна.
					left = GetAns(prevsn);
					right = null;
				}
				else if (left == null) left = num; //если левое null, то левое - число с окна.

				
				prevsn = action; //сохранение этого знака в поле прошлого знака.
				problemBox.Text = ""; //очистка окна от всех нажатий.
			}
		}
		/// <summary>
		/// обработчик нажатия на кнопку '='.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void EqualBtn(object sender, EventArgs e)
		{
			if (problemBox.Text != "") //если окно не пустое
			{
				//если не хватает правого числа.
				if (right == null) right = num; //если второе число null, то второе число - значение с экрана.
				//получение ответа.
				decimal ans = GetAns(action);
				//вывод ответа в окно.
				labelLastValue.Text = $"{num}";
				problemBox.Text = $"{ans}"; 

				//восстановление значений полей.
				left = null;
				right = null;
			}
			else //если окно пустое, то возврат имеющихся чисел.
			{
				//возврат последнего имеющегося числа.
				if (right != null) problemBox.Text = $"{right}";
				else if (left != null) problemBox.Text = $"{left}";
				else problemBox.Text = "0";//если чисел нет, то возвращается 0.
			}
		}
		/// <summary>
		/// обработчик события нажатия на кнопку с цифрой или запятой.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void NumsBtns(object sender, EventArgs e)
		{
			string sended = (sender as Button).Text; //получение нажатой кнопки
			if (problemBox.Text == "" && sended == ",") problemBox.Text = "0,";
			problemBox.Text += sended; //вывод текста, имеющегося на нажатой кнопке.
		}
		/// <summary>
		/// установка в <see langword="private"/> поле <see cref="num"/> число указанное в окне вывода.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SetNum(object sender, EventArgs e)
		{
			try { num = decimal.Parse(problemBox.Text); } //для проверки выведенного текста, проводится попытка перевести выведенный в окно текст в тип децимал.
			catch { BackSpace(); } //если не получается это сделать, то удаляется последний выведенный знак.
		}
		/// <summary>
		/// метод для изменения знака числа в поле ввода.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Negate(object sender, EventArgs e)
		{
			problemBox.Text = $"{-num}";
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