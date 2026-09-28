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
        int x;


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

            x = Input.GetMouseX();
            
            //Draw sky, road and foreground
            Window.ClearBackground(130 - x, 200 - x, 229 - x);
            Draw.SetLineSize(0);
            Draw.SetLineColor(0);
            Draw.SetFillColor(125);
            Draw.Rectangle(0, 260, 400, 40);
            Draw.SetFillColor(72, 111, 56);
            Draw.Rectangle(0, 300, 400, 100);

            //Draw clouds and trees

            
            //Draw car and headlights
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

            if (Input.IsMouseButtonDown(MouseButton.Left) == true)
            {
                Draw.Triangle(x + 75, 265, x + 120, 240, x + 120, 290);
            }



        }
    }

}
