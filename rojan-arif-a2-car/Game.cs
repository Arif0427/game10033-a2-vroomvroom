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
            Draw.Circle( (int)(-x * 0.5 + 230), 50, 10);
            Draw.Circle( (int)(-x * 0.5 + 260), 40, 20);
            Draw.Circle( (int)(-x * 0.5 + 290), 50, 10);
            Draw.Rectangle((int)(-x * 0.5 + 230), 40, 60, 20);

            //Draw Trees
            int s = -2; // speed of tree movement
            int d; //displacement of the trees

            d = 140;
            Draw.SetFillColor(75, 40, 30);
            Draw.Rectangle((s * x + d - 5), 240, 10, 20);
            Draw.SetFillColor(62, 134, 103);
            Draw.Triangle((s * x + d), 220, (s * x + d - 10), 240, (s * x + d + 10), 240);
            Draw.Triangle((s * x + d), 210, (s * x + d - 10), 230, (s * x + d + 10), 230);
            Draw.Triangle((s * x + d), 200, (s * x + d - 10), 220, (s * x + d + 10), 220);

            d = 250;
            Draw.SetFillColor(75, 40, 30);
            Draw.Rectangle((s * x + d - 5), 240, 10, 20);
            Draw.SetFillColor(62, 134, 103);
            Draw.Triangle((s * x + d), 220, (s * x + d - 10), 240, (s * x + d + 10), 240);
            Draw.Triangle((s * x + d), 210, (s * x + d - 10), 230, (s * x + d + 10), 230);
            Draw.Triangle((s * x + d), 200, (s * x + d - 10), 220, (s * x + d + 10), 220);

            d = 370;
            Draw.SetFillColor(75, 40, 30);
            Draw.Rectangle((s * x + d - 5), 240, 10, 20);
            Draw.SetFillColor(62, 134, 103);
            Draw.Triangle((s * x + d), 220, (s * x + d - 10), 240, (s * x + d + 10), 240);
            Draw.Triangle((s * x + d), 210, (s * x + d - 10), 230, (s * x + d + 10), 230);
            Draw.Triangle((s * x + d), 200, (s * x + d - 10), 220, (s * x + d + 10), 220);

            d = 420;
            Draw.SetFillColor(75, 40, 30);
            Draw.Rectangle((s * x + d - 5), 240, 10, 20);
            Draw.SetFillColor(62, 134, 103);
            Draw.Triangle((s * x + d), 220, (s * x + d - 10), 240, (s * x + d + 10), 240);
            Draw.Triangle((s * x + d), 210, (s * x + d - 10), 230, (s * x + d + 10), 230);
            Draw.Triangle((s * x + d), 200, (s * x + d - 10), 220, (s * x + d + 10), 220);

            d = 525;
            Draw.SetFillColor(75, 40, 30);
            Draw.Rectangle((s * x + d - 5), 240, 10, 20);
            Draw.SetFillColor(62, 134, 103);
            Draw.Triangle((s * x + d), 220, (s * x + d - 10), 240, (s * x + d + 10), 240);
            Draw.Triangle((s * x + d), 210, (s * x + d - 10), 230, (s * x + d + 10), 230);
            Draw.Triangle((s * x + d), 200, (s * x + d - 10), 220, (s * x + d + 10), 220);

            d = 611;
            Draw.SetFillColor(75, 40, 30);
            Draw.Rectangle((s * x + d - 5), 240, 10, 20);
            Draw.SetFillColor(62, 134, 103);
            Draw.Triangle((s * x + d), 220, (s * x + d - 10), 240, (s * x + d + 10), 240);
            Draw.Triangle((s * x + d), 210, (s * x + d - 10), 230, (s * x + d + 10), 230);
            Draw.Triangle((s * x + d), 200, (s * x + d - 10), 220, (s * x + d + 10), 220);

            d = 660;
            Draw.SetFillColor(75, 40, 30);
            Draw.Rectangle((s * x + d - 5), 240, 10, 20);
            Draw.SetFillColor(62, 134, 103);
            Draw.Triangle((s * x + d), 220, (s * x + d - 10), 240, (s * x + d + 10), 240);
            Draw.Triangle((s * x + d), 210, (s * x + d - 10), 230, (s * x + d + 10), 230);
            Draw.Triangle((s * x + d), 200, (s * x + d - 10), 220, (s * x + d + 10), 220);

            d = 777;
            Draw.SetFillColor(75, 40, 30);
            Draw.Rectangle((s * x + d - 5), 240, 10, 20);
            Draw.SetFillColor(62, 134, 103);
            Draw.Triangle((s * x + d), 220, (s * x + d - 10), 240, (s * x + d + 10), 240);
            Draw.Triangle((s * x + d), 210, (s * x + d - 10), 230, (s * x + d + 10), 230);
            Draw.Triangle((s * x + d), 200, (s * x + d - 10), 220, (s * x + d + 10), 220);

            d = 845;
            Draw.SetFillColor(75, 40, 30);
            Draw.Rectangle((s * x + d - 5), 240, 10, 20);
            Draw.SetFillColor(62, 134, 103);
            Draw.Triangle((s * x + d), 220, (s * x + d - 10), 240, (s * x + d + 10), 240);
            Draw.Triangle((s * x + d), 210, (s * x + d - 10), 230, (s * x + d + 10), 230);
            Draw.Triangle((s * x + d), 200, (s * x + d - 10), 220, (s * x + d + 10), 220);

            d = 911;
            Draw.SetFillColor(75, 40, 30);
            Draw.Rectangle((s * x + d - 5), 240, 10, 20);
            Draw.SetFillColor(62, 134, 103);
            Draw.Triangle((s * x + d), 220, (s * x + d - 10), 240, (s * x + d + 10), 240);
            Draw.Triangle((s * x + d), 210, (s * x + d - 10), 230, (s * x + d + 10), 230);
            Draw.Triangle((s * x + d), 200, (s * x + d - 10), 220, (s * x + d + 10), 220);

            d = 1040;
            Draw.SetFillColor(75, 40, 30);
            Draw.Rectangle((s * x + d - 5), 240, 10, 20);
            Draw.SetFillColor(62, 134, 103);
            Draw.Triangle((s * x + d), 220, (s * x + d - 10), 240, (s * x + d + 10), 240);
            Draw.Triangle((s * x + d), 210, (s * x + d - 10), 230, (s * x + d + 10), 230);
            Draw.Triangle((s * x + d), 200, (s * x + d - 10), 220, (s * x + d + 10), 220);

            d = 1130;
            Draw.SetFillColor(75, 40, 30);
            Draw.Rectangle((s * x + d - 5), 240, 10, 20);
            Draw.SetFillColor(62, 134, 103);
            Draw.Triangle((s * x + d), 220, (s * x + d - 10), 240, (s * x + d + 10), 240);
            Draw.Triangle((s * x + d), 210, (s * x + d - 10), 230, (s * x + d + 10), 230);
            Draw.Triangle((s * x + d), 200, (s * x + d - 10), 220, (s * x + d + 10), 220);

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
