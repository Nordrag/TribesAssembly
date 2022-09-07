
public class DesignHelper
{
    
    public void SelectBg(EventMetaType type)
    {
        bgDisplayed = true;
        switch (type)
        {
            case EventMetaType.Nature:
                bgUrl = "nature.jpg";
                break;
            case EventMetaType.Travel:
                bgUrl = "travel2_bg.jpg";
                break;
            case EventMetaType.Drinking:
                bgUrl = "food_and_drink_bg.jpg";
                break;
            case EventMetaType.Entertainment:
                bgUrl = "entertainment2_bg.jpg";
                break;
            case EventMetaType.Sports:
                bgUrl = "sports_bg.jpg";
                break;
        }
    }

    public void DisableBg()
    {
        bgDisplayed = false;
    }

    public void SetColors(EventMetaType type)
    {
        switch (type)
        {
            case EventMetaType.Nature:
                FontColor = "black";
                break;
            case EventMetaType.Travel:
                FontColor = "black";
                break;
            case EventMetaType.Drinking:
                FontColor = "white";
                break;
            case EventMetaType.Entertainment:
                FontColor = "black";
                break;
            case EventMetaType.Sports:
                FontColor = "black";
                break;
            default:
                FontColor = "white";
                break;
        }       
    }

    string fontColor = "white";

    public string FontColor 
    {
        get => fontColor;
        set
        {
            fontColor = value;
            NotifyChanged();
        }
    }

    bool displayed;
    public bool bgDisplayed
    {
        get => displayed;
        set
        {
            displayed = value;
            NotifyChanged();
        }
    }


    string url;
    public string bgUrl
    {
        get => url ?? "";
        set
        {
            url = value;
            NotifyChanged();
        }
    }

    public event Action? OnChange;
    void NotifyChanged() => OnChange.Invoke();

}

