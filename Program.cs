// See https://aka.ms/new-console-template for more information
using System;
using System.Threading.Channels;

public class ClsChannel
{
    public string Tag { set; get; }
    public string Channel { set; get; }

}

class Program
{
    
    static void Main(string[] args)
    {
        //string[] NotificationTitles = { "[BE]", "[FE]", "[QA]", "[Urgent]" };
        List<ClsChannel> NotificationChannel = new List<ClsChannel>();
        NotificationChannel.Add(new ClsChannel { Tag = "[BE]", Channel = "BE" });
        NotificationChannel.Add(new ClsChannel { Tag = "[FE]", Channel = "FE" });
        NotificationChannel.Add(new ClsChannel { Tag = "[QA]", Channel = "QA" });
        NotificationChannel.Add(new ClsChannel { Tag = "[Urgent]", Channel = "Urgent" });

        string input;
        bool isFirst =true;

        Console.Write("Input Title:");
        input = Console.ReadLine();
        string[] parts = input.Split('[', ']');
       

        foreach(string item in parts)
        {
            if (item != "")
            {
                string tag = "[" + item + "]";
                var obj = NotificationChannel.Where(x => x.Tag == tag).SingleOrDefault();
                if (obj != null)
                {
                    if (isFirst)
                    {
                        Console.Write(obj.Channel);
                        isFirst = false;
                    }
                    else Console.Write(","+obj.Channel);
                }
                
            }
           
        }
        
    }
}




