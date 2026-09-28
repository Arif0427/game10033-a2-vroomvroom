// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>


        public void Setup()
        {
            Window.SetTitle("Car");
            Window.SetSize(400, 400);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            //Set x variable to mouse input
            int x = Input.GetMouseX();
            
            //Draw sky, road and foreground
            Window.ClearBackground(130, 200, 229);
            Draw.SetLineSize(0);
            Draw.SetLineColor(0);
            Draw.SetFillColor(125);
            Draw.Rectangle(0, 260, 400, 40);
            Draw.SetFillColor(72, 111, 56);
            Draw.Rectangle(0, 300, 400, 100);

            //Draw cloud(s)
            Draw.SetFillColor(255);
            Draw.Circle( (int)(-x * 0.75 + 230), 50, 10);
            Draw.Circle( (int)(-x * 0.75 + 260), 40, 20);
            Draw.Circle( (int)(-x * 0.75 + 290), 50, 10);
            Draw.Rectangle((int)(-x * 0.75 + 230), 40, 60, 20);

            //Draw Trees

            //Draw car
            Draw.SetFillColor(255, 0, 0);
            Draw.Rectangle(x, 260, 20, 20);
            Draw.Rectangle(x + 20, 240, 40, 40);
            Draw.Rectangle(x + 60, 260, 20, 20);
            Draw.SetFillColor(0);
            Draw.Rectangle(x + 30, 250, 10, 10);
            Draw.Rectangle(x + 50, 250, 10, 10);
            Draw.Circle(x + 20, 280, 10);
            Draw.Circle(x + 60, 280, 10);
            Draw.SetFillColor(255, 255, 0);
            Draw.Rectangle(x + 70, 260, 10, 10);

            //Day Night gradient
            Draw.SetFillColor(0, 0, 0, (int)(x * 0.50));
            Draw.Square(0, 0, 400);

            //Headlight on when mouse held down
            if (Input.IsMouseButtonDown(MouseButton.Left) == true)
            {
                Draw.SetFillColor(255, 255, 0);
                Draw.Rectangle(x + 70, 260, 10, 10);
                Draw.Triangle(x + 75, 265, x + 120, 240, x + 120, 290);
            }



        }
    }

}
