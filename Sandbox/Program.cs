using MathLibrary;
using Raylib_cs;
using System.ComponentModel;


namespace Sandbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MathLibrary.Vector2 a = new MathLibrary.Vector2(1, 2);
            Console.WriteLine(a.ToString());


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
            /*
            int x = 32;
            int y = 32;

            int a = 100;
            int b = 350;
            */
            while (!Raylib.WindowShouldClose())
            {
                /*
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.White);
                Raylib.DrawText("They're making the twix bigger! They're trying to make us fat! \n - Kanye West 2022", 18, 18, 20, Color.Brown);
                Raylib.DrawText("Press Spacebar to hear Kanye!", 300,50, 20, Color.Brown);
                Raylib.DrawTexture(texture, 500, 200, Color.Gray);
                Raylib.DrawTexture(texture2, x,y , Color.Gray);
                Raylib.DrawTexture(texture3, a, b, Color.Gray);
                if (Raylib.IsKeyPressed(KeyboardKey.Space))
                {
                    Raylib.PlaySound(twixbigger);
                }

                if (Raylib.IsKeyPressed(KeyboardKey.W))
                {
                    y -= 32;
                }
                if (Raylib.IsKeyPressed(KeyboardKey.D))
                {
                    x += 32;
                }
                if (Raylib.IsKeyPressed(KeyboardKey.A))
                {
                    x -= 32;
                }
                if (Raylib.IsKeyPressed(KeyboardKey.S))
                {
                    y += 32;
                }

                if (Raylib.IsKeyPressed(KeyboardKey.U))
                {
                    b -= 32;    
                }
                if (Raylib.IsKeyPressed(KeyboardKey.J))
                {
                    b += 32;
                }


                */
                    Raylib.EndDrawing();
            }

            Raylib.CloseWindow();
            


        }
    }
}
