using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageDialogForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 通知ボタンクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNotice_Click(object sender, EventArgs e)
        {
            DialogResult  result = MessageBox.Show("送信しました。", "通知", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.labelNotice.Text = result.ToString();
        }

        /// <summary>
        /// 異常ボタンクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonError_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("エラーが発生しました。ログを表示しますか。",
                "異常",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Error);
            this.labelError.Text = result.ToString();
            if (result == DialogResult.Yes)
            {
                // はいをクリックされた場合の処理
                return;
            }

            if (result == DialogResult.No)
            {
                // いいえをクリックされた場合の処理
                return;
            }
        }

        /// <summary>
        /// 警告ボタンクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonWarn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("データを削除しますか？", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            this.labelWarn.Text = result.ToString();
            switch(result)
            {
                case DialogResult.OK:
                    // OKクリックの処理
                    break;
                case DialogResult.Cancel:
                    // Cancelクリックの処理
                    break;
                default:
                    // 上記以外の場合
                    break;
            }
        }
    }
}
