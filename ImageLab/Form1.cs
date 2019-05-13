using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageLab
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    public Bitmap bmp { get; set; }
    public Graphics graphics { get; set; }

    private void openBtn_Click(object sender, EventArgs e)
    {
      var dialog = new OpenFileDialog();
      dialog.Filter = "Image Files (*.BMP, *.JPG" +
        "*.GIF, *.PNG)|*.bmp;*.jpg;*.gif;*.png";
      
      if (dialog.ShowDialog() == DialogResult.OK)
      {
        var image = Image.FromFile(dialog.FileName);
        bmp = new Bitmap(
          image,
          image.Width,
          image.Height
        );

        pictureBox.Image = bmp;

        graphics = Graphics.FromImage(pictureBox.Image);
      }
    }

    private void saveBtn_Click(object sender, EventArgs e)
    {
      if (bmp == null) return;

      var saveFileDialog = new SaveFileDialog();
      saveFileDialog.Title = "Сохранить каринку как...";
      saveFileDialog.OverwritePrompt = true;
      saveFileDialog.CheckPathExists = true;
      saveFileDialog.Filter =
        "Bitmap File(*.bmp)|*.bmp|" +
        "GIF File(*.gif)|*.gif|" +
        "JPEG File(*.jpg)|*.jpg|" +
        "PNG File(*.png)|*.png";
      
      if (saveFileDialog.ShowDialog() == DialogResult.OK)
      {
        var fileName = saveFileDialog.FileName;
        var fileExt = fileName.Remove(0, fileName.Length - 3);

        switch (fileExt)
        {
          case "bmp":
            bmp.Save(fileName, ImageFormat.Bmp);
            break;
          case "jpg":
            bmp.Save(fileName, ImageFormat.Jpeg);
            break;
          case "gif":
            bmp.Save(fileName, ImageFormat.Gif);
            break;
          case "png":
            bmp.Save(fileName, ImageFormat.Png);
            break;
          default:
            break;
        }
      }
    }

    private void shiftColorBtn_Click(object sender, EventArgs e)
    {
      if (bmp == null) return;

      for (var i = 0; i < bmp.Width; i++)
        for (var j = 0; j < bmp.Height; j++)
        {
          var pixel = bmp.GetPixel(i, j);
          var givenColor = Color.FromArgb(pixel.R, pixel.G, pixel.B);
          var hue = givenColor.GetHue();
          var saturation = givenColor.GetSaturation();
          var brightness = givenColor.GetBrightness();


          if (
            hue > 200 && 
            hue < 240 &&
            saturation > 0.4 &&
            brightness > 0.2
          )
          {
            var redColor = Color.FromArgb(255, 0, 0);
            bmp.SetPixel(i, j, redColor);
          }
        }

      Refresh();
    }
  }
}
