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
        /// ボタンクリックイベント
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">E.</param>
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            //カウントアップ 
            count++;

            //ラベルに出力
            StateLabel.Text = count + " 回押されたよ";

        }
    }
}
