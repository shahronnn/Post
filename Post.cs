public class Post
{
    public string Title;
    public string Description;
    public DateTime DateTime;
    
    public int LikeCount=0;
    
    public List<string> Comments;

    public void Like()
    {
        LikeCount++;
    }
    public void Publish()
    {
        System.Console.WriteLine("Your post is publishing ...");
        System.Console.WriteLine("Your post has been published");
        DateTime=DateTime.Now;
        System.Console.WriteLine(DateTime);
        System.Console.WriteLine("- - - - - - - - - - - - - -");
    }
}