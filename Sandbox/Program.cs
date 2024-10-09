using MathLibrary;
using Raylib_cs;
using System.ComponentModel;


namespace Sandbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Raylib.InitWindow(1200, 600, "Hello World");
            Raylib.InitAudioDevice();

            Image image = Raylib.LoadImage("C:\\dev\\MathForGames\\Sandbox\\twix.png");
            Texture2D texture = Raylib.LoadTextureFromImage(image);
            Raylib.UnloadImage(image);

            Image image2 = Raylib.LoadImage("C:\\dev\\MathForGames\\Sandbox\\kanye.png");
            Texture2D texture2 = Raylib.LoadTextureFromImage(image2);
            Raylib.UnloadImage(image2);

            Image image3 = Raylib.LoadImage("C:\\dev\\MathForGames\\Sandbox\\kanye2.png");
            Texture2D texture3 = Raylib.LoadTextureFromImage(image3);
            Raylib.UnloadImage(image3);

            Sound twixbigger = Raylib.LoadSound("C:\\dev\\MathForGames\\Sandbox\\twixbigger.wav");

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.White);
                Raylib.DrawText("They're making the twix bigger! They're trying to make us fat! \n - Kanye West 2022", 18, 18, 20, Color.Brown);
                Raylib.DrawText("Press Spacebar to hear Kanye!", 300,50, 20, Color.Brown);
                Raylib.DrawTexture(texture, 500, 200, Color.Gray);
                Raylib.DrawTexture(texture2, 0,0 , Color.Gray);
                Raylib.DrawTexture(texture3, 100, 350, Color.Gray);
                if (Raylib.IsKeyPressed(KeyboardKey.Space))
                {
                    Raylib.PlaySound(twixbigger);
                }


                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();



        }
    }
}
