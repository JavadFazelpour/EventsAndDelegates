namespace Delegates;
public class MediaStorage
{
    public delegate int PlayMedia();
    public void ReportResutl(PlayMedia playerDelegate)
    {
        if (playerDelegate() == 0)
            Console.WriteLine("Media played successfully.");
        else
            Console.WriteLine("Media didn't play successfully.");
    }
}
public class AudioPlayer
{
    private int audioPlayerStatus;
    public int PlayAudioFile()
    {
        Console.WriteLine("\nSimiulating playing a valid audio file...");
        audioPlayerStatus = 0;
        return audioPlayerStatus;
    }
}
public class VidoePlayer()
{
    private int videoPlayerStatus;
    public int PlayVideoFile()
    {
        Console.WriteLine("\nSimiulating a failed video file...");
        videoPlayerStatus = -1;
        return videoPlayerStatus;
    }
}
public class Tester
{
    public void Run()
    {
        MediaStorage myMediaStorage = new MediaStorage();
        AudioPlayer myAudioPlayer = new AudioPlayer();
        VidoePlayer myVidoePlayer = new VidoePlayer();
        //instantiate delegates
        MediaStorage.PlayMedia audioPlayerDelegate =
                new MediaStorage.PlayMedia(myAudioPlayer.PlayAudioFile);
        MediaStorage.PlayMedia videoPlayerDelegate =
                new MediaStorage.PlayMedia(myVidoePlayer.PlayVideoFile);
        //call the delegates
        myMediaStorage.ReportResutl(audioPlayerDelegate);
        myMediaStorage.ReportResutl(videoPlayerDelegate);
    }

}
class Program
{
    static void Main(string[] args)
    {
        Tester t = new Tester();
        t.Run();
        Console.ReadKey();
    }
}
