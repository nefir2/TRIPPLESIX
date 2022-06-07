using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
			//checkBin.Checked = true;
		}

        ////поля
        ///// <summary>
        ///// поле где хранится состояние чекбокса.
        ///// </summary>
        //bool inBin = true;

        ////методы

        ///// <summary>
        ///// метод переводит из 
        ///// </summary>
        ///// <remarks>
        ///// угнаный метод.
        ///// </remarks>
        ///// <param name="data"></param>
        ///// <returns></returns>
        //public string ToBinaryString(byte[] data)
        //{
        //    return string.Join("", data.Select(byt => Convert.ToString(byt, 2).PadLeft(8, '0')));
        //}

        ///// <summary>
        ///// обработчик события нажатия на чекбокс.
        ///// </summary>
        ///// <remarks>
        ///// если на чекбокс произшло нажатие, то проверяется какое у него сейчас состояние, </br>
        ///// и переносится в поле.
        ///// </remarks>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void Check(object sender, EventArgs e)
        //{
        //    if (checkBin.Checked) inBin = true;
        //    else inBin = false;
        //}



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