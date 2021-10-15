namespace Snake
{
    //tastele pentru miscare
    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    };

    public class Settings
    {
        public static int Width { get; set; }
        public static int Height { get; set; }
        public static int Speed { get; set; }
        public static int Score { get; set; }
        public static int Points { get; set; }
        public static bool GameOver { get; set; }
        public static Direction direction { get; set; }

        public Settings()
        {//valorile de inceput
            Width = 16;
            Height = 16;

            //setare viteza joc
            Speed = 10;


            Score = 0;
            Points = 100;
            GameOver = false;
            direction = Direction.Down;
        }
    }


}
