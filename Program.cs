using System;
using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        //Create a game window
        Window _GameWindow = new Window("Animation Test", 250, 250);

        // Load the bitmap containing the animation frames
        Bitmap meowdodge = SplashKit.LoadBitmap("Meowbm", "Meow_Knight_Dodge.png");
        //Set the cells details based on the bitmap
        meowdodge.SetCellDetails(160, 123, 1, 8, 8);// cell width, height, cols, rows, totalcells

        //Load anination script from the .txt file
        AnimationScript dodgeScript = SplashKit.LoadAnimationScript("dodgeScript", "meowdodge.txt");
        // Create the animation from the script
        Animation test = dodgeScript.CreateAnimation("MeowDodge");
        //creating a drawing option
        DrawingOptions opt = SplashKit.OptionWithAnimation(test);

        while (!_GameWindow.CloseRequested)
        {
            SplashKit.ProcessEvents();
            _GameWindow.Clear(Color.White);
            _GameWindow.DrawBitmap(meowdodge, 20, 20, opt);
            _GameWindow.Refresh();
            test.Update();
        }
    }
}
