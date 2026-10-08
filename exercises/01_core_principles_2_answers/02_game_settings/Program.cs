using System;

class GameSettings
{
    public int Volume { get; private set; } = 100;
    public int ScreenWidth { get; private set; } = 1920;
    public int ScreenHeight { get; private set; } = 1080;
    public bool Fullscreen { get; private set; } = true;

    public void SetVolume(int volume)
    {
        if (volume < 0 || volume > 100)
        {
            Console.WriteLine("Volume must be between 0 and 100.");
            return;
        }

        Volume = volume;
    }

    public void SetResolution(int width, int height)
    {
        if (width <= 0 || height <= 0)
        {
            Console.WriteLine("Resolution values must be greater than 0.");
            return;
        }

        ScreenWidth = width;
        ScreenHeight = height;
    }

    public void SetFullscreen(bool fullscreen)
    {
        Fullscreen = fullscreen;
    }
}

class Program
{
    static void Main()
    {
        GameSettings settings = new GameSettings();

        settings.SetVolume(75);
        settings.SetResolution(2560, 1440);
        settings.SetFullscreen(false);

        settings.SetVolume(150);
        settings.SetResolution(-800, 600);

        Console.WriteLine("Volume: " + settings.Volume);
        Console.WriteLine("Resolution: " + settings.ScreenWidth + "x" + settings.ScreenHeight);
        Console.WriteLine("Fullscreen: " + settings.Fullscreen);
    }
}
