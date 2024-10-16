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
           
       
            /*
            int x = 32;
            int y = 32;

            int a = 100;
            int b = 350;
            */

            //player 
            float playerRadius = 10;
            Vector2 screenDimensions = new Vector2(Raylib.GetScreenWidth(), Raylib.GetScreenHeight());
           
            Vector2 playerForward = new Vector2(0, 1).Normalized;
            Vector2 playerPosition = new Vector2(screenDimensions.x * 0.5f, screenDimensions.y * 0.75f);

            
            //enemy 

            Vector2 enemyPosition = new Vector2(screenDimensions.x * 0.5f, screenDimensions.y * 0.5f);
            float enemyRadius = 10;
            Color enemyColor = Color.Red;

            float playerViewAngle = 90;

            float playerViewDistance = 200;

            float playerSpeed = 500;

            while (!Raylib.WindowShouldClose())
            {
                //UPDATE
                // playerPosition.x += 20 * Raylib.GetFrameTime();

                
                

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
                    Raylib.EndDrawing();
            }

            Raylib.CloseWindow();
            


        }
    }
}
