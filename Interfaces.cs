using System;

namespace ArchiveLogic
{
   

    public interface IDocument
    {
        public DocumentType Type { get; set; }  
        public string Name { get; set; }
        // ID = GUID
        public string ID { get; set; }

        public string GetID(); 

    }
    interface IBox
    {
        public  MyProperty { get; set; }
    }


    interface ILocation
    {
        
    }

    interface IDocIndex
    {
        public string BoxID { get; set; }
        public string DocID { get; set; }
    }

}
