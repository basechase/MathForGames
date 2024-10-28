using MathLibrary;
using Raylib_cs;
using System;
using System.ComponentModel;


namespace Sandbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Raylib.InitWindow(1200, 800, "Hello World");
            Raylib.SetTargetFPS(60); 

            Actor a = new Actor();

            Transform2D t1 = new Transform2D(a);

            t1.LocalScale = new Vector2(100,100);
            Vector2 offset = new Vector2(t1.LocalScale.x / 2, t1.LocalScale.y / 2);
            t1.LocalPosition = new Vector2(
                (Raylib.GetScreenWidth() * 0.33f) - offset.x, 
                (Raylib.GetScreenHeight() * 0.33f) - offset.y);

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

                t1.Translate(t1.Forward * 50 * Raylib.GetFrameTime());
                t1.Rotate(0.5f * Raylib.GetFrameTime());

                //draw t1
                Rectangle rect = new Rectangle(t1.GlobalPosition + offset, t1.GlobalScale);

                Raylib.DrawRectanglePro(
                    rect,
                    new Vector2(0,0) + offset,
                    -t1.GlobalRotationAngle *  (180 / (float)Math.PI),
                    Color.Blue);

                Raylib.DrawLineV(t1.GlobalPosition + offset, t1.GlobalPosition + offset + (t1.Forward * 100), Color.Red);

                Raylib.EndDrawing();


                /*
                #region old cold
                //UPDATE
                // playerPosition.x += 20 * Raylib.GetFrameTime();

                Matrix3 a = new Matrix3(2, 2, 2,
                                        3, 3, 2,
                                        2, 2, 2);

                Matrix3 b = new Matrix3(3, 4, 7,
                                        3, 3, 3,
                                        6, 3, 3);

               
                Matrix3 c = (a * b);

                Console.WriteLine(c);

                

                Vector2 movementInput = new Vector2();
                movementInput.y -= Raylib.IsKeyDown(KeyboardKey.W);
                movementInput.y += Raylib.IsKeyDown(KeyboardKey.S);
                movementInput.x -= Raylib.IsKeyDown(KeyboardKey.A);
                movementInput.x += Raylib.IsKeyDown(KeyboardKey.D);

               

                playerPosition += movementInput * playerSpeed * Raylib.GetFrameTime();


                Vector2 playerToEnemyDirection = (playerPosition - enemyPosition).Normalized;

                float distance =  enemyPosition.Distance(playerPosition);
                float angleToEnemy = (float)Math.Abs(Math.Acos(playerToEnemyDirection.DotProduct(playerForward)));
                

                Console.WriteLine(Math.Abs(angleToEnemy) + "|" + (playerViewAngle / 2) * (Math.PI / 180));

              
                // if enemy is in sight
                if (angleToEnemy < (playerViewAngle / 2) * (Math.PI / 180) && distance < playerViewDistance)
                {
                    enemyColor = Color.Pink;
                }
                else
                {
                    enemyColor = Color.Red;
                }



                //DRAW
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.White);

                //draw enemy
                Raylib.DrawCircleV(enemyPosition, enemyRadius, enemyColor);

                //draw player
                Raylib.DrawCircleV(playerPosition, playerRadius, Color.Green);

                //draw player forawds
                Raylib.DrawLineV(playerPosition, playerPosition - (playerForward * 100), Color.Orange);


                //draw view cone/cam
                Raylib.DrawCircleSectorLines(playerPosition, 
                    playerViewDistance, 
                    -90 - (playerViewAngle / 2 ),
                    -90 + (playerViewAngle / 2),
                    10, 
                    Color.Blue);
                #endregion


                /*
                 * 
                 * 
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
            }

            Raylib.CloseWindow();
            


        }
    }
}
