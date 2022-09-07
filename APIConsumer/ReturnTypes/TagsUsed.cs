using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TagsUsed
{
    public int Id { get; set; }
    public Subtags? TagId { get; set; }
    public EventModel? EventId { get; set; }

    public TagsUsed()
    {
        TagId = new Subtags();
        EventId = new EventModel();
    }
   
    public void AddTagName(string name)
    {
        TagId.TagName = name;
    }
}

