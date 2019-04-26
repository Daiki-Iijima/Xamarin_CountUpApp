using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CountUpApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        //カウントに使う
        private int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Addボタンクリックイベント
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">E.</param>
        void OnAddClicked(object sender, System.EventArgs e)
        {
            //カウントアップ 
            count++;

            //ラベルに出力
            StateLabel.Text = count + " 回押されたよ";

        }

        /// <summary>
        /// リセットボタンクリックイベント
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">E.</param>
        void OnResetClicked(object sender, System.EventArgs e)
        {
            //カウントリセット
            count = 0;

            //ラベルに出力
            StateLabel.Text = "カウントリセット";

            // 遷移先の画面としてPage2.xamlが作ってある場合
            Application.Current.MainPage = new Page2();

        }
    }
}
