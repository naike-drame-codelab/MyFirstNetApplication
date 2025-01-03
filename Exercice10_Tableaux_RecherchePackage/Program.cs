using ToolBox.Image;

int [,,] pixels = ImageUtils.GetPixel(@"D:\Téléchargements\ux-ui.png");

pixels[0, 0, 0] = 255;
pixels[0, 0, 1] = 0;
pixels[0, 0, 2] = 0;

for(int i = 0; i < 100; i++)
{
    for(int j = 0; j < 100; j++)
    {
        pixels[i, j, 0] = 255;
        pixels[i, j, 1] = 0;
        pixels[i, j, 2] = 0;
    }
}

ImageUtils.CreateImage(@"C:\Users\user\Desktop\test.jpg", pixels);

Console.WriteLine();
