using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace TRIPPLESIX
{
	public partial class Buttoner : Form
	{
		/// <summary>
		/// конструктор первой формы.
		/// </summary>
		public Buttoner()
		{
			InitializeComponent();
		}

		//поля
		/// <summary>
		/// вторая форма.
		/// </summary>
		celc f2 = new celc();
		/// <summary>
		/// третья форма.
		/// </summary>
		conv f3 = new conv();
		/// <summary>
		/// четвёртая форма.
		/// </summary>
		cyph f4 = new cyph();
		/// <summary>
		/// пятая форма.
		/// </summary>
		DontTouch f5 = new DontTouch();
		/// <summary>
		/// шестая форма.
		/// </summary>
		github f6 = new github();

		
		//		обработчики событий.
		/// <summary>
		/// обработчик события нажатия на кнопке Form2.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void changeForm2(object sender, EventArgs e)
		{
			f2.Show(); //открытие нажатой формы.
			this.Hide(); //скрытие этой формы.
		}

		/// <summary>
		/// обработчик события нажатия на кнопкe Form3.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void changeForm3(object sender, EventArgs e)
		{
			f3.Show(); //открытие нажатой формы.
			this.Hide(); //скрытие этой формы.
		}

		/// <summary>
		/// обработчик события нажатия на кнопкe Form4.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void changeForm4(object sender, EventArgs e)
		{
			f4.Show(); //открытие нажатой формы.
			this.Hide(); //скрытие этой формы.
		}

		/// <summary>
		/// обработчик события нажатия на кнопкe Form5.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void changeForm5(object sender, EventArgs e)
		{
			f5.Show(); //открытие нажатой формы.
			this.Hide(); //скрытие этой формы.
		}

		/// <summary>
		/// обработчик события нажатия на кнопкe Form6.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void changeForm6(object sender, EventArgs e)
		{
			f6.Show(); //открытие нажатой формы.
			this.Hide(); //скрытие этой формы.
		}

		/// <summary>
		/// обрабтчик события при нажатии на кнопку не связанную с формами.
		/// </summary>
		/// <remarks>
		/// при нажатии на кнопку откроется ссылка в браузере по умолчанию.
		/// </remarks>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OpenSource(object sender, EventArgs e)
		{
			Process.Start("https://github.com/nefir2/TRIPPLESIX");
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