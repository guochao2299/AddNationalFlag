using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddRedFlag
{
    public partial class frmMain: Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = false;
            ofd.Filter = "JPEG图片|*.jpg";
            if (ofd.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }

            Bitmap initImage = new Bitmap(ofd.FileName);
            if (initImage.Width < 200 || initImage.Height < 200)
            {
                MessageBox.Show("原图图片尺寸要大于等于200*200");
                return;
            }

            txtImagePath.Text = ofd.FileName;
            pBefore.Image = initImage;
            pAfter.Image = null;
            tabControl1.SelectedTab = tpBefore;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (pBefore.Image == null)
            {
                MessageBox.Show("请先选择要添加国旗的图片");
                return;
            }

            Image initImage = pBefore.Image;
            Bitmap flaggedImage = null; ;
            Graphics g = null;

            try
            {
                flaggedImage = new Bitmap(initImage.Width, initImage.Height);
                g = Graphics.FromImage(flaggedImage);
                g.DrawImage(initImage, 0, 0, flaggedImage.Width, flaggedImage.Height);

                int flagSize = (int)Math.Min(flaggedImage.Width * 0.2f, flaggedImage.Height * 0.2f);
                Rectangle rect = new Rectangle();
                rect.X = flaggedImage.Width - flagSize;
                rect.Y = flaggedImage.Height - flagSize;
                rect.Width = flagSize;
                rect.Height = flagSize;

                g.DrawImage(AddRedFlag.Properties.Resources.flag, rect);

                pAfter.Image = flaggedImage;
                tabControl1.SelectedTab = tpAfter;
            }
            catch (Exception ex)
            {
                MessageBox.Show("给图片添加国旗失败，错误消息为：" + ex.Message);
                if (flaggedImage != null)
                {
                    flaggedImage.Dispose();
                }
            }
            finally
            {
                if (g != null)
                {
                    g.Dispose();
                }                            
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (pAfter.Image == null)
            {
                MessageBox.Show("请先添加国旗图片");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "JPEG图片|*.jpg";
            if (sfd.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }

            try
            {
                pAfter.Image.Save(sfd.FileName);
            }
            catch(Exception ex)
            {
                MessageBox.Show("保存处理后的图片失败，错误消息为:" + ex.Message);
            }
        }
    }
}
