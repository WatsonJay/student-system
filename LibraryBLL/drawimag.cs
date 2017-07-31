using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBLL
{
    public class drawimag
    {
        public static Image headima(byte[] b,int Width,int Height)
        {
            MemoryStream s = new MemoryStream(b, true);
            s.Write(b, 0, b.Length);
            Image a = new Bitmap(s);
            s.Close();
            Bitmap bit = new Bitmap(Width,Height);//第一个参数：要绘制的图像
            Graphics g = Graphics.FromImage(bit);//从指定的 Image 创建新的 Graphics(绘图)。
            g.DrawImage(a, new Rectangle(0, 0, bit.Width, bit.Height), new Rectangle(0, 0, a.Width, a.Height), GraphicsUnit.Pixel);//第一个参数：要绘制的图像第二个参数：它指定所绘制图像的位置和大小。 将图像进行缩放以适合该矩形。//第三个参数：它指定 image 对象中要绘制的部分。
            return bit;
        }
    }
}
